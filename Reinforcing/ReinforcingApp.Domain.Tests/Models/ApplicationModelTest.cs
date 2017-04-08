using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReinforcingApp.Domain.Models;

namespace ReinforcingApp.Domain.Tests.Models
{
    [TestClass]
    public class ApplicationModelTest
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void CanICreateTheApplicationModelObject()
        {
            Assert.IsInstanceOfType(new ApplicationModel(), typeof(ApplicationModel));
        }

        [TestMethod]
        public void IsApplicationModelAModelBaseObject()
        {
            Assert.IsInstanceOfType(new ApplicationModel(), typeof(ModelBase));
        }

        [TestMethod]
        public void CanISetAllPropertiesFromApplicationModel()
        {
            var _sut = new ApplicationModel()
            {
                RegistrationDate = new System.DateTime(2017, 1, 1),
                Application_Id = "123456789",
                Display_Name = "Teste de App",
                SecretKey = "987654321"
            };
            Assert.AreEqual(4, _sut.GetType().GetProperties().Count());
            Assert.AreEqual(_sut.Application_Id, "123456789");
            Assert.AreEqual(_sut.Display_Name, "Teste de App");
            Assert.AreEqual(_sut.SecretKey, "987654321");
        }
    }
}