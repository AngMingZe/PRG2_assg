using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    abstract class Ticket
    {
        //Last updated: 21/1/2022

        //attr 
        public Screening Screening { get; set; }

        //Construct
        public Ticket()
        {
            //Add smth
        }
        public Ticket(Screening s)
        {
            Screening = s;
        }
        public abstract double CalculatePrice();

        public override string ToString()
        {
            return "Screening Details: " + Screening;
        }
    }
}
