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
using Character_Creator.Character;

namespace Character_Creator
{
    public partial class Character_Creator : Form
    {
        Priority charPriority;
        Info charInfo;

        public Character_Creator()
        {
            InitializeComponent();

            charPriority = new Priority();
            charInfo = new Info();
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

        #region tab-one events
        // all priority radio-button events are wired to this single point of contact
        private void RDO_SorcA_CheckedChanged(object sender, EventArgs e)
        {
            char check = 'F';
            List<bool> radios = new List<bool>() { RDO_AsstF.Checked, RDO_AttrF.Checked, RDO_CultF.Checked, RDO_ProfF.Checked,
                RDO_SkllF.Checked, RDO_SorcF.Checked };
            bool keep = false;
            
            // if statements to find out where the event fired from
            if (sender == RDO_AsstA || sender == RDO_AttrA || sender == RDO_CultA || sender == RDO_ProfA || 
                sender == RDO_SkllA || sender == RDO_SorcA)
            {
                // set up a list of bools to be evaluated
                radios = new List<bool>() { RDO_AsstA.Checked, RDO_AttrA.Checked, RDO_CultA.Checked, RDO_ProfA.Checked,
                RDO_SkllA.Checked, RDO_SorcA.Checked };

                check = 'A';  // and update the check char for the switch case on the other side, as well as later
            }
            // the rest of these checks follow the same set-up as above
            else if (sender == RDO_AsstB || sender == RDO_AttrB || sender == RDO_CultB || sender == RDO_ProfB ||
                sender == RDO_SkllB || sender == RDO_SorcB)
            {
                radios = new List<bool>() { RDO_AsstB.Checked, RDO_AttrB.Checked, RDO_CultB.Checked, RDO_ProfB.Checked,
                RDO_SkllB.Checked, RDO_SorcB.Checked };

                check = 'B';
            }
            else if (sender == RDO_AsstC || sender == RDO_AttrC || sender == RDO_CultC || sender == RDO_ProfC ||
                sender == RDO_SkllC || sender == RDO_SorcC)
            {
                radios = new List<bool>() { RDO_AsstC.Checked, RDO_AttrC.Checked, RDO_CultC.Checked, RDO_ProfC.Checked,
                RDO_SkllC.Checked, RDO_SorcC.Checked };

                check = 'C';
            }
            else if (sender == RDO_AsstD || sender == RDO_AttrD || sender == RDO_CultD || sender == RDO_ProfD||
                sender == RDO_SkllD|| sender == RDO_SorcD)
            {
                radios = new List<bool>() { RDO_AsstD.Checked, RDO_AttrD.Checked, RDO_CultD.Checked, RDO_ProfD.Checked,
                RDO_SkllD.Checked, RDO_SorcD.Checked };

                check = 'D';
            }
            else if (sender == RDO_AsstE || sender == RDO_AttrE|| sender == RDO_CultE || sender == RDO_ProfE ||
                sender == RDO_SkllE || sender == RDO_SorcE)
            {
                radios = new List<bool>() { RDO_AsstE.Checked, RDO_AttrE.Checked, RDO_CultE.Checked, RDO_ProfE.Checked,
                RDO_SkllE.Checked, RDO_SorcE.Checked };

                check = 'E';
            }

            keep = charPriority.CheckLevels(charInfo.PlayerKarma, radios, check);  // check the priority levels

            if (!keep)  // if the check fails
            {
                switch (check)
                {
                    case ('A'):  // then based on what we were checking
                        {
                            // de-select the radio button, if it's selected
                            if (RDO_AsstA.Checked) RDO_AsstA.Checked = false;
                            if (RDO_AttrA.Checked) RDO_AttrA.Checked = false;
                            if (RDO_CultA.Checked) RDO_CultA.Checked = false;
                            if (RDO_ProfA.Checked) RDO_ProfA.Checked = false;
                            if (RDO_SkllA.Checked) RDO_SkllA.Checked = false;
                            if (RDO_SorcA.Checked) RDO_SorcA.Checked = false;
                        }
                        break;
                    case ('B'):
                        {
                            if (RDO_AsstB.Checked) RDO_AsstB.Checked = false;
                            if (RDO_AttrB.Checked) RDO_AttrB.Checked = false;
                            if (RDO_CultB.Checked) RDO_CultB.Checked = false;
                            if (RDO_ProfB.Checked) RDO_ProfB.Checked = false;
                            if (RDO_SkllB.Checked) RDO_SkllB.Checked = false;
                            if (RDO_SorcB.Checked) RDO_SorcB.Checked = false;
                        }
                        break;
                    case ('C'):
                        {
                            if (RDO_AsstC.Checked) RDO_AsstC.Checked = false;
                            if (RDO_AttrC.Checked) RDO_AttrC.Checked = false;
                            if (RDO_CultC.Checked) RDO_CultC.Checked = false;
                            if (RDO_ProfC.Checked) RDO_ProfC.Checked = false;
                            if (RDO_SkllC.Checked) RDO_SkllC.Checked = false;
                            if (RDO_SorcC.Checked) RDO_SorcC.Checked = false;
                        }
                        break;
                    case ('D'):
                        {
                            if (RDO_AsstD.Checked) RDO_AsstD.Checked = false;
                            if (RDO_AttrD.Checked) RDO_AttrD.Checked = false;
                            if (RDO_CultD.Checked) RDO_CultD.Checked = false;
                            if (RDO_ProfD.Checked) RDO_ProfD.Checked = false;
                            if (RDO_SkllD.Checked) RDO_SkllD.Checked = false;
                            if (RDO_SorcD.Checked) RDO_SorcD.Checked = false;
                        }
                        break;
                    case ('E'):
                        {
                            if (RDO_AsstE.Checked) RDO_AsstE.Checked = false;
                            if (RDO_AttrE.Checked) RDO_AttrE.Checked = false;
                            if (RDO_CultE.Checked) RDO_CultE.Checked = false;
                            if (RDO_ProfE.Checked) RDO_ProfE.Checked = false;
                            if (RDO_SkllE.Checked) RDO_SkllE.Checked = false;
                            if (RDO_SorcE.Checked) RDO_SorcE.Checked = false;
                        }
                        break;
                    case ('F'):
                        {
                            if (RDO_AsstF.Checked) RDO_AsstF.Checked = false;
                            if (RDO_AttrF.Checked) RDO_AttrF.Checked = false;
                            if (RDO_CultF.Checked) RDO_CultF.Checked = false;
                            if (RDO_ProfF.Checked) RDO_ProfF.Checked = false;
                            if (RDO_SkllF.Checked) RDO_SkllF.Checked = false;
                            if (RDO_SorcF.Checked) RDO_SorcF.Checked = false;
                        }
                        break;
                }
            }
        }

        // all info-type entries are wired to this single point of contact
        private void TXB_CharName_TextChanged(object sender, EventArgs e)
        {
            // update all character information if required (not sure if this is any faster or slower...)
            if (charInfo.Name != TXB_CharName.Text) charInfo.Name = TXB_CharName.Text;
            if (charInfo.Nationality != TXB_CharNationality.Text) charInfo.Nationality = TXB_CharNationality.Text;
            if (charInfo.Gender != TXB_CharGender.Text) charInfo.Gender = TXB_CharGender.Text;

            try { charInfo.Age = int.Parse(TXB_CharAge.Text); }  // try to convert age to an int
            catch { charInfo.Age = 0; }  // if this is impossible, the age is invalid - set it to zero

            if (charInfo.Height != TXB_CharHeight.Text) charInfo.Height = TXB_CharHeight.Text;

            try { charInfo.Weight = int.Parse(TXB_CharWeight.Text); }  // same conversion as above
            catch { charInfo.Weight = 0; }

            if (charInfo.HairColour != TXB_CharHair.Text) charInfo.HairColour = TXB_CharHair.Text;
            if (charInfo.EyeColour != TXB_CharEye.Text) charInfo.EyeColour = TXB_CharEye.Text;

            if (charInfo.Contacts != TXB_CharContacts.Text) charInfo.Contacts = TXB_CharContacts.Text;
            if (charInfo.Appearance != TXB_CharAppearance.Text) charInfo.Appearance = TXB_CharAppearance.Text;
            if (charInfo.Equipment != TXB_CharEquip.Text) charInfo.Equipment = TXB_CharEquip.Text;
            if (charInfo.Other != TXB_CharOther.Text) charInfo.Other = TXB_CharOther.Text;

            charInfo.Loot = (Info.LootLevel)CMB_CharLootLvl.SelectedIndex;
            charInfo.PlayerKarma = (Info.Karma)CMB_Karma.SelectedIndex;

            charInfo.FirstPassion = new Passion(TXB_PassionOne.Text, (int)NUD_PassionOne.Value);
            charInfo.SecondPassion = new Passion(TXB_PassionTwo.Text, (int)NUD_PassionTwo.Value);
            charInfo.ThirdPassion = new Passion(TXB_PassionThree.Text, (int)NUD_PassionThree.Value);
        }

        // all changes to passion scores are wired to this event
        private void NUD_PassionOne_ValueChanged(object sender, EventArgs e)
        {
            // get the sum of all spent points
            int spent = (int)(NUD_PassionOne.Value + NUD_PassionTwo.Value + NUD_PassionThree.Value + NUD_Drama.Value);

            // evaluate if we're over cost - update UI colour and text
            LBL_Passion_Spent.ForeColor = (spent < 8) ? Color.Black : Color.Red;
            LBL_Passion_Spent.Text = "Points Spent: " + spent + " / 7";

            if (spent == 7) LBL_Passion_Spent.ForeColor = Color.Green;  // if we've spent all points, update colour

            // if we're under or at cost, update the character's passions
            if (spent < 8)
            {
                charInfo.FirstPassion = new Passion(TXB_PassionOne.Text, (int)NUD_PassionOne.Value);
                charInfo.SecondPassion = new Passion(TXB_PassionTwo.Text, (int)NUD_PassionTwo.Value);
                charInfo.ThirdPassion = new Passion(TXB_PassionThree.Text, (int)NUD_PassionThree.Value);
                charInfo.Drama = new Passion("Drama", (int)NUD_Drama.Value);
            }
        }
        #endregion
    }
}
