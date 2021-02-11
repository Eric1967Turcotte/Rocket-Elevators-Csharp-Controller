using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rocket_Elevators_Csharp_Controller
{ 
         
    class Program
    {

    static void Main(string[] args)
        {          
             Scenario1();

         
        }
        public static void Scenario1()
        {

            Battery battery = new Battery(1,"online", 4, 60, 6, 5);
            battery.columnsList[2].elevatorsList[0].currentFloor = 20;
            battery.columnsList[2].elevatorsList[0].status = "moving";
            battery.columnsList[2].elevatorsList[0].direction = "down";
            battery.columnsList[2].elevatorsList[0].floorRequestList.Add(5);

            battery.columnsList[2].elevatorsList[1].currentFloor = 3;
            battery.columnsList[2].elevatorsList[1].status = "moving";
            battery.columnsList[2].elevatorsList[1].direction = "up";
            battery.columnsList[2].elevatorsList[1].floorRequestList.Add(15);

            battery.columnsList[2].elevatorsList[2].currentFloor = 13;
            battery.columnsList[2].elevatorsList[2].status = "moving";
            battery.columnsList[2].elevatorsList[2].direction = "down";
            battery.columnsList[2].elevatorsList[2].floorRequestList.Add(1);

            battery.columnsList[2].elevatorsList[3].currentFloor = 15;
            battery.columnsList[2].elevatorsList[3].status = "moving";
            battery.columnsList[2].elevatorsList[3].direction = "down";
            battery.columnsList[2].elevatorsList[3].floorRequestList.Add(2);

            battery.columnsList[2].elevatorsList[4].currentFloor = 6;
            battery.columnsList[2].elevatorsList[4].status = "moving";
            battery.columnsList[2].elevatorsList[4].direction = "down";
            battery.columnsList[2].elevatorsList[4].floorRequestList.Add(1);


            battery.assignElevator(20, "up");

        }           
       
    }
  
}           