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

        public Column(int _id, string _status, int amountOfFloors, int amountOfElevators, List<int> servedFloorsList, bool _isBasement) 
        {
            this.ID = _id;
            this.status = _status;
            this.amountOfFloor = amountOfFloors;
            this.amountOfElevators = amountOfElevators;
            this.elevatorsList = new List<Elevator>();
            this.callButtonsList = new List<CallButton>();
            // var servedFloorsList = new List<int>(){_servedFloors};

            createElevators(amountOfFloors, amountOfElevators);
            createCallButtons(amountOfFloors, _isBasement);
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
        }
        public void createCallButtons(int amountOfFloors, bool _isBasement)
        {
            int callButtonID = 1;
            if (_isBasement == false)
            {
                int buttonFloor = 1;
                // int callButtonID = 1;
                for (int i = 1; i <= amountOfFloors; i++)
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
                for (int i = 1; i <= amountOfFloors; i++)
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

             //Doors.operateDoors();
        }
        public Elevator findElevator(int callPosition, string callDirection)
        {
            var bestElevatorInformation = new Dictionary<string, dynamic>(){
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
                        bestElevatorInformation = this.checkIfElevatorIsBetter(1, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(elevator.currentFloor == 1 && elevator.status == "idle")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(2, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(elevator.currentFloor < 1 && elevator.direction == "up")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(3, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(elevator.currentFloor > 1 && elevator.direction == "down")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(3, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(elevator.status == "idle")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(4, elevator, bestElevatorInformation, callPosition);
                    }
                    else
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(5, elevator, bestElevatorInformation, callPosition);
                    }
                }
            }
            else
            {    
                foreach (Elevator elevator in this.elevatorsList)
                {
                    if (elevator.currentFloor == callPosition && elevator.status == "stopped" && callDirection == elevator.direction)
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(1, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(callPosition > elevator.currentFloor && elevator.direction == "up" && callDirection == "up")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(2, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(callPosition < elevator.currentFloor && elevator.direction == "down" && callDirection == "down")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(2, elevator, bestElevatorInformation, callPosition);
                    }
                    else if(elevator.status == "idle")
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(4, elevator, bestElevatorInformation, callPosition);
                    }
                    else
                    {
                        bestElevatorInformation = this.checkIfElevatorIsBetter(5, elevator, bestElevatorInformation, callPosition);
                    }

                    //int bestElevator = bestElevatorInformation["bestElevator"];                                                                    
                    //int bestScore = bestElevatorInformation["bestScore"];                                                                          
                    //int referenceGap = bestElevatorInformation["referencegap"];    
                }
            };
            return bestElevatorInformation["bestElevator"];    
    
    }

        public Dictionary<string,dynamic> checkIfElevatorIsBetter(int scoreToCheck, Elevator newElevator, Dictionary<string, dynamic> bestElevatorInformation, int floor)
        {
            if (scoreToCheck < bestElevatorInformation["bestScore"])
            {
                bestElevatorInformation["bestscore"] = scoreToCheck;
                bestElevatorInformation["bestElevator"] = newElevator;
                bestElevatorInformation["referenceGap"] = (newElevator.currentFloor - floor);
            }
            else if(bestElevatorInformation["bestscore"] == scoreToCheck)
            {
                int gap = Math.Abs(newElevator.currentFloor - floor);
                if(bestElevatorInformation["referenceGap"] > gap)
                {
                    bestElevatorInformation["bestscore"] = scoreToCheck;
                    bestElevatorInformation["bestElevator"] = newElevator;
                    bestElevatorInformation["referenceGap"] = gap;  
                }
            }
            return bestElevatorInformation;
        }
    }
}
            //Console.WriteLine("Hello World!");                  //TEST
            //Column column = new Column(2,"yeah",2,2,0,true);
            //Console.WriteLine(columnID);
            //Console.WriteLine(column.columnsList[0].ID);

                    //int bestElevator = bestElevatorInformations["bestElevator"];                                                                    
                    //int bestScore = bestElevatorInformations["bestScore"];                                                                          
                    //int referenceGap = bestElevatorInformations["referencegap"]; 
