using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace codewars.OOP.ConstructingACar2_Driving_5
{
    public interface ICar
    {
        bool EngineIsRunning { get; }
        
        void BrakeBy(int speed); // car #2

        void Accelerate(int speed); // car #2

        void EngineStart();

        void EngineStop();

        void FreeWheel(); // car #2

        void Refuel(double liters);

        void RunningIdle();
    }

    public interface IDrivingInformationDisplay // car #2
    {
        int ActualSpeed { get; }
    }

    public interface IDrivingProcessor // car #2
    {
        int ActualSpeed { get; }

        void IncreaseSpeedTo(int speed);

        void ReduceSpeed(int speed);
    }

    public interface IEngine
    {
        bool IsRunning { get; }

        void Consume(double liters);

        void Start();

        void Stop();
    }

    public interface IFuelTank
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }

        void Consume(double liters);

        void Refuel(double liters);
    }

    public interface IFuelTankDisplay
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }
    }

    public abstract class Subject
    {
        private ArrayList observers = new ArrayList();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(Observer item in observers)
            {
                item.Update();
            }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class Car : ICar
    {
        public IFuelTankDisplay fuelTankDisplay;
        public IDrivingInformationDisplay drivingInformationDisplay; // car #2
        private IDrivingProcessor drivingProcessor;
        private IEngine engine;

        private IFuelTank fuelTank;

        public Car()
        {
            BuildCar();
        }

        public Car(double fuelLevel)
        {
            BuildCar(fuelLevel);
        }

        public Car(double fuelLevel, int maxAcceleration) // car #2
        {
            BuildCar(fuelLevel, maxAcceleration);

        }

        private void BuildCar(double fuelLevel = 20, int maxAcceleration = 10)
        {
            if (maxAcceleration > 20)
                maxAcceleration = 20;
            else if (maxAcceleration < 5)
                maxAcceleration = 5;

            fuelTank = new FuelTank();
            fuelTankDisplay = new FuelTankDisplay(fuelTank);
            engine = new Engine(fuelTank);

            if (fuelTank is Subject && fuelTankDisplay is Observer)
            {
                ((Subject)fuelTank).Attach((Observer)fuelTankDisplay);
            }

            if (fuelTank is Subject && engine is Observer)
            {
                ((Subject)fuelTank).Attach((Observer)engine);
            }

            fuelTank.Refuel(fuelLevel);

            drivingProcessor = new DrivingProcessor(maxAcceleration);
            drivingInformationDisplay = new DrivingInformationDisplay(drivingProcessor);

            if (drivingProcessor is Subject && drivingInformationDisplay is Observer)
            {
                ((Subject)drivingProcessor).Attach((Observer)drivingInformationDisplay);
            }
        }

        public bool EngineIsRunning => engine.IsRunning;

        public void Accelerate(int speed)
        {
            if (engine.IsRunning && speed >= drivingInformationDisplay.ActualSpeed)
            {
                drivingProcessor.IncreaseSpeedTo(speed);
                engine.Consume(GetConsumption());
            }
            else
            {
                FreeWheel();
            }
        }

        public void BrakeBy(int speed)
        {
            drivingProcessor.ReduceSpeed(speed);
        }

        public void EngineStart()
        {
            engine.Start();
        }

        public void EngineStop()
        {
            engine.Stop();
        }

        public void FreeWheel()
        {
            drivingProcessor.ReduceSpeed(1);
            if (drivingInformationDisplay.ActualSpeed == 0)
            {
                RunningIdle();
            }
        }

        public void Refuel(double liters)
        {
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            engine.Consume(0.0003);
        }

        private double GetConsumption()
        {
            switch (drivingInformationDisplay.ActualSpeed)
            {
                case int speed when 0 < speed && speed <= 60:
                    return 0.002;
                case int speed when 60 < speed && speed <= 100:
                    return 0.0014;
                case int speed when 100 < speed && speed <= 140:
                    return 0.002;
                case int speed when 140 < speed && speed <= 200:
                    return 0.0025;
                case int speed when 200 < speed && speed <= 250:
                    return 0.003;
                default:
                    return 0.0003;
            }
        }
    }

    public class Engine : Observer, IEngine
    {
        bool _engineIsRunning = false;
        IFuelTank fuelTank;

        public bool IsRunning => _engineIsRunning;

        public Engine(IFuelTank fuelTank)
        {
            this.fuelTank = fuelTank;
        }

        public void Consume(double liters)
        {
            if (IsRunning)
            {
                fuelTank.Consume(liters);
            }
        }

        public void Start()
        {
            if (fuelTank.FillLevel > 0)
            {
                _engineIsRunning = true;
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            _engineIsRunning = false;
        }

        public override void Update()
        {
            if (fuelTank.FillLevel == 0)
            {
                Stop();
            }
        }
    }

    public class DrivingInformationDisplay : Observer, IDrivingInformationDisplay // car #2
    {
        private int actualSpeed = 0;
        private IDrivingProcessor drivingProcessor;
        public int ActualSpeed => actualSpeed;

        public DrivingInformationDisplay(IDrivingProcessor drivingProcessor)
        {
            this.drivingProcessor = drivingProcessor;
        }

        public override void Update()
        {
            actualSpeed = drivingProcessor.ActualSpeed;
        }
    }

    public class DrivingProcessor : Subject, IDrivingProcessor // car #2
    {
        private int actualSpeed = 0;
        private int maxAcceleration;
        public int ActualSpeed => actualSpeed;

        public DrivingProcessor(int maxAcceleration)
        {
            this.maxAcceleration = maxAcceleration;
        }

        public void IncreaseSpeedTo(int speed)
        {
            if ((actualSpeed + maxAcceleration) > 250)
                actualSpeed = 250;
            else if ((actualSpeed + maxAcceleration) > speed)
                actualSpeed = speed;
            else
                actualSpeed += maxAcceleration;

            Notify();
        }

        public void ReduceSpeed(int speed)
        {
            if (speed > 10)
                speed = 10;

            if((actualSpeed - speed) < 0)
                actualSpeed = 0;
            else
                actualSpeed -= speed;

            Notify();
        }
    }

    public class FuelTank : Subject, IFuelTank
    {
        private double _fillLevel;
        private bool _isOnReserve;
        private bool _isComplete;
        public double FillLevel => _fillLevel;

        public bool IsOnReserve => _isOnReserve;
        public bool IsComplete => _isComplete;

        public void Consume(double liters)
        {
            _fillLevel -= liters;
            RecalculateSate();
            Notify();
        }

        public void Refuel(double liters)
        {
            _fillLevel += liters;
            RecalculateSate();
            Notify();
        }

        private void RecalculateSate()
        {
            _isOnReserve = _fillLevel <= 5 ? true : false;
            _isComplete = _fillLevel >= 60 ? true : false;

            if (_isComplete)
            {
                _fillLevel = 60;
            }

            if (_fillLevel < 0)
            {
                _fillLevel = 0;
            }
        }
    }

    public class FuelTankDisplay : Observer, IFuelTankDisplay
    {
        IFuelTank fuelTank;
        private double _fillLevel;
        private bool _isOnReserve;
        private bool _isComplete;
        
        public FuelTankDisplay(IFuelTank fuelTank)
        {
            this.fuelTank = fuelTank;
        }

        public double FillLevel 
        {
            get => _fillLevel;
        }

        public bool IsOnReserve => _isOnReserve;

        public bool IsComplete => _isComplete;

        public override void Update()
        {
            _fillLevel = Math.Round(fuelTank.FillLevel, 2);
            _isOnReserve = fuelTank.IsOnReserve;
            _isComplete = fuelTank.IsComplete;
        }
    }
}
