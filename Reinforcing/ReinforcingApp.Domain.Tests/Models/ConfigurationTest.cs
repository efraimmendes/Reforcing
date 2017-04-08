using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReinforcingApp.Domain.Models;

namespace ReinforcingApp.Domain.Tests.Models
{
    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void CanICreateAConfigurationModelObject()
        {
            Assert.IsInstanceOfType(new ConfigurationModel(), typeof(ConfigurationModel));
        }

        [TestMethod]
        public void IsLogModelAnInstanceOfModelBase()
        {
            Assert.IsInstanceOfType(new ConfigurationModel(), typeof(ModelBase));
        }

        [TestMethod]
        public void CanISetAllPropertiesFromLogModelModel()
        {
            var _sut = new ConfigurationModel()
            {
                RegistrationDate = new DateTime(2017, 1, 1),
                Configuration_Id = 1,
                NumberOfMinutesToCheckRequests = 1,
                NumberOfMinutesToWaitExceedLimite = 1,
                NumberOfRequestToExceedLimite = 1,
                TimeToExpireTheToken = 1,
            };
            Assert.AreEqual(6, _sut.GetType().GetProperties().Count());
            Assert.AreEqual(1, _sut.Configuration_Id);
            Assert.AreEqual(1, _sut.NumberOfMinutesToCheckRequests);
            Assert.AreEqual(1, _sut.NumberOfMinutesToWaitExceedLimite);
            Assert.AreEqual(1, _sut.NumberOfRequestToExceedLimite);
            Assert.AreEqual(1, _sut.TimeToExpireTheToken);
        }

    }
}