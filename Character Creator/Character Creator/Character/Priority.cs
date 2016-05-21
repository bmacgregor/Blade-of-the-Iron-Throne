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
    }
}
