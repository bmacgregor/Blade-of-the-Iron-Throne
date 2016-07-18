using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maneuver_List
{
    class Maneuver
    {
        public string Name { get; private set; }
        public string Brawling { get; private set; }
        public string CutThrust { get; private set; }
        public string Dagger { get; private set; }
        public string Greatsword { get; private set; }
        public string Lance { get; private set; }
        public string Longsword { get; private set; }
        public string MassWeapon { get; private set; }
        public string Polearm { get; private set; }
        public string SpearShield { get; private set; }
        public string SwordShield { get; private set; }
        public string Wrestling { get; private set; }
        public string Description { get; private set; }
        public string Notes { get; private set; }

        private static List<Maneuver> _offensive = new List<Maneuver>();
        private static List<Maneuver> _defensive = new List<Maneuver>();

        public static void LoadLists()
        {
            _offensive = ExtractInfo(Properties.Resources.Attack.Split('|'));
            _defensive = ExtractInfo(Properties.Resources.Defence.Split('|'));
        }

        private static List<Maneuver> ExtractInfo(string[] readIn)
        {
            List<Maneuver> sorted = new List<Maneuver>();

            for (int i = 0; i < readIn.Length - 2; i += 14)
            {
                Maneuver m = new Maneuver();

                m.Name = readIn[i];

                m.Brawling = readIn[i + 1];
                m.CutThrust = readIn[i + 2];
                m.Dagger = readIn[i + 3];
                m.Greatsword = readIn[i + 4];
                m.Lance = readIn[i + 5];
                m.Longsword = readIn[i + 6];
                m.MassWeapon = readIn[i + 7];
                m.Polearm = readIn[i + 8];
                m.SpearShield = readIn[i + 9];
                m.SwordShield = readIn[i + 10];
                m.Wrestling = readIn[i + 11];

                m.Description = readIn[i + 12];
                m.Notes = readIn[i + 13];

                sorted.Add(m);
            }

            return sorted;
        }

        public static Maneuver GetInfo(string checkName, bool offense)
        {
            List<Maneuver> selectedList = new List<Maneuver>();

            selectedList = offense ? _offensive : _defensive;

            foreach (Maneuver m in selectedList)
                if (m.Name == checkName)
                    return m;

            return null;
        }

        public static string GetCost(string weaponGroup, Maneuver m)
        {
            switch (weaponGroup)
            {
                case "Brawling":
                    return m.Brawling;
                case "Cut & Thrust":
                    return m.CutThrust;
                case "Dagger":
                    return m.Dagger;
                case "Greatsword":
                    return m.Greatsword;
                case "Lance":
                    return m.Lance;
                case "Longsword":
                    return m.Longsword;
                case "Mass Weapon & Shield":
                    return m.MassWeapon;
                case "Pole arm":
                    return m.Polearm;
                case "Spear & Shield":
                    return m.SpearShield;
                case "Sword & Shield":
                    return m.SwordShield;
                case "Wrestling":
                    return m.Wrestling;
                default:
                    return null;
            }
        }
    }
}
