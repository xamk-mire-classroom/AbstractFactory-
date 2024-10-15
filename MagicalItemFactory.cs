using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public class MagicalItemFactory : IItemFactory
    {
        public Weapon CreateWeapon()
        {
            return new Weapon { Damage = 20, WeaponType = WeaponTypeEnum.Ranged, Rarity = ItemRarity.Magical };
        }

        public Potion CreatePotion()
        {
            return new Potion { Effect = "Mana Restore", Duration = 10, Rarity = ItemRarity.Magical };
        }

        public Armor CreateArmor()
        {
            return new Armor { Defense = 10, Durability = 30, Rarity = ItemRarity.Magical };
        }
    }

}
