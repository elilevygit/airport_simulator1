using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using logical_layer;
using System.Timers;
using System.Threading;
using Repository;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var logic = new Logic();
            logic.DepartPlane(new Plane() { PlaneId = 1 });
            logic.DepartPlane(new Plane() { PlaneId = 2 });
            logic.DepartPlane(new Plane() { PlaneId = 3 });
            logic.DepartPlane(new Plane() { PlaneId = 4 });

            Thread.Sleep(50000);
            
            Assert.AreEqual(4, logic.GetStations().Count);
        }
    }
}
