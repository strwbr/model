using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mepavyyyy
{
    internal class Request
    {
        public int Num { get; set; }
        public DateTime startTime { get; set; }
        public DateTime finishTime { get; set; }
        public Request(int n)
        {
            Num = n;
        }
    }
}
