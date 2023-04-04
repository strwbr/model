using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mepavyyyy
{
    internal class Server
    {
        public Stack<Request> queue { get; set; }
        public Thread[] channels { get; set; }
        public Thread serverThread { get; set; }
        public object locker = new object();
        public event Action<string> AddProgress;
        public Server(int channelsAmount)
        {
            channels = new Thread[channelsAmount];
            serverThread = new Thread(ServerThread);
            serverThread.Start();
        }

        public void ServerThread()
        {
            while (true)
            {
                GetProgress();
                Thread.Sleep(1000);
            }
        }

        public void RequestMaker()
        {
            Random random = new Random();
            while (true)
            {
                Request request = new Request(random.Next(10000, 70000));
                request.startTime = DateTime.Now;
                queue.Push(request);
                ServeRequests();
                Thread.Sleep(random.Next(300, 1000));
            }
        }

        public void ServeRequests()
        {
            for(int i = 0; i < channels.Length; i++)
            {
                if (!channels[i].IsAlive)
                {
                    channels[i] = new Thread(() => DoChannel(queue.Pop()));
                    channels[i].Start();
                    break;
                }
            }
        }

        public void DoChannel(Request req)
        {
            Channel channel = new Channel(req.Num);
            channel.factorial();
        }

        /*public void factorial(int n)
        {
            int res = 1;
            for (int i = 0; i < n; i++)
            {
                res *= n;
            }
        }*/

        public void GetProgress()
        {
            AddProgress?.Invoke("прикол");
        }

    }
}
