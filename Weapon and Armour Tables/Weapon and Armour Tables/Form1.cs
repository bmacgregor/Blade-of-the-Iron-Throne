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
            PrepareWeapons();
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
            CMB_Armour.SelectedIndex = (rng.Next(1, CMB_Armour.Items.Count - 1));
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

        private void PrepareWeapons()
        {
            Weapon.LoadWeapons();

            List<string> WeaponNames = Weapon.GetWeaponGroups();

            CMB_WeaponGroup.Items.Add("Select Weapon Group");

            foreach (string s in WeaponNames)
                CMB_WeaponGroup.Items.Add(s);

            CMB_WeaponGroup.SelectedIndex = 0;
        }

        private void CMB_WeaponGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_Weapon.Enabled = false;
            BTN_Weap_Random.Enabled = false;
            List<string> weapons = new List<string>() { "Select Weapon" };
            
            if (CMB_WeaponGroup.SelectedIndex != 0)
            {
                CMB_Weapon.Enabled = true;
                BTN_Weap_Random.Enabled = true;
                CMB_Weapon.Items.Clear();
                List<string> temp = Weapon.AllWeaponsInGroup(CMB_WeaponGroup.SelectedIndex);

                foreach (string s in temp)
                    weapons.Add(s);
            }

            CMB_Weapon.SelectedIndex = 0;
        }

        private void CMB_Weapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Weapon update = CMB_WeaponGroup.SelectedIndex != 0 ? Weapon.FindWeapon(CMB_WeaponGroup.SelectedItem.ToString()) 
                : Weapon.PassDefault();

            LBL_Reach.Text = "Reach : " + update.Reach;
            LBL_SwingATN.Text = "Swing ATN : " + update.Swing_ATN;
            LBL_SwingDR.Text = "Swing DR : " + update.Swing_DR;
            LBL_ThrustATN.Text = "Thrust ATN : " + update.Thrust_ATN;
            LBL_ThrustDR.Text = "Thrust DR : " + update.Thrust_DR;
            LBL_DTN.Text = "DTN : " + update.DTN;
            LBL_BluntDR.Text = "Blunt DR : " + update.Blunt_DR;
            TXB_Weap_Description.Text = update.Description;
            TXB_Weap_Notes.Text = update.Notes;
        }

        private void BTN_Weap_RngGroup_Click(object sender, EventArgs e)
        {
            CMB_WeaponGroup.SelectedIndex = rng.Next(1, CMB_WeaponGroup.Items.Count - 1);
        }

        private void BTN_Weap_Random_Click(object sender, EventArgs e)
        {
            CMB_Weapon.SelectedIndex = rng.Next(1, CMB_Weapon.Items.Count - 1);
        }
    }
}
