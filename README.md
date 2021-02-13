# Rocket-Elevators-Csharp-Controller
C# from pseudoCode
The object of this projject was to transcript a PseudoCode from a comercial elevator into C# language.
Using this requierment:

I.	Scenario

In this exercise, it is a question of implementing the algorithm "Commercial_Controller.algo" delivered during the first week, this time with the two compiled languages proposed, C # and Go.

The program to be developed is a controller set up in a building of 66 floors including 6 basements served by 4 columns of 5 cages each. 
For the classic way, these columns respectively serve these stages (B6 to B1) + L, (2 to 20) + L, (20 to 40), (40 to 60). 
For the modern way, all columns will serve the lobby: (B6 to B1) + L, (2 to 20) + L, (21 to 40) + L, (41 to 60) + L
This controller is capable of supporting two main events:


1.	A person presses a call button to request an elevator, the controller selects an available cage and it is routed to that person based on two parameters provided by pressing the button:
1.	The floor where the person is
2.	the direction in which he wants to go (up or down)
2.	In classic approach, a person enters an elevator, chooses a floor of the control panel and it moves to the requested floor. The parameters provided:
1.	The elevator used
2.	The requested floor
3.	In a modern approach, a person at the RC presses a floor from an outside panel. The parameter provided:
1.	The requested floor

To meet these needs, the participant must implement the programmatic components needed to obtain the results. 
He will need to use the differents objects described in the week 1 requirements, with the correct attributes:

•	Battery(id, amountOfColumns, status, amountOfFloors, amountOfBasements, amountOfElevatorPerColumn)

    o	Attributes:
                	ID
                	amountOfColumns
                	status 
                	amountOfFloors
                	amountOfBasements
                	columnsList (List of Column objects)
                	floorRequestButtonsList (List of FloorRequestButton objects) Modern approach only
                
    o	Method: Modern approach only
                	assignElevator(requestedFloor, direction).
                	findBestColumn(requestedFloor). It should return a column object


•	Column(id, status, amountOfFloors, amountOfElevators, servedFloors, isBasement)

    o	Attributes:
                	ID
                	status 
                	servedFloors (List of floors)
                	amountOfElevators
                	elevatorsList (List of Elevator objects)
                	callButtonsList (List of CallButton objects)
                
    o	Method:
                	requestElevator (requestedFloor, direction).
                
•	Elevator(id, status, amountOfFloors, currentFloor)
    o	Attributes:
                	ID
                	status
                	direction
                	currentFloor
                	door (Door object)
                	floorRequestButtonsList (List of FloorRequestButton objects) Classic approach only
                	floorRequestList
                
    o	Method:
                	requestFloor(requestedFloor). Classic approach only
                
•	CallButton(id, status, floor, direction)
    o	Attributes:
                	ID
                	status
                	floor
                	direction
                
•	FloorRequestButton(id, status, floor)

    o	Attributes:
                	ID
                	status
                	floor
                
•	Door(id, status)

    o	Attributes:
                	ID
                	status

The requestElevator and requestFloor methods will be the anchors that allow a simulation program to validate the results.

