using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rocket_Elevators_Csharp_Controller
{ 
         
    class Program
    {
/*
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
  
}  */

/* static void Main(string[] args)
        {          
             Scenario2();

         
        }
        public static void Scenario2()
        {

            Battery battery = new Battery(1,"online", 4, 60, 6, 5);
            battery.columnsList[3].elevatorsList[0].currentFloor = 1;
            battery.columnsList[3].elevatorsList[0].status = "idle";
            battery.columnsList[3].elevatorsList[0].direction = "up";
            battery.columnsList[3].elevatorsList[0].floorRequestList.Add(21);

            battery.columnsList[3].elevatorsList[1].currentFloor = 23;
            battery.columnsList[3].elevatorsList[1].status = "moving";
            battery.columnsList[3].elevatorsList[1].direction = "up";
            battery.columnsList[3].elevatorsList[1].floorRequestList.Add(28);

            battery.columnsList[3].elevatorsList[2].currentFloor = 33;
            battery.columnsList[3].elevatorsList[2].status = "moving";
            battery.columnsList[3].elevatorsList[2].direction = "down";
            battery.columnsList[3].elevatorsList[2].floorRequestList.Add(1);

            battery.columnsList[3].elevatorsList[3].currentFloor = 40;
            battery.columnsList[3].elevatorsList[3].status = "moving";
            battery.columnsList[3].elevatorsList[3].direction = "down";
            battery.columnsList[3].elevatorsList[3].floorRequestList.Add(1);

            battery.columnsList[3].elevatorsList[4].currentFloor = 39;
            battery.columnsList[3].elevatorsList[4].status = "moving";
            battery.columnsList[3].elevatorsList[4].direction = "down";
            battery.columnsList[3].elevatorsList[4].floorRequestList.Add(1);


            battery.assignElevator(36, "up");

        }   
    }
  
} 

*/
/* static void Main(string[] args)
        {          
             Scenario3();

         
        }
        public static void Scenario3()
        {

            Battery battery = new Battery(1,"online", 4, 60, 6, 5);
            battery.columnsList[4].elevatorsList[0].currentFloor = 58;
            battery.columnsList[4].elevatorsList[0].status = "moving";
            battery.columnsList[4].elevatorsList[0].direction = "down";
            battery.columnsList[4].elevatorsList[0].floorRequestList.Add(1);

            battery.columnsList[4].elevatorsList[1].currentFloor = 50;
            battery.columnsList[4].elevatorsList[1].status = "moving";
            battery.columnsList[4].elevatorsList[1].direction = "up";
            battery.columnsList[4].elevatorsList[1].floorRequestList.Add(60);

            battery.columnsList[4].elevatorsList[2].currentFloor = 46;
            battery.columnsList[4].elevatorsList[2].status = "moving";
            battery.columnsList[4].elevatorsList[2].direction = "up";
            battery.columnsList[4].elevatorsList[2].floorRequestList.Add(58);

            battery.columnsList[4].elevatorsList[3].currentFloor = 1;
            battery.columnsList[4].elevatorsList[3].status = "moving";
            battery.columnsList[4].elevatorsList[3].direction = "up";
            battery.columnsList[4].elevatorsList[3].floorRequestList.Add(54);

            battery.columnsList[4].elevatorsList[4].currentFloor = 60;
            battery.columnsList[4].elevatorsList[4].status = "moving";
            battery.columnsList[4].elevatorsList[4].direction = "down";
            battery.columnsList[4].elevatorsList[4].floorRequestList.Add(1);


            battery.assignElevator(1, "down");

        }   
    }
  
} */

 /*static void Main(string[] args)
        {          
             Scenario4();

         
        }
        public static void Scenario4()
        {

            Battery battery = new Battery(1,"online", 4, 60, 6, 5);
            battery.columnsList[1].elevatorsList[0].currentFloor = 4;
            battery.columnsList[1].elevatorsList[0].status = "idle";
            battery.columnsList[1].elevatorsList[0].direction = "stoped";
            battery.columnsList[1].elevatorsList[0].floorRequestList.Add(0);

            battery.columnsList[1].elevatorsList[1].currentFloor = 1;
            battery.columnsList[1].elevatorsList[1].status = "idle";
            battery.columnsList[1].elevatorsList[1].direction = "stoped";
            battery.columnsList[1].elevatorsList[1].floorRequestList.Add(0);

            battery.columnsList[1].elevatorsList[2].currentFloor = 3;
            battery.columnsList[1].elevatorsList[2].status = "moving";
            battery.columnsList[1].elevatorsList[2].direction = "down";
            battery.columnsList[1].elevatorsList[2].floorRequestList.Add(5);

            battery.columnsList[1].elevatorsList[3].currentFloor = 6;
            battery.columnsList[1].elevatorsList[3].status = "moving";
            battery.columnsList[1].elevatorsList[3].direction = "up";
            battery.columnsList[1].elevatorsList[3].floorRequestList.Add(1);

            battery.columnsList[1].elevatorsList[4].currentFloor = 1;
            battery.columnsList[1].elevatorsList[4].status = "moving";
            battery.columnsList[1].elevatorsList[4].direction = "down";
            battery.columnsList[1].elevatorsList[4].floorRequestList.Add(6);


            battery.assignElevator(1, "up");

        }   
    }
  
} */