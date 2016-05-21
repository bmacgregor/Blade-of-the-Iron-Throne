using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Data
{
    class Prof_Melee
    {
        public string Name { get; set; }

        public int? dBrawl { get; set; }
        public int? dCut_Thrust { get; set; }
        public int? dDagger { get; set; }
        public int? dGreatsword { get; set; }
        public int? dLance { get; set; }
        public int? dLongsword { get; set; }
        public int? dMassWeapon { get; set; }
        public int? dPolearm { get; set; }
        public int? dSpear_Shield { get; set; }
        public int? dSword_Shield { get; set; }
        public int? dWrestling { get; set; }

        public string Description { get; set; }

        public Prof_Melee(string name, int? brawl, int? cut_thrust, int? dagger, int? greatsword, int? lance, int? longsword, int? massweapon,
            int? polearm, int? spear_shield, int? sword_shield, int? wrestling, string desc)
        {
            Name = name;
            dBrawl = brawl;
            dCut_Thrust = cut_thrust;
            dDagger = dagger;
            dGreatsword = greatsword;
            dLance = lance;
            dLongsword = longsword;
            dMassWeapon = massweapon;
            dPolearm = polearm;
            dSpear_Shield = spear_shield;
            dSword_Shield = sword_shield;
            dWrestling = wrestling;
            Description = desc;
        }
    }
}
