using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            Engine engine = new Engine();
            engine.manufacturer = "Motors";
            engine.power = 500;

            Car audi = new Car();
            audi.colour = "Red";
            //audi.wheels = 4;            
            audi.model = "Audi";
            audi.engine = engine;

            Console.WriteLine(audi.getMaxSpeed());

           /* Person p1 = new Person();
            Person.showCounter();

            /*p1.name = "Ivan";
            p1.age = 21;
            p1.gender = "Man";

            p1.showInfo();


            Person p2 = new Person();
            Person.showCounter();
            Person p3 = new Person();
            Person.showCounter();*/

            Console.ReadLine();
        }
    }

    class Calculator
    {
        
        private double _result;
        public double result
        {
            get { return _result; }
        }

        public void Add(int num)
        {
            _result += num;
        }
        public void Inc()
        {
            _result++;
        }
        public void Sub(int num)
        {
           _result -= num;
        }
        public void Dec()
        {
            _result--;
        }
        public void Mult(int num)
        {
            _result *= num;
        }
        public void Div(double num)
        {
            _result /= num;
        }
    }

   /* class Person
    {
        public static int counter = 0;
        public string name;
        public int age;
        public string gender;

        public Person()
        {
            Console.WriteLine("Person was created");
            counter++;
        }

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void showInfo()
        {
            Console.WriteLine("{0} {1} {2}", name, age, gender);
        }

        public static void showCounter()
        {
            Console.WriteLine(counter);
        }*/

   class Car
    {

        private int _wheels;
        public int wheels
        {
            get { return _wheels; }
        }
        public string model { get; set; }
        public string colour { get; set; }
        public Engine engine { get; set; }

        public Car()
        {
            _wheels = 4;
        }

        public Car(int wheels, string model, string colour)
        {
            this._wheels = wheels;
            this.model = model;
            this.colour = colour;
        }

            public double getMaxSpeed()
        {
            double result = (engine.power * wheels) / 8;
            return result;
        }
    }
    class Engine
    {
        public int power { get; set; }
        public string manufacturer { get; set; }
    }
}
