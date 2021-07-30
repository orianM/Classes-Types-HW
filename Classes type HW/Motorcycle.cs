using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_type_HW
{
    class Motorcycle : VehicleBase
    {
        public int NumberOfHandBrakes { get; set; }

        public Motorcycle()
        {

        }
        public Motorcycle(int numOfHandBreaks)
        {
            this.NumberOfHandBrakes = numOfHandBreaks;
        }

        public override int GetMaxNumOfPassengers()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 170;
        }

        public override string ToString()
        {
            return base.ToString() + $"{NumberOfHandBrakes} Handbreaks";
        }
    }
}
