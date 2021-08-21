using basics_POO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace basics_POO_Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange (Arreglar)
            var customer = new Customer
            {
                FirstName = "Jairo",
                LastName = "Rodríguez"
            };
            string expected = "Jairo Rodríguez";

            // Act (Actuar)
            string actual = customer.FullName;

            // Assert (Afirmar)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirsNameEmpty()
        {
            // Arrange (Arreglar)
            var customer = new Customer
            {
                FirstName = "Jairo"
            };
            string expected = "Jairo";

            // Act (Actuar)
            string actual = customer.FullName;

            // Assert (Afirmar)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange (Arreglar)
            var customer = new Customer
            {
                LastName = "Rodríguez"
            };
            string expected = "Rodríguez";

            // Act (Actuar)
            string actual = customer.FullName;

            // Assert (Afirmar)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameEmpty()
        {
            // Arrange (Arreglar)
            var customer = new Customer();
            string expected = "N/A";

            // Act (Actuar)
            string actual = customer.FullName;

            // Assert (Afirmar)
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            // Arrange (Arreglar)
            var customer = new Customer
            {
                FirstName = "Jairo",
                LastName = "Rodríguez"
            };
            Customer.InstanceCount += 1;
            var customer2 = new Customer
            {
                FirstName = "Jairo1",
                LastName = "Rodríguez1"
            };
            Customer.InstanceCount += 1;
            var customer3 = new Customer
            {
                FirstName = "Jairo2",
                LastName = "Rodríguez2"
            };
            Customer.InstanceCount += 1;
            string expected = "N/A";

            // Act (Actuar)

            // Assert (Afirmar)
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
