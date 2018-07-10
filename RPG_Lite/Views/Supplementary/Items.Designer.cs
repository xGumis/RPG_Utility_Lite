namespace RPG_Lite.Views.Supplementary
{
    partial class Items
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.numericUpDownQ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxQ = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(34, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(162, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.DropDown += new System.EventHandler(this.comboBox_DropDown);
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(28, 126);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(192, 100);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // numericUpDownQ
            // 
            this.numericUpDownQ.Location = new System.Drawing.Point(120, 75);
            this.numericUpDownQ.Name = "numericUpDownQ";
            this.numericUpDownQ.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownQ.TabIndex = 3;
            this.numericUpDownQ.ValueChanged += new System.EventHandler(this.numericUpDownQ_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jakość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dod. Inf.";
            // 
            // comboBoxQ
            // 
            this.comboBoxQ.FormattingEnabled = true;
            this.comboBoxQ.Items.AddRange(new object[] {
            "Kiepska",
            "Zwykła",
            "Dobra",
            "Najlepsza"});
            this.comboBoxQ.Location = new System.Drawing.Point(89, 41);
            this.comboBoxQ.Name = "comboBoxQ";
            this.comboBoxQ.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQ.TabIndex = 7;
            this.comboBoxQ.SelectedIndexChanged += new System.EventHandler(this.comboBoxQ_SelectedIndexChanged);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownQ);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBox);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(249, 242);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.NumericUpDown numericUpDownQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxQ;
    }
}
