namespace Die_Roller
{
    partial class DieRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieRoller));
            this.GB_Roll_d6 = new System.Windows.Forms.GroupBox();
            this.GB_Roll_d12 = new System.Windows.Forms.GroupBox();
            this.GB_Roll_dX = new System.Windows.Forms.GroupBox();
            this.LBL_d6Roll = new System.Windows.Forms.Label();
            this.NUD_d6Count = new System.Windows.Forms.NumericUpDown();
            this.BTN_d6Roll = new System.Windows.Forms.Button();
            this.NUD_d12Count = new System.Windows.Forms.NumericUpDown();
            this.LBL_d12Roll = new System.Windows.Forms.Label();
            this.NUD_d12Target = new System.Windows.Forms.NumericUpDown();
            this.LBL_d12Target = new System.Windows.Forms.Label();
            this.LBL_d12Odds = new System.Windows.Forms.Label();
            this.LBL_d12EstSuccess = new System.Windows.Forms.Label();
            this.BTN_d12Roll = new System.Windows.Forms.Button();
            this.NUD_dXCount = new System.Windows.Forms.NumericUpDown();
            this.LBL_dXCount = new System.Windows.Forms.Label();
            this.NUD_dXSides = new System.Windows.Forms.NumericUpDown();
            this.LBL_dXSides = new System.Windows.Forms.Label();
            this.BTN_dXRoll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LSB_Results = new System.Windows.Forms.ListBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.LBL_d12Successes = new System.Windows.Forms.Label();
            this.GB_Roll_d6.SuspendLayout();
            this.GB_Roll_d12.SuspendLayout();
            this.GB_Roll_dX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d12Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d12Target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_dXCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_dXSides)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Roll_d6
            // 
            this.GB_Roll_d6.Controls.Add(this.BTN_d6Roll);
            this.GB_Roll_d6.Controls.Add(this.NUD_d6Count);
            this.GB_Roll_d6.Controls.Add(this.LBL_d6Roll);
            this.GB_Roll_d6.Location = new System.Drawing.Point(12, 12);
            this.GB_Roll_d6.Name = "GB_Roll_d6";
            this.GB_Roll_d6.Size = new System.Drawing.Size(200, 84);
            this.GB_Roll_d6.TabIndex = 0;
            this.GB_Roll_d6.TabStop = false;
            this.GB_Roll_d6.Text = "Roll d6\'s";
            // 
            // GB_Roll_d12
            // 
            this.GB_Roll_d12.Controls.Add(this.BTN_d12Roll);
            this.GB_Roll_d12.Controls.Add(this.LBL_d12EstSuccess);
            this.GB_Roll_d12.Controls.Add(this.LBL_d12Odds);
            this.GB_Roll_d12.Controls.Add(this.NUD_d12Target);
            this.GB_Roll_d12.Controls.Add(this.LBL_d12Target);
            this.GB_Roll_d12.Controls.Add(this.NUD_d12Count);
            this.GB_Roll_d12.Controls.Add(this.LBL_d12Roll);
            this.GB_Roll_d12.Location = new System.Drawing.Point(12, 102);
            this.GB_Roll_d12.Name = "GB_Roll_d12";
            this.GB_Roll_d12.Size = new System.Drawing.Size(200, 159);
            this.GB_Roll_d12.TabIndex = 1;
            this.GB_Roll_d12.TabStop = false;
            this.GB_Roll_d12.Text = "Roll d12\'s";
            // 
            // GB_Roll_dX
            // 
            this.GB_Roll_dX.Controls.Add(this.BTN_dXRoll);
            this.GB_Roll_dX.Controls.Add(this.NUD_dXSides);
            this.GB_Roll_dX.Controls.Add(this.LBL_dXSides);
            this.GB_Roll_dX.Controls.Add(this.NUD_dXCount);
            this.GB_Roll_dX.Controls.Add(this.LBL_dXCount);
            this.GB_Roll_dX.Location = new System.Drawing.Point(12, 267);
            this.GB_Roll_dX.Name = "GB_Roll_dX";
            this.GB_Roll_dX.Size = new System.Drawing.Size(200, 113);
            this.GB_Roll_dX.TabIndex = 2;
            this.GB_Roll_dX.TabStop = false;
            this.GB_Roll_dX.Text = "Custom Roll";
            // 
            // LBL_d6Roll
            // 
            this.LBL_d6Roll.AutoSize = true;
            this.LBL_d6Roll.Location = new System.Drawing.Point(7, 22);
            this.LBL_d6Roll.Name = "LBL_d6Roll";
            this.LBL_d6Roll.Size = new System.Drawing.Size(106, 17);
            this.LBL_d6Roll.TabIndex = 0;
            this.LBL_d6Roll.Text = "Number of Dice";
            // 
            // NUD_d6Count
            // 
            this.NUD_d6Count.Location = new System.Drawing.Point(119, 20);
            this.NUD_d6Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d6Count.Name = "NUD_d6Count";
            this.NUD_d6Count.Size = new System.Drawing.Size(75, 22);
            this.NUD_d6Count.TabIndex = 0;
            this.NUD_d6Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_d6Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_d6Roll
            // 
            this.BTN_d6Roll.Location = new System.Drawing.Point(6, 48);
            this.BTN_d6Roll.Name = "BTN_d6Roll";
            this.BTN_d6Roll.Size = new System.Drawing.Size(187, 23);
            this.BTN_d6Roll.TabIndex = 1;
            this.BTN_d6Roll.Text = "Roll d6\'s";
            this.BTN_d6Roll.UseVisualStyleBackColor = true;
            this.BTN_d6Roll.Click += new System.EventHandler(this.BTN_d6Roll_Click);
            // 
            // NUD_d12Count
            // 
            this.NUD_d12Count.Location = new System.Drawing.Point(118, 20);
            this.NUD_d12Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d12Count.Name = "NUD_d12Count";
            this.NUD_d12Count.Size = new System.Drawing.Size(75, 22);
            this.NUD_d12Count.TabIndex = 0;
            this.NUD_d12Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_d12Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d12Count.ValueChanged += new System.EventHandler(this.NUD_d12Count_ValueChanged);
            // 
            // LBL_d12Roll
            // 
            this.LBL_d12Roll.AutoSize = true;
            this.LBL_d12Roll.Location = new System.Drawing.Point(6, 22);
            this.LBL_d12Roll.Name = "LBL_d12Roll";
            this.LBL_d12Roll.Size = new System.Drawing.Size(106, 17);
            this.LBL_d12Roll.TabIndex = 3;
            this.LBL_d12Roll.Text = "Number of Dice";
            // 
            // NUD_d12Target
            // 
            this.NUD_d12Target.Location = new System.Drawing.Point(118, 48);
            this.NUD_d12Target.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUD_d12Target.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d12Target.Name = "NUD_d12Target";
            this.NUD_d12Target.Size = new System.Drawing.Size(75, 22);
            this.NUD_d12Target.TabIndex = 1;
            this.NUD_d12Target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_d12Target.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NUD_d12Target.ValueChanged += new System.EventHandler(this.NUD_d12Target_ValueChanged);
            // 
            // LBL_d12Target
            // 
            this.LBL_d12Target.AutoSize = true;
            this.LBL_d12Target.Location = new System.Drawing.Point(6, 50);
            this.LBL_d12Target.Name = "LBL_d12Target";
            this.LBL_d12Target.Size = new System.Drawing.Size(104, 17);
            this.LBL_d12Target.TabIndex = 5;
            this.LBL_d12Target.Text = "Target Number";
            // 
            // LBL_d12Odds
            // 
            this.LBL_d12Odds.AutoSize = true;
            this.LBL_d12Odds.Location = new System.Drawing.Point(6, 77);
            this.LBL_d12Odds.Name = "LBL_d12Odds";
            this.LBL_d12Odds.Size = new System.Drawing.Size(167, 17);
            this.LBL_d12Odds.TabIndex = 7;
            this.LBL_d12Odds.Text = "Odds of Success : 50.0%";
            // 
            // LBL_d12EstSuccess
            // 
            this.LBL_d12EstSuccess.AutoSize = true;
            this.LBL_d12EstSuccess.Location = new System.Drawing.Point(6, 103);
            this.LBL_d12EstSuccess.Name = "LBL_d12EstSuccess";
            this.LBL_d12EstSuccess.Size = new System.Drawing.Size(174, 17);
            this.LBL_d12EstSuccess.TabIndex = 8;
            this.LBL_d12EstSuccess.Text = "Estimated Successes : 0.5";
            // 
            // BTN_d12Roll
            // 
            this.BTN_d12Roll.Location = new System.Drawing.Point(6, 127);
            this.BTN_d12Roll.Name = "BTN_d12Roll";
            this.BTN_d12Roll.Size = new System.Drawing.Size(187, 23);
            this.BTN_d12Roll.TabIndex = 2;
            this.BTN_d12Roll.Text = "Roll d12\'s";
            this.BTN_d12Roll.UseVisualStyleBackColor = true;
            this.BTN_d12Roll.Click += new System.EventHandler(this.BTN_d12Roll_Click);
            // 
            // NUD_dXCount
            // 
            this.NUD_dXCount.Location = new System.Drawing.Point(119, 21);
            this.NUD_dXCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_dXCount.Name = "NUD_dXCount";
            this.NUD_dXCount.Size = new System.Drawing.Size(75, 22);
            this.NUD_dXCount.TabIndex = 0;
            this.NUD_dXCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_dXCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBL_dXCount
            // 
            this.LBL_dXCount.AutoSize = true;
            this.LBL_dXCount.Location = new System.Drawing.Point(7, 23);
            this.LBL_dXCount.Name = "LBL_dXCount";
            this.LBL_dXCount.Size = new System.Drawing.Size(106, 17);
            this.LBL_dXCount.TabIndex = 3;
            this.LBL_dXCount.Text = "Number of Dice";
            // 
            // NUD_dXSides
            // 
            this.NUD_dXSides.Location = new System.Drawing.Point(119, 49);
            this.NUD_dXSides.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_dXSides.Name = "NUD_dXSides";
            this.NUD_dXSides.Size = new System.Drawing.Size(75, 22);
            this.NUD_dXSides.TabIndex = 1;
            this.NUD_dXSides.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_dXSides.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LBL_dXSides
            // 
            this.LBL_dXSides.AutoSize = true;
            this.LBL_dXSides.Location = new System.Drawing.Point(7, 51);
            this.LBL_dXSides.Name = "LBL_dXSides";
            this.LBL_dXSides.Size = new System.Drawing.Size(113, 17);
            this.LBL_dXSides.TabIndex = 5;
            this.LBL_dXSides.Text = "Number of Sides";
            // 
            // BTN_dXRoll
            // 
            this.BTN_dXRoll.Location = new System.Drawing.Point(10, 81);
            this.BTN_dXRoll.Name = "BTN_dXRoll";
            this.BTN_dXRoll.Size = new System.Drawing.Size(184, 23);
            this.BTN_dXRoll.TabIndex = 2;
            this.BTN_dXRoll.Text = "Roll Custom Dice";
            this.BTN_dXRoll.UseVisualStyleBackColor = true;
            this.BTN_dXRoll.Click += new System.EventHandler(this.BTN_dXRoll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_d12Successes);
            this.groupBox1.Controls.Add(this.BTN_Clear);
            this.groupBox1.Controls.Add(this.LSB_Results);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 368);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // LSB_Results
            // 
            this.LSB_Results.FormattingEnabled = true;
            this.LSB_Results.ItemHeight = 16;
            this.LSB_Results.Location = new System.Drawing.Point(7, 22);
            this.LSB_Results.Name = "LSB_Results";
            this.LSB_Results.Size = new System.Drawing.Size(187, 292);
            this.LSB_Results.TabIndex = 0;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(7, 336);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(187, 23);
            this.BTN_Clear.TabIndex = 1;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // LBL_d12Successes
            // 
            this.LBL_d12Successes.AutoSize = true;
            this.LBL_d12Successes.Location = new System.Drawing.Point(54, 316);
            this.LBL_d12Successes.Name = "LBL_d12Successes";
            this.LBL_d12Successes.Size = new System.Drawing.Size(92, 17);
            this.LBL_d12Successes.TabIndex = 2;
            this.LBL_d12Successes.Text = "Successes: 0";
            this.LBL_d12Successes.Visible = false;
            // 
            // DieRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_Roll_dX);
            this.Controls.Add(this.GB_Roll_d12);
            this.Controls.Add(this.GB_Roll_d6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DieRoller";
            this.Text = "Die Roller";
            this.GB_Roll_d6.ResumeLayout(false);
            this.GB_Roll_d6.PerformLayout();
            this.GB_Roll_d12.ResumeLayout(false);
            this.GB_Roll_d12.PerformLayout();
            this.GB_Roll_dX.ResumeLayout(false);
            this.GB_Roll_dX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d12Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d12Target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_dXCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_dXSides)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Roll_d6;
        private System.Windows.Forms.Button BTN_d6Roll;
        private System.Windows.Forms.NumericUpDown NUD_d6Count;
        private System.Windows.Forms.Label LBL_d6Roll;
        private System.Windows.Forms.GroupBox GB_Roll_d12;
        private System.Windows.Forms.Button BTN_d12Roll;
        private System.Windows.Forms.Label LBL_d12EstSuccess;
        private System.Windows.Forms.Label LBL_d12Odds;
        private System.Windows.Forms.NumericUpDown NUD_d12Target;
        private System.Windows.Forms.Label LBL_d12Target;
        private System.Windows.Forms.NumericUpDown NUD_d12Count;
        private System.Windows.Forms.Label LBL_d12Roll;
        private System.Windows.Forms.GroupBox GB_Roll_dX;
        private System.Windows.Forms.Button BTN_dXRoll;
        private System.Windows.Forms.NumericUpDown NUD_dXSides;
        private System.Windows.Forms.Label LBL_dXSides;
        private System.Windows.Forms.NumericUpDown NUD_dXCount;
        private System.Windows.Forms.Label LBL_dXCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_d12Successes;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.ListBox LSB_Results;
    }
}

