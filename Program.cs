using System;

namespace Exercise3
{
    class Car
    {
        public string color = "red";
        public int maxspeed = 200;

    }

   
    class Program 
    { 

        static void Main(string[] args)
        {
            Car myobj1 = new Car();
            Car myobj2 = new Car();
            Console.WriteLine(myobj1.color);
            Console.WriteLine(myobj2.maxspeed);
        }
    }
}
