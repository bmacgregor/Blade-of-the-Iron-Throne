using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator.Character
{
    class Info
    {
        public enum LootLevel { DeadBroke = 1, Poor, Average, Rich, Filthy_Rich, Fantastically_Rich }
        private LootLevel _loot = LootLevel.DeadBroke;
        
        public enum Karma { None = 1, Bonus_E, Bonus_D, Bonus_C, Bonus_B, Bonus_A, Bonus_A_C, Bonus_A_B, Bonus_A_A,
            Bonus_A_A_C, Bonus_A_A_B, Bonus_A_A_A }
        private Karma _karma = Karma.None;

        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string HairColour { get; set; }
        public string EyeColour { get; set; }
        public LootLevel Loot { get { return _loot; } set { _loot = value; } }
        public string Contacts { get; set; }
        public string Appearance { get; set; }
        public string Equipment { get; set; }
        public string Other { get; set; }

        public Karma PlayerKarma { get { return _karma; } set { _karma = value; } }

        public Passion FirstPassion;
        public Passion SecondPassion;
        public Passion ThirdPassion;
        public Passion Drama;        
    }

    class Passion
    {
        string Name { get; set; }
        int Value { get; set; }

        public Passion(string name, int val)
        {
            Name = name;
            Value = val;
        }
    }
}
