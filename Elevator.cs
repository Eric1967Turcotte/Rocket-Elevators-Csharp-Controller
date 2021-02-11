using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rocket_Elevators_Csharp_Controller
{
    public class Elevator
    {
        public int ID;
        public string status;
        public int amountOfFloor;
        public string direction;
        public int currentFloor;
        public List<int> floorRequestList;

        public Elevator(int _id, string _status, int _amountOfFloor, int _currentFloor)
        {
            this.ID = _id;
            this.status = _status;
            this.amountOfFloor = _amountOfFloor;
            this.direction = "none";
            this.currentFloor = 1;
            this.floorRequestList = new List<int>();
            var doors = new Doors(ID,"closed");
        }
        public void Move()
        {
            
            while (this.floorRequestList.Count != 0)                                    // execute the next operations until the floorrequest list is empty
            {                                                
            int goToFloor = this.floorRequestList [0];                                  // going to the first floor in the list
            this.status = "moving";
        
                if (this.currentFloor < goToFloor) {                                    // instructions if the request floor is above
                    this.direction = "up";
                    while (this.currentFloor < goToFloor)
                    {
                        this.currentFloor++; // console.log("The elevator is moving up to floor",this.currentFloor + 1)
                    }
                }
                else if (this.currentFloor > goToFloor)                                // instructions if the request floor is below
                {                                               
                    this.direction = "down";
                    while (this.currentFloor > goToFloor)
                    {
                        this.currentFloor--;// console.log("The elevator is moving down to floor",this.currentFloor - 1)
                    }
                } 
                else
                {                                    
                    this.status = "stopped";                                            // instructions when we are at the floor
                    // console.log("The elevator is",this.status,"at floor",this.currentFloor)
                    this.direction = null;
                    this.floorRequestList.RemoveAt(0);
                }
            }
            this.status = "idle";

        }
        public void SortFloorList()
        {
            if (this.direction == "up")
            {
                floorRequestList.Sort();
            }
            else
            {
                floorRequestList.Sort();
                floorRequestList.Reverse();
            }
            System.Console.WriteLine("The floor request list: " + floorRequestList[0]);
            
        }
    }
}
