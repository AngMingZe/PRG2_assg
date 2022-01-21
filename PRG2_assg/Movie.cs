using System;
using System.Collections.Generic;
using System.Text;

namespace PRG2_assg
{
    class Movie
    {
        //Last updated: 21/1/2022

        //attr
        public string Title { get; set; }
        
        public int Duration { get; set; }
        
        public string Classification { get; set; }
        
        public DateTime OpeingDate { get; set; }
        
        public List<string> GenreList = new List<string>();
        
        public List<string> ScreeningList = new List<string>();

        //constructor
        public Movie() { }

        public Movie(string t, int d, string c, DateTime od, List<string> Glist)
        {
            GenreList = Glist;
            Title = t;
            Duration = d;
            Classification = c;
            OpeingDate = od;
                                                       
        }
        
        public void AddGenre (string Chua)
        {
            GenreList.Add(Chua);
        }

        public void AddScreening(string Guo)
        {
            ScreeningList.Add(Guo);
        }
        public override string ToString()
        {
            return "Title: " + Title + "Duration: " + Duration + "Classification: " + Classification + "OpeningDate: " + OpeingDate;
        }

    }
}
