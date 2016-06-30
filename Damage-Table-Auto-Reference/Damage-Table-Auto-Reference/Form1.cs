using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damage_Table_Auto_Reference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in Helpers._damageTables)
                CMB_DamageTable.Items.Add(s);

            CMB_DamageTable.SelectedIndex = 0;
        }

        private void CMB_DamageTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_AttackAreas.Items.Clear();

            Helpers.SetUpArea(CMB_DamageTable.SelectedIndex);

            foreach (KeyValuePair<int, string> kvp in Helpers._damageAreas)
                CMB_AttackAreas.Items.Add(kvp.Value);

            CMB_AttackAreas.SelectedIndex = 0;
        }

        private void CMB_AttackAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_AttackAreas.SelectedIndex == 0)
            {
                NUD_d6Result.Enabled = false;
                BTN_Rolld6.Enabled = false;

                LBL_BloodLoss.Text = "Blood Loss : 0";
                LBL_Description.Text = "Description :";
                LBL_Pain.Text = "Pain : 0";
                LBL_Shock.Text = "Shock : 0";
            }
            else
            {
                NUD_d6Result.Enabled = true;
                BTN_Rolld6.Enabled = true;
            }
        }

        private void NUD_d6Result_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Rolld6_Click(object sender, EventArgs e)
        {
            NUD_d6Result.Value = Helpers.Rolld6();
        }
    }
}
