namespace RPG_Lite.Views.Types
{
    partial class God
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxSymbol = new System.Windows.Forms.PictureBox();
            this.buttonSymbol = new System.Windows.Forms.Button();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelSkill = new System.Windows.Forms.Label();
            this.listViewSkills = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSkill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTalents = new System.Windows.Forms.Label();
            this.listViewTalents = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTalent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).BeginInit();
            this.contextMenuStripSkill.SuspendLayout();
            this.contextMenuStripTalent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(47, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(51, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Bóg";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(52, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(90, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa:";
            // 
            // pictureBoxSymbol
            // 
            this.pictureBoxSymbol.Location = new System.Drawing.Point(6, 73);
            this.pictureBoxSymbol.Name = "pictureBoxSymbol";
            this.pictureBoxSymbol.Size = new System.Drawing.Size(96, 74);
            this.pictureBoxSymbol.TabIndex = 5;
            this.pictureBoxSymbol.TabStop = false;
            // 
            // buttonSymbol
            // 
            this.buttonSymbol.Location = new System.Drawing.Point(109, 126);
            this.buttonSymbol.Name = "buttonSymbol";
            this.buttonSymbol.Size = new System.Drawing.Size(31, 23);
            this.buttonSymbol.TabIndex = 6;
            this.buttonSymbol.Text = "...";
            this.buttonSymbol.UseVisualStyleBackColor = true;
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Location = new System.Drawing.Point(3, 57);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(44, 13);
            this.labelSymbol.TabIndex = 7;
            this.labelSymbol.Text = "Symbol:";
            // 
            // labelSkill
            // 
            this.labelSkill.AutoSize = true;
            this.labelSkill.Location = new System.Drawing.Point(3, 153);
            this.labelSkill.Name = "labelSkill";
            this.labelSkill.Size = new System.Drawing.Size(70, 13);
            this.labelSkill.TabIndex = 8;
            this.labelSkill.Text = "Umiejętności:";
            // 
            // listViewSkills
            // 
            this.listViewSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSkills.ContextMenuStrip = this.contextMenuStripSkill;
            this.listViewSkills.Location = new System.Drawing.Point(6, 170);
            this.listViewSkills.Name = "listViewSkills";
            this.listViewSkills.Size = new System.Drawing.Size(135, 85);
            this.listViewSkills.TabIndex = 9;
            this.listViewSkills.UseCompatibleStateImageBehavior = false;
            this.listViewSkills.View = System.Windows.Forms.View.Details;
            this.listViewSkills.ItemActivate += new System.EventHandler(this.listViewSkills_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dod. Inf.";
            // 
            // contextMenuStripSkill
            // 
            this.contextMenuStripSkill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.edytujToolStripMenuItem});
            this.contextMenuStripSkill.Name = "contextMenuStrip1";
            this.contextMenuStripSkill.Size = new System.Drawing.Size(108, 70);
            this.contextMenuStripSkill.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripSkill_Opening);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // labelTalents
            // 
            this.labelTalents.AutoSize = true;
            this.labelTalents.Location = new System.Drawing.Point(3, 258);
            this.labelTalents.Name = "labelTalents";
            this.labelTalents.Size = new System.Drawing.Size(56, 13);
            this.labelTalents.TabIndex = 10;
            this.labelTalents.Text = "Zdolności:";
            // 
            // listViewTalents
            // 
            this.listViewTalents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTalents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewTalents.ContextMenuStrip = this.contextMenuStripTalent;
            this.listViewTalents.Location = new System.Drawing.Point(6, 275);
            this.listViewTalents.Name = "listViewTalents";
            this.listViewTalents.Size = new System.Drawing.Size(135, 85);
            this.listViewTalents.TabIndex = 11;
            this.listViewTalents.UseCompatibleStateImageBehavior = false;
            this.listViewTalents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nazwa";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dod. Inf.";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(6, 380);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDesc.Size = new System.Drawing.Size(135, 72);
            this.textBoxDesc.TabIndex = 19;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(3, 363);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(28, 13);
            this.labelDesc.TabIndex = 18;
            this.labelDesc.Text = "Opis";
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // contextMenuStripTalent
            // 
            this.contextMenuStripTalent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem1,
            this.edytujToolStripMenuItem1,
            this.usuńToolStripMenuItem1});
            this.contextMenuStripTalent.Name = "contextMenuStripTalent";
            this.contextMenuStripTalent.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStripTalent.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTalent_Opening);
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // edytujToolStripMenuItem1
            // 
            this.edytujToolStripMenuItem1.Name = "edytujToolStripMenuItem1";
            this.edytujToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.edytujToolStripMenuItem1.Text = "Edytuj";
            this.edytujToolStripMenuItem1.Click += new System.EventHandler(this.edytujToolStripMenuItem1_Click);
            // 
            // usuńToolStripMenuItem1
            // 
            this.usuńToolStripMenuItem1.Name = "usuńToolStripMenuItem1";
            this.usuńToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.usuńToolStripMenuItem1.Text = "Usuń";
            this.usuńToolStripMenuItem1.Click += new System.EventHandler(this.usuńToolStripMenuItem1_Click);
            // 
            // God
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.listViewTalents);
            this.Controls.Add(this.labelTalents);
            this.Controls.Add(this.listViewSkills);
            this.Controls.Add(this.labelSkill);
            this.Controls.Add(this.labelSymbol);
            this.Controls.Add(this.buttonSymbol);
            this.Controls.Add(this.pictureBoxSymbol);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(144, 455);
            this.Name = "God";
            this.Size = new System.Drawing.Size(144, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSymbol)).EndInit();
            this.contextMenuStripSkill.ResumeLayout(false);
            this.contextMenuStripTalent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxSymbol;
        private System.Windows.Forms.Button buttonSymbol;
        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelSkill;
        private System.Windows.Forms.ListView listViewSkills;
        private System.Windows.Forms.Label labelTalents;
        private System.Windows.Forms.ListView listViewTalents;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSkill;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTalent;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem1;
    }
}
