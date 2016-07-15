namespace Die_Roller
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
            this.NUD_d6 = new System.Windows.Forms.NumericUpDown();
            this.NUD_d12 = new System.Windows.Forms.NumericUpDown();
            this.BTN_Roll_d6 = new System.Windows.Forms.Button();
            this.BTN_Roll_d12 = new System.Windows.Forms.Button();
            this.LBL_Number_d6 = new System.Windows.Forms.Label();
            this.LBL_Number_d12 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_TargetNumber = new System.Windows.Forms.NumericUpDown();
            this.CHB_Target = new System.Windows.Forms.CheckBox();
            this.GB_Results = new System.Windows.Forms.GroupBox();
            this.LBL_Successes = new System.Windows.Forms.Label();
            this.LSB_Results = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d12)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TargetNumber)).BeginInit();
            this.GB_Results.SuspendLayout();
            this.SuspendLayout();
            // 
            // NUD_d6
            // 
            this.NUD_d6.Location = new System.Drawing.Point(96, 14);
            this.NUD_d6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d6.Name = "NUD_d6";
            this.NUD_d6.Size = new System.Drawing.Size(52, 20);
            this.NUD_d6.TabIndex = 0;
            this.NUD_d6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_d6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUD_d12
            // 
            this.NUD_d12.Location = new System.Drawing.Point(96, 43);
            this.NUD_d12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_d12.Name = "NUD_d12";
            this.NUD_d12.Size = new System.Drawing.Size(52, 20);
            this.NUD_d12.TabIndex = 1;
            this.NUD_d12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_d12.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_Roll_d6
            // 
            this.BTN_Roll_d6.Location = new System.Drawing.Point(154, 11);
            this.BTN_Roll_d6.Name = "BTN_Roll_d6";
            this.BTN_Roll_d6.Size = new System.Drawing.Size(75, 23);
            this.BTN_Roll_d6.TabIndex = 2;
            this.BTN_Roll_d6.Text = "Roll d6";
            this.BTN_Roll_d6.UseVisualStyleBackColor = true;
            this.BTN_Roll_d6.Click += new System.EventHandler(this.BTN_Roll_d6_Click);
            // 
            // BTN_Roll_d12
            // 
            this.BTN_Roll_d12.Location = new System.Drawing.Point(154, 40);
            this.BTN_Roll_d12.Name = "BTN_Roll_d12";
            this.BTN_Roll_d12.Size = new System.Drawing.Size(75, 23);
            this.BTN_Roll_d12.TabIndex = 3;
            this.BTN_Roll_d12.Text = "Roll d12";
            this.BTN_Roll_d12.UseVisualStyleBackColor = true;
            this.BTN_Roll_d12.Click += new System.EventHandler(this.BTN_Roll_d12_Click);
            // 
            // LBL_Number_d6
            // 
            this.LBL_Number_d6.AutoSize = true;
            this.LBL_Number_d6.Location = new System.Drawing.Point(6, 16);
            this.LBL_Number_d6.Name = "LBL_Number_d6";
            this.LBL_Number_d6.Size = new System.Drawing.Size(78, 13);
            this.LBL_Number_d6.TabIndex = 4;
            this.LBL_Number_d6.Text = "Number of d6\'s";
            // 
            // LBL_Number_d12
            // 
            this.LBL_Number_d12.AutoSize = true;
            this.LBL_Number_d12.Location = new System.Drawing.Point(6, 45);
            this.LBL_Number_d12.Name = "LBL_Number_d12";
            this.LBL_Number_d12.Size = new System.Drawing.Size(84, 13);
            this.LBL_Number_d12.TabIndex = 5;
            this.LBL_Number_d12.Text = "Number of d12\'s";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(7, 198);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(224, 23);
            this.BTN_Clear.TabIndex = 7;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NUD_TargetNumber);
            this.groupBox1.Controls.Add(this.CHB_Target);
            this.groupBox1.Controls.Add(this.LBL_Number_d6);
            this.groupBox1.Controls.Add(this.NUD_d6);
            this.groupBox1.Controls.Add(this.NUD_d12);
            this.groupBox1.Controls.Add(this.LBL_Number_d12);
            this.groupBox1.Controls.Add(this.BTN_Roll_d6);
            this.groupBox1.Controls.Add(this.BTN_Roll_d12);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Die Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Target Number";
            // 
            // NUD_TargetNumber
            // 
            this.NUD_TargetNumber.Enabled = false;
            this.NUD_TargetNumber.Location = new System.Drawing.Point(135, 88);
            this.NUD_TargetNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUD_TargetNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_TargetNumber.Name = "NUD_TargetNumber";
            this.NUD_TargetNumber.Size = new System.Drawing.Size(52, 20);
            this.NUD_TargetNumber.TabIndex = 7;
            this.NUD_TargetNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_TargetNumber.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NUD_TargetNumber.ValueChanged += new System.EventHandler(this.NUD_TargetNumber_ValueChanged);
            // 
            // CHB_Target
            // 
            this.CHB_Target.AutoSize = true;
            this.CHB_Target.Location = new System.Drawing.Point(25, 70);
            this.CHB_Target.Name = "CHB_Target";
            this.CHB_Target.Size = new System.Drawing.Size(189, 17);
            this.CHB_Target.TabIndex = 6;
            this.CHB_Target.Text = "Count Target Number Successes?";
            this.CHB_Target.UseVisualStyleBackColor = true;
            this.CHB_Target.CheckedChanged += new System.EventHandler(this.CHB_Target_CheckedChanged);
            // 
            // GB_Results
            // 
            this.GB_Results.Controls.Add(this.LBL_Successes);
            this.GB_Results.Controls.Add(this.LSB_Results);
            this.GB_Results.Controls.Add(this.BTN_Clear);
            this.GB_Results.Location = new System.Drawing.Point(12, 133);
            this.GB_Results.Name = "GB_Results";
            this.GB_Results.Size = new System.Drawing.Size(240, 247);
            this.GB_Results.TabIndex = 9;
            this.GB_Results.TabStop = false;
            this.GB_Results.Text = "Roll Results";
            // 
            // LBL_Successes
            // 
            this.LBL_Successes.AutoSize = true;
            this.LBL_Successes.Location = new System.Drawing.Point(50, 224);
            this.LBL_Successes.Name = "LBL_Successes";
            this.LBL_Successes.Size = new System.Drawing.Size(140, 13);
            this.LBL_Successes.TabIndex = 10;
            this.LBL_Successes.Text = "Number of Successes : N/A";
            // 
            // LSB_Results
            // 
            this.LSB_Results.FormattingEnabled = true;
            this.LSB_Results.Location = new System.Drawing.Point(9, 19);
            this.LSB_Results.Name = "LSB_Results";
            this.LSB_Results.Size = new System.Drawing.Size(220, 173);
            this.LSB_Results.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 392);
            this.Controls.Add(this.GB_Results);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(280, 431);
            this.MinimumSize = new System.Drawing.Size(280, 431);
            this.Name = "Form1";
            this.Text = "Die Roller";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_d12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TargetNumber)).EndInit();
            this.GB_Results.ResumeLayout(false);
            this.GB_Results.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUD_d6;
        private System.Windows.Forms.NumericUpDown NUD_d12;
        private System.Windows.Forms.Button BTN_Roll_d6;
        private System.Windows.Forms.Button BTN_Roll_d12;
        private System.Windows.Forms.Label LBL_Number_d6;
        private System.Windows.Forms.Label LBL_Number_d12;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GB_Results;
        private System.Windows.Forms.ListBox LSB_Results;
        private System.Windows.Forms.Label LBL_Successes;
        private System.Windows.Forms.CheckBox CHB_Target;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_TargetNumber;
    }
}

