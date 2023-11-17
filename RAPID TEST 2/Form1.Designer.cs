namespace RAPID_TEST_2
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.SequentialTxtBox = new System.Windows.Forms.TextBox();
            this.BinaryTxtBox = new System.Windows.Forms.TextBox();
            this.btnMidExtreme = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnRange = new System.Windows.Forms.Button();
            this.EditTxtBox = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.midExTxt = new System.Windows.Forms.TextBox();
            this.modeTxt = new System.Windows.Forms.TextBox();
            this.AvgTxt = new System.Windows.Forms.TextBox();
            this.RangeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(39, 85);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(178, 238);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSort.Location = new System.Drawing.Point(37, 49);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(56, 24);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort\r\n";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sequential Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(457, 85);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(120, 26);
            this.btnBinary.TabIndex = 3;
            this.btnBinary.Text = "Binary Search";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.button3_Click);
            // 
            // SequentialTxtBox
            // 
            this.SequentialTxtBox.Location = new System.Drawing.Point(359, 55);
            this.SequentialTxtBox.Name = "SequentialTxtBox";
            this.SequentialTxtBox.Size = new System.Drawing.Size(92, 20);
            this.SequentialTxtBox.TabIndex = 4;
            // 
            // BinaryTxtBox
            // 
            this.BinaryTxtBox.Location = new System.Drawing.Point(359, 85);
            this.BinaryTxtBox.Name = "BinaryTxtBox";
            this.BinaryTxtBox.Size = new System.Drawing.Size(92, 20);
            this.BinaryTxtBox.TabIndex = 5;
            // 
            // btnMidExtreme
            // 
            this.btnMidExtreme.Location = new System.Drawing.Point(459, 145);
            this.btnMidExtreme.Name = "btnMidExtreme";
            this.btnMidExtreme.Size = new System.Drawing.Size(120, 27);
            this.btnMidExtreme.TabIndex = 6;
            this.btnMidExtreme.Text = "Calculate mid-extreme";
            this.btnMidExtreme.UseVisualStyleBackColor = true;
            this.btnMidExtreme.Click += new System.EventHandler(this.btnMidExtreme_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(460, 181);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(120, 25);
            this.btnMode.TabIndex = 7;
            this.btnMode.Text = "Calculate Mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(460, 218);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(120, 28);
            this.btnAverage.TabIndex = 8;
            this.btnAverage.Text = "Calculate average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(461, 263);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(119, 25);
            this.btnRange.TabIndex = 9;
            this.btnRange.Text = "Calculate Range";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // EditTxtBox
            // 
            this.EditTxtBox.Location = new System.Drawing.Point(41, 343);
            this.EditTxtBox.Name = "EditTxtBox";
            this.EditTxtBox.Size = new System.Drawing.Size(86, 20);
            this.EditTxtBox.TabIndex = 10;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(151, 343);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(65, 20);
            this.BtnEdit.TabIndex = 11;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // midExTxt
            // 
            this.midExTxt.Location = new System.Drawing.Point(359, 149);
            this.midExTxt.Name = "midExTxt";
            this.midExTxt.Size = new System.Drawing.Size(95, 20);
            this.midExTxt.TabIndex = 12;
            this.midExTxt.TextChanged += new System.EventHandler(this.midExTxt_TextChanged);
            // 
            // modeTxt
            // 
            this.modeTxt.Location = new System.Drawing.Point(359, 181);
            this.modeTxt.Name = "modeTxt";
            this.modeTxt.Size = new System.Drawing.Size(95, 20);
            this.modeTxt.TabIndex = 13;
            // 
            // AvgTxt
            // 
            this.AvgTxt.Location = new System.Drawing.Point(359, 218);
            this.AvgTxt.Name = "AvgTxt";
            this.AvgTxt.Size = new System.Drawing.Size(95, 20);
            this.AvgTxt.TabIndex = 14;
            // 
            // RangeTxt
            // 
            this.RangeTxt.Location = new System.Drawing.Point(359, 263);
            this.RangeTxt.Name = "RangeTxt";
            this.RangeTxt.Size = new System.Drawing.Size(95, 20);
            this.RangeTxt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.RangeTxt);
            this.Controls.Add(this.AvgTxt);
            this.Controls.Add(this.modeTxt);
            this.Controls.Add(this.midExTxt);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.EditTxtBox);
            this.Controls.Add(this.btnRange);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.btnMidExtreme);
            this.Controls.Add(this.BinaryTxtBox);
            this.Controls.Add(this.SequentialTxtBox);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.TextBox SequentialTxtBox;
        private System.Windows.Forms.TextBox BinaryTxtBox;
        private System.Windows.Forms.Button btnMidExtreme;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.TextBox EditTxtBox;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox midExTxt;
        private System.Windows.Forms.TextBox modeTxt;
        private System.Windows.Forms.TextBox AvgTxt;
        private System.Windows.Forms.TextBox RangeTxt;
    }
}

