using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpm7
{
    /// <summary>
    /// Интерфейс ряда чисел
    /// </summary>
    internal interface ISeries
    {
        int Next {  get; }
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
}
