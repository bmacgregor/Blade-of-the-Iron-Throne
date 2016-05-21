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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loaded h = new Loaded();
            List<string> extracted = new List<string>();

            extracted = h.ReadText(Properties.Resources.Arcance_Secrets);
            Loaded.GetSecrets(extracted);
            extracted.Clear();

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
        }
    }
}
