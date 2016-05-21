using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Prof_Ranged
    {
        public string Name { get; set; }

        public int? dBlack_Powder { get; set; }
        public int? dBow { get; set; }
        public int? dCrossbow { get; set; }
        public int? dSling { get; set; }
        public int? dSpear_Javelin { get; set; }

        public int? dThrown_Knife { get; set; }
        public int? dThrown_Axe { get; set; }
        public int? dThrown_Rock { get; set; }

        public int? dPolearm { get; set; }
        public int? dSpear_Shield { get; set; }
        public int? dDagger { get; set; }
        public int? dMass_Weapon { get; set; }

        public Prof_Ranged(string name, int? blackpowder, int? bow, int? crossbow, int? sling, int? spear_javelin, int? tKnife, int? tAxe,
            int? tRock, int? polearm, int? spear_shield, int? dagger, int? massweapon)
        {
            Name = name;
            dBlack_Powder = blackpowder;
            dBow = bow;
            dCrossbow = crossbow;
            dSling = sling;
            dSpear_Javelin = spear_javelin;
            dThrown_Knife = tKnife;
            dThrown_Axe = tAxe;
            dThrown_Rock = tRock;
            dPolearm = polearm;
            dSpear_Shield = spear_shield;
            dDagger = dagger;
            dMass_Weapon = massweapon;
        }
    }
}
