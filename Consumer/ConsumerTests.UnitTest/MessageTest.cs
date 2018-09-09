using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMQConsumer;

namespace ConsumerTests.UnitTest
{
    [TestClass]
    public class ConsumerMessageValidationTests
    {
        [TestMethod]
        public void Consumer_ReceivedNameIsString_ReturnsReceivedName()
        {
            var consumer = new Consumer();

            consumer.SetReceivedName("Sesethu");
            var name = consumer.GetReceivedName();

            Assert.IsInstanceOfType(name, typeof(String), "The name is invalid.");
        }

        [TestMethod]
        public void Consumer_ReceivedNameIsEmpty_ReturnsTrue()
        {
            var consumer = new Consumer();
            consumer.SetReceivedName("");
            var name = consumer.GetReceivedName();
            Boolean isValid = consumer.ValidName(name);

            Assert.IsFalse(isValid, "The validation is incorrect.");
        }

        [TestMethod]
        public void Consumer_ReceivedNameIsNotEmpty_ReturnsTrue()
        {
            var consumer = new Consumer();
            consumer.SetReceivedName("Sesethu");
            var name = consumer.GetReceivedName();
            Boolean isValid = consumer.ValidName(name);

            Assert.IsTrue(isValid, "The validation is incorrect.");
        }

        [TestMethod]
        public void Consumer_InitialMessageIsSet_ReturnsTrue()
        {
            var consumer = new Consumer();

            String initialMessage = "No message received.";
            Assert.AreEqual(consumer.GetReceivedName(), initialMessage, "Consumer's name is not initialised correctly.");
        }
    }
}
