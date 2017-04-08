using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReinforcingApp.Domain.Models;

namespace ReinforcingApp.Domain.Tests.Models
{
    [TestClass]
    public class SessionModelTest
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void CanICreateTheApplicationModelObject()
        {
            Assert.IsInstanceOfType(new SessionModel(), typeof(SessionModel));
        }

        [TestMethod]
        public void IsApplicationModelAModelBaseObject()
        {
            Assert.IsInstanceOfType(new SessionModel(), typeof(SessionModel));
        }

        [TestMethod]
        public void CanISetAllPropertiesFromApplicationModel()
        {
            var _sut = new SessionModel()
            {
                RegistrationDate = new DateTime(2017, 1, 1),
                SessionsControl_Id = 1 ,
                DateTimeToControlRequestLimist = new DateTime(2017, 1, 1),
                RequestCountByMinute = 1, 
                RequestLimitExceded = true,
                LastValidToken = "123456789",
                Application_Id = "123456789",
                Application = new ApplicationModel() { Application_Id = "123456789"}
            };
            Assert.AreEqual(8, _sut.GetType().GetProperties().Count());
            Assert.AreEqual("123456789", _sut.Application_Id);
            Assert.AreEqual("123456789", _sut.Application.Application_Id);
            Assert.AreEqual(new DateTime(2017, 1, 1), _sut.DateTimeToControlRequestLimist);
            Assert.AreEqual(1, _sut.SessionsControl_Id);
            Assert.AreEqual(1, _sut.RequestCountByMinute);
            Assert.AreEqual(true, _sut.RequestLimitExceded);
            Assert.AreEqual("123456789", _sut.LastValidToken);
        }
    }
}
