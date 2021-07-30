using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_type_HW
{
    public static class PermissionForFiles
    {
        public static bool permissionForFile1 = true;
        public static bool permissionForFile2 = false;
        public static bool permissionForFile3 = true;
        public static string Type { get; set; }

        static PermissionForFiles()
        {
            Type = "I'm a static class";
            Console.WriteLine(Type);
        }

        public static void myFunc1()
        {

        }

        public static void myFunc2()
        {

        }

    }
}
