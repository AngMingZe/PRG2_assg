using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class SeniorCitizen:Ticket
    {
        //Last updated: 21/1/2022
        
        //attr
        public int YearOfBirth { get; set; }

        //construct 
        public SeniorCitizen() { }
        public SeniorCitizen(Screening s,int YOB) : base(s)
        {
            YearOfBirth = YOB;
        }
        public override double CalculatePrice()
        {
            return 0.00;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
