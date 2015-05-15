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
                //case "InfestationSpores":
                //    power = new InfestationSpores();
                //    unit = GetUnit(commandWords[2]);
                //    unit.AddSupplement(power);
                //    break;
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
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            Unit targetUnit;
            Unit sourceUnit;

            switch (interaction.InteractionType)
            {
                case InteractionType.Attack:
                    targetUnit = this.GetUnit(interaction.TargetUnit);
                    sourceUnit = this.GetUnit(interaction.SourceUnit);
                    if (targetUnit.UnitClassification == UnitClassification.Biological && sourceUnit.UnitClassification == UnitClassification.Biological)
                    {
                            sourceUnit.AddSupplement(new InfestationSpores());
                    }
                    if (targetUnit.UnitClassification == UnitClassification.Psionic && sourceUnit.UnitClassification == UnitClassification.Mechanical)
                    {
                            sourceUnit.AddSupplement(new InfestationSpores());
                    }
                    if (targetUnit.UnitClassification == UnitClassification.Psionic && sourceUnit.UnitClassification == UnitClassification.Psionic)
                    {
                            sourceUnit.AddSupplement(new InfestationSpores());
                    }
                    targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                    break;
                case InteractionType.Infest:
                    targetUnit = this.GetUnit(interaction.TargetUnit);
                    targetUnit.AddSupplement(new InfestationSpores());
                    targetUnit.DecreaseBaseHealth(interaction.SourceUnit.Power);
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }
    }
}


