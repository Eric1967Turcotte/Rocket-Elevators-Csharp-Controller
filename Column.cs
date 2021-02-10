using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rocket_Elevators_Csharp_Controller
{

public class Column
{
        public int ID;
        public string status;
        public int amountOfFloor;
        public int amountOfElevators;
        public List<Elevator> elevatorsList;
        public List<CallButton> callButtonsList;
        public List<int> servedFloorsList;


   public Column(int id, string status, int amountOfFloors, int amountOfElevators, List<int> servedFloorsList, bool isBasement)
   {
            this.ID = id;
            this.status = status;
            this.amountOfFloors = amountOfFloors;
            this.amountOfElevators = amountOfElevators;
            //this.elevatorsList = new List<Elevator>();
            //this.callButtonsList = new List<CallButton>();


       

   }

   public void createElevators(int amountOfFloors, int amountOfElevators)
        {
            int elevatorID = 1;
            for (int i = 1; i <= amountOfElevators; i++)
            {
                Elevator elevator = new Elevator(elevatorID, "idle", amountOfFloors, 1);
                elevatorsList.Add(elevator);
                elevatorID += 1;
            }

              Console.WriteLine("Hello World!");                  //TEST
            Column column = new Column(2,"yeah",2,2,0,true);
            Console.WriteLine(columnID);
            Console.WriteLine(column.columnsList[0].ID);

}

//createCallButtons

/*     public void createCallButtons(int floor_amount, bool _isBasement)
        {
            int callButtonID = 1;
            if (_isBasement == false)
            {
                int buttonFloor = 1;
                // int callButtonID = 1;
                for (int i = 1; i <= floor_amount; i++)
                {
                    CallButton callButton = new CallButton(callButtonID, "off", buttonFloor, "down");
                    callButtonsList.Add(callButton);
                    buttonFloor += 1;
                    callButtonID += 1;
                }
            }
            else
            {
                int buttonFloor = -1;
                // int callButtonID = 1;
                for (int i = 1; i <= floor_amount; i++)
                {
                    CallButton callButton = new CallButton(i, "off", buttonFloor, "up");
                    callButtonsList.Add(callButton);
                    buttonFloor -= 1;
                    callButtonID += 1;
                } 
            }
        }
*/
//createElevators

            // Console.WriteLine("Hello World!");                  //TEST
           // Column column = new Column(2,"yeah",2,2,0,true);
            //Console.WriteLine(columnID);
           // Console.WriteLine(column.columnsList[0].ID);

//requestElevator

/*      public void requestElevator(int userPosition, string userDirection)
        {
            var elevator = this.findElevator(userPosition, userDirection);
            elevator.floorRequestList.Add(userPosition);
            elevator.SortFloorList();
            elevator.Move();
            Doors.doorsInstructions();
        }
*/
//findElevator

//checkIfElevatorIsBetter



}
            //Console.WriteLine("Hello World!");                  //TEST
            //Column column = new Column(2,"yeah",2,2,0,true);
            //Console.WriteLine(columnID);
            //Console.WriteLine(column.columnsList[0].ID);
