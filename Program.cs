using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rocket_Elevators_Csharp_Controller
{ 
          [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
           // Battery battery = new Battery(1, "online", 4, 60, 6, 5);
           // System.Console.WriteLine(battery);

            //Console.WriteLine("Hello World!");                  //TEST
            //Column column = new Column(2,"yeah",2,2,0,true);
            //Console.WriteLine(columnID);
            //Console.WriteLine(battery.columnsList[0].ID);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

            //Console.WriteLine("Hello World!");
            //Battery battery = new Battery(2,2,"yeah",2,2,2);
            //Console.WriteLine(battery.ID);
            //Console.WriteLine(battery.columnsList[0].ID);

    /*       public static void Scenario1();
         {

                    Battery battery = new Battery(1, 4, "online", 60, 5);
                    battery.columnList[1].elevatorsList[0].currentFloor = 20;
                    battery.columnList[1].elevatorsList[0].floorRequestButtonsList.Add(5);
                    battery.columnList[1].elevatorsList[0].currentFloor = 20;
                    battery.columnList[1].elevatorsList[0].floorRequestButtonsList.Add(5);
                    battery.columnList[1].elevatorsList[0].currentFloor = 20;
                    battery.columnList[1].elevatorsList[0].floorRequestButtonsList.Add(5);
                    battery.columnList[1].elevatorsList[0].currentFloor = 20;
                    battery.columnList[1].elevatorsList[0].floorRequestButtonsList.Add(5);
                    battery.columnList[1].elevatorsList[0].currentFloor = 20;
                    battery.columnList[1].elevatorsList[0].floorRequestButtonsList.Add(5);

                    battery.assignElevator(20, "up");

                    static void Main(string[] args)
                    {
                        Scenario1();
                    }   
         }      */