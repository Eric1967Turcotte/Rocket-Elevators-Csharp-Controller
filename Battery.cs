

public class Battery
{
    public int ID;
    public string status;
    public int amountOfFloors;
    public int amountOfColumns;
    public int amountOfBasements;
    public int columnID;
    public List<Column> columnsList;
    public List<CallButton> callButtonsList;
    
    public Battery(int id, int amountOfColumns, string status, int amountOfFloors, int amountOfBasements, int amountOfElevatorPerColumn)
    {
        this.ID = id;
        this.amountOfColumns = amountOfColumns;
        this.status = status;
        this.amountOfFloors = amountOfFloors;
        this.amountOfBasements = amountOfBasements;
        this.columnsList = new List<Column>();
        this.callButtonsList = new List<CallButton>();
        this.columnID = 1;

    }

} 

    // assignElevator(requestedFloor, direction)
    //findBestColumn(requestedFloor)

    //createFloorRequestButtons(amountOfFloors)
    //createColumns(amountOfColumns, amountOfFloors, amountOfElevatorPerColumn)

 
//methods=========================

    //Create Basement Column Method

    static void createBasementColumn(int amountOfColumn, int amountOfFloors, int amountOfBasements, int amountOfElevatorPerColumn)
    {
        List<int> servedFloors = new List<int>();
        this.floor = -1;

        foreach (amountOfBasements)
            floor.add( new servedFloors()); // (new servedFloors(floor++))???
                // decrement floor

        this.column = new Column(int columnID, string "online", int amountOfBasements, int amountOfElevatorPerColumn, int servedFloors)
            column.add(this.columnList)//???
                // columnID++;
    //END Create Basement Column Method

    }


}