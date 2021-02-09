using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Rocket_Elevators_Csharp_Controller
{

public class Battery
{
    public int ID;
    public string status;
    public int amountOfFloors;
    public int amountOfColumns;
    public int amountOfBasements;
    public int columnID;
    public List<Column> columnsList;
    public List<FloorRequestButton> floorRequestButtonsList;
        private object column;

        public Battery(int id, int amountOfColumns, string status, int amountOfFloors, int amountOfBasements, int amountOfElevatorPerColumn)
    {
        this.ID = id;
        this.amountOfColumns = amountOfColumns;
        this.status = status;
        this.amountOfFloors = amountOfFloors;
        this.amountOfBasements = amountOfBasements;
        this.columnsList = new List<Column>();
        this.floorRequestButtonsList = new List<FloorRequestButton>();
        this.columnID = 1;

    }

     // Method assignElevator(requestedFloor, direction)

    public void assignElevator(int requestedFloor, string direction)
    {
       ref.column = this.findBestColumn(int requestedFloor)
            return column
    }   

    //findBestColumn(requestedFloor)

    public void findBestColumn(int requestedFloor)
    {

    }

    //Call createFloorRequestButtons(amountOfFloors)
    //Call createColumns(amountOfColumns, amountOfFloors, amountOfElevatorPerColumn)

 
//methods=========================

    //Create Basement Column Method

    //END Create Basement Column Method

//Console.WriteLine(val1 + val2);
   //Console.WriteLine(val1 < val2);
   //Console.WriteLine(!(status));
   //Console.ReadKey();


    } 
  }