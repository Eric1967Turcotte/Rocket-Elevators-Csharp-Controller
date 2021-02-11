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
            
            while (this.floorRequestList.Count != 0)                                    
            {                                                
            int goToFloor = this.floorRequestList [0];                                 
            this.status = "moving";
        
                if (this.currentFloor < goToFloor) {                                  
                    this.direction = "up";
                    while (this.currentFloor < goToFloor)
                    {
                        this.currentFloor++; 
                    }
                }
                else if (this.currentFloor > goToFloor)                                
                {                                               
                    this.direction = "down";
                    while (this.currentFloor > goToFloor)
                    {
                        this.currentFloor--;
                    }
                } 
                else
                {                                    
                    this.status = "stopped";                                           
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
