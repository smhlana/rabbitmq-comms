using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace RMQProducer
{
    public class Producer
    {
        private String name;
        private String message;

        public Producer()
        {
            name = "John Doe";
        }

        public void CreateMessage()
        {
            this.message = $"Hello my name is, {this.name}.";
        }

        public String GetMessage()
        {
            return this.message;
        }

        public String GetName()
        {
            return this.name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
    }
}