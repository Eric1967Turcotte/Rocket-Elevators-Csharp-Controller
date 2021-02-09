

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

}