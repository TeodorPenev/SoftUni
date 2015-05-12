using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infestation.Supplements;
using Infestation.Units;

namespace Infestation.Engine
{
    internal class UpdatedHoldingPen :HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    var power = new PowerCatalyst(commandWords[2]);
                    
                    break;
                case "Human":
                    var human = new Human(commandWords[2]);
                    this.InsertUnit(human);
                    break;
                default:
                    break;
            }
        }
    }
}


