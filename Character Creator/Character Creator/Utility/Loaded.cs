using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Character_Creator.Data;

namespace Character_Creator.Utility
{
    class Loaded
    {
        public static List<Asset> allAssets = new List<Asset>();
        public static List<Mystery> allMysteries = new List<Mystery>();
        public static List<Prof_Melee> allProf_Melee = new List<Prof_Melee>();
        public static List<Prof_Ranged> allProf_Ranged = new List<Prof_Ranged>();
        public static List<Secret> allSecrets = new List<Secret>();
        public static List<Skill> allSkills = new List<Skill>();

        public List<string> ReadText(string filename)
        {
            string[] split = filename.Split('|', '\n');

            return split.ToList();
        }

        public static void GetAssets(List<string> conv)
        {
            for (int i = 0; i < conv.Count; i += 5)
            {
                Asset a = new Asset(conv[i], Convert.ToInt32(conv[i + 1]),
                    Convert.ToInt32(conv[i + 2]), Convert.ToInt32(conv[i + 3]), conv[i + 4]);

                allAssets.Add(a);
            }

            Console.WriteLine("Asset values read in");
        }

        public static void GetSecrets(List<string> conv)
        {
            for (int i = 0; i < conv.Count; i += 4)
            {
                Secret s = new Secret(conv[i], Convert.ToInt32(conv[i + 1]), Convert.ToInt32(conv[i + 2]), 
                    conv[i + 3]);

                allSecrets.Add(s);
            }

            Console.WriteLine("Secret values read in");
        }

        public static void GetMysteries(List<string> conv)
        {
            for (int i = 0; i < conv.Count; i += 3)
            {
                Mystery m = new Mystery(conv[i], Convert.ToInt32(conv[i + 1]), conv[i + 2]);

                allMysteries.Add(m);
            }

            Console.WriteLine("Mystery values read in");
        }

        public static void GetProfMelee(List<string> conv)
        {
            for (int i = 0; i < conv.Count; i += 13)
            {
                Prof_Melee m = new Prof_Melee(conv[i], Convert.ToInt32(conv[i + 1]), Convert.ToInt32(conv[i + 2]),
                    Convert.ToInt32(conv[i + 3]), Convert.ToInt32(conv[i + 4]), Convert.ToInt32(conv[i + 5]),
                    Convert.ToInt32(conv[i + 6]), Convert.ToInt32(conv[i + 7]), Convert.ToInt32(conv[i + 8]),
                    Convert.ToInt32(conv[i + 9]), Convert.ToInt32(conv[i + 10]), Convert.ToInt32(conv[i + 11]),
                    conv[i + 12]);

                allProf_Melee.Add(m);
            }

            Console.WriteLine("Melee proficiency values read in");
        }

        public static void GetProfRanged(List<string> conv)
        {
            for (int i = 0; i < conv.Count; i += 13)
            {
                Prof_Ranged r = new Prof_Ranged(conv[i], Convert.ToInt32(conv[i + 1]), Convert.ToInt32(conv[i + 2]),
                    Convert.ToInt32(conv[i + 3]), Convert.ToInt32(conv[i + 4]), Convert.ToInt32(conv[i + 5]),
                    Convert.ToInt32(conv[i + 6]), Convert.ToInt32(conv[i + 7]), Convert.ToInt32(conv[i + 8]),
                    Convert.ToInt32(conv[i + 9]), Convert.ToInt32(conv[i + 10]), Convert.ToInt32(conv[i + 11]),
                    Convert.ToInt32(conv[i + 12]));

                allProf_Ranged.Add(r);
            }

            Console.WriteLine("Ranged proficiency values read in");
        }

        public static void GetSkills(List<string> conv)
        {
            for (int i = 0; i < conv.Count; i += 3)
            {
                Skill s = new Skill(conv[i], Convert.ToInt32(conv[i + 1]), conv[i + 2]);

                allSkills.Add(s);
            }

            Console.WriteLine("Skill values read in");
        }
    }
}
