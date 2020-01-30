using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCraft_Adapter_7
{
    public class Target
    {
        public int Health { get; set; }
    }
    public interface IUnit
    {
        void Attack(Target target);
    }

    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }

    public class Zealot : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 8;
        }
    }

    public class Zergling : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 5;
        }
    }

    public class Mario
    {
        public int jumpAttack()
        {
            Console.WriteLine("Mamamia!");
            return 3;
        }
    }

    public class MarioAdapter : IUnit
    {
        private Mario mario;
        public MarioAdapter(Mario mario)
        {
            this.mario = mario;
        }

        public void Attack(Target target)
        {
            int dmg = this.mario.jumpAttack();
            target.Health -= dmg;
        }
    }
}
