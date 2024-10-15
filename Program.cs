using AbstractFacotry;
using System;

class Program
{
    static void Main(string[] args)
    {
        IItemFactory commonFactory = new CommonItemFactory();
        IItemFactory magicalFactory = new MagicalItemFactory();
        IItemFactory rareFactory = new RareItemFactory();
        IItemFactory legendaryFactory = new LegendaryItemFactory();

        var commonWeapon = commonFactory.CreateWeapon();
        var magicalPotion = magicalFactory.CreatePotion();
        var rareArmor = rareFactory.CreateArmor();
        var legendaryWeapon = legendaryFactory.CreateWeapon();

        Console.WriteLine(commonWeapon.GetDetails());
        Console.WriteLine(magicalPotion.GetDetails());
        Console.WriteLine(rareArmor.GetDetails());
        Console.WriteLine(legendaryWeapon.GetDetails());
    }
}
