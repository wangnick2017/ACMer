using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    using TOffset = UInt32;
    public class BPlusTree<TKey, TData> : IDisposable where TKey : IComparable<TKey>
    {
        const TOffset MaxBufferSize = 102400;
        const TOffset InvalidOffset = TOffset.MaxValue;
        static public TOffset MaxBlockSize;

        const string SufDatabase = ".dat";
        const string SufIndex = ".idx";

        enum NodeType
        {
            InternNode = 1,
            LeafNode = 2,
            Deleted = 3
        }
        enum ReturnType
        {
            NotExist = 109,
            Invalid = 110,
            Nothing = 111,
            Splited = 112,
            BorrowedLeft = 113,
            BorrowedRight = 114,
            MergeLeft = 115,
            MergeRight = 116
        }

        [Serializable]
        struct TreeData
        {
            public TKey Key;
            public TOffset Offset;
            public TreeData(TKey k, TOffset o)
            {
                Key = k;
                Offset = o;
            }
        }
        class ReturnValue
        {
            public TreeData ReturnData;
            public ReturnType Status;
            public ReturnValue()
            {
            }
            public ReturnValue(TreeData d, ReturnType t)
            {
                ReturnData = d;
                Status = t;
            }
        }
        [Serializable]
        class BPlusTreeNode
        {
            public NodeType NodeType;
            public TOffset Size;
            public TOffset NodeOffset, NextNode, PrevNode;
            public TreeData[] Data;

            public BPlusTreeNode(NodeType nodeType = NodeType.Deleted)
            {
                NodeType = nodeType;
                Size = 0;
                NodeOffset = NextNode = PrevNode = InvalidOffset;
                Data = new TreeData[MaxBlockSize];
            }
        }

        string fileNameDatabase;
        string fileNameIndex;
        FileStream fIndex, fDatabase;
        BinaryFormatter formatter;
        byte[] buffer;
        TOffset dataSize = 0, rootOffset = 0;
        BPlusTreeNode currentNode;


        #region private basic methods

        TOffset BinarySearch(BPlusTreeNode p, TKey key, bool canOutOfRange = false)
        {
            TOffset L = 0, R = p.Size, M = 0;
            int c;
            while (L < R)
            {
                M = (L + R) >> 1;
                c = key.CompareTo(p.Data[M].Key);
                if (c == 0)
                    return M;
                if (c > 0)
                    L = M + 1;
                else
                    R = M;
            }
            if (canOutOfRange)
                return R;
            return R == 0 ? 0 : R - 1;
        }
        
        #endregion


        #region file IO

        BPlusTreeNode AllocNode(NodeType nodeType)
        {
            BPlusTreeNode tmp = new BPlusTreeNode(nodeType);
            WriteNode(tmp);
            return tmp;
        }

        bool WriteNode(BPlusTreeNode p, TOffset offset = 0)
        {
            if (offset == 0)
            {
                fIndex.Seek(0, SeekOrigin.End);
                offset = (TOffset)fIndex.Position;
            }
            else
            {
                fIndex.Seek(offset, SeekOrigin.Begin);
            }
            p.NodeOffset = offset;
            formatter.Serialize(fIndex, p);
            fIndex.Flush();
            return true;
        }
        BPlusTreeNode ReadNode(TOffset offset)
        {
            fIndex.Seek(offset, SeekOrigin.Begin);
            return (BPlusTreeNode)formatter.Deserialize(fIndex);
        }
        bool RemoveNode(BPlusTreeNode p, TOffset offset)
        {
            return true;
        }

        void WriteIndex()
        {
            fIndex.Seek(0, SeekOrigin.Begin);
            fIndex.Write(BitConverter.GetBytes(dataSize), 0, 4);
            fIndex.Write(BitConverter.GetBytes(rootOffset), 0, 4);
            fIndex.Flush();
        }
        void ReadIndex()
        {
            fIndex.Seek(0, SeekOrigin.Begin);
            fIndex.Read(buffer, 0, 4);
            dataSize = BitConverter.ToUInt32(buffer, 0);
            fIndex.Read(buffer, 0, 4);
            rootOffset = BitConverter.ToUInt32(buffer, 0);
            //fIndex.Flush();
        }

        TOffset WriteData(TData data)
        {
            fDatabase.Seek(0, SeekOrigin.End);
            TOffset offset = (TOffset)fDatabase.Position;
            formatter.Serialize(fDatabase, data);
            fDatabase.Flush();
            return offset;
        }
        TData ReadData(TOffset offset)
        {
            fDatabase.Seek(offset, SeekOrigin.Begin);
            return (TData)formatter.Deserialize(fDatabase);
        }
        TOffset ModifyData(TData data, TOffset offset)
        {
            fDatabase.Seek(offset, SeekOrigin.Begin);
            formatter.Serialize(fDatabase, data);
            fDatabase.Flush();
            return offset;
        }
        bool RemoveData(TOffset offset)
        {
            return true;
        }

        bool ImportIndexFile(TOffset sz)
        {
            if (!File.Exists(fileNameIndex))
            {
                fIndex = File.Open(fileNameIndex, FileMode.Create);
                fDatabase = File.Open(fileNameDatabase, FileMode.OpenOrCreate);
                WriteIndex();
                currentNode = AllocNode(NodeType.LeafNode);
                rootOffset = currentNode.NodeOffset;
                WriteIndex();
            }
            else
            {
                fIndex = File.Open(fileNameIndex, FileMode.Open);
                fDatabase = File.Open(fileNameDatabase, FileMode.OpenOrCreate);
                ReadIndex();
                currentNode = ReadNode(rootOffset);
            }
            return true;
        }

        void BackToRoot()
        {
            if (currentNode != null && currentNode.NodeOffset == rootOffset)
                return;
            if (currentNode != null)
                WriteNode(currentNode, currentNode.NodeOffset);
            currentNode = ReadNode(rootOffset);
        }

        #endregion


        #region tree methods

        bool Splitable(BPlusTreeNode p)
        {
            return (p.Size == MaxBlockSize);
        }

        TreeData SplitNode(BPlusTreeNode p)
        {
            BPlusTreeNode ntmp = AllocNode(p.NodeType);
            ntmp.NextNode = p.NextNode;
            ntmp.PrevNode = p.NodeOffset;
            p.NextNode = ntmp.NodeOffset;
            if (p.NextNode != InvalidOffset)
            {
                BPlusTreeNode tmpNext = ReadNode(p.NextNode);
                tmpNext.PrevNode = ntmp.NodeOffset;
                WriteNode(tmpNext, tmpNext.NodeOffset);
            }
            for (TOffset i = (MaxBlockSize >> 1); i < MaxBlockSize; ++i)
                ntmp.Data[i - (MaxBlockSize >> 1)] = p.Data[i];
            p.Size = MaxBlockSize >> 1;
            ntmp.Size = MaxBlockSize - (MaxBlockSize >> 1);
            WriteNode(p, p.NodeOffset);
            WriteNode(ntmp, ntmp.NodeOffset);
            if (p.NodeOffset == rootOffset)
            {
                BPlusTreeNode newRoot = AllocNode(NodeType.InternNode);
                newRoot.Size = 2;
                newRoot.Data[0].Key = p.Data[0].Key;
                newRoot.Data[0].Offset = p.NodeOffset;
                newRoot.Data[1].Key = ntmp.Data[0].Key;
                newRoot.Data[1].Offset = ntmp.NodeOffset;
                WriteNode(newRoot, newRoot.NodeOffset);
                rootOffset = newRoot.NodeOffset;
                WriteIndex();
            }
            TreeData ret = ntmp.Data[0];
            ret.Offset = ntmp.NodeOffset;
            return ret;
        }

        void MergeNode(BPlusTreeNode l, BPlusTreeNode r)
        {
            for (TOffset i = 0; i < r.Size; ++i)
                l.Data[l.Size + i] = r.Data[i];
            l.NextNode = r.NextNode;
            if (r.NextNode != InvalidOffset)
            {
                BPlusTreeNode tmpRight = ReadNode(r.NextNode);
                tmpRight.PrevNode = l.NodeOffset;
                WriteNode(tmpRight, tmpRight.NodeOffset);
            }
            l.Size += r.Size;
            r.Size = 0;
            WriteNode(l, l.NodeOffset);
            RemoveNode(r, r.NodeOffset);
        }

        ReturnValue BorrowFromRight(BPlusTreeNode n, BPlusTreeNode next)
        {
            ReturnValue ret = new ReturnValue(default(TreeData), ReturnType.Invalid);
            if (n.Size >= (MaxBlockSize >> 1) || next.Size >= (MaxBlockSize >> 1))
                return ret;
            n.Data[n.Size] = next.Data[0];
            ++n.Size;
            for (TOffset i = 0; i < next.Size - 1; ++i)
                next.Data[i] = next.Data[i + 1];
            --next.Size;
            WriteNode(n, n.NodeOffset);
            WriteNode(next, next.NodeOffset);
            ret.ReturnData = next.Data[0];
            ret.ReturnData.Offset = next.NodeOffset;
            ret.Status = ReturnType.BorrowedRight;
            return ret;
        }

        ReturnValue BorrowFromLeft(BPlusTreeNode prev, BPlusTreeNode n)
        {
            ReturnValue ret = new ReturnValue(default(TreeData), ReturnType.Invalid);
            if (n.Size >= (MaxBlockSize >> 1) || prev.Size >= (MaxBlockSize >> 1))
                return ret;
            for (TOffset i = n.Size - 1; i >= 0 && i <= n.Size - 1; --i)
                n.Data[i + 1] = n.Data[i];
            n.Data[0] = prev.Data[prev.Size - 1];
            ++n.Size;
            --prev.Size;
            WriteNode(n, n.NodeOffset);
            WriteNode(prev, prev.NodeOffset);
            ret.ReturnData = n.Data[0];
            ret.ReturnData.Offset = n.NodeOffset;
            ret.Status = ReturnType.BorrowedLeft;
            return ret;
        }

        TreeData TreeFind(TKey key, BPlusTreeNode p)
        {
            TOffset pos = BinarySearch(p, key);
            int c = key.CompareTo(p.Data[pos].Key);
            if (p.NodeType == NodeType.LeafNode && c == 0)
                return p.Data[pos];
            if (p.NodeType != NodeType.LeafNode && c >= 0)
                return TreeFind(key, ReadNode(p.Data[pos].Offset));
            return new TreeData(default(TKey), InvalidOffset);
        }

        ReturnValue TreeInsert(TKey key, TData data, BPlusTreeNode p)
        {
            int c;
            TOffset pos;
            if (p.NodeType == NodeType.LeafNode)
            {
                if (p.Size == 0)
                {
                    p.Data[0].Key = key;
                    p.Data[0].Offset = WriteData(data);
                    ++p.Size;
                    WriteNode(p, p.NodeOffset);
                    return new ReturnValue(p.Data[0], ReturnType.Nothing);
                }
                pos = BinarySearch(p, key);
                c = key.CompareTo(p.Data[pos].Key);
                if (c == 0)
                    return new ReturnValue(default(TreeData), ReturnType.Invalid);
                if (c > 0)
                {
                    for (TOffset j = p.Size - 1; j >= pos + 1 && j <= p.Size; --j)
                        p.Data[j + 1] = p.Data[j];
                    TreeData ins = new TreeData()
                    {
                        Key = key,
                        Offset = WriteData(data)
                    };
                    p.Data[pos + 1] = ins;
                    ++p.Size;
                    WriteNode(p, p.NodeOffset);
                    if (Splitable(p))
                        return new ReturnValue(SplitNode(p), ReturnType.Splited);
                    else
                        return new ReturnValue(p.Data[0], ReturnType.Nothing);
                }
            }
            pos = BinarySearch(p, key);
            c = key.CompareTo(p.Data[pos].Key);
            if (c > 0)
            {
                BPlusTreeNode tp = ReadNode(p.Data[pos].Offset);
                ReturnValue ret = TreeInsert(key, data, tp);
                if (ret.Status == ReturnType.Nothing)
                {
                    if (p.Data[pos].Key.CompareTo(ret.ReturnData.Key) != 0)
                    {
                        p.Data[pos].Key = ret.ReturnData.Key;
                        WriteNode(p, p.NodeOffset);
                    }
                    return new ReturnValue(p.Data[0], ReturnType.Nothing);
                }
                else if (ret.Status == ReturnType.Splited)
                {
                    for (TOffset j = p.Size - 1; j >= pos + 1 && j <= p.Size; --j)
                        p.Data[j + 1] = p.Data[j];
                    p.Data[pos + 1] = ret.ReturnData;
                    ++p.Size;
                    WriteNode(p, p.NodeOffset);
                    if (Splitable(p))
                        return new ReturnValue(SplitNode(p), ReturnType.Splited);
                    else
                        return new ReturnValue(p.Data[0], ReturnType.Nothing);
                }
            }
            return new ReturnValue(default(TreeData), ReturnType.Invalid);
        }

        ReturnValue TreeInsertFirst(TKey key, TData data, BPlusTreeNode p)
        {
            if (p.NodeType == NodeType.LeafNode)
            {
                if (p.Size == 0)
                {
                    p.Data[0].Key = key;
                    p.Data[0].Offset = WriteData(data);
                    ++p.Size;
                    WriteNode(p, p.NodeOffset);
                    return new ReturnValue(p.Data[0], ReturnType.Nothing);
                }
                for (TOffset i = p.Size - 1; i >= 0 && i <= p.Size - 1; --i)
                    p.Data[i + 1] = p.Data[i];
                p.Data[0].Key = key;
                p.Data[0].Offset = WriteData(data);
                ++p.Size;
                WriteNode(p, p.NodeOffset);
                if (Splitable(p))
                    return new ReturnValue(SplitNode(p), ReturnType.Splited);
                else
                    return new ReturnValue(p.Data[0], ReturnType.Nothing);
            }
            if (key.CompareTo(p.Data[0].Key) >= 0)
                return new ReturnValue(default(TreeData), ReturnType.Invalid);
            BPlusTreeNode tp = ReadNode(p.Data[0].Offset);
            p.Data[0].Key = key;
            ReturnValue ret = TreeInsertFirst(key, data, tp);
            if (ret.Status == ReturnType.Splited)
            {
                for (TOffset i = p.Size - 1; i >= 1 && i <= p.Size; --i)
                    p.Data[i + 1] = p.Data[i];
                p.Data[1] = ret.ReturnData;
                ++p.Size;
                WriteNode(p, p.NodeOffset);
                if (Splitable(p))
                    return new ReturnValue(SplitNode(p), ReturnType.Splited);
                else
                    return new ReturnValue(p.Data[0], ReturnType.Nothing);
            }
            else if (ret.Status == ReturnType.Nothing)
            {
                p.Data[0].Key = ret.ReturnData.Key;
                WriteNode(p, p.NodeOffset);
                return new ReturnValue(p.Data[0], ReturnType.Nothing);
            }
            return new ReturnValue(default(TreeData), ReturnType.Invalid);
        }

        ReturnValue TreeRemove(TKey key, BPlusTreeNode p)
        {
            if (p.Size == 0)
                return new ReturnValue(default(TreeData), ReturnType.NotExist);
            TOffset posFather, posSon;
            int c;
            if (p.NodeType == NodeType.LeafNode)
            {
                posFather = BinarySearch(p, key);
                if (key.CompareTo(p.Data[posFather].Key) != 0)
                    return new ReturnValue(default(TreeData), ReturnType.NotExist);
                RemoveData(p.Data[posFather].Offset);
                for (TOffset i = posFather; i < p.Size - 1; ++i)
                    p.Data[i] = p.Data[i + 1];
                --p.Size;
                WriteNode(p, p.NodeOffset);
                return new ReturnValue(default(TreeData), ReturnType.Nothing);
            }
            posFather = BinarySearch(p, key);
            c = key.CompareTo(p.Data[posFather].Key);
            if (c < 0)
                return new ReturnValue(default(TreeData), ReturnType.NotExist);
            BPlusTreeNode tp = ReadNode(p.Data[posFather].Offset);
            ReturnValue ret = new ReturnValue(default(TreeData), ReturnType.Nothing);
            if (tp.NodeType == NodeType.LeafNode)
            {
                posSon = BinarySearch(tp, key);
                if (key.CompareTo(tp.Data[posSon].Key) != 0)
                    return new ReturnValue(default(TreeData), ReturnType.NotExist);
                RemoveData(tp.Data[posSon].Offset);
                for (TOffset i = posSon; i < tp.Size - 1; ++i)
                    tp.Data[i] = tp.Data[i + 1];
                --tp.Size;
                if (p.Data[posFather].Key.CompareTo(tp.Data[0].Key) != 0)
                {
                    p.Data[posFather] = tp.Data[0];
                    p.Data[posFather].Offset = tp.NodeOffset;
                    WriteNode(p, p.NodeOffset);
                }
                WriteNode(tp, tp.NodeOffset);
            }
            else
            {
                ret = TreeRemove(key, tp);
                if (p.Data[posFather].Key.CompareTo(tp.Data[0].Key) != 0)
                {
                    p.Data[posFather].Key = tp.Data[0].Key;
                    WriteNode(p, p.NodeOffset);
                }
            }
            if (ret.Status == ReturnType.MergeLeft || ret.Status == ReturnType.MergeRight || tp.NodeType == NodeType.LeafNode)
            {
                if (tp.Size < (MaxBlockSize >> 1))
                {
                    BPlusTreeNode tl = default(BPlusTreeNode), tr = default(BPlusTreeNode);
                    if (posFather + 1 <= p.Size - 1)
                        tr = ReadNode(p.Data[posFather + 1].Offset);
                    if (posFather - 1 <= p.Size - 1)
                        tl = ReadNode(p.Data[posFather - 1].Offset);
                    if (tr != null && tr.Size > (MaxBlockSize >> 1))
                    {
                        ret = BorrowFromRight(tp, tr);
                        p.Data[posFather + 1].Key = tr.Data[0].Key;
                        WriteNode(p, p.NodeOffset);
                    }
                    else if (tl != null && tl.Size > (MaxBlockSize >> 1))
                    {
                        ret = BorrowFromLeft(tl, tp);
                        p.Data[posFather].Key = tp.Data[0].Key;
                        WriteNode(p, p.NodeOffset);
                    }
                    else if (tl != null && tl.Size <= (MaxBlockSize >> 1))
                    {
                        MergeNode(tl, tp);
                        for (TOffset i = posFather; i < p.Size - 1; ++i)
                            p.Data[i] = p.Data[i + 1];
                        --p.Size;
                        WriteNode(p, p.NodeOffset);
                        if (p.Size == 1 && p.NodeOffset == rootOffset)
                        {
                            rootOffset = p.Data[0].Offset;
                            WriteIndex();
                            RemoveNode(p, p.NodeOffset);
                        }
                        ret.Status = ReturnType.MergeLeft;
                        ret.ReturnData = p.Data[0];
                        ret.ReturnData.Offset = p.NodeOffset;
                    }
                    else if (tr != null && tr.Size <= (MaxBlockSize >> 1))
                    {
                        MergeNode(tp, tr);
                        for (TOffset i = posFather + 1; i < p.Size - 1; ++i)
                            p.Data[i] = p.Data[i + 1];
                        --p.Size;
                        WriteNode(p, p.NodeOffset);
                        if (p.Size == 1 && p.NodeOffset == rootOffset)
                        {
                            rootOffset = p.Data[0].Offset;
                            WriteIndex();
                            RemoveNode(p, p.NodeOffset);
                        }
                        ret.Status = ReturnType.MergeRight;
                        ret.ReturnData = p.Data[0];
                        ret.ReturnData.Offset = p.NodeOffset;
                    }
                    return ret;
                }
                else
                {
                    WriteNode(p, p.NodeOffset);
                    return new ReturnValue(default(TreeData), ReturnType.Nothing);
                }
            }
            else if (ret.Status != ReturnType.NotExist && ret.Status != ReturnType.Invalid)
                ret.Status = ReturnType.Nothing;
            return ret;
        }

        ReturnType TreeModify(TKey key, TData data, BPlusTreeNode p)
        {
            if (p.Size == 0)
                return ReturnType.NotExist;
            TOffset posFather, posSon, result;
            int c;
            if (p.NodeType == NodeType.LeafNode)
            {
                posFather = BinarySearch(p, key);
                c = key.CompareTo(p.Data[posFather].Key);
                if (c != 0)
                    return ReturnType.NotExist;
                else
                    result = ModifyData(data, p.Data[posFather].Offset);
                return result == InvalidOffset ? ReturnType.Invalid : ReturnType.Nothing;
            }
            posFather = BinarySearch(p, key);
            c = key.CompareTo(p.Data[posFather].Key);
            if (c < 0)
                return ReturnType.Invalid;
            BPlusTreeNode tp = ReadNode(p.Data[posFather].Offset);
            if (tp.NodeType == NodeType.LeafNode)
            {
                posSon = BinarySearch(tp, key);
                if (key.CompareTo(tp.Data[posSon].Key) != 0)
                    return ReturnType.NotExist;
                return ModifyData(data, tp.Data[posSon].Offset) == InvalidOffset ? ReturnType.Invalid : ReturnType.Nothing;
            }
            else
                return TreeModify(key, data, tp);
        }

        List<TKey> TreeFindRange(TKey key1, TKey key2, BPlusTreeNode p)
        {
            if (key1.CompareTo(key2) == 0)
                return new List<TKey>();
            TOffset pos;
            BPlusTreeNode tp;
            if (p.NodeType == NodeType.LeafNode)
            {
                pos = BinarySearch(p, key1, true);
                List<TKey> ret = new List<TKey>();
                if (pos >= p.Size)
                    return ret;
                while (true)
                {
                    for (; pos < p.Size && key2.CompareTo(p.Data[pos].Key) >= 0; ++pos)
                        ret.Add(p.Data[pos].Key);
                    if ((pos == p.Size || key2.CompareTo(p.Data[pos].Key) >= 0) && p.NextNode != InvalidOffset)
                    {
                        p = ReadNode(p.NextNode);
                        pos = 0;
                    }
                    else
                        return ret;
                }
            }
            else
            {
                pos = BinarySearch(p, key1);
                tp = ReadNode(p.Data[pos].Offset);
                return TreeFindRange(key1, key2, tp);
            }
        }

        List<TData> TreeFindRangeForData(TKey key1, TKey key2, BPlusTreeNode p)
        {
            if (key1.CompareTo(key2) == 0)
                return new List<TData>();
            TOffset pos;
            BPlusTreeNode tp;
            if (p.NodeType == NodeType.LeafNode)
            {
                pos = BinarySearch(p, key1, true);
                List<TData> ret = new List<TData>();
                if (pos >= p.Size)
                    return ret;
                while (true)
                {
                    for (; pos < p.Size && key2.CompareTo(p.Data[pos].Key) >= 0; ++pos)
                        ret.Add(ReadData(p.Data[pos].Offset));
                    if ((pos == p.Size || key2.CompareTo(p.Data[pos].Key) >= 0) && p.NextNode != InvalidOffset)
                    {
                        p = ReadNode(p.NextNode);
                        pos = 0;
                    }
                    else
                        return ret;
                }
            }
            else
            {
                pos = BinarySearch(p, key1);
                tp = ReadNode(p.Data[pos].Offset);
                return TreeFindRangeForData(key1, key2, tp);
            }
        }

        void TreeClear()
        {
            fIndex.Close();
            fIndex.Dispose();
            fDatabase.Close();
            fDatabase.Dispose();
            fIndex = File.Open(fileNameIndex, FileMode.Truncate);
            fDatabase = File.Open(fileNameDatabase, FileMode.Truncate);
            dataSize = 0;
            WriteIndex();
            currentNode = AllocNode(NodeType.LeafNode);
            rootOffset = currentNode.NodeOffset;
            WriteIndex();
        }

        #endregion


        #region public interface

        public BPlusTree(string fileName, int objectSize)
        {
            formatter = new BinaryFormatter();
            buffer = new byte[100];
            fileNameDatabase = fileName + SufDatabase;
            fileNameIndex = fileName + SufIndex;
            MaxBlockSize = (TOffset)((MaxBufferSize - 50) / (objectSize + objectSize + 100));
            ImportIndexFile((TOffset)objectSize);
        }

        public bool InsertData(TKey key, TData data)
        {
            BackToRoot();
            ReturnValue ret;
            if (currentNode.Size == 0)
            {
                ret = TreeInsert(key, data, currentNode);
                ++dataSize;
                WriteIndex();
                return true;
            }
            int c = key.CompareTo(currentNode.Data[0].Key);
            if (c < 0)
                ret = TreeInsertFirst(key, data, currentNode);
            else if (c > 0)
                ret = TreeInsert(key, data, currentNode);
            else
                return false;
            if (ret.Status == ReturnType.Invalid)
                return false;
            ++dataSize;
            WriteIndex();
            return true;
        }

        public bool ModifyData(TKey key, TData data)
        {
            if (dataSize == 0)
                return false;
            BackToRoot();
            ReturnType ret = TreeModify(key, data, currentNode);
            if (ret == ReturnType.Invalid || ret == ReturnType.NotExist)
                return false;
            return true;
        }

        public bool RemoveData(TKey key)
        {
            if (dataSize == 0)
                return false;
            BackToRoot();
            ReturnValue ret = TreeRemove(key, currentNode);
            if (ret.Status == ReturnType.Invalid || ret.Status == ReturnType.NotExist)
                return false;
            --dataSize;
            WriteIndex();
            return true;
        }

        public TData Find(TKey key)
        {
            if (dataSize == 0)
                return default(TData);
            BackToRoot();
            TreeData ret = TreeFind(key, currentNode);
            if (ret.Offset == InvalidOffset)
                return default(TData);
            return ReadData(ret.Offset);
        }

        public List<TKey> FindRange(TKey key1, TKey key2)
        {
            if (dataSize == 0)
                return new List<TKey>();
            BackToRoot();
            return TreeFindRange(key1, key2, currentNode);
        }

        public List<TData> FindRangeData(TKey key1, TKey key2)
        {
            if (dataSize == 0)
                return new List<TData>();
            BackToRoot();
            return TreeFindRangeForData(key1, key2, currentNode);
        }

        public void Trunc()
        {
            TreeClear();
        }

        public int Size()
        {
            return (int)dataSize;
        }

        public void Dispose()
        {
            fIndex.Close();
            fIndex.Dispose();
            fDatabase.Close();
            fDatabase.Dispose();
        }

        #endregion
    }
}
