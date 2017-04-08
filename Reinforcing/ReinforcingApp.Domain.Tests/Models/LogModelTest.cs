using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReinforcingApp.Domain.Models;

namespace ReinforcingApp.Domain.Tests.Models
{
    [TestClass]
    public class LogModelTest
    {
        [TestMethod]
        public void CanICreateALogModelObject()
        {
            Assert.IsInstanceOfType(new LogModel(), typeof(LogModel));
        }

        [TestMethod]
        public void IsLogModelAnInstanceOfModelBase()
        {
            Assert.IsInstanceOfType(new LogModel(), typeof(ModelBase));
        }
        [TestMethod]
        public void CanISetAllPropertiesFromLogModelModel()
        {
            var _sut = new LogModel()
            {
                RegistrationDate = new DateTime(2017, 1, 1),
                Log_Id = 1,
                Logger = "App.Test.System",
                Level = "ERROR",
                Message = "This is a test",
                Application_Id = "123456789",
                Application = new ApplicationModel() { Application_Id = "123456789"}
            };
            Assert.AreEqual(7, _sut.GetType().GetProperties().Count());
            Assert.AreEqual(1,_sut.Log_Id);
            Assert.AreEqual("App.Test.System", _sut.Logger);
            Assert.AreEqual("ERROR", _sut.Level);
            Assert.AreEqual("This is a test", _sut.Message);
            Assert.AreEqual("123456789", _sut.Application_Id);
            Assert.AreEqual("123456789",  _sut.Application.Application_Id);
        }
    }
}