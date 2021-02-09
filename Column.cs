namespace Rocket_Elevators_Csharp_Controller
{

public class Column
{
   public int ID;
   public string status;
   public int amountOfFloors;
   public int amountOfElevator;
   public List<Elevator> elevatorsList;
   public List<CallButton> callButtonsList;
   public List<FloorRequestButton> floorRequestButtonsList;

   public Column(int id, string status, int amountOfFloors, int amountOfElevators, int servedFloors, int isBasement)
   {
       this.ID = id;
       this.status = status;
       this.amountOfFloors = amountOfFloors;
       this.amountOfElevator = amountOfElevators;
       this.elevatorsList = new List<Elevator>();
       this.callButtonsList = new List<CallButton>();
       this.floorRequestButtonsList = new List<FloorRequestButton>();
       
       
   }
}

//createCallButtons

//createElevators

//requestElevator

//findElevator

//checkIfElevatorIsBetter



}
//Console.WriteLine(val1 + val2);
   //Console.WriteLine(val1 < val2);
   //Console.WriteLine(!(status));
   //Console.ReadKey();