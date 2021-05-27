using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    /// <summary>
    /// Esegue il comando di STOP della macchina.
    /// </summary>
    class Stop : ICommand
    {
        void ICommand.Execute(Manager man)
        {
            man.finito = true;
        }
    }
}
