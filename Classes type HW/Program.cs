using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_type_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from main");

            #region question 1

            /*class types: a. sealed class - is a class that can not be inherited.
              
                           b. static class - is a class in which all fields/functions must be static, it isn't possible
                             to create an instance of a static class and also not possible to inherit from static class.

                           c. abstract class - is a class that can be inherited but not create an instance of.
                              all inherting classes of an abstract class must utilize all "abstract" properties/functions of the class,
                              abstract classes can also include fields/functions that don't have to be utilized.*/

            #endregion

            #region question 2

            /*a sealed class is used when creating a class that you don't want any class to inherit.
              a static class is used when creating a class that is full of only static fields/functions.
              an abstract class is used when creating a class that will methods/properties that must be used by inherting classes.*/

            #endregion

            #region question 3

            /*a static class in different than a sealed class because; it's possible to create an instance of a sealed class,
                                                                       but it's not possible to create an instance of a static class.*/

            #endregion

            #region question 4

            /*a sealed class doesn't work with abstract functions since no class can inherit from it.*/

            #endregion

            #region question 5

            /*it is possible to declare a specific function as sealed, when overriding.*/

            #endregion

            #region question 6

            /*a. differences between abstract class and interface: 1. abstract can include fields, interface can't.
                                                                   2. abstract can include functions that the inherting class doesn't
                                                                      have to intialize, in interface all functions must be intialized.
                                                                   3. in abstract the inherting class must Override the abstract method,
                                                                      in interface you just need to intialize the method.
            
             b. similarities between abstract class and interface: 1. it's not possible to create an instance of,
                                                                      the abstract class or interface.
                                                                   2. methods can not be intialized in neither, 
                                                                      abstract class or interface, only signature declared.*/
            #endregion

            #region question 7

            OS myC = new OS();

            #endregion

            #region question 8
            bool firstfile = PermissionForFiles.permissionForFile1;
            bool sceondfile = PermissionForFiles.permissionForFile2;
            bool thirdfile = PermissionForFiles.permissionForFile3;

            PermissionForFiles.myFunc1();
            PermissionForFiles.myFunc2();

            //constructor prints first.
            Console.WriteLine($"\n{PermissionForFiles.Type}");

            #endregion

            #region question 9


            VehicleBase myCar1 = new Car()
            {
                Model = "Lamborghini\n",
                NumOfWheels = 4,
                NumOfDoors = 2
            };
            
            VehicleBase myCar2 = new Car()
            {
                Model = "\nFerrari\n",
                NumOfWheels = 4,
                NumOfDoors = 2
            };

            VehicleBase myCar3 = new Car()
            {
                Model = "\nJeep\n",
                NumOfWheels = 4,
                NumOfDoors = 4
            };

            VehicleBase myMotorC1 = new Motorcycle()
            {
                Model = "\nHonda\n",
                NumOfWheels = 2,
                NumberOfHandBrakes = 2
            };

            VehicleBase myMotorC2 = new Motorcycle()
            {
                Model = "\nHarley Davidson\n",
                NumOfWheels = 2,
                NumberOfHandBrakes = 2
            };

            VehicleBase myMotorC3 = new Motorcycle()
            {
                Model = "\nKawasaki\n",
                NumOfWheels = 2,
                NumberOfHandBrakes = 2
            };

            VehicleBase[] myVehicles = { myCar1, myCar2, myCar3, myMotorC1, myMotorC2, myMotorC3 };

            Carrier vehicles = new Carrier(myVehicles);
            Console.WriteLine(vehicles.ToString());

            #endregion
        }
    }
}
