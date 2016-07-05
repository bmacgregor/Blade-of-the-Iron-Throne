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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CMB_DamageTable = new System.Windows.Forms.ComboBox();
            this.CMB_AttackAreas = new System.Windows.Forms.ComboBox();
            this.BTN_Rolld6 = new System.Windows.Forms.Button();
            this.NUD_d6Result = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_Location = new System.Windows.Forms.Label();
            this.TXB_Description = new System.Windows.Forms.RichTextBox();
            this.LBL_Knockout = new System.Windows.Forms.Label();
            this.LBL_Knockdown = new System.Windows.Forms.Label();
            this.LBL_Pain = new System.Windows.Forms.Label();
            this.LBL_Shock = new System.Windows.Forms.Label();
            this.LBL_BloodLoss = new System.Windows.Forms.Label();
            this.LBL_d6Roll = new System.Windows.Forms.Label();
            this.CHB_Gender = new System.Windows.Forms.CheckBox();
            this.LBL_AttackLevel = new System.Windows.Forms.Label();
            this.NUD_AttackLevel = new System.Windows.Forms.NumericUpDown();
            this.MENU_All = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_HowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.MSI_Bugs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6Result)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AttackLevel)).BeginInit();
            this.MENU_All.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMB_DamageTable
            // 
            this.CMB_DamageTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_DamageTable.FormattingEnabled = true;
            this.CMB_DamageTable.Location = new System.Drawing.Point(12, 27);
            this.CMB_DamageTable.Name = "CMB_DamageTable";
            this.CMB_DamageTable.Size = new System.Drawing.Size(260, 21);
            this.CMB_DamageTable.TabIndex = 0;
            this.CMB_DamageTable.SelectedIndexChanged += new System.EventHandler(this.CMB_DamageTable_SelectedIndexChanged);
            // 
            // CMB_AttackAreas
            // 
            this.CMB_AttackAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_AttackAreas.FormattingEnabled = true;
            this.CMB_AttackAreas.Location = new System.Drawing.Point(12, 54);
            this.CMB_AttackAreas.Name = "CMB_AttackAreas";
            this.CMB_AttackAreas.Size = new System.Drawing.Size(260, 21);
            this.CMB_AttackAreas.TabIndex = 1;
            this.CMB_AttackAreas.SelectedIndexChanged += new System.EventHandler(this.CMB_AttackAreas_SelectedIndexChanged);
            // 
            // BTN_Rolld6
            // 
            this.BTN_Rolld6.Enabled = false;
            this.BTN_Rolld6.Location = new System.Drawing.Point(135, 107);
            this.BTN_Rolld6.Name = "BTN_Rolld6";
            this.BTN_Rolld6.Size = new System.Drawing.Size(137, 23);
            this.BTN_Rolld6.TabIndex = 5;
            this.BTN_Rolld6.Text = "Roll Randomly?";
            this.BTN_Rolld6.UseVisualStyleBackColor = true;
            this.BTN_Rolld6.Click += new System.EventHandler(this.BTN_Rolld6_Click);
            // 
            // NUD_d6Result
            // 
            this.NUD_d6Result.Enabled = false;
            this.NUD_d6Result.Location = new System.Drawing.Point(231, 81);
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
            this.NUD_d6Result.TabIndex = 3;
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
            this.groupBox1.Controls.Add(this.LBL_Location);
            this.groupBox1.Controls.Add(this.TXB_Description);
            this.groupBox1.Controls.Add(this.LBL_Knockout);
            this.groupBox1.Controls.Add(this.LBL_Knockdown);
            this.groupBox1.Controls.Add(this.LBL_Pain);
            this.groupBox1.Controls.Add(this.LBL_Shock);
            this.groupBox1.Controls.Add(this.LBL_BloodLoss);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Damage Results";
            // 
            // LBL_Location
            // 
            this.LBL_Location.AutoSize = true;
            this.LBL_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Location.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL_Location.Location = new System.Drawing.Point(12, 62);
            this.LBL_Location.Name = "LBL_Location";
            this.LBL_Location.Size = new System.Drawing.Size(117, 13);
            this.LBL_Location.TabIndex = 6;
            this.LBL_Location.Text = "Attack Location : None";
            // 
            // TXB_Description
            // 
            this.TXB_Description.Location = new System.Drawing.Point(15, 81);
            this.TXB_Description.Name = "TXB_Description";
            this.TXB_Description.ReadOnly = true;
            this.TXB_Description.Size = new System.Drawing.Size(234, 75);
            this.TXB_Description.TabIndex = 0;
            this.TXB_Description.Text = "Description :";
            // 
            // LBL_Knockout
            // 
            this.LBL_Knockout.AutoSize = true;
            this.LBL_Knockout.Location = new System.Drawing.Point(104, 41);
            this.LBL_Knockout.Name = "LBL_Knockout";
            this.LBL_Knockout.Size = new System.Drawing.Size(68, 13);
            this.LBL_Knockout.TabIndex = 5;
            this.LBL_Knockout.Text = "Knockout : 0";
            // 
            // LBL_Knockdown
            // 
            this.LBL_Knockdown.AutoSize = true;
            this.LBL_Knockdown.Location = new System.Drawing.Point(12, 41);
            this.LBL_Knockdown.Name = "LBL_Knockdown";
            this.LBL_Knockdown.Size = new System.Drawing.Size(79, 13);
            this.LBL_Knockdown.TabIndex = 4;
            this.LBL_Knockdown.Text = "Knockdown : 0";
            // 
            // LBL_Pain
            // 
            this.LBL_Pain.AutoSize = true;
            this.LBL_Pain.Location = new System.Drawing.Point(206, 20);
            this.LBL_Pain.Name = "LBL_Pain";
            this.LBL_Pain.Size = new System.Drawing.Size(43, 13);
            this.LBL_Pain.TabIndex = 3;
            this.LBL_Pain.Text = "Pain : 0";
            // 
            // LBL_Shock
            // 
            this.LBL_Shock.AutoSize = true;
            this.LBL_Shock.Location = new System.Drawing.Point(104, 20);
            this.LBL_Shock.Name = "LBL_Shock";
            this.LBL_Shock.Size = new System.Drawing.Size(53, 13);
            this.LBL_Shock.TabIndex = 2;
            this.LBL_Shock.Text = "Shock : 0";
            // 
            // LBL_BloodLoss
            // 
            this.LBL_BloodLoss.AutoSize = true;
            this.LBL_BloodLoss.Location = new System.Drawing.Point(12, 20);
            this.LBL_BloodLoss.Name = "LBL_BloodLoss";
            this.LBL_BloodLoss.Size = new System.Drawing.Size(74, 13);
            this.LBL_BloodLoss.TabIndex = 1;
            this.LBL_BloodLoss.Text = "Blood Loss : 0";
            // 
            // LBL_d6Roll
            // 
            this.LBL_d6Roll.AutoSize = true;
            this.LBL_d6Roll.Location = new System.Drawing.Point(182, 83);
            this.LBL_d6Roll.Name = "LBL_d6Roll";
            this.LBL_d6Roll.Size = new System.Drawing.Size(43, 13);
            this.LBL_d6Roll.TabIndex = 7;
            this.LBL_d6Roll.Text = "d6 Roll:";
            // 
            // CHB_Gender
            // 
            this.CHB_Gender.AutoSize = true;
            this.CHB_Gender.Checked = true;
            this.CHB_Gender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHB_Gender.Location = new System.Drawing.Point(12, 111);
            this.CHB_Gender.Name = "CHB_Gender";
            this.CHB_Gender.Size = new System.Drawing.Size(115, 17);
            this.CHB_Gender.TabIndex = 4;
            this.CHB_Gender.Text = "Opponent is Male?";
            this.CHB_Gender.UseVisualStyleBackColor = true;
            this.CHB_Gender.CheckedChanged += new System.EventHandler(this.CHB_Gender_CheckedChanged);
            // 
            // LBL_AttackLevel
            // 
            this.LBL_AttackLevel.AutoSize = true;
            this.LBL_AttackLevel.Location = new System.Drawing.Point(9, 83);
            this.LBL_AttackLevel.Name = "LBL_AttackLevel";
            this.LBL_AttackLevel.Size = new System.Drawing.Size(70, 13);
            this.LBL_AttackLevel.TabIndex = 8;
            this.LBL_AttackLevel.Text = "Attack Level:";
            // 
            // NUD_AttackLevel
            // 
            this.NUD_AttackLevel.Location = new System.Drawing.Point(85, 81);
            this.NUD_AttackLevel.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NUD_AttackLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_AttackLevel.Name = "NUD_AttackLevel";
            this.NUD_AttackLevel.Size = new System.Drawing.Size(41, 20);
            this.NUD_AttackLevel.TabIndex = 2;
            this.NUD_AttackLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_AttackLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_AttackLevel.ValueChanged += new System.EventHandler(this.NUD_d6Result_ValueChanged);
            // 
            // MENU_All
            // 
            this.MENU_All.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.MENU_All.Location = new System.Drawing.Point(0, 0);
            this.MENU_All.Name = "MENU_All";
            this.MENU_All.Size = new System.Drawing.Size(284, 24);
            this.MENU_All.TabIndex = 6;
            this.MENU_All.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_HowTo,
            this.MSI_Bugs});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MSI_HowTo
            // 
            this.MSI_HowTo.Name = "MSI_HowTo";
            this.MSI_HowTo.Size = new System.Drawing.Size(175, 22);
            this.MSI_HowTo.Text = "How Do I Use This?";
            this.MSI_HowTo.Click += new System.EventHandler(this.MSI_HowTo_Click);
            // 
            // MSI_Bugs
            // 
            this.MSI_Bugs.Name = "MSI_Bugs";
            this.MSI_Bugs.Size = new System.Drawing.Size(175, 22);
            this.MSI_Bugs.Text = "I Found a Bug!";
            this.MSI_Bugs.Click += new System.EventHandler(this.MSI_Bugs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.LBL_AttackLevel);
            this.Controls.Add(this.NUD_AttackLevel);
            this.Controls.Add(this.CHB_Gender);
            this.Controls.Add(this.LBL_d6Roll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUD_d6Result);
            this.Controls.Add(this.BTN_Rolld6);
            this.Controls.Add(this.CMB_AttackAreas);
            this.Controls.Add(this.CMB_DamageTable);
            this.Controls.Add(this.MENU_All);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENU_All;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 361);
            this.MinimumSize = new System.Drawing.Size(300, 361);
            this.Name = "Form1";
            this.Text = "Blade Damage Tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6Result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_AttackLevel)).EndInit();
            this.MENU_All.ResumeLayout(false);
            this.MENU_All.PerformLayout();
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
        private System.Windows.Forms.Label LBL_Pain;
        private System.Windows.Forms.Label LBL_Shock;
        private System.Windows.Forms.Label LBL_BloodLoss;
        private System.Windows.Forms.Label LBL_Knockout;
        private System.Windows.Forms.Label LBL_Knockdown;
        private System.Windows.Forms.CheckBox CHB_Gender;
        private System.Windows.Forms.Label LBL_AttackLevel;
        private System.Windows.Forms.NumericUpDown NUD_AttackLevel;
        private System.Windows.Forms.RichTextBox TXB_Description;
        private System.Windows.Forms.Label LBL_Location;
        private System.Windows.Forms.MenuStrip MENU_All;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MSI_HowTo;
        private System.Windows.Forms.ToolStripMenuItem MSI_Bugs;
    }
}

