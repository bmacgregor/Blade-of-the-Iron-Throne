using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Secret
    {
        public enum Mystery { none, goety, necromancy, cursing, enslavement, mending, prophecy, scrying, witchfire }
        private Mystery _prereq_One = Mystery.none;
        private Mystery _prereq_Two = Mystery.none;

        public string Name { get; set; }
        public Mystery Prereq_One { get { return _prereq_One; } set { _prereq_One = value; } }
        public Mystery Prereq_Two { get { return _prereq_Two; } set { _prereq_Two = value; } }
        public string Description { get; set; }
        
        public Secret(string name, int prereq_One, int prereq_Two, string desc)
        {
            Name = name;
            Prereq_One = (Mystery)prereq_One;
            Prereq_Two = (Mystery)prereq_Two;
            Description = desc;
        }
    }
}
