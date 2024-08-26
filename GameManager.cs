using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScrissor
{
    public class GameManager
    {

        Random random = new Random();

        public Result Play()
        {
            //player1
            Choice p1;
            Console.WriteLine("Choice between (R)ock, (P)aper and (S)crissor");
            string input = Console.ReadLine().ToUpper();
            while (true){
                if (input == "R"){
                    p1 = Choice.Rock;             
                    break;
                }
                else if (input == "P"){
                    p1 = Choice.Paper;
                    break;
                }
                else if (input == "S"){
                    p1 = Choice.Scrissor;
                    break;
                }
                else{
                    Console.WriteLine("Invalid choice");
                }
            }

            //player2
            Choice p2 = (Choice)random.Next(0, 3);


            Console.WriteLine("Player 1 choose " +p1);
            Console.WriteLine("Player 2 choose " +p2);
            if (p1 == p2){
                return Result.Draw;
            }
            else if ((p1 == Choice.Rock && p2 == Choice.Scrissor) ||
                    (p1 == Choice.Paper && p2 == Choice.Rock) ||
                    (p1 == Choice.Scrissor && p2 == Choice.Paper)){
                return Result.Player1Win;
            }
            else {
                return Result.Player2Win;
            }

        }
    }


    public enum Choice
    {
        Rock,
        Paper,
        Scrissor
    }

    public enum Result{
        Player1Win,
        Player2Win,
        Draw
    }
}
