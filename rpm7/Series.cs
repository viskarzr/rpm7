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
     class Series : ISeries
    {
        int start;
        int value;
        public Series()
        {
            start = 0;
            value = 0;
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
    }
}
