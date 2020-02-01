using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using codewars.OOP.ConstructingACar2_Driving_5;
using System.Linq;

namespace NUnitTestProject1
{
    [TestFixture]
    public class ConstructingACar2_Driving_5_Test
    {
        [Test]
        public void TestStartSpeed()
        {
            var car = new Car();

            car.EngineStart();

            Assert.AreEqual(0, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        }

        [Test]
        public void TestFreeWheelSpeed()
        {
            var car = new Car();

            car.EngineStart();

            Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

            Assert.AreEqual(100, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");

            car.FreeWheel();
            car.FreeWheel();
            car.FreeWheel();

            Assert.AreEqual(97, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        }

        [Test]
        public void TestAccelerateBy10()
        {
            var car = new Car();

            car.EngineStart();

            Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

            car.Accelerate(160);
            Assert.AreEqual(110, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(160);
            Assert.AreEqual(120, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(160);
            Assert.AreEqual(130, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(160);
            Assert.AreEqual(140, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(145);
            Assert.AreEqual(145, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        }

        [Test]
        public void TestAccelerateBy5()
        {
            var car = new Car(20, 5);

            car.EngineStart();

            Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

            car.Accelerate(160);
            Assert.AreEqual(55, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(160);
            Assert.AreEqual(60, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(160);
            Assert.AreEqual(65, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(160);
            Assert.AreEqual(70, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
            car.Accelerate(145);
            Assert.AreEqual(75, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        }

        [Test]
        public void TestBraking()
        {
            var car = new Car();

            car.EngineStart();

            Enumerable.Range(0, 10).ToList().ForEach(s => car.Accelerate(100));

            car.BrakeBy(20);

            Assert.AreEqual(90, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");

            car.BrakeBy(10);

            Assert.AreEqual(80, car.drivingInformationDisplay.ActualSpeed, "Wrong actual speed!");
        }

        [Test]
        public void TestConsumptionSpeedUpTo30()
        {
            var car = new Car(1, 20);

            car.EngineStart();

            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);
            car.Accelerate(30);

            Assert.AreEqual(0.98, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
        }
    }
}
