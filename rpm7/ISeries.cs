using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpm7
{
    internal interface ISeries
    {
        int Next {  get; }
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
}
