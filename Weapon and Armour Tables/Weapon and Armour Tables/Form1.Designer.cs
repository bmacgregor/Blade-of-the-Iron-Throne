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
            this.TXB_Arm_Notes = new System.Windows.Forms.TextBox();
            this.TXB_Arm_Description = new System.Windows.Forms.TextBox();
            this.LBL_Arm_Notes = new System.Windows.Forms.Label();
            this.LBL_Arm_Description = new System.Windows.Forms.Label();
            this.LBL_Arm_Cleaving = new System.Windows.Forms.Label();
            this.LBL_Arm_Blunt = new System.Windows.Forms.Label();
            this.LBL_Arm_Piercing = new System.Windows.Forms.Label();
            this.CMB_Armour = new System.Windows.Forms.ComboBox();
            this.BTN_Arm_Random = new System.Windows.Forms.Button();
            this.GB_Weapons.SuspendLayout();
            this.GB_Armour.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Weapons
            // 
            this.GB_Weapons.Controls.Add(this.CMB_Weapon);
            this.GB_Weapons.Controls.Add(this.CMB_WeaponGroup);
            this.GB_Weapons.Location = new System.Drawing.Point(13, 13);
            this.GB_Weapons.Name = "GB_Weapons";
            this.GB_Weapons.Size = new System.Drawing.Size(423, 100);
            this.GB_Weapons.TabIndex = 0;
            this.GB_Weapons.TabStop = false;
            this.GB_Weapons.Text = "Weapon Information";
            // 
            // CMB_Weapon
            // 
            this.CMB_Weapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Weapon.FormattingEnabled = true;
            this.CMB_Weapon.Location = new System.Drawing.Point(7, 53);
            this.CMB_Weapon.Name = "CMB_Weapon";
            this.CMB_Weapon.Size = new System.Drawing.Size(324, 24);
            this.CMB_Weapon.TabIndex = 1;
            // 
            // CMB_WeaponGroup
            // 
            this.CMB_WeaponGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_WeaponGroup.FormattingEnabled = true;
            this.CMB_WeaponGroup.Location = new System.Drawing.Point(7, 22);
            this.CMB_WeaponGroup.Name = "CMB_WeaponGroup";
            this.CMB_WeaponGroup.Size = new System.Drawing.Size(323, 24);
            this.CMB_WeaponGroup.TabIndex = 0;
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
            this.GB_Armour.Location = new System.Drawing.Point(13, 120);
            this.GB_Armour.Name = "GB_Armour";
            this.GB_Armour.Size = new System.Drawing.Size(423, 367);
            this.GB_Armour.TabIndex = 1;
            this.GB_Armour.TabStop = false;
            this.GB_Armour.Text = "Armour Information";
            // 
            // TXB_Arm_Notes
            // 
            this.TXB_Arm_Notes.Location = new System.Drawing.Point(7, 279);
            this.TXB_Arm_Notes.Multiline = true;
            this.TXB_Arm_Notes.Name = "TXB_Arm_Notes";
            this.TXB_Arm_Notes.ReadOnly = true;
            this.TXB_Arm_Notes.Size = new System.Drawing.Size(404, 77);
            this.TXB_Arm_Notes.TabIndex = 9;
            // 
            // TXB_Arm_Description
            // 
            this.TXB_Arm_Description.Location = new System.Drawing.Point(7, 98);
            this.TXB_Arm_Description.Multiline = true;
            this.TXB_Arm_Description.Name = "TXB_Arm_Description";
            this.TXB_Arm_Description.ReadOnly = true;
            this.TXB_Arm_Description.Size = new System.Drawing.Size(404, 158);
            this.TXB_Arm_Description.TabIndex = 8;
            // 
            // LBL_Arm_Notes
            // 
            this.LBL_Arm_Notes.AutoSize = true;
            this.LBL_Arm_Notes.Location = new System.Drawing.Point(7, 259);
            this.LBL_Arm_Notes.Name = "LBL_Arm_Notes";
            this.LBL_Arm_Notes.Size = new System.Drawing.Size(45, 17);
            this.LBL_Arm_Notes.TabIndex = 7;
            this.LBL_Arm_Notes.Text = "Notes";
            // 
            // LBL_Arm_Description
            // 
            this.LBL_Arm_Description.AutoSize = true;
            this.LBL_Arm_Description.Location = new System.Drawing.Point(7, 78);
            this.LBL_Arm_Description.Name = "LBL_Arm_Description";
            this.LBL_Arm_Description.Size = new System.Drawing.Size(79, 17);
            this.LBL_Arm_Description.TabIndex = 6;
            this.LBL_Arm_Description.Text = "Description";
            // 
            // LBL_Arm_Cleaving
            // 
            this.LBL_Arm_Cleaving.AutoSize = true;
            this.LBL_Arm_Cleaving.Location = new System.Drawing.Point(273, 52);
            this.LBL_Arm_Cleaving.Name = "LBL_Arm_Cleaving";
            this.LBL_Arm_Cleaving.Size = new System.Drawing.Size(123, 17);
            this.LBL_Arm_Cleaving.TabIndex = 5;
            this.LBL_Arm_Cleaving.Text = "AV vs. Cleaving : -";
            // 
            // LBL_Arm_Blunt
            // 
            this.LBL_Arm_Blunt.AutoSize = true;
            this.LBL_Arm_Blunt.Location = new System.Drawing.Point(151, 52);
            this.LBL_Arm_Blunt.Name = "LBL_Arm_Blunt";
            this.LBL_Arm_Blunt.Size = new System.Drawing.Size(101, 17);
            this.LBL_Arm_Blunt.TabIndex = 4;
            this.LBL_Arm_Blunt.Text = "AV vs. Blunt : -";
            // 
            // LBL_Arm_Piercing
            // 
            this.LBL_Arm_Piercing.AutoSize = true;
            this.LBL_Arm_Piercing.Location = new System.Drawing.Point(10, 52);
            this.LBL_Arm_Piercing.Name = "LBL_Arm_Piercing";
            this.LBL_Arm_Piercing.Size = new System.Drawing.Size(120, 17);
            this.LBL_Arm_Piercing.TabIndex = 3;
            this.LBL_Arm_Piercing.Text = "AV vs. Piercing : -";
            // 
            // CMB_Armour
            // 
            this.CMB_Armour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Armour.FormattingEnabled = true;
            this.CMB_Armour.Location = new System.Drawing.Point(10, 21);
            this.CMB_Armour.Name = "CMB_Armour";
            this.CMB_Armour.Size = new System.Drawing.Size(320, 24);
            this.CMB_Armour.TabIndex = 2;
            this.CMB_Armour.SelectedIndexChanged += new System.EventHandler(this.CMB_Armour_SelectedIndexChanged);
            // 
            // BTN_Arm_Random
            // 
            this.BTN_Arm_Random.Location = new System.Drawing.Point(336, 21);
            this.BTN_Arm_Random.Name = "BTN_Arm_Random";
            this.BTN_Arm_Random.Size = new System.Drawing.Size(75, 23);
            this.BTN_Arm_Random.TabIndex = 10;
            this.BTN_Arm_Random.Text = "Random";
            this.BTN_Arm_Random.UseVisualStyleBackColor = true;
            this.BTN_Arm_Random.Click += new System.EventHandler(this.BTN_Arm_Random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 502);
            this.Controls.Add(this.GB_Armour);
            this.Controls.Add(this.GB_Weapons);
            this.Name = "Form1";
            this.Text = "Weapon and Armour Tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Weapons.ResumeLayout(false);
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
    }
}

