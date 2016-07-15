using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maneuver_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Maneuver.LoadLists();
            GrappleOptions.LoadList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in Helpers._weaponGroups)
            {
                CMB_Offense.Items.Add(s);
                CMB_Defence.Items.Add(s);
            }

            foreach(string s in Helpers._offensiveManeuver)
                CMB_OffensiveManeuver.Items.Add(s);

            foreach (string s in Helpers._defensiveManeuver)
                CMB_DefensiveManeuver.Items.Add(s);

            foreach (string s in Helpers._grappleOptions)
                CMB_Grapple.Items.Add(s);

            CMB_Offense.SelectedIndex = 0;
            CMB_Defence.SelectedIndex = 0;
            CMB_Grapple.SelectedIndex = 0;
        }

        private void CMB_Offense_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_OffensiveManeuver.Enabled = CMB_Offense.SelectedIndex != 0;

            if (CMB_Offense.SelectedIndex == 0)
                CMB_OffensiveManeuver.SelectedIndex = 0;
            else
                UpdateFields(CMB_Offense, CMB_OffensiveManeuver, TXB_OffenseDesc, LBL_OffenceActivation, LBL_OffensiveProfLvl, true);
        }

        private void CMB_Defence_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_DefensiveManeuver.Enabled = CMB_Defence.SelectedIndex != 0;

            if (CMB_Defence.SelectedIndex == 0)
                CMB_DefensiveManeuver.SelectedIndex = 0;
            else
                UpdateFields(CMB_Defence, CMB_DefensiveManeuver, TXB_DefenceDesc, LBL_DefenceActivation, LBL_DefensiveProfLvl, false);
        }

        private void CMB_OffensiveManeuver_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFields(CMB_Offense, CMB_OffensiveManeuver, TXB_OffenseDesc, LBL_OffenceActivation, LBL_OffensiveProfLvl, true);
        }

        private void CMB_DefensiveManeuver_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFields(CMB_Defence, CMB_DefensiveManeuver, TXB_DefenceDesc, LBL_DefenceActivation, LBL_DefensiveProfLvl, false);
        }

        private void UpdateFields(ComboBox weapon, ComboBox attack, TextBox desc, Label activation, Label level, bool isOffence)
        {
            desc.Text = "";
            activation.Text = "Activation Cost : NA";
            level.Visible = false;

            if (attack.SelectedIndex != 0)
            {
                Maneuver m = Maneuver.GetInfo(attack.SelectedItem.ToString(), isOffence);

                desc.Text = m.Description;
                activation.Text = "Activation Cost : " + Maneuver.GetCost(CMB_Offense.SelectedItem.ToString(), m);
                level.Text = m.Notes;
                level.Visible = true;
            }
        }

        private void CMB_Grapple_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXB_GrappleDesc.Text = GrappleOptions.GetDescription(CMB_Grapple.SelectedItem.ToString());
        }
    }
}
