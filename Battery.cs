using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rocket_Elevators_Csharp_Controller
{
    public class Battery
    {
        public int ID;
        public int amountOfColumns;
        public string status;
        public int amountOfFloors;
        public int amountOfBasements;
        public int columnID;
        public List<Column> columnsList;
        public List<FloorRequestButton> floorRequestButtonsList;
        public List<int> servedFloorsList;
        public List<int> servedFloors;

        public Battery(int _id, string _status, int _amountOfColumns, int _amountOfFloors, int _amountOfBasements, int _amountOfElevatorPerColumn)
        {
            this.ID = _id;
            this.status = _status;
            this.amountOfColumns = _amountOfColumns;
            this.amountOfFloors = _amountOfFloors;
            this.amountOfBasements = _amountOfBasements;
            this.columnsList = new List<Column>();
            this.floorRequestButtonsList = new List<FloorRequestButton>();
            this.servedFloorsList = new List<int>();
            this.columnID = 1;

            System.Console.WriteLine($"Total column with basement = " + _amountOfColumns);     //console log *******
            if (_amountOfBasements > 0)
            {
                createBasementFloorRequestButtonsList(_amountOfBasements);
                createBasementColumn(_amountOfBasements, _amountOfElevatorPerColumn);
                _amountOfColumns -= 1;
            }
            System.Console.WriteLine("Total column without basement = " + _amountOfColumns);     //console log *******
            createColumns(_amountOfColumns, _amountOfFloors, _amountOfElevatorPerColumn);
            createFloorRequestButtonsList(_amountOfFloors);
            
        }
        public void createBasementColumn(int _amountOfBasements, int _amountOfElevatorPerColumn)
        {
            int basement = -1;
            for (int i = 1; i <= _amountOfBasements; i++)
            // List<int> servedFloors = new List<int>();
            {   
                servedFloorsList.Add(basement);
                basement -= 1;
            }
            
            Column column = new Column(columnID, "online", _amountOfBasements, _amountOfElevatorPerColumn, servedFloorsList, true);
            columnsList.Add(column);
            columnID += 1;
        }
        public void createColumns(int _amountOfColumns, int _amountOfFloors, int _amountOfElevatorPerColumn)
        
        {
        //     double aOfPc = (_amountOfFloors/_amountOfColumns);
        //     double amountOfFloorsPerColumn = Math.Ceiling(aOfPc);
            int amountOfFloorsPerColumn = (int)Math.Ceiling((double)_amountOfFloors / _amountOfColumns);
            int floor = 1;
                        
            for (int i  = 1; i <= _amountOfColumns; i++)
            {
                // List<int> servedFloors = new List<int>();
                for (int j = 1; j <= amountOfFloorsPerColumn; j++)
                {
                    if (floor <= _amountOfFloors)
                    {
                        servedFloorsList.Add(floor);
                        floor += 1;
                    }
                }
                Column column = new Column(columnID, "online", _amountOfFloors, _amountOfElevatorPerColumn, servedFloorsList, false);
                columnsList.Add(column);
                columnID += 1;
                // System.Console.WriteLine(columnsList);
                // System.Console.WriteLine("Column " + column.ID);
            }
        }
        public void createFloorRequestButtonsList(int _amountOfFloors)
        {
            int buttonFloor = 1;
            int floorRequestButtonID = 1;
            for (int i = 1; i <= _amountOfFloors; i++)
            {
                FloorRequestButton floorRequestButton = new FloorRequestButton(floorRequestButtonID, "off", buttonFloor, "up");
                buttonFloor += 1;
                floorRequestButtonID += 1;   
            }
        }
        public void createBasementFloorRequestButtonsList(int _amountOfBasements)
        {
            int buttonFloor = -1;
            int floorRequestButtonID = 1;
            for (int i = 1; i >= _amountOfBasements; i--)
            {
                FloorRequestButton floorRequestButton = new FloorRequestButton(floorRequestButtonID, "off", buttonFloor, "down");
                buttonFloor -= 1;
                floorRequestButtonID += 1;   
            }
        }
        public Column findBestColumn(int _requestedFloor)
        {
            Column bestColumn = null;
            foreach (Column column in columnsList)
            {
                System.Console.WriteLine("column: " + column.ID);
                if (servedFloorsList.Contains(_requestedFloor))
                {
                    bestColumn = column;
                }
            }
            return bestColumn;
        }
        // public static void assignElevator(int _requestedFloor, string direction)
        // {
        //     var column = findBestColumn(_requestedFloor);
        //     var elevator = Elevator.findElevator();
        //     elevator.floorRequestList.Add(_requestedFloor);
        //     Elevator.SortFloorList();

        // }

    } 
  }