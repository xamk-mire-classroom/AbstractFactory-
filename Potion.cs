using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class Potion : Item
    {
        public string Effect { get; set; }
        public int Duration { get; set; }

        public override string GetDetails()
        {
            return $"Potion: Effect={Effect}, Duration={Duration}, Rarity={Rarity}";
        }
    }

}
