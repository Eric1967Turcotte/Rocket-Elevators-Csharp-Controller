using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

 namespace Rocket_Elevators_Csharp_Controller
{
    public class CallButton
    {
        public int ID;
        public string status;
        public int floor;
        public string direction;

        public CallButton(int _id, string _status, int _floor, string _direction)
        {
            this.ID = _id;
            this.status = _status;
            this.floor = _floor;
            this.direction = _direction;
        }

    }
}
// //Console.WriteLine(val1 + val2);
//    //Console.WriteLine(val1 < val2);
//    //Console.WriteLine(!(status));
//    //Console.ReadKey();