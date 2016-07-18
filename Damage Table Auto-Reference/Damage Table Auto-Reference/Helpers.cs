using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_Table_Auto_Reference
{
    class Helpers
    {
        static Random _rng = new Random();  // one random to rule them all
        public static List<string> _damageTables = new List<string>()
            { "Select Damage Type", "Cleaving", "Piercing", "Blunt", "Swung Piercing" };
        public static Dictionary<int, string> _damageAreas;

        public static int Rolld6()
        {
            return _rng.Next(1, 7);  // sends back a random number between one and six
        }

        public static void SetUpArea(int index)
        {
            // all possible damage areas
            _damageAreas = new Dictionary<int, string>() { { 0, "Select Attack Area" }, { 1, "Swing to Lower Legs (Area 1)" },
                { 2, "Swing to Upper Legs (Area 2)" }, { 3, "Horizontal Swing to Upper Body (Area 3)" }, { 4, "Overhand Swing (Area 4)" },
                { 5, "Vertical Swing (Area 5)" }, { 6, "Upward Swing (Area 6)" }, { 7, "Swing to Arms (Area 7)" },
                { 8, "Thrust to Lower Legs (Area 8)" }, { 9, "Thrust to Upper Legs (Area 9)" }, { 10, "Thrust to Pelvic Region (Area 10)" },
                { 11, "Thrust to Stomach (Area 11)" }, { 12, "Thrust to Chest (Area 12)" }, { 13, "Thrust to Head (Area 13)" },
                { 14, "Thrust to Arms (Area 14)" } };

            switch (index)
            {
                case 1:  // cleaving (1 - 7)
                case 4:  // swung piercing
                    for (int i = 8; i < 15; ++i)
                        _damageAreas.Remove(i);  // only passes back a list of items between one and seven
                    break;
                case 2:  // piercing (8 - 14)
                    for (int i = 1; i < 8; ++i)
                        _damageAreas.Remove(i);  // only passes back a list of items between eight and fourteen
                    break;
                case 3:  // blunt (1 - 14)
                    break;  // sends back everything
                default:  // invalid (0)
                    for (int i = 1; i < 15; ++i)
                        _damageAreas.Remove(i);  // only passes back a list of item zero
                    break;
            }
        }
    }
}
