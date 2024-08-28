using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScrissor
{
    public class Human : IHumanPlayer 
    {
        public Choice MakeChoice()
        {
            Choice p1;
            Console.WriteLine("Choice between (R)ock, (P)aper and (S)crissor");
            string input = Console.ReadLine().ToUpper();
            while (true)
            {
                if (input == "R")
                {
                    p1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    p1 = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    p1 = Choice.Scrissor;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
            return p1;
        }
    }
}
