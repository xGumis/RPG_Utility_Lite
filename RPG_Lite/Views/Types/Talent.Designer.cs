namespace RPG_Lite.Views.Types
{
    partial class Talent
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBonus = new System.Windows.Forms.Label();
            this.comboBoxStat = new System.Windows.Forms.ComboBox();
            this.numericUpDownBonus = new System.Windows.Forms.NumericUpDown();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(25, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Zdolność";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(52, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(119, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa:";
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Location = new System.Drawing.Point(3, 62);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(87, 13);
            this.labelBonus.TabIndex = 5;
            this.labelBonus.Text = "Bonus do cechy:";
            // 
            // comboBoxStat
            // 
            this.comboBoxStat.FormattingEnabled = true;
            this.comboBoxStat.Location = new System.Drawing.Point(3, 78);
            this.comboBoxStat.Name = "comboBoxStat";
            this.comboBoxStat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStat.TabIndex = 19;
            this.comboBoxStat.DropDown += new System.EventHandler(this.comboBoxStat_DropDown);
            this.comboBoxStat.SelectedIndexChanged += new System.EventHandler(this.comboBoxStat_SelectedIndexChanged);
            // 
            // numericUpDownBonus
            // 
            this.numericUpDownBonus.Location = new System.Drawing.Point(134, 78);
            this.numericUpDownBonus.Name = "numericUpDownBonus";
            this.numericUpDownBonus.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownBonus.TabIndex = 20;
            this.numericUpDownBonus.ValueChanged += new System.EventHandler(this.numericUpDownBonus_ValueChanged);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(7, 118);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDesc.Size = new System.Drawing.Size(164, 67);
            this.textBoxDesc.TabIndex = 22;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(4, 102);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(28, 13);
            this.labelDesc.TabIndex = 21;
            this.labelDesc.Text = "Opis";
            // 
            // Talent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.numericUpDownBonus);
            this.Controls.Add(this.comboBoxStat);
            this.Controls.Add(this.labelBonus);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(174, 188);
            this.Name = "Talent";
            this.Size = new System.Drawing.Size(174, 188);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.ComboBox comboBoxStat;
        private System.Windows.Forms.NumericUpDown numericUpDownBonus;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
    }
}
