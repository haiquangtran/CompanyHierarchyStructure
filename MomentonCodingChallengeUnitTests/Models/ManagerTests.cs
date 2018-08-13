using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MomentonCodingChallenge;
using MomentonCodingChallenge.Common;
using MomentonCodingChallenge.Models;

namespace MomentonCodingChallengeUnitTests.Models
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void Manager_Constructor_SetsProperties()
        {
            const string expectedName = "test";
            const int expectedID = 1;
            const WorkerType expectedType = WorkerType.CONTRACTOR;

            var manager = new Manager(expectedName, expectedID, expectedType);

            Assert.AreEqual(expectedName, manager.Name);
            Assert.AreEqual(expectedID, manager.WorkerID);
            Assert.AreEqual(expectedType, manager.WorkerType);
        }

        [TestMethod]
        public void Manager_Constructor_HasNoSubordinates()
        {
            var manager = new Manager("test", 0, WorkerType.CONTRACTOR);

            Assert.AreEqual(0, manager.Subordinates.Count);
        }

        [TestMethod]
        public void Manager_Add_TierTwoHierarchy_AddTwoEmployees_SubordinatesCountIsTwo()
        {
            var worker1 = new Employee("worker1", 1, WorkerType.EMPLOYEE);
            var worker2 = new Employee("worker2", 2, WorkerType.EMPLOYEE);
            var manager = new Manager("manager1", 3, WorkerType.CONTRACTOR);

            manager.Add(worker1);
            manager.Add(worker2);

            Assert.AreEqual(2, manager.Subordinates.Count);
        }

        [TestMethod]
        public void Manager_Add_TierThreeHierarchy_ManagersAllHaveSubordinates()
        {
            var manager1 = new Manager("manager1", 3, WorkerType.CONTRACTOR);

            var manager2 = new Manager("manager2", 3, WorkerType.CONTRACTOR);

            var worker1 = new Employee("worker1", 1, WorkerType.EMPLOYEE);
            var worker2 = new Employee("worker2", 2, WorkerType.EMPLOYEE);

            manager1.Add(manager1);

            manager2.Add(worker1);
            manager2.Add(worker2);

            Assert.AreEqual(1, manager1.Subordinates.Count);
            Assert.AreEqual(2, manager2.Subordinates.Count);
        }
    }
}
