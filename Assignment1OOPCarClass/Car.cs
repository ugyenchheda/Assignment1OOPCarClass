using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOPCarClass
{
    class Car
    {
        public Car(int yearmodel, string make, String model, int speed) {
            yearModel = yearmodel;
            Make = make;
            Model = model;
            Speed = speed;
        }
        public int yearModel { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public int Accelerate()
        {
            if (Speed < 20) { 
                Speed += 5;
            return Speed;
            }
            else
            {
                return Speed;
            }
        }

        public int Brake()
        { 
            if(Speed > 0)
            { 
               Speed -= 5;
            }
            return Speed;
        }

        public int CurrentSpeed()
        {
            return Speed;
        }
    }
}
