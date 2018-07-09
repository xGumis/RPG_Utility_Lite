namespace RPG_Lite.Views.Types
{
    partial class Weapon
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.textBoxTreats = new System.Windows.Forms.TextBox();
            this.labelTreats = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownReload = new System.Windows.Forms.NumericUpDown();
            this.labelReload = new System.Windows.Forms.Label();
            this.textBoxDamage = new System.Windows.Forms.TextBox();
            this.labelDamage = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReload)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(66, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(58, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Broń";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(46, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(143, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Items.AddRange(new object[] {
            "Znikoma",
            "Rzadka",
            "Sporadyczna",
            "Mała",
            "Przeciętna",
            "Duża",
            "Powszechna"});
            this.comboBoxAvailability.Location = new System.Drawing.Point(71, 62);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(118, 21);
            this.comboBoxAvailability.TabIndex = 6;
            this.comboBoxAvailability.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailability_SelectedIndexChanged);
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(3, 65);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(67, 13);
            this.labelAvailability.TabIndex = 5;
            this.labelAvailability.Text = "Dostępność:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(3, 93);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(63, 13);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Obciążenie:";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWeight.Location = new System.Drawing.Point(71, 91);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownWeight.TabIndex = 8;
            this.numericUpDownWeight.ValueChanged += new System.EventHandler(this.numericUpDownWeight_ValueChanged);
            // 
            // textBoxTreats
            // 
            this.textBoxTreats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTreats.Location = new System.Drawing.Point(49, 117);
            this.textBoxTreats.Name = "textBoxTreats";
            this.textBoxTreats.Size = new System.Drawing.Size(140, 20);
            this.textBoxTreats.TabIndex = 11;
            this.textBoxTreats.TextChanged += new System.EventHandler(this.textBoxTreats_TextChanged);
            // 
            // labelTreats
            // 
            this.labelTreats.AutoSize = true;
            this.labelTreats.Location = new System.Drawing.Point(3, 120);
            this.labelTreats.Name = "labelTreats";
            this.labelTreats.Size = new System.Drawing.Size(40, 13);
            this.labelTreats.TabIndex = 10;
            this.labelTreats.Text = "Cechy:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(4, 292);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(185, 129);
            this.textBoxDesc.TabIndex = 15;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(4, 276);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(28, 13);
            this.labelDesc.TabIndex = 14;
            this.labelDesc.Text = "Opis";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(3, 149);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(42, 13);
            this.labelRange.TabIndex = 17;
            this.labelRange.Text = "Zasięg:";
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownRange.Location = new System.Drawing.Point(51, 147);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownRange.TabIndex = 16;
            this.numericUpDownRange.ValueChanged += new System.EventHandler(this.numericUpDownRange_ValueChanged);
            // 
            // numericUpDownReload
            // 
            this.numericUpDownReload.Location = new System.Drawing.Point(90, 173);
            this.numericUpDownReload.Name = "numericUpDownReload";
            this.numericUpDownReload.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownReload.TabIndex = 18;
            this.numericUpDownReload.ValueChanged += new System.EventHandler(this.numericUpDownReload_ValueChanged);
            // 
            // labelReload
            // 
            this.labelReload.AutoSize = true;
            this.labelReload.Location = new System.Drawing.Point(3, 175);
            this.labelReload.Name = "labelReload";
            this.labelReload.Size = new System.Drawing.Size(81, 13);
            this.labelReload.TabIndex = 19;
            this.labelReload.Text = "Przeładowanie:";
            // 
            // textBoxDamage
            // 
            this.textBoxDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDamage.Location = new System.Drawing.Point(38, 199);
            this.textBoxDamage.Name = "textBoxDamage";
            this.textBoxDamage.Size = new System.Drawing.Size(151, 20);
            this.textBoxDamage.TabIndex = 21;
            this.textBoxDamage.TextChanged += new System.EventHandler(this.textBoxDamage_TextChanged);
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Location = new System.Drawing.Point(3, 202);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(29, 13);
            this.labelDamage.TabIndex = 20;
            this.labelDamage.Text = "Siła:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Location = new System.Drawing.Point(38, 222);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 20);
            this.textBoxPrice.TabIndex = 23;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(3, 225);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "Cena:";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCategory.Location = new System.Drawing.Point(64, 245);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(125, 20);
            this.textBoxCategory.TabIndex = 25;
            this.textBoxCategory.TextChanged += new System.EventHandler(this.textBoxCategory_TextChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(3, 248);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 13);
            this.labelCategory.TabIndex = 24;
            this.labelCategory.Text = "Kategoria:";
            // 
            // Weapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxDamage);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.labelReload);
            this.Controls.Add(this.numericUpDownReload);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.textBoxTreats);
            this.Controls.Add(this.labelTreats);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.comboBoxAvailability);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(195, 424);
            this.Name = "Weapon";
            this.Size = new System.Drawing.Size(195, 424);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.TextBox textBoxTreats;
        private System.Windows.Forms.Label labelTreats;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.NumericUpDown numericUpDownReload;
        private System.Windows.Forms.Label labelReload;
        private System.Windows.Forms.TextBox textBoxDamage;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelCategory;
    }
}
