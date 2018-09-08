using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMQProducer;

namespace Send
{
    class SendMessage
    {
        static void Main(string[] args)
        {
            Producer sender = new Producer();
            String senderName;

            Console.WriteLine("Please enter your name.");
            senderName = Console.ReadLine();
            sender.SetName(senderName);
            sender.CreateMessage();
            Console.WriteLine(sender.GetMessage());
            Console.Read();
        }
    }
}
