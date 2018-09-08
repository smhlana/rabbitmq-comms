using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMQProducer
{
    public class Producer
    {
        public String name;

        public Producer()
        {
            name = "John Doe";
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public static void Main()
        {
            Producer sender = new Producer();
            String senderName = Console.ReadLine();

            Console.WriteLine(sender.name);
            sender.setName(senderName);
            Console.WriteLine(sender.name);
        }
    }
}


