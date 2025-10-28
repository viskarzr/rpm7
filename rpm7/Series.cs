using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpm7
{
    /// <summary>
    /// класс для ряда чисел 
    /// </summary>
     class Series : ISeries, ICloneable, IComparable
    {
        public int start;
        public int value;
        public Series()
        {
            start = 1;
            value = 1;
        }

        public int Next
        {
            get {  return GetNext(); }
        }

        public int GetNext()
        {
            value *= 2;
            return value;
        }
        public void Reset()
        {
            value = start;
        }

        public void SetStart(int x)
        {
            start = x;
            value = start;
        }

        public object Clone()
        {
            Series s = new Series();
            s.start = this.start;
            s.value = this.value;
            return s;
        }

        public int CompareTo(object obj)
        {
            Series ser =(Series)obj;
            if (this.value > ser.value) return this.value-ser.value;
            if (this.value < ser.value) return ser.value-this.value;
            return 0;
        }
    }
}
