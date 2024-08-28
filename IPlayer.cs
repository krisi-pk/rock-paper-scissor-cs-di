using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScrissor
{
    public interface IPlayer
    {
        Choice MakeChoice();
    }

    public interface IHumanPlayer : IPlayer 
    { 
    }

    public interface IComputerPlayer : IPlayer
    {
    }
}
