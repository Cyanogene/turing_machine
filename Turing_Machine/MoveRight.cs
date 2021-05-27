using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class MoveRight:ICommand
    {
        void ICommand.Execute(Manager man)
        {
            man.previousPosition = man.currentPosition;
            man.currentPosition++;
            man.listTape[man.currentPosition].Style.BackColor = Color.Cyan;
            man.listTape[man.previousPosition].Style.BackColor = Color.Empty;
        }
    }
}
