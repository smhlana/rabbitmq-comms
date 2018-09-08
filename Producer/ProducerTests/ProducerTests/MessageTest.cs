using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMQProducer;

namespace ProducerTests
{
    [TestClass]
    public class ProducerMessageValidationTests
    {
        [TestMethod]
        public void Producer_InitialMessage_ReturnsInitialMessage()
        {
            var producer = new Producer();
            String initialMessage = "Hello my name is, John Doe.";

            producer.CreateMessage();

            Assert.AreEqual(producer.GetMessage(), initialMessage, "The message is not created correctly.");
        }

        [TestMethod]
        public void Producer_NewMessage_ReturnsNewMessage()
        {
            var producer = new Producer();
            String initialMessage = "Hello my name is, John Doe.";
            String newMessage = "Hello my name is, Sesethu Mhlana.";

            producer.SetName("Sesethu Mhlana");
            producer.CreateMessage();

            Assert.AreNotEqual(producer.GetMessage(), initialMessage, "New message should be different from the initial message.");
            Assert.AreEqual(producer.GetMessage(), newMessage, "The message is not created correctly.");
        }
    }
}
