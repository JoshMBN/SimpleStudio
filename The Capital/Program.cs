using System;

namespace The_Capital
{
    internal class Program
    {
        public static Weapon[] weapon = new Weapon[5];
        public static Potion[] potion = new Potion[5];
        public static Armor[] armor = new Armor[5];
        static void Main(string[] args)
        {
            LoadData.LoadAllData();

            for (int i = 0; i < weapon.Length; i++)
            {
                Console.WriteLine($"Name: {weapon[i].Name.PadRight(30)} Damage: {Convert.ToString(weapon[i].Value).PadRight(20)} Cost: {Convert.ToString(weapon[i].Cost).PadRight(20)}");
                Console.WriteLine($"Name: {armor[i].Name.PadRight(30)} Protects: {Convert.ToString(armor[i].Value).PadRight(20)} Cost: {Convert.ToString(armor[i].Cost).PadRight(20)}");
                Console.WriteLine($"Name: {potion[i].Name.PadRight(30)} Heals: {Convert.ToString(potion[i].Value).PadRight(20)} Cost: {Convert.ToString(potion[i].Cost).PadRight(20)}");
            }

        }
    }
}
