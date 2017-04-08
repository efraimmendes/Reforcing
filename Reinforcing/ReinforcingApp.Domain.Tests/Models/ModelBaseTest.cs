using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReinforcingApp.Domain.Models;

namespace ReinforcingApp.Domain.Tests.Models
{
    [TestClass]
    public class ModelBaseTest
    {
        [TestMethod]
        public void CanICreateTheModelBaseObject()
        {
            Assert.IsInstanceOfType(new ModelBase(), typeof(ModelBase));
        }

        [TestMethod]
        public void CanISetValuesToModelBaseObject()
        {
            var _sut = new ModelBase();
            _sut.RegistrationDate = new DateTime(2017, 1, 1);
            Assert.AreEqual(1, _sut.GetType().GetProperties().Count());
            Assert.AreEqual(new DateTime(2017, 1, 1), _sut.RegistrationDate);
        }
    }
}
