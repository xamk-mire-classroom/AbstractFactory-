using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class CommonItemFactory : IItemFactory
    {
        public Weapon CreateWeapon()
        {
            return new Weapon { Damage = 10, WeaponType = WeaponTypeEnum.Melee, Rarity = ItemRarity.Common };
        }

        public Potion CreatePotion()
        {
            return new Potion { Effect = "Heal", Duration = 5, Rarity = ItemRarity.Common };
        }

        public Armor CreateArmor()
        {
            return new Armor { Defense = 5, Durability = 20, Rarity = ItemRarity.Common };
        }
    }

}
