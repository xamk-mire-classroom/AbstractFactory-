using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class RareItemFactory : IItemFactory
    {
        public Weapon CreateWeapon()
        {
            return new Weapon { Damage = 30, WeaponType = WeaponTypeEnum.Melee, Rarity = ItemRarity.Rare };
        }

        public Potion CreatePotion()
        {
            return new Potion { Effect = "Strength Boost", Duration = 15, Rarity = ItemRarity.Rare };
        }

        public Armor CreateArmor()
        {
            return new Armor { Defense = 20, Durability = 50, Rarity = ItemRarity.Rare };
        }
    }

}
