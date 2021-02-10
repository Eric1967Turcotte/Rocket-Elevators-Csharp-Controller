using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

 namespace Rocket_Elevators_Csharp_Controller
 {
    public class Doors
    {
        public int ID;
        public string status;

        public Doors(int _id, string _status)
        {
            ID = _id;
            status = _status;
        }
        public void operateDoors()
        {
            this.status = "open";
            this.status = "close";
        }
    }
}