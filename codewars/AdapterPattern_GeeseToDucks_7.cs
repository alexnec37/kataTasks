using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern_GeeseToDucks
{
    public interface IDuck
    {
        string Quack();
        void Fly();
    }

    public class Goose
    {
        public string Honk() => "sdasdsd";
        public void Fly() => Console.WriteLine("I am flying");
    }

    public class GooseToIDuckAdapter : IDuck
    {
        private Goose goose;
        public GooseToIDuckAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Fly()
        {
            this.goose.Fly();
        }

        public string Quack()
        {
            return this.goose.Honk();
        }
    }
}
