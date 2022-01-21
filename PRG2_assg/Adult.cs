using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class Adult:Ticket
    {
        //Last updated: 21/1/2022

        //attr
        public bool PopcornOffer { get; set; }

        //construct
        public Adult() { }
        public Adult(Screening s,bool b) : base(s)
        {
            PopcornOffer = b;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalculatePrice()
        {
            return 0.00;
        }
    }
}
