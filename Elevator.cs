

public class Elevator
{
   public int ID;
   public string status;
   public int amountOfFloors;
   public string direction;
   public int currentFloor;
   public int Door; // verifier car Object
   public List<floorRequestList>;// a verifer List

   public Elevator(int _id, string _status, int _amountOfFloors, int _currentFloor)
   {
       this.ID = _id;
       this.status = _status;
       this.amountOfFloors = _amountOfFloors;
       this.currentFloor = _currentFloor;

   }

}