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
        public int step;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Series()
        {
            start = 1;
            value = 1;
            step = 2;
        }

        public int Next
        {
            get {  return GetNext(); }
        }

        /// <summary>
        /// Расчет следующего числа прогрессии
        /// </summary>
        /// <returns> следующее число прогрессии </returns>
        public int GetNext()
        {
            //value *= step ;
            return value*step;
        }

        /// <summary>
        /// Обнуление расчёта
        /// </summary>
        public void Reset()
        {
            value = start;
        }

        /// <summary>
        /// назначение стартового числа прогрессии
        /// </summary>
        /// <param name="x"> задаваемое число </param>
        public void SetStart(int x)
        {
            start = x;
            value = start;
        }

        /// <summary>
        /// полное клонирование элемента прогрессии
        /// </summary>
        /// <returns> клонированный экземпляр </returns>
        public object Clone()
        {
            Series s = new Series();
            s.start = this.start;
            s.value = this.value;
            s.step = this.step;
            return s;
        }

        public int CompareTo(object obj)
        {
            Series ser =(Series)obj;
            if (this.value > ser.value) return this.value-ser.value;
            if (this.value < ser.value) return ser.value-this.value;
            return 0;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
