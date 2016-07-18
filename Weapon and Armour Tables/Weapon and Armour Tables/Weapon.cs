using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_and_Armour_Tables
{
    class Weapon
    {
        public enum WeaponGroup { None, CutandThrust, Dagger, Greatsword, Longsword, MassWeapon, Polearm,
            SpearandShield, SwordandShield };

        public string Name { get; private set; }
        public string Reach { get; private set; }
        public char Swing_ATN { get; private set; }
        public string Swing_DR { get; private set; }
        public char Thrust_ATN { get; private set; }
        public string Thrust_DR { get; private set; }
        public char DTN { get; private set; }
        public char Blunt_DR { get; private set; }
        public string Description { get; private set; }
        public string Notes { get; private set; }
        public WeaponGroup Weapon_Group { get; private set; }

        public static List<Weapon> AllWeapons = new List<Weapon>();

        public static void LoadWeapons()
        {
            string[] split = (Properties.Resources.Weapon_Info).Split('|', '\n', '\r');

            for (int i = 0; i < split.Length; i += 13)
            {
                Weapon w = new Weapon();

                w.Name = split[i];
                w.Reach = split[i + 1];
                w.Swing_ATN = Convert.ToChar(split[i + 2]);
                w.Swing_DR = split[i + 3];
                w.Thrust_ATN = Convert.ToChar(split[i + 4]);
                w.Thrust_DR = split[i + 5];
                w.DTN = Convert.ToChar(split[i + 6]);
                w.Blunt_DR = Convert.ToChar(split[i + 7]);
                w.Description = split[i + 8];
                w.Notes = split[i + 9];
                w.Weapon_Group = (WeaponGroup)(Convert.ToInt32(split[i + 10]));

                AllWeapons.Add(w);
            }
        }

        public static List<string> GetWeaponGroups()
        {
            List<string> groups = new List<string>() { "Cut and Thrust", "Dagger", "Greatsword", "Longsword",
                "Mass Weapon and Shield", "Pole Arm", "Spear and Shield", "Sword and Shield" };

            return groups;
        }

        public static Weapon PassDefault()
        {
            Weapon def = new Weapon();

            def.Name = "";
            def.Reach = "";
            def.Swing_ATN = '-';
            def.Swing_DR = "-";
            def.Thrust_ATN = '-';
            def.Thrust_DR = "-";
            def.DTN = '-';
            def.Blunt_DR = '-';
            def.Description = "";
            def.Notes = "";
            def.Weapon_Group = WeaponGroup.None;

            return def;
        }

        public static Weapon FindWeapon(string name)
        {
            foreach(Weapon w in AllWeapons)
                if (w.Name == name)
                    return w;

            return null;
        }

        public static List<string> AllWeaponsInGroup(int group)
        {
            WeaponGroup wg = (WeaponGroup)group;
            List<string> allOfType = new List<string>();

            foreach (Weapon w in AllWeapons)
                if (w.Weapon_Group == wg)
                    allOfType.Add(w.Name);

            allOfType.Sort();

            return allOfType;
        }
    }
}
