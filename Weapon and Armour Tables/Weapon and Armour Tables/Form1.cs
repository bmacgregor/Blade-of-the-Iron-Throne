using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weapon_and_Armour_Tables
{
    public partial class Form1 : Form
    {
        private static Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrepareArmour();
        }

        private void CMB_Armour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Armour loaded = Armour.GetArmourInfo(CMB_Armour.SelectedIndex);

            LBL_Arm_Blunt.Text = "AV vs. Blunt : " + loaded.Vs_Blunt;
            LBL_Arm_Cleaving.Text = "AV vs. Cleaving : " + loaded.Vs_Cleaving;
            LBL_Arm_Piercing.Text = "AV vs. Piercing : " + loaded.Vs_Piercing;
            TXB_Arm_Description.Text = loaded.Description;
            TXB_Arm_Notes.Text = loaded.Notes;
        }

        private void BTN_Arm_Random_Click(object sender, EventArgs e)
        {
            CMB_Armour.SelectedIndex = (rng.Next(1, Armour.AllArmours.Count));
        }

        private void PrepareArmour()
        {
            Armour.LoadArmours();

            List<string> ArmourNames = Armour.GetArmourNames();

            CMB_Armour.Items.Add("Select Armour Type");

            foreach (string s in ArmourNames)
                CMB_Armour.Items.Add(s);

            CMB_Armour.SelectedIndex = 0;
        }
    }
}
