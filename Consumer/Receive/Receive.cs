using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMQConsumer;

namespace Receive
{
    class ReceiveMessage
    {
        static void Main(string[] args)
        {
            Consumer receiver = new Consumer();
            receiver.ReceiveMessage();
        }
    }
}
