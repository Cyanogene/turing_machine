using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    class MoveRight : ICommand
    {
        void ICommand.Execute(Manager man)
        {
            man.previousPosition = man.currentPosition;
            if (man.currentPosition + 1 >= man.listTape.Count)
                man.dataGrid.Columns.Add("", "");

            man.currentPosition++;
            man.listTape[man.currentPosition].Style.BackColor = Color.Cyan;
            man.listTape[man.previousPosition].Style.BackColor = Color.Empty;
        }
    }
}
