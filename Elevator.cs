using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Elevator
{
   public int ID;
   public string status;
   public int amountOfFloors;
   public string direction;
   public int currentFloor;
   public int Door; 
   public List<floorRequest> floorRequestList; //??

   public Elevator(int id, string status, int amountOfFloors, int currentFloor)
   {
       this.ID = id;
       this.status = status;
       this.amountOfFloors = amountOfFloors;
       this.currentFloor = currentFloor;

   }

//move

   public void Move(){

   }

//sortFloorList

//operateDoors (move to Door)



}
//Console.WriteLine(val1 + val2);
   //Console.WriteLine(val1 < val2);
   //Console.WriteLine(!(status));
   //Console.ReadKey();