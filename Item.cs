using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFacotry
{
    public abstract class Item
    {
        public ItemRarity Rarity { get; set; }
        public abstract string GetDetails();
    }

}
