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

        public Column(int _id, string _status, int floor_amount, int elevator_amount, List<int> servedFloorsList, bool _isBasement) 
        {
            this.ID = _id;
            this.status = _status;
            this.amountOfFloor = floor_amount;
            this.amountOfElevators = elevator_amount;
            this.elevatorsList = new List<Elevator>();
            this.callButtonsList = new List<CallButton>();
            // var servedFloorsList = new List<int>(){_servedFloors};

            createElevators(floor_amount, elevator_amount);
            createCallButtons(floor_amount, _isBasement);
        }
        public void createElevators(int floor_amount, int elevator_amount)
        {
            int elevatorID = 1;
            for (int i = 1; i <= elevator_amount; i++)
            {
                Elevator elevator = new Elevator(elevatorID, "idle", floor_amount, 1);
                elevatorsList.Add(elevator);
                elevatorID += 1;
            }
        }
        public void createCallButtons(int floor_amount, bool _isBasement)
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
        public void requestElevator(int userPosition, string userDirection)
        {
            var elevator = this.findElevator(userPosition, userDirection);
            elevator.floorRequestList.Add(userPosition);
            elevator.SortFloorList();
            elevator.Move();
            Doors.doorsInstructions();
        }
        public Elevator findElevator(int callPosition, string callDirection)
        {
            var dataset = new Dictionary<string, dynamic>(){
                {"bestElevator", 0},
                {"bestscore", 6}, 
                {"referenceGap", 100000}    
            };
            if (callPosition == 1)
            {
                foreach (Elevator elevator in this.elevatorsList)
                {
                    if (elevator.currentFloor == 1 && elevator.status == "stopped")
                    {
                        dataset = this.checkIfElevatorIsBetter(1, elevator, dataset, callPosition);
                    }
                    else if(elevator.currentFloor == 1 && elevator.status == "idle")
                    {
                        dataset = this.checkIfElevatorIsBetter(2, elevator, dataset, callPosition);
                    }
                    else if(elevator.currentFloor < 1 && elevator.direction == "up")
                    {
                        dataset = this.checkIfElevatorIsBetter(3, elevator, dataset, callPosition);
                    }
                    else if(elevator.currentFloor > 1 && elevator.direction == "down")
                    {
                        dataset = this.checkIfElevatorIsBetter(3, elevator, dataset, callPosition);
                    }
                    else if(elevator.status == "idle")
                    {
                        dataset = this.checkIfElevatorIsBetter(4, elevator, dataset, callPosition);
                    }
                    else
                    {
                        dataset = this.checkIfElevatorIsBetter(5, elevator, dataset, callPosition);
                    }
                }
            }
            else
            {    
                foreach (Elevator elevator in this.elevatorsList)
                {
                    if (elevator.currentFloor == callPosition && elevator.status == "stopped" && callDirection == elevator.direction)
                    {
                        dataset = this.checkIfElevatorIsBetter(1, elevator, dataset, callPosition);
                    }
                    else if(callPosition > elevator.currentFloor && elevator.direction == "up" && callDirection == "up")
                    {
                        dataset = this.checkIfElevatorIsBetter(2, elevator, dataset, callPosition);
                    }
                    else if(callPosition < elevator.currentFloor && elevator.direction == "down" && callDirection == "down")
                    {
                        dataset = this.checkIfElevatorIsBetter(2, elevator, dataset, callPosition);
                    }
                    else if(elevator.status == "idle")
                    {
                        dataset = this.checkIfElevatorIsBetter(4, elevator, dataset, callPosition);
                    }
                    else
                    {
                        dataset = this.checkIfElevatorIsBetter(5, elevator, dataset, callPosition);
                    }
                    dataset["bestElevator"] = 
                }
            }
            
        }
        public Dictionary<string,dynamic> checkIfElevatorIsBetter(int scoreToCheck, Elevator newElevator, Dictionary<string, dynamic> dataset, int floor)
        {
            if (scoreToCheck < dataset["bestScore"])
            {
                dataset["bestscore"] = scoreToCheck;
                dataset["bestElevator"] = newElevator;
                dataset["referenceGap"] = (newElevator.currentFloor - floor);
            }
        }
    }
}
            //Console.WriteLine("Hello World!");                  //TEST
            //Column column = new Column(2,"yeah",2,2,0,true);
            //Console.WriteLine(columnID);
            //Console.WriteLine(column.columnsList[0].ID);
