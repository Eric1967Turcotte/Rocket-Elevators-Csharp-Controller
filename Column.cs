

public class Column
{
   public int ID;
   public string status;
   public int amountOfFloors;
   public int amountOfElevator;
   public List<Elevator> elevatorsList;
   public List<CallButton> callButtonsList;
   public List<FloorRequestButton> floorRequestButtonsList;

   public Column(int _id, string _status, int _amountOfFloors, int _amountOfElevators, int _servedFloors, int _isBasement)
   {
       this.ID = _id;
       this.status = _status;
       this.amountOfFloors = _amountOfFloors;
       this.amountOfElevator = _amountOfElevators;
       
   }

}