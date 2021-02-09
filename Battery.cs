

public class Battery
{
    public int ID;
    public string status;
    public int amountOfFloors;
    public int amountOfBasements;
    public List<Column> columnsList;
    public List<CallButton> callButtonsList;
    
    public Battery(int _id, int _amountOfColumns, string _status, int _amountOfFloors, int _amountOfBasements, int _amountOfElevatorPerColumn)
    {
        this.ID = _id;
        this.status = _status;
        this.amountOfFloors = _amountOfFloors;
        this.amountOfBasements = _amountOfBasements;
        this.columnsList = //??
        this.callButtonsList = //??

    }

} 



    public void assignElevator(int requestedFloor, string direction);
    public void findBestColumn(int requestedFloor);





}