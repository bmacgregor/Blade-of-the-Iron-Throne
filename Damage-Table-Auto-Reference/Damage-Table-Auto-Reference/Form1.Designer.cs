namespace Damage_Table_Auto_Reference
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CMB_DamageTable = new System.Windows.Forms.ComboBox();
            this.CMB_AttackAreas = new System.Windows.Forms.ComboBox();
            this.BTN_Rolld6 = new System.Windows.Forms.Button();
            this.NUD_d6Result = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_d6Roll = new System.Windows.Forms.Label();
            this.LBL_BloodLoss = new System.Windows.Forms.Label();
            this.LBL_Shock = new System.Windows.Forms.Label();
            this.LBL_Pain = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6Result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMB_DamageTable
            // 
            this.CMB_DamageTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_DamageTable.FormattingEnabled = true;
            this.CMB_DamageTable.Location = new System.Drawing.Point(12, 12);
            this.CMB_DamageTable.Name = "CMB_DamageTable";
            this.CMB_DamageTable.Size = new System.Drawing.Size(260, 21);
            this.CMB_DamageTable.TabIndex = 0;
            this.CMB_DamageTable.SelectedIndexChanged += new System.EventHandler(this.CMB_DamageTable_SelectedIndexChanged);
            // 
            // CMB_AttackAreas
            // 
            this.CMB_AttackAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_AttackAreas.FormattingEnabled = true;
            this.CMB_AttackAreas.Location = new System.Drawing.Point(12, 39);
            this.CMB_AttackAreas.Name = "CMB_AttackAreas";
            this.CMB_AttackAreas.Size = new System.Drawing.Size(260, 21);
            this.CMB_AttackAreas.TabIndex = 1;
            this.CMB_AttackAreas.SelectedIndexChanged += new System.EventHandler(this.CMB_AttackAreas_SelectedIndexChanged);
            // 
            // BTN_Rolld6
            // 
            this.BTN_Rolld6.Enabled = false;
            this.BTN_Rolld6.Location = new System.Drawing.Point(135, 66);
            this.BTN_Rolld6.Name = "BTN_Rolld6";
            this.BTN_Rolld6.Size = new System.Drawing.Size(137, 23);
            this.BTN_Rolld6.TabIndex = 3;
            this.BTN_Rolld6.Text = "Roll Randomly?";
            this.BTN_Rolld6.UseVisualStyleBackColor = true;
            this.BTN_Rolld6.Click += new System.EventHandler(this.BTN_Rolld6_Click);
            // 
            // NUD_d6Result
            // 
            this.NUD_d6Result.Enabled = false;
            this.NUD_d6Result.Location = new System.Drawing.Point(58, 66);
            this.NUD_d6Result.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NUD_d6Result.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d6Result.Name = "NUD_d6Result";
            this.NUD_d6Result.Size = new System.Drawing.Size(41, 20);
            this.NUD_d6Result.TabIndex = 4;
            this.NUD_d6Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_d6Result.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d6Result.ValueChanged += new System.EventHandler(this.NUD_d6Result_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_Description);
            this.groupBox1.Controls.Add(this.LBL_Pain);
            this.groupBox1.Controls.Add(this.LBL_Shock);
            this.groupBox1.Controls.Add(this.LBL_BloodLoss);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Damage Results";
            // 
            // LBL_d6Roll
            // 
            this.LBL_d6Roll.AutoSize = true;
            this.LBL_d6Roll.Location = new System.Drawing.Point(9, 68);
            this.LBL_d6Roll.Name = "LBL_d6Roll";
            this.LBL_d6Roll.Size = new System.Drawing.Size(43, 13);
            this.LBL_d6Roll.TabIndex = 6;
            this.LBL_d6Roll.Text = "d6 Roll:";
            // 
            // LBL_BloodLoss
            // 
            this.LBL_BloodLoss.AutoSize = true;
            this.LBL_BloodLoss.Location = new System.Drawing.Point(7, 20);
            this.LBL_BloodLoss.Name = "LBL_BloodLoss";
            this.LBL_BloodLoss.Size = new System.Drawing.Size(74, 13);
            this.LBL_BloodLoss.TabIndex = 0;
            this.LBL_BloodLoss.Text = "Blood Loss : 0";
            // 
            // LBL_Shock
            // 
            this.LBL_Shock.AutoSize = true;
            this.LBL_Shock.Location = new System.Drawing.Point(104, 20);
            this.LBL_Shock.Name = "LBL_Shock";
            this.LBL_Shock.Size = new System.Drawing.Size(53, 13);
            this.LBL_Shock.TabIndex = 1;
            this.LBL_Shock.Text = "Shock : 0";
            // 
            // LBL_Pain
            // 
            this.LBL_Pain.AutoSize = true;
            this.LBL_Pain.Location = new System.Drawing.Point(211, 20);
            this.LBL_Pain.Name = "LBL_Pain";
            this.LBL_Pain.Size = new System.Drawing.Size(43, 13);
            this.LBL_Pain.TabIndex = 2;
            this.LBL_Pain.Text = "Pain : 0";
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Location = new System.Drawing.Point(6, 42);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(69, 13);
            this.LBL_Description.TabIndex = 3;
            this.LBL_Description.Text = "Description : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LBL_d6Roll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUD_d6Result);
            this.Controls.Add(this.BTN_Rolld6);
            this.Controls.Add(this.CMB_AttackAreas);
            this.Controls.Add(this.CMB_DamageTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6Result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_DamageTable;
        private System.Windows.Forms.ComboBox CMB_AttackAreas;
        private System.Windows.Forms.Button BTN_Rolld6;
        private System.Windows.Forms.NumericUpDown NUD_d6Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_d6Roll;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.Label LBL_Pain;
        private System.Windows.Forms.Label LBL_Shock;
        private System.Windows.Forms.Label LBL_BloodLoss;
    }
}

