namespace RPG_Lite.Views.Types
{
    partial class Spell
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
            this.comboBoxTalent = new System.Windows.Forms.ComboBox();
            this.labelTalent = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelCast = new System.Windows.Forms.Label();
            this.labelDur = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCast = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDur = new System.Windows.Forms.NumericUpDown();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.numericUpDownBonus = new System.Windows.Forms.NumericUpDown();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(45, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(93, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Zaklęcie";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(50, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa:";
            // 
            // comboBoxTalent
            // 
            this.comboBoxTalent.FormattingEnabled = true;
            this.comboBoxTalent.Location = new System.Drawing.Point(63, 57);
            this.comboBoxTalent.Name = "comboBoxTalent";
            this.comboBoxTalent.Size = new System.Drawing.Size(108, 21);
            this.comboBoxTalent.TabIndex = 20;
            this.comboBoxTalent.SelectedIndexChanged += new System.EventHandler(this.comboBoxTalent_SelectedIndexChanged);
            // 
            // labelTalent
            // 
            this.labelTalent.AutoSize = true;
            this.labelTalent.Location = new System.Drawing.Point(3, 60);
            this.labelTalent.Name = "labelTalent";
            this.labelTalent.Size = new System.Drawing.Size(54, 13);
            this.labelTalent.TabIndex = 19;
            this.labelTalent.Text = "Zdolność:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(3, 87);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(28, 13);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Typ:";
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxType.Location = new System.Drawing.Point(37, 84);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(134, 20);
            this.textBoxType.TabIndex = 22;
            this.textBoxType.TextChanged += new System.EventHandler(this.textBoxType_TextChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(3, 116);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(99, 13);
            this.labelLevel.TabIndex = 23;
            this.labelLevel.Text = "Wymagany poziom:";
            // 
            // labelCast
            // 
            this.labelCast.AutoSize = true;
            this.labelCast.Location = new System.Drawing.Point(3, 140);
            this.labelCast.Name = "labelCast";
            this.labelCast.Size = new System.Drawing.Size(76, 13);
            this.labelCast.TabIndex = 24;
            this.labelCast.Text = "Czas rzucania:";
            // 
            // labelDur
            // 
            this.labelDur.AutoSize = true;
            this.labelDur.Location = new System.Drawing.Point(3, 163);
            this.labelDur.Name = "labelDur";
            this.labelDur.Size = new System.Drawing.Size(70, 13);
            this.labelDur.TabIndex = 25;
            this.labelDur.Text = "Czas trwania:";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(3, 185);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(129, 13);
            this.labelItem.TabIndex = 26;
            this.labelItem.Text = "Przedmiot wspomagający:";
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(108, 114);
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownLevel.TabIndex = 27;
            this.numericUpDownLevel.ValueChanged += new System.EventHandler(this.numericUpDownLevel_ValueChanged);
            // 
            // numericUpDownCast
            // 
            this.numericUpDownCast.Location = new System.Drawing.Point(85, 138);
            this.numericUpDownCast.Name = "numericUpDownCast";
            this.numericUpDownCast.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownCast.TabIndex = 28;
            this.numericUpDownCast.ValueChanged += new System.EventHandler(this.numericUpDownCast_ValueChanged);
            // 
            // numericUpDownDur
            // 
            this.numericUpDownDur.Location = new System.Drawing.Point(79, 161);
            this.numericUpDownDur.Name = "numericUpDownDur";
            this.numericUpDownDur.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDur.TabIndex = 29;
            this.numericUpDownDur.ValueChanged += new System.EventHandler(this.numericUpDownDur_ValueChanged);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(3, 201);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(108, 21);
            this.comboBoxItem.TabIndex = 30;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // numericUpDownBonus
            // 
            this.numericUpDownBonus.Location = new System.Drawing.Point(117, 201);
            this.numericUpDownBonus.Name = "numericUpDownBonus";
            this.numericUpDownBonus.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownBonus.TabIndex = 31;
            this.numericUpDownBonus.ValueChanged += new System.EventHandler(this.numericUpDownBonus_ValueChanged);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(4, 243);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(167, 103);
            this.textBoxDesc.TabIndex = 33;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(1, 227);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(28, 13);
            this.labelDesc.TabIndex = 32;
            this.labelDesc.Text = "Opis";
            // 
            // Spell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.numericUpDownBonus);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.numericUpDownDur);
            this.Controls.Add(this.numericUpDownCast);
            this.Controls.Add(this.numericUpDownLevel);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelDur);
            this.Controls.Add(this.labelCast);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxTalent);
            this.Controls.Add(this.labelTalent);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(174, 349);
            this.Name = "Spell";
            this.Size = new System.Drawing.Size(174, 349);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxTalent;
        private System.Windows.Forms.Label labelTalent;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelCast;
        private System.Windows.Forms.Label labelDur;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.NumericUpDown numericUpDownCast;
        private System.Windows.Forms.NumericUpDown numericUpDownDur;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.NumericUpDown numericUpDownBonus;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
    }
}
