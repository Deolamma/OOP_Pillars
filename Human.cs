using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPillars
{
    class Human
    {
        private string _name;
        private int _age;
        
        public Human(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name()
        {
            return this._name;
        }
        public int Age()
        {
            return this._age;
        }

        public void Eat_Breathe()
        {
            Console.WriteLine("I can eat and breathe");
        }

        public virtual bool Is_Disabled()
        {
            return false;
        }

        public virtual void Work()
        {
            Console.WriteLine("I believe every human should work");
        }

        public void HumanInfo()
        {
            Console.WriteLine($"My name is {this._name} and I am {this._age} years old");
        }
    }

    class Student : Human
    {
        private bool _is_disabled;
        public Student(string name, int age, bool is_disabled) : base(name, age)
        {
            this._is_disabled = is_disabled;
        }

        public override bool Is_Disabled()
        {
            return this._is_disabled;
        }

        public override void Work()
        {
            Console.WriteLine("NO Human!!! I am underage and can't work");
        }


    }

    class Worker : Human
    {
        private bool _is_working;
        public Worker(string name, int age, bool is_working) : base(name, age)
        {
            this._is_working = is_working;
        }

        public new void Work()
        {
            if (this._is_working)
            {
                Console.WriteLine("I am disabled, but I work at Microsoft");
            } else
            {
                Console.WriteLine("I am Not disabled, I also work at Microsoft");
            }

        }
    }
}
