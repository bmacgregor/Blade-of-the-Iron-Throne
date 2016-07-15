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
    public partial class Form1 : Form
    {
        private static Random rng = new Random();
        private static List<int> results = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            LSB_Results.Items.Clear();
            results.Clear();

            LBL_Successes.Text = CHB_Target.Checked ? "Number of Successes : "
                + SuccessCounter((int)NUD_TargetNumber.Value).ToString() : "Number of Successes : N/A";
        }

        private void BTN_Roll_d6_Click(object sender, EventArgs e)
        {
            RollDice(6, (int)NUD_d6.Value);
        }      

        private void BTN_Roll_d12_Click(object sender, EventArgs e)
        {
            RollDice(12, (int)NUD_d12.Value);
        }

        private void CHB_Target_CheckedChanged(object sender, EventArgs e)
        {
            NUD_TargetNumber.Enabled = CHB_Target.Checked;

            LBL_Successes.Text = CHB_Target.Checked ? "Number of Successes : " 
                + SuccessCounter((int)NUD_TargetNumber.Value).ToString() : "Number of Successes : N/A";
        }

        private void RollDice(int max, int counter)
        {
            results.Clear();
            LSB_Results.Items.Clear();
            max++;

            for (int i = 0; i < counter; ++i)
                results.Add(rng.Next(1, max));

            results.Sort();
            results.Reverse();

            foreach (int i in results)
                LSB_Results.Items.Add(i.ToString());

            if (max > 7 && CHB_Target.Checked)
                LBL_Successes.Text = "Number of Successes : " + SuccessCounter((int)NUD_TargetNumber.Value).ToString();
        }

        private int SuccessCounter(int target)
        {
            int total = 0;

            if (results.Count == 0)
                return total;

            foreach (int i in results)
                if (i >= target)
                    total++;

            return total;
        }

        private void NUD_TargetNumber_ValueChanged(object sender, EventArgs e)
        {
            LBL_Successes.Text = "Number of Successes : " + SuccessCounter((int)NUD_TargetNumber.Value).ToString();
        }
    }
}
