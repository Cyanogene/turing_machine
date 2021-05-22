using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    interface ICommand
    {
        void execute(Manager man);
    }
}
