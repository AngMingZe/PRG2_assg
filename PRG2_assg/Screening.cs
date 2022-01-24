using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class Screening
    {
        //Last updated: 21/1/2022

        //attr
        public int ScreeningNo { get; set; }

        public DateTime ScreeningDateTime { get; set; }

        public string ScreeningType { get; set; }  

        public int SeatsRemaining { get; set; }

        public Cinema cinema { get; set; }

        public Movie movie { get; set; }
        //constructor
        public Screening() { }

        public Screening(int num, DateTime dt, string st, Cinema c, Movie m)
        {
            ScreeningNo = num;
            ScreeningDateTime = dt;
            ScreeningType = st;
            cinema = c;
            movie = m;
        }

        public override string ToString()
        {
            return "ScreeningNo: " + ScreeningNo + "ScreeningDateTime: " + ScreeningDateTime + "ScreenType: " + ScreeningType + "Cinema: " + cinema + "Movie: " + movie;
        }




    }
}
