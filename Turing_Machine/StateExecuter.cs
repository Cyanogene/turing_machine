using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine
{
    class StateExecuter
    {
        public List<ICommand> actions = new List<ICommand>();
        public StateExecuter(string azioni, Manager man)
        {
            string input = "abcdef";
            if (input.StartsWith("abc"))
            {
                Console.WriteLine("STARTSWITH: ABC");
            }
            string[] splitted = azioni.Split(',', '=');
            foreach (var item in splitted)
            {
                if (item == "<")
                    actions.Add(new MoveLeft());
                if (item == ">")
                    actions.Add(new MoveRight());
                if (item.StartsWith("S"))
                    actions.Add(new ChangeState(Convert.ToInt32(item)));
                //if (char.IsDigit(Convert.ToChar(item)))
                //    actions.Add(new ChangeCell(item));
            }
            //foreach (var item in actions)
            //{
            //    item.execute(man);
            //}
        }
    }
}
