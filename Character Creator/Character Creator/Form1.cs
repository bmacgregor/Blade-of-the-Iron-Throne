using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Character_Creator.Utility;

namespace Character_Creator
{
    public partial class Character_Creator : Form
    {
        public Character_Creator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaded h = new Loaded();
            List<string> extracted = new List<string>();  // holds .txt entries to be converted

            extracted = h.ReadText(Properties.Resources.Arcance_Secrets);  // read all secret info
            Loaded.GetSecrets(extracted);  // extract strings into secret-object-form
            extracted.Clear();  // clear down the list for the next entries

            // all the loading works as described above, just alters the object-type
            extracted = h.ReadText(Properties.Resources.Assets);
            Loaded.GetAssets(extracted);
            extracted.Clear();

            extracted = h.ReadText(Properties.Resources.Mysteries);
            Loaded.GetMysteries(extracted);
            extracted.Clear();

            extracted = h.ReadText(Properties.Resources.Proficiencies_Melee);
            Loaded.GetProfMelee(extracted);
            extracted.Clear();

            extracted = h.ReadText(Properties.Resources.Proficiencies_Ranged);
            Loaded.GetProfRanged(extracted);
            extracted.Clear();

            extracted = h.ReadText(Properties.Resources.Skills);
            Loaded.GetSkills(extracted);
            // all .txt info is now loaded into the program
        }
    }
}
