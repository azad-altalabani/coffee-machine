using CoffeeMachine.Dal.Models;
using CoffeeMachine.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Dal.Assemblers
{
    internal static class DrinkAssembler
    {
        public static DrinkDTO ToDto(this DrinkModel source)
        {
            if (source == null)
            {
                return null;
            }

            return new DrinkDTO
            {
                DrinkID = source.ID,
                Code = source.Code,
                Description = source.Description
            };
        }

        public static DrinkModel ToModel(this DrinkDTO source)
        {
            if (source == null)
            {
                return null;
            }

            return new DrinkModel
            {
                ID = source.DrinkID,
                Code = source.Code,
                Description = source.Description
            };
        }
    }
}
