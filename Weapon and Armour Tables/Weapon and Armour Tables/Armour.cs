using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_and_Armour_Tables
{
    class Armour
    {
        public string Name { get; private set; }
        public string Vs_Piercing { get; private set; }
        public string Vs_Blunt { get; private set; }
        public string Vs_Cleaving { get; private set; }
        public string Description { get; private set; }
        public string Notes { get; private set; }

        public static List<Armour> AllArmours = new List<Armour>();

        public static void LoadArmours()
        {
            string[] split = (Properties.Resources.Armour_Info).Split('|', '\n', '\r');
            
            for (int i = 0; i < split.Length; i += 8)
            {
                Armour a = new Armour();

                a.Name = split[i];
                a.Vs_Piercing = split[i + 1];
                a.Vs_Blunt = split[i + 2];
                a.Vs_Cleaving = split[i + 3];
                a.Description = split[i + 4];
                a.Notes = split[i + 5];

                AllArmours.Add(a);
            }
        }

        public static List<string> GetArmourNames()
        {
            List<string> names = new List<string>();

            foreach (Armour a in AllArmours)
                names.Add(a.Name);
            
            return names;
        }

        private static Armour PassDefault()
        {
            Armour def = new Armour();

            def.Name = "";
            def.Vs_Piercing = "-";
            def.Vs_Blunt = "-";
            def.Vs_Cleaving = "-";
            def.Description = "";
            def.Notes = "";

            return def;
        }

        public static Armour GetArmourInfo(int index)
        {
            Armour sendBack = new Armour();

            if (index == 0)
                sendBack = PassDefault();
            else
                sendBack = AllArmours[index - 1];

            return sendBack;
        }
    }
}
