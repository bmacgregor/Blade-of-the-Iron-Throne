using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Character
{
    class Priority
    {
        public enum Sorcery { Mysteriarch, Sorcerer, Dabbler, Mundane, Cursed, Doomed }
        public enum Culture { Enlightened, Savage, Hillman_Nomad, Civilized, Decadent, Degenerate }
        public enum Attribute { A = 34, B = 29, C = 26, D = 24, E = 22, F = 18 }
        public enum Skill { A = 48, B = 33, C = 24, D = 18, E = 12, F = 0 }
        public enum Proficiency { A = 16, B = 11, C = 8, D = 6, E = 4, F = 0 }
        public enum Asset { A = 6, B = 3, C = 1, D = 0, E = -1, F = -3 }

        public bool CheckLevels(Info.Karma k, List<bool> radios, char check)
        {
            int count = 1;

            switch(check)
            {
                case ('A'):
                    {
                        switch (k)
                        {
                            case (Info.Karma.Bonus_A):
                            case (Info.Karma.Bonus_A_B):
                            case (Info.Karma.Bonus_A_C):
                                count = 2;
                                break;
                            case (Info.Karma.Bonus_A_A):
                            case (Info.Karma.Bonus_A_A_B):
                            case (Info.Karma.Bonus_A_A_C):
                                count = 3;
                                break;
                            case (Info.Karma.Bonus_A_A_A):
                                count = 4;
                                break;
                        }
                    }
                    break;
                case ('B'):
                case ('C'):
                case ('D'):
                case ('E'):
                    {
                        switch(k)
                        {
                            case (Info.Karma.Bonus_B):
                            case (Info.Karma.Bonus_A_B):
                            case (Info.Karma.Bonus_A_A_B):
                            case (Info.Karma.Bonus_C):
                            case (Info.Karma.Bonus_A_C):
                            case (Info.Karma.Bonus_A_A_C):
                            case (Info.Karma.Bonus_D):
                            case (Info.Karma.Bonus_E):
                                count = 2;
                                break;
                        }
                    }
                    break;
            }
            
            foreach (bool b in radios)
                if (b)
                    --count;

            return count >= 0;
        }
    }
}
