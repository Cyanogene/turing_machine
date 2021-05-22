using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class MoveLeft:ICommand
    {
        void ICommand.execute(Manager man)
        {
            man.currentPosition--;
        }
    }
}
