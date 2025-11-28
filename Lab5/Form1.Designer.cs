namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblDice1 = new Label();
            btnRollDice = new Button();
            lblRollName = new Label();
            btnSwapNumbers = new Button();
            label7 = new Label();
            lblDice2 = new Label();
            grpOneRoll = new GroupBox();
            btnClear = new Button();
            radOneRoll = new RadioButton();
            groupBox1 = new GroupBox();
            radRollStats = new RadioButton();
            grpMarkStats = new GroupBox();
            btnReset = new Button();
            btnGenerate = new Button();
            lblFail = new Label();
            lblPass = new Label();
            lblAverage = new Label();
            lstMarks = new ListBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            chkSeed = new CheckBox();
            label3 = new Label();
            nudNumber = new NumericUpDown();
            grpOneRoll.SuspendLayout();
            groupBox1.SuspendLayout();
            grpMarkStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 0;
            label1.Text = "Dice 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 29);
            label2.TabIndex = 1;
            label2.Text = "Dice 2:";
            // 
            // lblDice1
            // 
            lblDice1.BackColor = Color.MistyRose;
            lblDice1.BorderStyle = BorderStyle.Fixed3D;
            lblDice1.Location = new Point(119, 28);
            lblDice1.Margin = new Padding(4, 0, 4, 0);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(59, 34);
            lblDice1.TabIndex = 2;
            lblDice1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            btnRollDice.Location = new Point(7, 174);
            btnRollDice.Margin = new Padding(4, 3, 4, 3);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(118, 72);
            btnRollDice.TabIndex = 5;
            btnRollDice.Text = "&Roll \r\nDice";
            btnRollDice.UseVisualStyleBackColor = true;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // lblRollName
            // 
            lblRollName.BackColor = Color.LightSalmon;
            lblRollName.BorderStyle = BorderStyle.Fixed3D;
            lblRollName.Location = new Point(156, 110);
            lblRollName.Margin = new Padding(4, 0, 4, 0);
            lblRollName.Name = "lblRollName";
            lblRollName.Size = new Size(217, 34);
            lblRollName.TabIndex = 7;
            lblRollName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSwapNumbers
            // 
            btnSwapNumbers.Location = new Point(136, 174);
            btnSwapNumbers.Margin = new Padding(4, 3, 4, 3);
            btnSwapNumbers.Name = "btnSwapNumbers";
            btnSwapNumbers.Size = new Size(118, 72);
            btnSwapNumbers.TabIndex = 8;
            btnSwapNumbers.Text = "&Swap Numbers";
            btnSwapNumbers.UseVisualStyleBackColor = true;
            btnSwapNumbers.Click += btnSwapNumbers_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 119);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 29);
            label7.TabIndex = 4;
            label7.Text = "Roll Name:";
            // 
            // lblDice2
            // 
            lblDice2.BackColor = Color.MistyRose;
            lblDice2.BorderStyle = BorderStyle.Fixed3D;
            lblDice2.Location = new Point(119, 69);
            lblDice2.Margin = new Padding(4, 0, 4, 0);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(59, 34);
            lblDice2.TabIndex = 6;
            lblDice2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpOneRoll
            // 
            grpOneRoll.Controls.Add(btnClear);
            grpOneRoll.Controls.Add(label1);
            grpOneRoll.Controls.Add(label2);
            grpOneRoll.Controls.Add(btnSwapNumbers);
            grpOneRoll.Controls.Add(lblDice1);
            grpOneRoll.Controls.Add(lblDice2);
            grpOneRoll.Controls.Add(lblRollName);
            grpOneRoll.Controls.Add(btnRollDice);
            grpOneRoll.Controls.Add(label7);
            grpOneRoll.Location = new Point(11, 88);
            grpOneRoll.Name = "grpOneRoll";
            grpOneRoll.Size = new Size(390, 255);
            grpOneRoll.TabIndex = 9;
            grpOneRoll.TabStop = false;
            grpOneRoll.Text = "One Roll";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(265, 174);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 72);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear \r\nOne Roll";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // radOneRoll
            // 
            radOneRoll.AutoSize = true;
            radOneRoll.Location = new Point(30, 29);
            radOneRoll.Name = "radOneRoll";
            radOneRoll.Size = new Size(145, 33);
            radOneRoll.TabIndex = 10;
            radOneRoll.TabStop = true;
            radOneRoll.Text = "One Roll";
            radOneRoll.UseVisualStyleBackColor = true;
            radOneRoll.CheckedChanged += radOneRoll_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radRollStats);
            groupBox1.Controls.Add(radOneRoll);
            groupBox1.Location = new Point(11, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 68);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select";
            // 
            // radRollStats
            // 
            radRollStats.AutoSize = true;
            radRollStats.Location = new Point(588, 29);
            radRollStats.Name = "radRollStats";
            radRollStats.Size = new Size(172, 33);
            radRollStats.TabIndex = 11;
            radRollStats.TabStop = true;
            radRollStats.Text = "Mark Stats";
            radRollStats.UseVisualStyleBackColor = true;
            // 
            // grpMarkStats
            // 
            grpMarkStats.Controls.Add(btnReset);
            grpMarkStats.Controls.Add(btnGenerate);
            grpMarkStats.Controls.Add(lblFail);
            grpMarkStats.Controls.Add(lblPass);
            grpMarkStats.Controls.Add(lblAverage);
            grpMarkStats.Controls.Add(lstMarks);
            grpMarkStats.Controls.Add(label6);
            grpMarkStats.Controls.Add(label5);
            grpMarkStats.Controls.Add(label4);
            grpMarkStats.Controls.Add(chkSeed);
            grpMarkStats.Controls.Add(label3);
            grpMarkStats.Controls.Add(nudNumber);
            grpMarkStats.Location = new Point(409, 88);
            grpMarkStats.Name = "grpMarkStats";
            grpMarkStats.Size = new Size(486, 255);
            grpMarkStats.TabIndex = 12;
            grpMarkStats.TabStop = false;
            grpMarkStats.Text = "Mark Stats";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(214, 174);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 72);
            btnReset.TabIndex = 14;
            btnReset.Text = "&Reset \r\nStats";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(47, 174);
            btnGenerate.Margin = new Padding(4, 3, 4, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(118, 72);
            btnGenerate.TabIndex = 13;
            btnGenerate.Text = "&Generate Numbers";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblFail
            // 
            lblFail.BackColor = Color.MistyRose;
            lblFail.BorderStyle = BorderStyle.Fixed3D;
            lblFail.Location = new Point(121, 95);
            lblFail.Margin = new Padding(4, 0, 4, 0);
            lblFail.Name = "lblFail";
            lblFail.Size = new Size(105, 34);
            lblFail.TabIndex = 12;
            lblFail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            lblPass.BackColor = Color.MistyRose;
            lblPass.BorderStyle = BorderStyle.Fixed3D;
            lblPass.Location = new Point(121, 58);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(105, 34);
            lblPass.TabIndex = 11;
            lblPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAverage
            // 
            lblAverage.BackColor = Color.MistyRose;
            lblAverage.BorderStyle = BorderStyle.Fixed3D;
            lblAverage.Location = new Point(121, 133);
            lblAverage.Margin = new Padding(4, 0, 4, 0);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(105, 34);
            lblAverage.TabIndex = 10;
            lblAverage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstMarks
            // 
            lstMarks.FormattingEnabled = true;
            lstMarks.Location = new Point(364, 19);
            lstMarks.Name = "lstMarks";
            lstMarks.Size = new Size(105, 207);
            lstMarks.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 100);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 29);
            label6.TabIndex = 5;
            label6.Text = "Fail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 63);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 29);
            label5.TabIndex = 4;
            label5.Text = "Pass:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 137);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 29);
            label4.TabIndex = 3;
            label4.Text = "Average:";
            // 
            // chkSeed
            // 
            chkSeed.AutoSize = true;
            chkSeed.Location = new Point(214, 23);
            chkSeed.Name = "chkSeed";
            chkSeed.Size = new Size(176, 33);
            chkSeed.TabIndex = 2;
            chkSeed.Text = "Seed Value";
            chkSeed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 29);
            label3.TabIndex = 1;
            label3.Text = "Marks:";
            // 
            // nudNumber
            // 
            nudNumber.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudNumber.Location = new Point(102, 23);
            nudNumber.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudNumber.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudNumber.Name = "nudNumber";
            nudNumber.Size = new Size(87, 35);
            nudNumber.TabIndex = 0;
            nudNumber.TextAlign = HorizontalAlignment.Center;
            nudNumber.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 353);
            Controls.Add(grpMarkStats);
            Controls.Add(groupBox1);
            Controls.Add(grpOneRoll);
            Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 5 by";
            Load += Form1_Load;
            grpOneRoll.ResumeLayout(false);
            grpOneRoll.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpMarkStats.ResumeLayout(false);
            grpMarkStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDice1;
        private Button btnRollDice;
        private Label lblRollName;
        private Button btnSwapNumbers;
        private Label label7;
        private Label lblDice2;
        private GroupBox grpOneRoll;
        private Button btnClear;
        private RadioButton radOneRoll;
        private GroupBox groupBox1;
        private RadioButton radRollStats;
        private GroupBox grpMarkStats;
        private Label label3;
        private NumericUpDown nudNumber;
        private CheckBox chkSeed;
        private ListBox lstMarks;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblAverage;
        private Label lblFail;
        private Label lblPass;
        private Button btnReset;
        private Button btnGenerate;
    }
}
