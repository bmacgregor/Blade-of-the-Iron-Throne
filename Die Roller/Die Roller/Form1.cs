using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Die_Roller
{
    public partial class DieRoller : Form
    {
        private static List<int> results = new List<int>();
        private static Random rng = new Random();
        System.Media.SoundPlayer roll = new System.Media.SoundPlayer(Properties.Resources.Dice);

        public DieRoller()
        {
            InitializeComponent();
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BTN_d6Roll_Click(object sender, EventArgs e)
        {
            Roll(false, (int)NUD_d6Count.Value, 6);
        }

        private void BTN_d12Roll_Click(object sender, EventArgs e)
        {
            Roll(true, (int)NUD_d12Count.Value, 12);
        }

        private void BTN_dXRoll_Click(object sender, EventArgs e)
        {
            Roll(false, (int)NUD_dXCount.Value, (int)NUD_dXSides.Value);
        }

        private void NUD_d12Count_ValueChanged(object sender, EventArgs e)
        {
            ProbableSuccesses();
        }

        private void NUD_d12Target_ValueChanged(object sender, EventArgs e)
        {
            GetOdds();
            ProbableSuccesses();
        }

        private void Roll(bool visibility, int count, int max)
        {
            roll.Play();

            Clear();

            for (int i = 0; i < count; ++i)
                results.Add(rng.Next(1, max + 1));

            results.Sort();
            results.Reverse();

            foreach (int i in results)
                LSB_Results.Items.Add(i);

            if (visibility)
                SuccessCount();
        }

        private void Clear()
        {
            LSB_Results.Items.Clear();
            results.Clear();
            LBL_d12Successes.Visible = false;
        }

        private void SuccessCount()
        {
            int count = 0;

            LBL_d12Successes.Visible = true;

            foreach (int i in results)
                if (i >= NUD_d12Target.Value)
                    ++count;

            LBL_d12Successes.Text = "Successes: " + count;
        }

        private void GetOdds()
        {
            LBL_d12Odds.Text = "Odds of Success : " + ((double)(NUD_d12Target.Value - 1) / 12 * -100 + 100).ToString("N1") + "%";
        }

        private void ProbableSuccesses()
        {
            decimal odds = (NUD_d12Target.Value - 1) / 12 * -1 + 1;

            LBL_d12EstSuccess.Text = "Estimated Successes : " + (odds * NUD_d12Count.Value).ToString("N1");
        }
    }
}
