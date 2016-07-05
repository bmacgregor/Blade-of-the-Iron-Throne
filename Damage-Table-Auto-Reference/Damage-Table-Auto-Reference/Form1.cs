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
        DamageInfo info = new DamageInfo();  // for holding specified damage-source info
        string gender = "";  // if the user is attacking a non-male foe...

        public Form1()
        {
            InitializeComponent();
            DamageInfo.LoadLists();  // loads all back-end lists based on textfile data
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in Helpers._damageTables)  // populates the first combo-box
                CMB_DamageTable.Items.Add(s);

            CMB_DamageTable.SelectedIndex = 0;  // and sets the selected index to zero
        }

        private void CMB_DamageTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_AttackAreas.Items.Clear();  // if the selected index is changed, clear down the second combo-box and prepare to load it

            Helpers.SetUpArea(CMB_DamageTable.SelectedIndex);  // populates the second combo-box with valid entries

            foreach (KeyValuePair<int, string> kvp in Helpers._damageAreas)
                CMB_AttackAreas.Items.Add(kvp.Value);

            CMB_AttackAreas.SelectedIndex = 0;  // and sets the selected index to zero

            if (CMB_DamageTable.SelectedIndex == 0)
                ResetUI();
        }

        private void CMB_AttackAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_AttackAreas.SelectedIndex == 0)  // if we're not at a 'valid' index
                ResetUI();
            else  // otherwise, we must have a valid index
            {
                NUD_d6Result.Enabled = true;  // so everything gets enabled
                NUD_AttackLevel.Enabled = true;
                BTN_Rolld6.Enabled = true;
                CHB_Gender.Enabled = true;

                UpdateDamage();  // and we update labels and the textbox based on the returned information
                DeadSettings();  // if the foe is dead, set the text to red, otherwise, it's black
            }
        }

        private void NUD_d6Result_ValueChanged(object sender, EventArgs e)
        {
            if (CMB_AttackAreas.SelectedIndex > 0 && CMB_DamageTable.SelectedIndex > 0)
            {
                UpdateDamage();  // as above
                DeadSettings();
            }
        }

        private void BTN_Rolld6_Click(object sender, EventArgs e)
        {
            NUD_d6Result.Value = Helpers.Rolld6();  // puts a random number between one and six in the numeric up-down
        }

        private void DeadSettings()
        {
            if (info.Dead)  // if the for is dead
            {
                LBL_BloodLoss.ForeColor = Color.Red;  // make everything red
                TXB_Description.ForeColor = Color.Red;
                LBL_Knockdown.ForeColor = Color.Red;
                LBL_Knockout.ForeColor = Color.Red;
                LBL_Pain.ForeColor = Color.Red;
                LBL_Shock.ForeColor = Color.Red;
                LBL_Location.ForeColor = Color.Red;
            }
            else  // otherise
            {
                LBL_BloodLoss.ForeColor = Color.Black;  // all text is black
                TXB_Description.ForeColor = Color.Black;
                LBL_Knockdown.ForeColor = Color.Black;
                LBL_Knockout.ForeColor = Color.Black;
                LBL_Pain.ForeColor = Color.Black;
                LBL_Shock.ForeColor = Color.Black;
                LBL_Location.ForeColor = Color.Black;
            }

            LBL_BloodLoss.Text = "Blood Loss : " + info.BloodLoss;  // update label info
            LBL_Knockdown.Text = "Knockdown : " + info.Knockdown;
            LBL_Knockout.Text = "Knockout : " + info.Knockout;
            LBL_Pain.Text = "Pain : " + info.Pain;
            LBL_Shock.Text = "Shock : " + info.Shock;
            LBL_Location.Text = "Attack Location : " + info.Location;
            TXB_Description.Text = "Description : " + info.Description;  // and show the new description
        }

        private void CHB_Gender_CheckedChanged(object sender, EventArgs e)
        {
            gender = CHB_Gender.Checked ? "" : "Female\r";  // update the string, depepnding on checkbox state

            if (CMB_AttackAreas.SelectedIndex > 0 && CMB_DamageTable.SelectedIndex > 0)
            {
                UpdateDamage();  // and as above
                DeadSettings();
            }
        }

        private void UpdateDamage()
        {
            LBL_Location.Text = "Attack Location : None";  // assume invalid entry, gets over-written if we have something valid

            if (CMB_AttackAreas.SelectedIndex > 0 && CMB_DamageTable.SelectedIndex > 0)  // check if we need to do anything based on indexes
            {
                int index = CMB_AttackAreas.SelectedIndex;  // save the current index of the combo

                if (CMB_DamageTable.SelectedIndex == 2)  // and potentially add an offset if we're piercing
                    index += 7;

                info = info.FindDamageInfo(CMB_DamageTable.SelectedIndex, index,  // then find the correct damage info and update the info object
                    (int)NUD_d6Result.Value, (int)NUD_AttackLevel.Value, gender);
            }
            else
                ResetUI();
        }

        private void MSI_HowTo_Click(object sender, EventArgs e)
        {
            // messagebox to tell user how the application works
            MessageBox.Show("First, you'll need to select the damage type being used from the first drop-down menu." + 
                "\n\nAfter you've chosen the damage type, pick the attack area from the second drop-down menu." + 
                "\n\nNow, you'll be able to enter in the attack level and the die roll for the attack, as well as " +
                "specifying the foe's gender.  If you'd like to roll randomly, just click the \"Roll Randomly\" button." +
                "\n\nAll results will be populated based on what you've entered.  If your attack was enough to outright " +
                "kill your foe, the text colour will change to red, otherwise, it will appear in black.", "How Do I Use This?");
        }

        private void MSI_Bugs_Click(object sender, EventArgs e)
        {
            // messagebox to tell the user how to submit bugs
            MessageBox.Show("If you've found a bug (or an error.  Or a spelling mistake.  Or something not quite right with this tool)" +
                ", feel free to send me an e-mail about it!  I can be reached at: " +
                "\n\n\t\t\tthe_maker@zoho.com\n\n" +
                "If it's a bug, let me know what went wrong, how you made it happen, and the current version number of the " +
                "Damage Table you're using (this is version 1.0).  Otherwise, just tell me where the error is, and I'll fix it!",
                "I Found a Bug!");
        }

        private void ResetUI()
        {
            NUD_d6Result.Enabled = false;  // disable everything
            NUD_AttackLevel.Enabled = false;
            BTN_Rolld6.Enabled = false;
            CHB_Gender.Enabled = false;

            LBL_BloodLoss.Text = "Blood Loss : 0";  // and reset the labels
            TXB_Description.Text = "Description :";
            LBL_Pain.Text = "Pain : 0";
            LBL_Shock.Text = "Shock : 0";
            LBL_Knockdown.Text = "Knockdown : 0";
            LBL_Knockout.Text = "Knockout : 0";
            LBL_Location.Text = "Attack Location : None";

            NUD_AttackLevel.Value = 1;
            NUD_d6Result.Value = 1;
        }
    }
}
