using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace PRG2_assg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last updated: 24/1/2022

            //Creation of list to store data
            List<Movie> Mlist = new List<Movie>();
            List<Cinema> Clist = new List<Cinema>();
            List<Screening> Slist = new List<Screening>();
            //End of creation of list

            //Loading of data
            LoadData(Mlist,Clist,Slist);
            //End of loading of data

            printstuff(Mlist, Clist, Slist);
            while (true)
            {
                Menu();
                Console.Write("Enter option: ");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    //do op 1 things
                }
                if (op == 2)
                {
                    //do op 2 things
                }
                if (op == 3)
                {
                    //do op 3 things 
                }
                if (op == 0)
                {
                    Console.WriteLine("Thanks for using our system");
                    break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("[1] General");
            Console.WriteLine("[2] Screening");
            Console.WriteLine("[3] Order");
            Console.WriteLine("[0] Exit");
        }

        static void printstuff(List<Movie> Mlist, List<Cinema> Clist, List<Screening> Slist)
        {
            //for testing purposes
            foreach (Movie m in Mlist)
            {
                Console.WriteLine(m);
            }
            foreach (Cinema c in Clist)
            {
                Console.WriteLine(c);
            }
            foreach (Screening s in Slist)
            {
                Console.WriteLine(s);
            }
        }
        static void LoadData(List<Movie> Mlist,List<Cinema> Clist,List<Screening> Slist)
        {
            //Extracting data from Movie csv file
            string[] Mfile = File.ReadAllLines("Movie.csv");
            for (int i = 1; i < Mfile.Length; i++)
            {
                string[] data = Mfile[i].Split(',');
                if (data[0] == "")
                {
                    break;
                }
                List<string> Glist = new List<string>(data[3].Split('/'));
                string[] temp = data[4].Split('/');
                DateTime yeet = new DateTime(Convert.ToInt32(temp[2]), Convert.ToInt32(temp[1]), Convert.ToInt32(temp[0]));
                Movie mov = new Movie(data[0],Convert.ToInt32(data[1]),data[3],yeet,Glist);
                Mlist.Add(mov);
            }

            //Extracting Cinema csv
            string[] CFile = File.ReadAllLines("Cinema.csv");
            for (int i = 1; i < CFile.Length; i++)
            {
                string[] data = CFile[i].Split(',');
                Cinema cin = new Cinema(data[0],Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));
                Clist.Add(cin);
            }

            //Extracting Screening csv
            string[] SFile = File.ReadAllLines("Screening.csv");
            for (int i = 1; i < SFile.Length; i++)
            {
                int seats = 0;
                Movie temp = null;
                string[] data = SFile[i].Split(',');
                foreach(Cinema c in Clist)
                {
                    if (data[2] == c.Name)
                    {
                        if (Convert.ToInt32(data[3]) == c.HallNo)
                        {
                            seats = c.Capacity;
                        }
                    }
                }
                foreach (Movie m in Mlist)
                {
                    if (data[4] == m.Title)
                    {
                        temp = m;
                    }
                }
                string[] tempo = data[0].Split('/');
                DateTime yeet = DateTime.Parse(data[0]);
                Screening scr = new Screening(i,yeet,data[1],new Cinema(data[2], Convert.ToInt32(data[3]), seats),temp);
                Slist.Add(scr);
            }
        }
    }
}
