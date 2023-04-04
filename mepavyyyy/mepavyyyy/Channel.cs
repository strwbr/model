using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace mepavyyyy
{
    internal class Channel
    {
        public bool Busy { get; set; }
        public int res { get; set; }
        public int N { get; set; }
        //public object locker = new object();
        public Channel(int n)
        {
            Busy = false;
            res = 1;
            N = n;
        }

        /*public void ServeRequest(Request req)
        {
            lock (req)
            {
                Busy = true;
                req.startTime = DateTime.Now;
                factorial(req.Num);
                req.finishTime = DateTime.Now;
                Busy = false;
            }
        }*/

        public void factorial()
        {
            for(int i = 0; i < N; i++)
            {
                res *= i;
            }
        }
    }
}
