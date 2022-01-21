using System;

namespace PRG2_assg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last updated: 21/1/2022
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

        public static void LoadMandCData()
        {
            //Load data
        }
    }
}
