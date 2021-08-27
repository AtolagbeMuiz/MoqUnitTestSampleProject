using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqUnitTestSampleProject.Classes;
using MoqUnitTestSampleProject.Controllers;

namespace CustomerControllerUnitTests
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void GetNameById_GetCustomerWithID_ReturnsCustomer()
        {
            //Arange
            var customerMock = new Mock<ICustomerRepo>();
            var customerController = new CustomerController(customerMock.Object);

            //Act
            customerMock.Setup(x => x.GetNameById(1)).Returns("Muiz");
            var result = customerController.GetNameById(1);

            //Assert
            Assert.AreEqual("Muiz", result);
        }
    }
}
