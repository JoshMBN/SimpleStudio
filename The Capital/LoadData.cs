using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_Capital
{
    public class LoadData
    {
        public static string[] loadList = {"Armor", "Potions", "Weapons"};
        public static void LoadAllData()
        {
            StreamReader sr = new StreamReader(@$"RawText/items-Weapons.txt");
            for (int j = 0; j < 5; j++)
            {
                string Name = sr.ReadLine();
                int Value = Convert.ToInt32(sr.ReadLine());
                int Cost = Convert.ToInt32(sr.ReadLine());

                Program.weapon[j] = new Weapon(Name, Value, Cost);
            }
            sr.Close();

            sr = new StreamReader(@$"RawText/items-Potions.txt");
            for (int j = 0; j < 5; j++)
            {
                string Name = sr.ReadLine();
                int Value = Convert.ToInt32(sr.ReadLine());
                int Cost = Convert.ToInt32(sr.ReadLine());

                Program.potion[j] = new Potion(Name, Value, Cost);
            }
            sr.Close();

            sr = new StreamReader(@$"RawText/items-Armors.txt");
            for (int j = 0; j < 5; j++)
            {
                string Name = sr.ReadLine();
                int Value = Convert.ToInt32(sr.ReadLine());
                int Cost = Convert.ToInt32(sr.ReadLine());

                Program.armor[j] = new Armor(Name, Value, Cost);
            }
            sr.Close();


        }
    }

}

