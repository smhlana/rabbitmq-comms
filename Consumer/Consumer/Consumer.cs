﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RMQConsumer
{
    public class Consumer
    {
        private String receivedName;

        public Consumer()
        {
            this.receivedName = "No message received.";
        }

        public String GetReceivedName()
        {
            return this.receivedName;
        }

        public Boolean ValidName(String name)
        {
            if (name.GetType() == typeof(String)) return true;
            else return false;
        }

        public void DisplayMessage(String name)
        {
            if (ValidName(name))
                this.receivedName = name;
            else this.receivedName = "Invalid name.";
            Console.WriteLine($"Hello {this.receivedName}, I am your father!");

        }

        public void ReceiveMessage()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    String[] words;
                    var body = ea.Body;
                    var receivedMessage = Encoding.UTF8.GetString(body);
                    words = receivedMessage.Split(' ');
                    DisplayMessage(words[words.Length - 1]);
                };
                channel.BasicConsume(queue: "hello",
                                    autoAck: true,
                                    consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}