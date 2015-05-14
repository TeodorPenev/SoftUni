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
        CatalistsBase power;
        Unit unit;
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            
            switch (commandWords[1])
            {
                case "PowerCatalyst":
                    power = new PowerCatalyst();
                    unit = GetUnit(commandWords[2]);
                    unit.AddSupplement(power);
                    break;
                case "HealthCatalyst":
                    power = new HealthCatalyst();
                    unit = GetUnit(commandWords[2]);
                    unit.AddSupplement(power);
                    break;
                case "AggressionCatalyst":
                    power = new AggressionCatalyst();
                    unit = GetUnit(commandWords[2]);
                    unit.AddSupplement(power);
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    power = new WeaponrySkill();
                    unit = GetUnit(commandWords[2]);
                    unit.AddSupplement(power);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }
    }
}


