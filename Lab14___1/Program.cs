using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14___1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal c = new Cat();
            c.ShowInfo();
            Animal d = new Dog();
            d.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string AnimalNames { get; set; }
        public Animal()
        {
        }
        public abstract string Say();
        
        
        public virtual void ShowInfo()
        {
            Console.WriteLine(AnimalNames, Say());
        }
    }
    class Cat: Animal
    {
        string name = "Кошка";
        public override string AnimalNames
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public override string Say()
        {
            return "Мяу";
        }
        public override void ShowInfo()
        {
            Console.WriteLine("{0} говорит {1}", AnimalNames, Say());
        }
    }
    class Dog: Animal
    {
        string name = "Собака";
        public override string AnimalNames
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say ()
        {
            return "Гав";
        }
        public override void ShowInfo()
        {
           Console.WriteLine("{0} говорит {1}", AnimalNames, Say());
        }
    }

}
