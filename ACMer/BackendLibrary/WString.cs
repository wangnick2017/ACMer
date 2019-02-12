using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMer.BackendLibrary
{
    [Serializable]
    public class WString : IComparable<WString>
    {
        public char[] Chars;
        public int Length;

        public WString()
        {
            Length = 0;
        }

        public WString(int size, string s = "")
        {
            Chars = new char[size];
            Length = Math.Min(size, s.Length);
            for (int i = 0; i < Length; ++i)
                Chars[i] = s[i];
        }

        public WString(int size, char c)
        {
            Chars = new char[size];
            Length = size;
            for (int i = 0; i < Length; ++i)
                Chars[i] = c;
        }

        public int ToInt()
        {
            return Convert.ToInt32(new string(Chars));
        }

        public override string ToString()
        {
            return new string(Chars, 0, Length);
        }

        public char this[int index]
        {
            get
            {
                return Chars[index];
            }
            set
            {
                Chars[index] = value;
            }
        }

        public int CompareTo(WString other)
        {
            int l = Math.Min(Length, other.Length);
            for (int i = 0; i < l; ++i)
                if (this[i] != other[i])
                {
                    return this[i] - other[i];
                }
            return Length - other.Length;
        }

        public static bool operator !=(WString a, string b)
        {
            return a.ToString() != b;
        }

        public static bool operator ==(WString a, string b)
        {
            return a.ToString() == b;
        }
    }
}
