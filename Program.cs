using System;
//using System.Linq;
//using System.Collections;
//using System.Collections.Generic;

namespace Rocket_Elevators_Csharp_Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Battery battery = new Battery(2,2,"yeah",2,2,2);
            Console.WriteLine(battery.ID);
            Console.WriteLine(battery.columnsList[0].ID);
        }
    }
}
