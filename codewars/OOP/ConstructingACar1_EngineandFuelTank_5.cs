using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace codewars.OOP.nConstructingACar1_EngineandFuelTank_5
{
    public interface ICar
    {
        bool EngineIsRunning { get; }

        void EngineStart();

        void EngineStop();

        void Refuel(double liters);

        void RunningIdle();
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

        private IEngine engine;

        private IFuelTank fuelTank;

        public Car(double fuelLevel = 20)
        {
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
        }

        public bool EngineIsRunning => engine.IsRunning;

        public void EngineStart()
        {
            engine.Start();
        }

        public void EngineStop()
        {
            engine.Stop();
        }

        public void Refuel(double liters)
        {
            fuelTank.Refuel(liters);
        }

        public void RunningIdle()
        {
            engine.Consume(0.0003);
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
