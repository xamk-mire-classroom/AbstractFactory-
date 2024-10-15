using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public interface IItemFactory
    {
        Weapon CreateWeapon();
        Potion CreatePotion();
        Armor CreateArmor();
    }

}
