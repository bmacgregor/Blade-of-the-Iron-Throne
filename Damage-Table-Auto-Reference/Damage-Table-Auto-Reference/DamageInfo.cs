using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damage_Table_Auto_Reference
{
    class DamageInfo
    {
        enum DamageType { Cleaving = 1, Piercing, Blunt, SwungPiercing }  // for ease of debugging

        // a ton of properties, all private set
        public int Area { get; private set; }
        public int Roll { get; private set; }
        public string Location { get; private set; }
        public int Level { get; private set; }
        public int BloodLoss { get; private set; }
        public int Shock { get; private set; }
        public int Pain { get; private set; }
        public int Knockdown { get; private set; }
        public int Knockout { get; private set; }
        public string Description { get; private set; }
        public bool Dead { get; private set; }
        public string Gender { get; private set; }

        // lists to hold each type of damage info
        private static List<DamageInfo> _blunt = new List<DamageInfo>();
        private static List<DamageInfo> _cleaving = new List<DamageInfo>();
        private static List<DamageInfo> _piercing = new List<DamageInfo>();
        private static List<DamageInfo> _swungPiercing = new List<DamageInfo>();

        public static void LoadLists()
        {
            // looks at each textfile, splits on pipes (|) and newlines (\n) and then pops the result into a receiving list
            _blunt = ExtractInfo(Properties.Resources.Blunt.Split('|', '\n'));
            _cleaving = ExtractInfo(Properties.Resources.Cleaving.Split('|', '\n'));
            _piercing = ExtractInfo(Properties.Resources.Piercing.Split('|', '\n'));
            _swungPiercing = ExtractInfo(Properties.Resources.Swung_Piercing.Split('|', '\n'));
        }

        private static List<DamageInfo> ExtractInfo(string[] readIn)
        {
            // populates a damageInfo object, which then gets put into a list of damageInfos
            List<DamageInfo> sorted = new List<DamageInfo>();

            for (int i = 0; i < readIn.Length; i += 12)  // +12 is offset to the next item
            {
                DamageInfo d = new DamageInfo();

                d.Area = Convert.ToInt32(readIn[i]);
                d.Roll = Convert.ToInt32(readIn[i + 1]);
                d.Location = readIn[i + 2];
                d.Level = Convert.ToInt32(readIn[i + 3]);
                d.BloodLoss = Convert.ToInt32(readIn[i + 4]);
                d.Shock = Convert.ToInt32(readIn[i + 5]);
                d.Pain = Convert.ToInt32(readIn[i + 6]);
                d.Knockdown = Convert.ToInt32(readIn[i + 7]);
                d.Knockout = Convert.ToInt32(readIn[i + 8]);
                d.Description = readIn[i + 9];
                d.Dead = Convert.ToBoolean(readIn[i + 10]);
                d.Gender = readIn[i + 11];

                sorted.Add(d);  // once we have everything an item needs, add the completed item to the list
            }

            return sorted;  // once we have everything, return the complete list
        }

        public DamageInfo FindDamageInfo(int damageType, int area, int roll, int level, string gender)
        {
            List<DamageInfo> fullList = GetTypeList((DamageType)damageType);  // receives back the right list to use
            
            if (gender == "")  // if our checkbox IS checked, we pretty much ignore the gender alltogether
            {
                foreach (DamageInfo di in fullList)  // go through the list
                    if (di.Area == area && di.Roll == roll && di.Level == level)  // if we find a match
                        return di;  // return it
            }
            else  // if we're looking (maybe) for a female object
            {
                DamageInfo genderCheck = new DamageInfo();  // set up a temp object

                foreach (DamageInfo di in fullList)
                {
                    if (di.Area == area && di.Roll == roll && di.Level == level)  // as above
                    {
                        genderCheck = di;  // we have a (potential) hit, update the temp object

                        if (di.Gender == gender)  // if it's an exact match, return it back, otherwise, keep iterating
                            return genderCheck;
                    }
                }
                return genderCheck;  // we didn't find a complete match, but we maybe found something that is close
            }

            return null;  // or we didn't find anything at all - this will throw (eventually)
        }

        private List<DamageInfo> GetTypeList(DamageType type)
        {
            switch (type)  // tells us what list to use for finding the right damage info
            {
                case DamageType.Cleaving:
                    return _cleaving;
                case DamageType.Piercing:
                    return _piercing;
                case DamageType.Blunt:
                    return _blunt;
                case DamageType.SwungPiercing:
                    return _swungPiercing;
                default:
                    return null;
            }
        }
    }
}
