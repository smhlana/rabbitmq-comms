using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMQProducer;

namespace ProducerTests
{
    [TestClass]
    public class ProducerNameValidationTests
    {
        [TestMethod]
        public void Producer_InitialNameIsSet_ReturnsTrue()
        {
            var producer = new Producer();

            String initialName = "John Doe";
            Assert.AreEqual(producer.GetName(), initialName, "Producer's name is not initialised correctly.");
        }

        [TestMethod]
        public void Producer_SetName_ReturnsNewName()
        {
            var producer = new Producer();
            String initialName = "John Doe";
            String newName = "Sesethu Mhlana";

            producer.SetName(newName);

            Assert.AreNotEqual(producer.GetName(), initialName, "New name should be different from the initial name.");
            Assert.AreEqual(producer.GetName(), newName, "The name is not set correctly.");
        }
    }
}
