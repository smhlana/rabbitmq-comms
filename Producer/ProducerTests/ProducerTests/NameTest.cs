using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMQProducer;

namespace ProducerTests
{
    [TestClass]
    public class ProducerValidationTests
    {
        [TestMethod]
        public void Producer_InitialMessage_ReturnsInitialMessage()
        {
            var producer = new Producer();

            String initialName = "John Doe";
            Assert.AreEqual(producer.name, initialName, "Producer's name is not initialised correctly.");
        }

        [TestMethod]
        public void Producer_SetMessage_ReturnsSetMessage()
        {
            var producer = new Producer();
            String initialName = "John Doe";
            String newName = "Sesethu Mhlana";

            producer.setName(newName);

            Assert.AreNotEqual(producer.name, initialName, "New name should be different from the initial name.");
            Assert.AreEqual(producer.name, newName, "The name is not set correctly.");
        }
    }
}
