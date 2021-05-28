using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_Machine
{
    class MoveLeft : ICommand
    {
        void ICommand.Execute(Manager man)
        {
            man.previousPosition = man.currentPosition;
            if (man.currentPosition - 1 < 0)
                man.dataGrid.Columns.Insert(0, new DataGridViewColumn() { CellTemplate = new DataGridViewTextBoxCell() });

            man.currentPosition--;
            man.listTape[man.currentPosition].Style.BackColor = Color.Cyan;
            man.listTape[man.previousPosition].Style.BackColor = Color.Empty;
        }
    }
}
