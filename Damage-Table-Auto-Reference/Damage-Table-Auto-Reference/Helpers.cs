using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_Table_Auto_Reference
{
    class Helpers
    {
        static Random _rng = new Random();
        public static List<string> _damageTables = new List<string>()
            { "Select Damage Type", "Cleaving", "Piercing", "Blunt", "Swung Piercing" };
        public static Dictionary<int, string> _damageAreas;

        public static int Rolld6()
        {
            return _rng.Next(1, 7);
        }

        public static void SetUpArea(int index)
        {
            _damageAreas = new Dictionary<int, string>() { { 0, "Select Attack Area" }, { 1, "Swing to Lower Legs (area 1)" },
                { 2, "Swing to Upper Legs (area 2)" }, { 3, "Swing to Upper Body (area 3)" }, { 4, "Overhand Swing (area 4)" },
                { 5, "Vertical Swing (area 5)" }, { 6, "Upward Swing (area 6)" }, { 7, "Swing to Arms (area 7)" },
                { 8, "Thrust to Lower Legs (area 8)" }, { 9, "Thrust to Upper Legs (area 9)" }, { 10, "Thrust to Pelvis (area 10)" },
                { 11, "Thrust to Stomach (area 11)" }, { 12, "Thrust to Chest (area 12)" }, { 13, "Thrust to Head (area 13)" },
                { 14, "Thrust to Arms (area 14)" } };

            switch (index)
            {
                case 1:  // cleaving (1 - 7)
                case 4:  // swung piercing
                    for (int i = 8; i < 15; ++i)
                        _damageAreas.Remove(i);
                    break;
                case 2:  // piercing (8 - 14)
                    for (int i = 1; i < 8; ++i)
                        _damageAreas.Remove(i);
                    break;
                case 3:  // blunt (1 - 14)
                    break;
                default:  // invalid (0)
                    for (int i = 1; i < 15; ++i)
                        _damageAreas.Remove(i);
                    break;
            }
        }


    }
}
