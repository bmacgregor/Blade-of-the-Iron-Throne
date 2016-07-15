using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maneuver_List
{
    class Helpers
    {
        public static List<string> _weaponGroups = new List<string>() { "Select Weapon Group", "Brawling", "Cut & Thrust", "Dagger",
            "Greatsword", "Lance", "Longsword", "Mass Weapon & Shield", "Pole arm", "Spear & Shield", "Sword & Shield", "Wrestling" };

        public static List<string> _offensiveManeuver = new List<string>() { "Select Maneuver", "Bash", "Beat", "Bind & Strike", "Cut",
            "Disarm", "Double Attack", "Evasive Attack", "Feint & Swing", "Feint & Thrust", "Grapple", "Half Sword", "Hook",
            "Master Strike", "Murder Stroke", "Quick Draw", "Simultaneous Block/Strike", "Stop Short", "Thrust", "Toss" };

        public static List<string> _defensiveManeuver = new List<string>() { "Select Maneuver", "Block", "Block Open & Strike",
            "Counter", "Disarm", "Evasion", "Expulsion", "Grapple", "Half Sword", "Master Strike", "Overrun", "Quick Draw",
            "Parry", "Rota", "Winding & Binding" };

        public static List<string> _grappleOptions = new List<string>() { "Select Option", "Immobilize", "Throw", "Break", "Break Out" };

        public static string _brawlNoteOffense = 
            "Bash Activation Cost 0 is for punches, 1 for kicks and any other Bashes that might come up.";
        public static string _daggerNoteOffense = 
            "Bash Activation Cost 1 is for punches, 2 for any other Bashes that might come up.";
        public static string _wrestlingNoteOffense = 
            "Bash Activation Cost 1 is for punches, 2 for kicks and any other Bashes that might come up.";

        public static string _massWeapNoteDefence = "Lower of two given Activation Costs is for use without shield.";
        public static string _swordNoteDefence = "Lower of two given Activation Costs is for use without shield.";
    }

    class GrappleOptions
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        private static List<GrappleOptions> _options = new List<GrappleOptions>();

        public static void LoadList()
        {
            _options = ExtractInfo(Properties.Resources.Grapple.Split('|'));
        }

        private static List<GrappleOptions> ExtractInfo(string[] readIn)
        {
            List<GrappleOptions> sorted = new List<GrappleOptions>();

            for (int i = 0; i < readIn.Length; i += 2)
            {
                GrappleOptions g = new GrappleOptions();

                g.Name = readIn[i];
                g.Description = readIn[i + 1];

                sorted.Add(g);
            }

            return sorted;
        }

        public static string GetDescription(string choice)
        {
            foreach (GrappleOptions g in _options)
                if (g.Name == choice)
                    return g.Description;

            return "";
        }
    }
}
