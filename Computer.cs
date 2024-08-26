using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScrissor
{
    public class Computer : IPlayer
    {
        private Random random = new Random();
        
        public Choice MakeChoice(){
            
            Choice p2 = (Choice)random.Next(0, 3);

            return p2;
        }
    }
}
