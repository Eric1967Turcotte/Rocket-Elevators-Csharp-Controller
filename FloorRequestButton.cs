

public class FloorRequestButton
{
    public int ID;
    public string status;
    public int floor;
    public string direction;
    
    public FloorRequestButton(int id, string status, int floor, string direction)
    {
        this.ID = id;
        this.status = status;
        this.floor = floor;
        this.direction = direction;
    }
}