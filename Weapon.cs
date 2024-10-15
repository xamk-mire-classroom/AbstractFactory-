using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public WeaponTypeEnum WeaponType { get; set; }

        public override string GetDetails()
        {
            return $"Weapon: Damage={Damage}, Type={WeaponType}, Rarity={Rarity}";
        }
    }

}
