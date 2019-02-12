using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    public class Vector<TData> : IDisposable
    {
        string fileName;
        int objectSize;
        int size;
        public int Size
        {
            get
            {
                return size;
            }
        }
        
        public void Init(string fileName, int objectSize)
        {
            this.fileName = fileName;
            this.objectSize = objectSize;
            this.fileName += ".dat";
            if (!File.Exists(this.fileName))
            {
                using (FileStream fs = File.Create(this.fileName))
                {
                }
            }
            size = (int)(new FileInfo(this.fileName).Length / objectSize);
        }

        public void Insert(TData data)
        {
            using (FileStream fs = File.OpenWrite(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Seek(size * objectSize, SeekOrigin.Begin);
                bf.Serialize(fs, data);
            }
            ++size;
        }

        public Tuple<TData, bool> Find(int pos)
        {
            if (pos >= size || pos < 0)
                return new Tuple<TData, bool>(default(TData), false);
            TData tData;
            using (FileStream fs = File.OpenRead(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Seek(pos * objectSize, SeekOrigin.Begin);
                tData = (TData)bf.Deserialize(fs);
            }
            return new Tuple<TData, bool>(tData, true);
        }

        public void Modify(int pos, TData data)
        {
            using (FileStream fs = File.OpenWrite(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                fs.Seek(pos * objectSize, SeekOrigin.Begin);
                bf.Serialize(fs, data);
            }
        }

        public void Trunc()
        {
            using (FileStream fs = File.Open(fileName, FileMode.Truncate))
            {
            }
            size = 0;
        }

        public void Dispose()
        {
            //nothing needs to be done
        }
    }
}
