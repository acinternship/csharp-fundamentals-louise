using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar   = new Car();

            Car.myMethod()

            /*
            myCar.Make  = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year  = 1978;
            myCar.Color = "Silver";
            

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make,
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Color);


            myOtherCar.Model = "98";
            
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar = null;

        
            Console.WriteLine("{0} {1} {2} {3}",
               myOtherCar.Make,
               myOtherCar.Model,
               myOtherCar.Year,
               myOtherCar.Color);
            

            Console.ReadLine(); 

        }
    }

    
    */
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

       /*
        public Car()
        {
            //You could load from a configuration file, 
            //or from db, etc.
            this.Make = "Nissan";
        }
        

        public Car(string make, string model, int year, string color)
        {
            Make  = make;
            Model = model;
            Year  = year;
            Color = color;
        }
       

    */
       public static void myMethod()
        {
            Console.WriteLine("Called Static myMehtod");
            Console.WriteLine(Make);
        }





    }
}
