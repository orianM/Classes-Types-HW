using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_type_HW
{
    public abstract class VehicleBase
    {
        public int NumOfWheels { get; set; }
        public string Model { get; set; }


        public VehicleBase()
        {

        }

        protected VehicleBase(int numOfWheels, string model)
        {
            NumOfWheels = numOfWheels;
            Model = model;
        }

        public abstract int GetMaxNumOfPassengers();

        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"{Model + NumOfWheels} Wheels ";
        }
    }
}
