using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class LegendaryItemFactory : IItemFactory
    {
        public Weapon CreateWeapon()
        {
            return new Weapon { Damage = 50, WeaponType = WeaponTypeEnum.Ranged, Rarity = ItemRarity.Legendary };
        }

        public Potion CreatePotion()
        {
            return new Potion { Effect = "Invincibility", Duration = 20, Rarity = ItemRarity.Legendary };
        }

        public Armor CreateArmor()
        {
            return new Armor { Defense = 50, Durability = 100, Rarity = ItemRarity.Legendary };
        }
    }

}
