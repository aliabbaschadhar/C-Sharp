using System;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            //  getters & setters =  Add a security to fields by encapulation
            //                      They're accessors found within properties
            // porperties = Combine aspects of both fields and methods( share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to set the property new value
            // value keyword = defines the value being asigned by the set (parameter)   

            Car car = new Car(389989);
            // car.Speed = 100000000;

            Console.WriteLine(car.Speed);
        }
    }

    class Car
    {
        int speed;

        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else if (value > 200)
                {
                    speed = 200;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}