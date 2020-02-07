using System;

namespace OOPclass
{
    class Car
    {
        public string color;
        public int maxSpeed;
        public string model;
        public int year;
        

        public Car(string modelName, string modelColor, int modelYear)
        {
        model= modelName;
        color= modelColor;
        year = modelYear;
        }
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }
}


            
        

    
    
    
 