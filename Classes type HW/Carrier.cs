using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_type_HW
{
    class Carrier
    {
        public VehicleBase[] Vehicle { get; set; }

        public Carrier(VehicleBase[] myVehicles)
        {
                Vehicle = myVehicles;
        }

        public override string ToString()
        {
            string variable = "";
            for (int i = 0; i < Vehicle.Length; i++)
            {
                variable += $"\n{Vehicle[i]}";
            }
            return variable;
        }
    }
}
