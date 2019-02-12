using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    public class Database<TKey, TData> : IDisposable where TKey : IComparable<TKey>
    {
        BPlusTree<TKey, TData> tree;

        public void Init(string fileName, int objectSize)
        {
            tree = new BPlusTree<TKey, TData>(fileName, objectSize);
        }

        public bool Insert(TKey key, TData data)
        {
            return tree.InsertData(key, data);
        }

        public bool Modify(TKey key, TData data)
        {
            return tree.ModifyData(key, data);
        }

        public bool Remove(TKey key)
        {
            return tree.RemoveData(key);
        }

        public Tuple<TData, bool> Find(TKey key)
        {
            TData d = tree.Find(key);
            return new Tuple<TData, bool>(d, d != null);
        }

        public List<TKey> FindRange(TKey key1, TKey key2)
        {
            return tree.FindRange(key1, key2);
        }

        public List<TData> FindRangeData(TKey key1, TKey key2)
        {
            return tree.FindRangeData(key1, key2);
        }

        public int Size()
        {
            return tree.Size();
        }

        public void Trunc()
        {
            tree.Trunc();
        }

        public void Dispose()
        {
            tree.Dispose();
        }
    }
}
