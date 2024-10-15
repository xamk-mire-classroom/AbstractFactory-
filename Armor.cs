using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class Armor : Item
    {
        public int Defense { get; set; }
        public int Durability { get; set; }

        public override string GetDetails()
        {
            return $"Armor: Defense={Defense}, Durability={Durability}, Rarity={Rarity}";
        }
    }

}
