namespace RPG_Lite.Views.Types
{
    partial class Armor
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
            this.labelAvailability = new System.Windows.Forms.Label();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelCover = new System.Windows.Forms.Label();
            this.textBoxCover = new System.Windows.Forms.TextBox();
            this.labelPoints = new System.Windows.Forms.Label();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.labelDesc = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(49, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(92, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Pancerz";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nazwa:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(52, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(139, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(3, 65);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(67, 13);
            this.labelAvailability.TabIndex = 3;
            this.labelAvailability.Text = "Dostępność:";
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
            this.comboBoxAvailability.TabIndex = 4;
            this.comboBoxAvailability.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailability_SelectedIndexChanged);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWeight.Location = new System.Drawing.Point(71, 89);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownWeight.TabIndex = 6;
            this.numericUpDownWeight.ValueChanged += new System.EventHandler(this.numericUpDownWeight_ValueChanged);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(3, 91);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(63, 13);
            this.labelWeight.TabIndex = 7;
            this.labelWeight.Text = "Obciążenie:";
            // 
            // labelCover
            // 
            this.labelCover.AutoSize = true;
            this.labelCover.Location = new System.Drawing.Point(3, 121);
            this.labelCover.Name = "labelCover";
            this.labelCover.Size = new System.Drawing.Size(95, 13);
            this.labelCover.TabIndex = 8;
            this.labelCover.Text = "Chronione lokacje:";
            // 
            // textBoxCover
            // 
            this.textBoxCover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCover.Location = new System.Drawing.Point(105, 121);
            this.textBoxCover.Name = "textBoxCover";
            this.textBoxCover.Size = new System.Drawing.Size(86, 20);
            this.textBoxCover.TabIndex = 9;
            this.textBoxCover.TextChanged += new System.EventHandler(this.textBoxCover_TextChanged);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(3, 151);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(24, 13);
            this.labelPoints.TabIndex = 10;
            this.labelPoints.Text = "PZ:";
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(33, 149);
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownPoints.TabIndex = 11;
            this.numericUpDownPoints.ValueChanged += new System.EventHandler(this.numericUpDownPoints_ValueChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(3, 182);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(28, 13);
            this.labelDesc.TabIndex = 12;
            this.labelDesc.Text = "Opis";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(6, 198);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(185, 160);
            this.textBoxDesc.TabIndex = 13;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // Armor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.numericUpDownPoints);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.textBoxCover);
            this.Controls.Add(this.labelCover);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.comboBoxAvailability);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(194, 361);
            this.Name = "Armor";
            this.Size = new System.Drawing.Size(194, 361);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelCover;
        private System.Windows.Forms.TextBox textBoxCover;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.NumericUpDown numericUpDownPoints;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}
