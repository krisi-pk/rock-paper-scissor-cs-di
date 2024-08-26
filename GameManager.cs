using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScrissor
{
    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public GameManager(IPlayer player1,IPlayer player2) { 
            _player1 = player1;
            _player2 = player2;
        }

       
        public Result Play()
        {
            Choice p1 = _player1.MakeChoice();
            Choice p2 = _player2.MakeChoice();

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
