using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScrissor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameManager game = new GameManager(new Human(),new Computer());

            while (true){
                Console.WriteLine(game.Play().ToString());
                Console.WriteLine("Do you want to play more? Y or N");
                string input = Console.ReadLine().ToUpper();
                if (input == "N") {
                    break;
                }
            }
        }
    }
}
