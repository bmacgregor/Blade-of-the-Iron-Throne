namespace Weapon_and_Armour_Tables
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
            this.GB_Weapons = new System.Windows.Forms.GroupBox();
            this.CMB_Weapon = new System.Windows.Forms.ComboBox();
            this.CMB_WeaponGroup = new System.Windows.Forms.ComboBox();
            this.GB_Armour = new System.Windows.Forms.GroupBox();
            this.BTN_Arm_Random = new System.Windows.Forms.Button();
            this.TXB_Arm_Notes = new System.Windows.Forms.TextBox();
            this.TXB_Arm_Description = new System.Windows.Forms.TextBox();
            this.LBL_Arm_Notes = new System.Windows.Forms.Label();
            this.LBL_Arm_Description = new System.Windows.Forms.Label();
            this.LBL_Arm_Cleaving = new System.Windows.Forms.Label();
            this.LBL_Arm_Blunt = new System.Windows.Forms.Label();
            this.LBL_Arm_Piercing = new System.Windows.Forms.Label();
            this.CMB_Armour = new System.Windows.Forms.ComboBox();
            this.BTN_Weap_RngGroup = new System.Windows.Forms.Button();
            this.BTN_Weap_Random = new System.Windows.Forms.Button();
            this.LBL_Reach = new System.Windows.Forms.Label();
            this.LBL_SwingATN = new System.Windows.Forms.Label();
            this.LBL_SwingDR = new System.Windows.Forms.Label();
            this.LBL_DTN = new System.Windows.Forms.Label();
            this.LBL_ThrustDR = new System.Windows.Forms.Label();
            this.LBL_ThrustATN = new System.Windows.Forms.Label();
            this.LBL_BluntDR = new System.Windows.Forms.Label();
            this.LBL_Weap_Description = new System.Windows.Forms.Label();
            this.TXB_Weap_Description = new System.Windows.Forms.TextBox();
            this.TXB_Weap_Notes = new System.Windows.Forms.TextBox();
            this.LBL_Weap_Notes = new System.Windows.Forms.Label();
            this.GB_Weapons.SuspendLayout();
            this.GB_Armour.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Weapons
            // 
            this.GB_Weapons.Controls.Add(this.TXB_Weap_Notes);
            this.GB_Weapons.Controls.Add(this.LBL_Weap_Notes);
            this.GB_Weapons.Controls.Add(this.TXB_Weap_Description);
            this.GB_Weapons.Controls.Add(this.LBL_Weap_Description);
            this.GB_Weapons.Controls.Add(this.LBL_BluntDR);
            this.GB_Weapons.Controls.Add(this.LBL_DTN);
            this.GB_Weapons.Controls.Add(this.LBL_ThrustDR);
            this.GB_Weapons.Controls.Add(this.LBL_ThrustATN);
            this.GB_Weapons.Controls.Add(this.LBL_SwingDR);
            this.GB_Weapons.Controls.Add(this.LBL_SwingATN);
            this.GB_Weapons.Controls.Add(this.LBL_Reach);
            this.GB_Weapons.Controls.Add(this.BTN_Weap_Random);
            this.GB_Weapons.Controls.Add(this.BTN_Weap_RngGroup);
            this.GB_Weapons.Controls.Add(this.CMB_Weapon);
            this.GB_Weapons.Controls.Add(this.CMB_WeaponGroup);
            this.GB_Weapons.Location = new System.Drawing.Point(10, 11);
            this.GB_Weapons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_Weapons.Name = "GB_Weapons";
            this.GB_Weapons.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_Weapons.Size = new System.Drawing.Size(317, 386);
            this.GB_Weapons.TabIndex = 0;
            this.GB_Weapons.TabStop = false;
            this.GB_Weapons.Text = "Weapon Information";
            // 
            // CMB_Weapon
            // 
            this.CMB_Weapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Weapon.Enabled = false;
            this.CMB_Weapon.FormattingEnabled = true;
            this.CMB_Weapon.Location = new System.Drawing.Point(5, 43);
            this.CMB_Weapon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_Weapon.Name = "CMB_Weapon";
            this.CMB_Weapon.Size = new System.Drawing.Size(244, 21);
            this.CMB_Weapon.TabIndex = 1;
            this.CMB_Weapon.SelectedIndexChanged += new System.EventHandler(this.CMB_Weapon_SelectedIndexChanged);
            // 
            // CMB_WeaponGroup
            // 
            this.CMB_WeaponGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_WeaponGroup.FormattingEnabled = true;
            this.CMB_WeaponGroup.Location = new System.Drawing.Point(5, 18);
            this.CMB_WeaponGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_WeaponGroup.Name = "CMB_WeaponGroup";
            this.CMB_WeaponGroup.Size = new System.Drawing.Size(243, 21);
            this.CMB_WeaponGroup.TabIndex = 0;
            this.CMB_WeaponGroup.SelectedIndexChanged += new System.EventHandler(this.CMB_WeaponGroup_SelectedIndexChanged);
            // 
            // GB_Armour
            // 
            this.GB_Armour.Controls.Add(this.BTN_Arm_Random);
            this.GB_Armour.Controls.Add(this.TXB_Arm_Notes);
            this.GB_Armour.Controls.Add(this.TXB_Arm_Description);
            this.GB_Armour.Controls.Add(this.LBL_Arm_Notes);
            this.GB_Armour.Controls.Add(this.LBL_Arm_Description);
            this.GB_Armour.Controls.Add(this.LBL_Arm_Cleaving);
            this.GB_Armour.Controls.Add(this.LBL_Arm_Blunt);
            this.GB_Armour.Controls.Add(this.LBL_Arm_Piercing);
            this.GB_Armour.Controls.Add(this.CMB_Armour);
            this.GB_Armour.Location = new System.Drawing.Point(331, 11);
            this.GB_Armour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_Armour.Name = "GB_Armour";
            this.GB_Armour.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GB_Armour.Size = new System.Drawing.Size(317, 298);
            this.GB_Armour.TabIndex = 1;
            this.GB_Armour.TabStop = false;
            this.GB_Armour.Text = "Armour Information";
            // 
            // BTN_Arm_Random
            // 
            this.BTN_Arm_Random.Location = new System.Drawing.Point(252, 17);
            this.BTN_Arm_Random.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Arm_Random.Name = "BTN_Arm_Random";
            this.BTN_Arm_Random.Size = new System.Drawing.Size(56, 19);
            this.BTN_Arm_Random.TabIndex = 10;
            this.BTN_Arm_Random.Text = "Random";
            this.BTN_Arm_Random.UseVisualStyleBackColor = true;
            this.BTN_Arm_Random.Click += new System.EventHandler(this.BTN_Arm_Random_Click);
            // 
            // TXB_Arm_Notes
            // 
            this.TXB_Arm_Notes.Location = new System.Drawing.Point(5, 229);
            this.TXB_Arm_Notes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXB_Arm_Notes.Multiline = true;
            this.TXB_Arm_Notes.Name = "TXB_Arm_Notes";
            this.TXB_Arm_Notes.ReadOnly = true;
            this.TXB_Arm_Notes.Size = new System.Drawing.Size(304, 63);
            this.TXB_Arm_Notes.TabIndex = 9;
            // 
            // TXB_Arm_Description
            // 
            this.TXB_Arm_Description.Location = new System.Drawing.Point(5, 80);
            this.TXB_Arm_Description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXB_Arm_Description.Multiline = true;
            this.TXB_Arm_Description.Name = "TXB_Arm_Description";
            this.TXB_Arm_Description.ReadOnly = true;
            this.TXB_Arm_Description.Size = new System.Drawing.Size(304, 129);
            this.TXB_Arm_Description.TabIndex = 8;
            // 
            // LBL_Arm_Notes
            // 
            this.LBL_Arm_Notes.AutoSize = true;
            this.LBL_Arm_Notes.Location = new System.Drawing.Point(5, 212);
            this.LBL_Arm_Notes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Arm_Notes.Name = "LBL_Arm_Notes";
            this.LBL_Arm_Notes.Size = new System.Drawing.Size(35, 13);
            this.LBL_Arm_Notes.TabIndex = 7;
            this.LBL_Arm_Notes.Text = "Notes";
            // 
            // LBL_Arm_Description
            // 
            this.LBL_Arm_Description.AutoSize = true;
            this.LBL_Arm_Description.Location = new System.Drawing.Point(5, 63);
            this.LBL_Arm_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Arm_Description.Name = "LBL_Arm_Description";
            this.LBL_Arm_Description.Size = new System.Drawing.Size(60, 13);
            this.LBL_Arm_Description.TabIndex = 6;
            this.LBL_Arm_Description.Text = "Description";
            // 
            // LBL_Arm_Cleaving
            // 
            this.LBL_Arm_Cleaving.AutoSize = true;
            this.LBL_Arm_Cleaving.Location = new System.Drawing.Point(205, 42);
            this.LBL_Arm_Cleaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Arm_Cleaving.Name = "LBL_Arm_Cleaving";
            this.LBL_Arm_Cleaving.Size = new System.Drawing.Size(94, 13);
            this.LBL_Arm_Cleaving.TabIndex = 5;
            this.LBL_Arm_Cleaving.Text = "AV vs. Cleaving : -";
            // 
            // LBL_Arm_Blunt
            // 
            this.LBL_Arm_Blunt.AutoSize = true;
            this.LBL_Arm_Blunt.Location = new System.Drawing.Point(113, 42);
            this.LBL_Arm_Blunt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Arm_Blunt.Name = "LBL_Arm_Blunt";
            this.LBL_Arm_Blunt.Size = new System.Drawing.Size(77, 13);
            this.LBL_Arm_Blunt.TabIndex = 4;
            this.LBL_Arm_Blunt.Text = "AV vs. Blunt : -";
            // 
            // LBL_Arm_Piercing
            // 
            this.LBL_Arm_Piercing.AutoSize = true;
            this.LBL_Arm_Piercing.Location = new System.Drawing.Point(8, 42);
            this.LBL_Arm_Piercing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Arm_Piercing.Name = "LBL_Arm_Piercing";
            this.LBL_Arm_Piercing.Size = new System.Drawing.Size(91, 13);
            this.LBL_Arm_Piercing.TabIndex = 3;
            this.LBL_Arm_Piercing.Text = "AV vs. Piercing : -";
            // 
            // CMB_Armour
            // 
            this.CMB_Armour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Armour.FormattingEnabled = true;
            this.CMB_Armour.Location = new System.Drawing.Point(8, 17);
            this.CMB_Armour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CMB_Armour.Name = "CMB_Armour";
            this.CMB_Armour.Size = new System.Drawing.Size(241, 21);
            this.CMB_Armour.TabIndex = 2;
            this.CMB_Armour.SelectedIndexChanged += new System.EventHandler(this.CMB_Armour_SelectedIndexChanged);
            // 
            // BTN_Weap_RngGroup
            // 
            this.BTN_Weap_RngGroup.Location = new System.Drawing.Point(252, 18);
            this.BTN_Weap_RngGroup.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Weap_RngGroup.Name = "BTN_Weap_RngGroup";
            this.BTN_Weap_RngGroup.Size = new System.Drawing.Size(56, 19);
            this.BTN_Weap_RngGroup.TabIndex = 11;
            this.BTN_Weap_RngGroup.Text = "Random";
            this.BTN_Weap_RngGroup.UseVisualStyleBackColor = true;
            this.BTN_Weap_RngGroup.Click += new System.EventHandler(this.BTN_Weap_RngGroup_Click);
            // 
            // BTN_Weap_Random
            // 
            this.BTN_Weap_Random.Enabled = false;
            this.BTN_Weap_Random.Location = new System.Drawing.Point(252, 43);
            this.BTN_Weap_Random.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Weap_Random.Name = "BTN_Weap_Random";
            this.BTN_Weap_Random.Size = new System.Drawing.Size(56, 19);
            this.BTN_Weap_Random.TabIndex = 12;
            this.BTN_Weap_Random.Text = "Random";
            this.BTN_Weap_Random.UseVisualStyleBackColor = true;
            this.BTN_Weap_Random.Click += new System.EventHandler(this.BTN_Weap_Random_Click);
            // 
            // LBL_Reach
            // 
            this.LBL_Reach.AutoSize = true;
            this.LBL_Reach.Location = new System.Drawing.Point(6, 80);
            this.LBL_Reach.Name = "LBL_Reach";
            this.LBL_Reach.Size = new System.Drawing.Size(96, 13);
            this.LBL_Reach.TabIndex = 13;
            this.LBL_Reach.Text = "Reach : Very Long";
            // 
            // LBL_SwingATN
            // 
            this.LBL_SwingATN.AutoSize = true;
            this.LBL_SwingATN.Location = new System.Drawing.Point(108, 80);
            this.LBL_SwingATN.Name = "LBL_SwingATN";
            this.LBL_SwingATN.Size = new System.Drawing.Size(82, 13);
            this.LBL_SwingATN.TabIndex = 14;
            this.LBL_SwingATN.Text = "Swing ATN : 12";
            // 
            // LBL_SwingDR
            // 
            this.LBL_SwingDR.AutoSize = true;
            this.LBL_SwingDR.Location = new System.Drawing.Point(196, 80);
            this.LBL_SwingDR.Name = "LBL_SwingDR";
            this.LBL_SwingDR.Size = new System.Drawing.Size(76, 13);
            this.LBL_SwingDR.TabIndex = 15;
            this.LBL_SwingDR.Text = "Swing DR : +3";
            // 
            // LBL_DTN
            // 
            this.LBL_DTN.AutoSize = true;
            this.LBL_DTN.Location = new System.Drawing.Point(196, 103);
            this.LBL_DTN.Name = "LBL_DTN";
            this.LBL_DTN.Size = new System.Drawing.Size(51, 13);
            this.LBL_DTN.TabIndex = 18;
            this.LBL_DTN.Text = "DTN : 12";
            // 
            // LBL_ThrustDR
            // 
            this.LBL_ThrustDR.AutoSize = true;
            this.LBL_ThrustDR.Location = new System.Drawing.Point(108, 103);
            this.LBL_ThrustDR.Name = "LBL_ThrustDR";
            this.LBL_ThrustDR.Size = new System.Drawing.Size(77, 13);
            this.LBL_ThrustDR.TabIndex = 17;
            this.LBL_ThrustDR.Text = "Thrust DR : +3";
            // 
            // LBL_ThrustATN
            // 
            this.LBL_ThrustATN.AutoSize = true;
            this.LBL_ThrustATN.Location = new System.Drawing.Point(6, 103);
            this.LBL_ThrustATN.Name = "LBL_ThrustATN";
            this.LBL_ThrustATN.Size = new System.Drawing.Size(83, 13);
            this.LBL_ThrustATN.TabIndex = 16;
            this.LBL_ThrustATN.Text = "Thrust ATN : 12";
            // 
            // LBL_BluntDR
            // 
            this.LBL_BluntDR.AutoSize = true;
            this.LBL_BluntDR.Location = new System.Drawing.Point(6, 126);
            this.LBL_BluntDR.Name = "LBL_BluntDR";
            this.LBL_BluntDR.Size = new System.Drawing.Size(71, 13);
            this.LBL_BluntDR.TabIndex = 19;
            this.LBL_BluntDR.Text = "Blunt DR : +3";
            // 
            // LBL_Weap_Description
            // 
            this.LBL_Weap_Description.AutoSize = true;
            this.LBL_Weap_Description.Location = new System.Drawing.Point(6, 151);
            this.LBL_Weap_Description.Name = "LBL_Weap_Description";
            this.LBL_Weap_Description.Size = new System.Drawing.Size(60, 13);
            this.LBL_Weap_Description.TabIndex = 20;
            this.LBL_Weap_Description.Text = "Description";
            // 
            // TXB_Weap_Description
            // 
            this.TXB_Weap_Description.Location = new System.Drawing.Point(5, 168);
            this.TXB_Weap_Description.Multiline = true;
            this.TXB_Weap_Description.Name = "TXB_Weap_Description";
            this.TXB_Weap_Description.ReadOnly = true;
            this.TXB_Weap_Description.Size = new System.Drawing.Size(303, 41);
            this.TXB_Weap_Description.TabIndex = 21;
            // 
            // TXB_Weap_Notes
            // 
            this.TXB_Weap_Notes.Location = new System.Drawing.Point(5, 229);
            this.TXB_Weap_Notes.Multiline = true;
            this.TXB_Weap_Notes.Name = "TXB_Weap_Notes";
            this.TXB_Weap_Notes.ReadOnly = true;
            this.TXB_Weap_Notes.Size = new System.Drawing.Size(303, 63);
            this.TXB_Weap_Notes.TabIndex = 23;
            // 
            // LBL_Weap_Notes
            // 
            this.LBL_Weap_Notes.AutoSize = true;
            this.LBL_Weap_Notes.Location = new System.Drawing.Point(6, 212);
            this.LBL_Weap_Notes.Name = "LBL_Weap_Notes";
            this.LBL_Weap_Notes.Size = new System.Drawing.Size(35, 13);
            this.LBL_Weap_Notes.TabIndex = 22;
            this.LBL_Weap_Notes.Text = "Notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 408);
            this.Controls.Add(this.GB_Armour);
            this.Controls.Add(this.GB_Weapons);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Weapon and Armour Tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Weapons.ResumeLayout(false);
            this.GB_Weapons.PerformLayout();
            this.GB_Armour.ResumeLayout(false);
            this.GB_Armour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Weapons;
        private System.Windows.Forms.ComboBox CMB_Weapon;
        private System.Windows.Forms.ComboBox CMB_WeaponGroup;
        private System.Windows.Forms.GroupBox GB_Armour;
        private System.Windows.Forms.TextBox TXB_Arm_Notes;
        private System.Windows.Forms.TextBox TXB_Arm_Description;
        private System.Windows.Forms.Label LBL_Arm_Notes;
        private System.Windows.Forms.Label LBL_Arm_Description;
        private System.Windows.Forms.Label LBL_Arm_Cleaving;
        private System.Windows.Forms.Label LBL_Arm_Blunt;
        private System.Windows.Forms.Label LBL_Arm_Piercing;
        private System.Windows.Forms.ComboBox CMB_Armour;
        private System.Windows.Forms.Button BTN_Arm_Random;
        private System.Windows.Forms.Button BTN_Weap_Random;
        private System.Windows.Forms.Button BTN_Weap_RngGroup;
        private System.Windows.Forms.Label LBL_Reach;
        private System.Windows.Forms.TextBox TXB_Weap_Notes;
        private System.Windows.Forms.Label LBL_Weap_Notes;
        private System.Windows.Forms.TextBox TXB_Weap_Description;
        private System.Windows.Forms.Label LBL_Weap_Description;
        private System.Windows.Forms.Label LBL_BluntDR;
        private System.Windows.Forms.Label LBL_DTN;
        private System.Windows.Forms.Label LBL_ThrustDR;
        private System.Windows.Forms.Label LBL_ThrustATN;
        private System.Windows.Forms.Label LBL_SwingDR;
        private System.Windows.Forms.Label LBL_SwingATN;
    }
}

