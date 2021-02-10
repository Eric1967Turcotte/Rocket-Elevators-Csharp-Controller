using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Diagnostics;

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
    //public List<FloorRequestButton> floorRequestButtonsList;
    public List<int> servedFloorsList;
    public List<int> servedFloors;


    public Battery(int id, string status, int amountOfColumns, int amountOfFloors, int amountOfBasements, int amountOfElevatorPerColumn)
    {
            this.ID = id;
            this.status = status;
            this.amountOfColumns = amountOfColumns;
            this.amountOfFloors = amountOfFloors;
            this.amountOfBasements = amountOfBasements;

            this.columnsList = new List<Column>();
            //this.floorRequestButtonsList = new List<FloorRequestButton>();
            this.servedFloorsList = new List<int>();
            this.columnID = 1;

            System.Console.WriteLine($"Total column with basement = " + amountOfColumns);    
            if (amountOfBasements > 0)
            {

                //createBasementFloorRequestButtonsList(_amountOfBasements);
                //createBasementColumn(_amountOfBasements, _amountOfElevatorPerColumn);
                //_amountOfColumns -= 1;

            }

           // Console.WriteLine("Hello World!");                  //TEST
           // Battery battery = new Battery(2,2,"yeah",2,2,2);
           // Console.WriteLine(battery.ID);
           // Console.WriteLine(battery.columnsList[0].ID);
    }

     // Method assignElevator(requestedFloor, direction)

    public void assignElevator(int requestedFloor, string direction)
    {
   
    }   

    //findBestColumn(requestedFloor)

    public void findBestColumn(int requestedFloor)
    {

    }

        //createFloorRequestButtons(amountOfFloors)



       // public void createColumns(int amountOfColumns, int amountOfFloors, int amountOfElevatorPerColumn)
       // {
           //int amountOfFloorsPerColumn = (int)Math.Ceiling((double)amountOfFloors / amountOfColumns);
            //int floor = 1;


                     
            //for (int i  = 1; i <= amountOfColumns; i++)
           // {
                // List<int> servedFloors = new List<int>();
               // for (int j = 1; j <= amountOfFloorsPerColumn; j++)
               // {
                   // if (floor <= amountOfFloors)
                    //{
                       // servedFloorsList.Add(floor);
                        //floor += 1;
                    //}
                //}
                //Column column = new Column(columnID, "online", amountOfFloors, amountOfElevatorPerColumn, servedFloorsList, false);
                //columnsList.Add(column);
                //columnID += 1;

           // }

            
            Console.WriteLine("Hello World!");                  //TEST
            Column column = new Column(2,"yeah",2,2,0,true);
            Console.WriteLine(columnID);
            Console.WriteLine(column.columnsList[0].ID);

        }


//methods=========================

    //Create Basement Column Method

    //END Create Basement Column Method

// Console.WriteLine(val1 + val2);
//    Console.WriteLine(val1 < val2);
//    Console.WriteLine(!(status));
//    Console.ReadKey();

     } 
  }