using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_type_HW
{
    class Car : VehicleBase
    {
        public int NumOfDoors { get; set; }

        public Car()
        {

        }
        public Car(int numOfDoors)
        {
            this.NumOfDoors = numOfDoors;
        }
        public override int GetMaxNumOfPassengers()
        {
            return 5;
        }

        public override int GetMaxSpeed()
        {
            return 200;
        }

        public override string ToString()
        {
            return base.ToString() + $"{NumOfDoors} Doors";
        }
    }
}
