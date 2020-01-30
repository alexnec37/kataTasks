using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace codewars
{
    public interface IVisitor
    {
        void VisitLight(ILightUnit unit);
        void VisitArmored(IArmoredUnit unit);
    }

    public interface ILightUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }

    public interface IArmoredUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }

    public class Marine : ILightUnit
    {
        public int Health { get; set; }

        public Marine()
        {
            Health = 100;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }

    class Map 
    {
        ArrayList units;

        public void Accept(IVisitor visitor)
        {
            // так как у юнитов нет общего предка а по правилам должен быть
            //foreach(var item in units)
            //{
            //    item.Accept();
            //}
        }
    }

    public class Marauder : IArmoredUnit
    {
        public int Health { get; set; }

        public Marauder()
        {
            Health = 125;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitArmored(this);
        }
    }

    public class TankBullet : IVisitor
    {
        public void VisitLight(ILightUnit unit)
        {
            unit.Health -= 21;
        }

        public void VisitArmored(IArmoredUnit unit)
        {
            unit.Health -= 32;
        }
    }
}
