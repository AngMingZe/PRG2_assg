using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class Cinema
    {
        //Last updated: 21/1/2022

        //Attr
        public string Name { get; set; }

        public int HallNo { get; set; }

        public int Capacity { get; set; }

        //Constructor
        public Cinema() { }

        public Cinema(string n, int hn, int c)
        {
            Name = n;
            HallNo = hn;
            Capacity = c;
        }
        public override string ToString()
        {
            return "Name: " + Name + "HallNo: " + HallNo + "Capacity: " + Capacity;
        }
    }
}
