using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class Student:Ticket
    {
        //Last updated: 21/1/2022

        //attr
        public string LevelOfStudy { get; set; }

        //construct
        public Student() { }
        public Student(Screening s,string LOS) : base(s)
        {
            LevelOfStudy = LOS;
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
