using OOPAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Classes
{
    public class CarStringCommandExecutor : CarCommandExecutorBase, IStringCommand
    {
        public CarStringCommandExecutor(ICarCommand carCommand) : base(carCommand)
        {
        }

        public void ExecuteCommand(string commandObject)
        {
            if (string.IsNullOrEmpty(commandObject))
            {
                throw new Exception();
            }
            foreach (char command in commandObject)
            {
                if (command == 'L')
                {
                    CarCommand.TurnLeft();
                }
                else if (command == 'R')
                {
                    CarCommand.TurnRight();
                }
                else if (command == 'M')
                {
                    CarCommand.Move();
                }
                else
                {
                    throw new Exception();
                }
            }


        }
    }
}
