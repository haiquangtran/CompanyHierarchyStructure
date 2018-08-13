using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MomentonCodingChallenge;
using MomentonCodingChallenge.Common;
using MomentonCodingChallenge.Models;

namespace MomentonCodingChallengeUnitTests.Models
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_Constructor_SetsProperties()
        {
            const string expectedName = "test";
            const int expectedID = 1;
            const WorkerType expectedType = WorkerType.EMPLOYEE;

            var employee = new Employee(expectedName, expectedID, expectedType);

            Assert.AreEqual(expectedName, employee.Name);
            Assert.AreEqual(expectedID, employee.WorkerID);
            Assert.AreEqual(expectedType, employee.WorkerType);
        }
    }
}
