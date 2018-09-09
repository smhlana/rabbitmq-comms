using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMQConsumer;

namespace ConsumerTests.UnitTest
{
    [TestClass]
    public class ConsumerMessageValidationTests
    {
        [TestMethod]
        public void Consumer_ReceivedName_ReturnsTrue()
        {
            var consumer = new Consumer();
            var name = consumer.GetReceivedName();

            Assert.IsInstanceOfType(name, typeof(String), "The name is invalid.");
        }

        [TestMethod]
        public void Consumer_InitialMessage_ReturnsTrue()
        {
            var consumer = new Consumer();

            String initialMessage = "No message received.";
            Assert.AreEqual(consumer.GetReceivedName(), initialMessage, "Consumer's name is not initialised correctly.");
        }
    }
}
