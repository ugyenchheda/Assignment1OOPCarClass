using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1OOPCarClass;

namespace carinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(2023, "Tesla", "S", 0);

            Console.WriteLine("You are in your front garden.");
            Console.WriteLine("Your car is in the garage.");
            Console.WriteLine("You can end this by chosing E.");
            Console.WriteLine("More speed, current speed, less speed (MCL)?.");

            string chooseOption = "";
            while (chooseOption != "e")
            {
                chooseOption = Console.ReadLine();
                {
                    switch (chooseOption)
                    {
                        case "e":
                            Console.WriteLine("Bye Bye");
                            break;
                        case "m":
                            if(myCar.Speed >= 20)
                                Console.WriteLine("You cannot go faster than 20Km/h.");
                            else 
                                Console.WriteLine("Your current is speed is {0} km/h.", myCar.Accelerate());
                                Console.WriteLine("More speed, current speed, less speed (MCL)?.");
                            break;
                        case "c":
                            Console.WriteLine("Your current constant speed is {0} km/h.", myCar.Speed);
                            Console.WriteLine("More speed, current speed, less speed (CL)?.");
                            break;
                        case "l":
                            if (myCar.Speed <= 0)
                                Console.WriteLine("Your are currently not moving at all.");
                            else
                                Console.WriteLine("Your current speed is {0} km/h.", myCar.Brake());
                                Console.WriteLine("More speed, current speed, less speed (MCL)?.");
                            break;
                        default:
                            Console.WriteLine("Not a valid option.");
                            break;
                    }


                }


            }

        }
    }
}
