namespace RPG_Lite.Views.Types
{
    partial class Race
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
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.listViewTalents = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTalents = new System.Windows.Forms.Label();
            this.listViewSkills = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSkill = new System.Windows.Forms.Label();
            this.listViewStat = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelStat = new System.Windows.Forms.Label();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.textBoxTips = new System.Windows.Forms.TextBox();
            this.labelTips = new System.Windows.Forms.Label();
            this.listViewCareer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCareer = new System.Windows.Forms.Label();
            this.contextMenuStripStat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItemStat = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItemStat = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItemStat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCareer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItemCareer = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItemCareer = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItemCareer = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripSkill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItemSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItemSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItemSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTalent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItemTalent = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItemTalent = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItemTalent = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripStat.SuspendLayout();
            this.contextMenuStripCareer.SuspendLayout();
            this.contextMenuStripSkill.SuspendLayout();
            this.contextMenuStripTalent.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(60, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(63, 26);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Rasa";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(52, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(3, 353);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDesc.Size = new System.Drawing.Size(538, 59);
            this.textBoxDesc.TabIndex = 25;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(3, 337);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(28, 13);
            this.labelDesc.TabIndex = 24;
            this.labelDesc.Text = "Opis";
            // 
            // listViewTalents
            // 
            this.listViewTalents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTalents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listViewTalents.ContextMenuStrip = this.contextMenuStripTalent;
            this.listViewTalents.Location = new System.Drawing.Point(278, 168);
            this.listViewTalents.Name = "listViewTalents";
            this.listViewTalents.Size = new System.Drawing.Size(254, 66);
            this.listViewTalents.TabIndex = 23;
            this.listViewTalents.UseCompatibleStateImageBehavior = false;
            this.listViewTalents.View = System.Windows.Forms.View.Details;
            this.listViewTalents.ItemActivate += new System.EventHandler(this.listViewTalents_ItemActivate);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nazwa";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dod. Inf.";
            this.columnHeader7.Width = 125;
            // 
            // labelTalents
            // 
            this.labelTalents.AutoSize = true;
            this.labelTalents.Location = new System.Drawing.Point(272, 152);
            this.labelTalents.Name = "labelTalents";
            this.labelTalents.Size = new System.Drawing.Size(56, 13);
            this.labelTalents.TabIndex = 22;
            this.labelTalents.Text = "Zdolności:";
            // 
            // listViewSkills
            // 
            this.listViewSkills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSkills.ContextMenuStrip = this.contextMenuStripSkill;
            this.listViewSkills.Location = new System.Drawing.Point(6, 168);
            this.listViewSkills.Name = "listViewSkills";
            this.listViewSkills.Size = new System.Drawing.Size(254, 66);
            this.listViewSkills.TabIndex = 21;
            this.listViewSkills.UseCompatibleStateImageBehavior = false;
            this.listViewSkills.View = System.Windows.Forms.View.Details;
            this.listViewSkills.ItemActivate += new System.EventHandler(this.listViewSkills_ItemActivate);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nazwa";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dod. Inf.";
            this.columnHeader5.Width = 125;
            // 
            // labelSkill
            // 
            this.labelSkill.AutoSize = true;
            this.labelSkill.Location = new System.Drawing.Point(3, 152);
            this.labelSkill.Name = "labelSkill";
            this.labelSkill.Size = new System.Drawing.Size(70, 13);
            this.labelSkill.TabIndex = 20;
            this.labelSkill.Text = "Umiejętności:";
            // 
            // listViewStat
            // 
            this.listViewStat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listViewStat.ContextMenuStrip = this.contextMenuStripStat;
            this.listViewStat.Location = new System.Drawing.Point(6, 76);
            this.listViewStat.Name = "listViewStat";
            this.listViewStat.Size = new System.Drawing.Size(212, 73);
            this.listViewStat.TabIndex = 27;
            this.listViewStat.UseCompatibleStateImageBehavior = false;
            this.listViewStat.View = System.Windows.Forms.View.Details;
            this.listViewStat.ItemActivate += new System.EventHandler(this.listViewStat_ItemActivate);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nazwa";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Wartość";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(3, 60);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(40, 13);
            this.labelStat.TabIndex = 26;
            this.labelStat.Text = "Cechy:";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Location = new System.Drawing.Point(6, 253);
            this.textBoxHistory.Multiline = true;
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistory.Size = new System.Drawing.Size(263, 81);
            this.textBoxHistory.TabIndex = 29;
            this.textBoxHistory.TextChanged += new System.EventHandler(this.textBoxHistory_TextChanged);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(3, 237);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(45, 13);
            this.labelHistory.TabIndex = 28;
            this.labelHistory.Text = "Historia:";
            // 
            // textBoxTips
            // 
            this.textBoxTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTips.Location = new System.Drawing.Point(278, 253);
            this.textBoxTips.Multiline = true;
            this.textBoxTips.Name = "textBoxTips";
            this.textBoxTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTips.Size = new System.Drawing.Size(263, 81);
            this.textBoxTips.TabIndex = 31;
            this.textBoxTips.TextChanged += new System.EventHandler(this.textBoxTips_TextChanged);
            // 
            // labelTips
            // 
            this.labelTips.AutoSize = true;
            this.labelTips.Location = new System.Drawing.Point(275, 237);
            this.labelTips.Name = "labelTips";
            this.labelTips.Size = new System.Drawing.Size(65, 13);
            this.labelTips.TabIndex = 30;
            this.labelTips.Text = "Wskazówki:";
            // 
            // listViewCareer
            // 
            this.listViewCareer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCareer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCareer.ContextMenuStrip = this.contextMenuStripCareer;
            this.listViewCareer.Location = new System.Drawing.Point(260, 76);
            this.listViewCareer.Name = "listViewCareer";
            this.listViewCareer.Size = new System.Drawing.Size(254, 73);
            this.listViewCareer.TabIndex = 33;
            this.listViewCareer.UseCompatibleStateImageBehavior = false;
            this.listViewCareer.View = System.Windows.Forms.View.Details;
            this.listViewCareer.ItemActivate += new System.EventHandler(this.listViewCareer_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 250;
            // 
            // labelCareer
            // 
            this.labelCareer.AutoSize = true;
            this.labelCareer.Location = new System.Drawing.Point(257, 60);
            this.labelCareer.Name = "labelCareer";
            this.labelCareer.Size = new System.Drawing.Size(48, 13);
            this.labelCareer.TabIndex = 32;
            this.labelCareer.Text = "Profesje:";
            // 
            // contextMenuStripStat
            // 
            this.contextMenuStripStat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItemStat,
            this.edytujToolStripMenuItemStat,
            this.usuńToolStripMenuItemStat});
            this.contextMenuStripStat.Name = "contextMenuStripStat";
            this.contextMenuStripStat.Size = new System.Drawing.Size(108, 70);
            this.contextMenuStripStat.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripStat_Opening);
            // 
            // dodajToolStripMenuItemStat
            // 
            this.dodajToolStripMenuItemStat.Name = "dodajToolStripMenuItemStat";
            this.dodajToolStripMenuItemStat.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItemStat.Text = "Dodaj";
            this.dodajToolStripMenuItemStat.Click += new System.EventHandler(this.dodajToolStripMenuItemStat_Click);
            // 
            // edytujToolStripMenuItemStat
            // 
            this.edytujToolStripMenuItemStat.Name = "edytujToolStripMenuItemStat";
            this.edytujToolStripMenuItemStat.Size = new System.Drawing.Size(152, 22);
            this.edytujToolStripMenuItemStat.Text = "Edytuj";
            this.edytujToolStripMenuItemStat.Click += new System.EventHandler(this.edytujToolStripMenuItemStat_Click);
            // 
            // usuńToolStripMenuItemStat
            // 
            this.usuńToolStripMenuItemStat.Name = "usuńToolStripMenuItemStat";
            this.usuńToolStripMenuItemStat.Size = new System.Drawing.Size(152, 22);
            this.usuńToolStripMenuItemStat.Text = "Usuń";
            this.usuńToolStripMenuItemStat.Click += new System.EventHandler(this.usuńToolStripMenuItemStat_Click);
            // 
            // contextMenuStripCareer
            // 
            this.contextMenuStripCareer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItemCareer,
            this.edytujToolStripMenuItemCareer,
            this.usuńToolStripMenuItemCareer});
            this.contextMenuStripCareer.Name = "contextMenuStripCareer";
            this.contextMenuStripCareer.Size = new System.Drawing.Size(108, 70);
            this.contextMenuStripCareer.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripCareer_Opening);
            // 
            // dodajToolStripMenuItemCareer
            // 
            this.dodajToolStripMenuItemCareer.Name = "dodajToolStripMenuItemCareer";
            this.dodajToolStripMenuItemCareer.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItemCareer.Text = "Dodaj";
            this.dodajToolStripMenuItemCareer.Click += new System.EventHandler(this.dodajToolStripMenuItemCareer_Click);
            // 
            // edytujToolStripMenuItemCareer
            // 
            this.edytujToolStripMenuItemCareer.Name = "edytujToolStripMenuItemCareer";
            this.edytujToolStripMenuItemCareer.Size = new System.Drawing.Size(152, 22);
            this.edytujToolStripMenuItemCareer.Text = "Edytuj";
            this.edytujToolStripMenuItemCareer.Click += new System.EventHandler(this.edytujToolStripMenuItemCareer_Click);
            // 
            // usuńToolStripMenuItemCareer
            // 
            this.usuńToolStripMenuItemCareer.Name = "usuńToolStripMenuItemCareer";
            this.usuńToolStripMenuItemCareer.Size = new System.Drawing.Size(152, 22);
            this.usuńToolStripMenuItemCareer.Text = "Usuń";
            this.usuńToolStripMenuItemCareer.Click += new System.EventHandler(this.usuńToolStripMenuItemCareer_Click);
            // 
            // contextMenuStripSkill
            // 
            this.contextMenuStripSkill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItemSkill,
            this.edytujToolStripMenuItemSkill,
            this.usuńToolStripMenuItemSkill});
            this.contextMenuStripSkill.Name = "contextMenuStripSkill";
            this.contextMenuStripSkill.Size = new System.Drawing.Size(108, 70);
            this.contextMenuStripSkill.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripSkill_Opening);
            // 
            // dodajToolStripMenuItemSkill
            // 
            this.dodajToolStripMenuItemSkill.Name = "dodajToolStripMenuItemSkill";
            this.dodajToolStripMenuItemSkill.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItemSkill.Text = "Dodaj";
            this.dodajToolStripMenuItemSkill.Click += new System.EventHandler(this.dodajToolStripMenuItemSkill_Click);
            // 
            // edytujToolStripMenuItemSkill
            // 
            this.edytujToolStripMenuItemSkill.Name = "edytujToolStripMenuItemSkill";
            this.edytujToolStripMenuItemSkill.Size = new System.Drawing.Size(152, 22);
            this.edytujToolStripMenuItemSkill.Text = "Edytuj";
            this.edytujToolStripMenuItemSkill.Click += new System.EventHandler(this.edytujToolStripMenuItemSkill_Click);
            // 
            // usuńToolStripMenuItemSkill
            // 
            this.usuńToolStripMenuItemSkill.Name = "usuńToolStripMenuItemSkill";
            this.usuńToolStripMenuItemSkill.Size = new System.Drawing.Size(152, 22);
            this.usuńToolStripMenuItemSkill.Text = "Usuń";
            this.usuńToolStripMenuItemSkill.Click += new System.EventHandler(this.usuńToolStripMenuItemSkill_Click);
            // 
            // contextMenuStripTalent
            // 
            this.contextMenuStripTalent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItemTalent,
            this.edytujToolStripMenuItemTalent,
            this.usuńToolStripMenuItemTalent});
            this.contextMenuStripTalent.Name = "contextMenuStripTalent";
            this.contextMenuStripTalent.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStripTalent.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTalent_Opening);
            // 
            // dodajToolStripMenuItemTalent
            // 
            this.dodajToolStripMenuItemTalent.Name = "dodajToolStripMenuItemTalent";
            this.dodajToolStripMenuItemTalent.Size = new System.Drawing.Size(152, 22);
            this.dodajToolStripMenuItemTalent.Text = "Dodaj";
            this.dodajToolStripMenuItemTalent.Click += new System.EventHandler(this.dodajToolStripMenuItemTalent_Click);
            // 
            // edytujToolStripMenuItemTalent
            // 
            this.edytujToolStripMenuItemTalent.Name = "edytujToolStripMenuItemTalent";
            this.edytujToolStripMenuItemTalent.Size = new System.Drawing.Size(152, 22);
            this.edytujToolStripMenuItemTalent.Text = "Edytuj";
            this.edytujToolStripMenuItemTalent.Click += new System.EventHandler(this.edytujToolStripMenuItemTalent_Click);
            // 
            // usuńToolStripMenuItemTalent
            // 
            this.usuńToolStripMenuItemTalent.Name = "usuńToolStripMenuItemTalent";
            this.usuńToolStripMenuItemTalent.Size = new System.Drawing.Size(152, 22);
            this.usuńToolStripMenuItemTalent.Text = "Usuń";
            this.usuńToolStripMenuItemTalent.Click += new System.EventHandler(this.usuńToolStripMenuItemTalent_Click);
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCareer);
            this.Controls.Add(this.labelCareer);
            this.Controls.Add(this.textBoxTips);
            this.Controls.Add(this.labelTips);
            this.Controls.Add(this.textBoxHistory);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.listViewStat);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.listViewTalents);
            this.Controls.Add(this.labelTalents);
            this.Controls.Add(this.listViewSkills);
            this.Controls.Add(this.labelSkill);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(547, 415);
            this.Name = "Race";
            this.Size = new System.Drawing.Size(547, 415);
            this.contextMenuStripStat.ResumeLayout(false);
            this.contextMenuStripCareer.ResumeLayout(false);
            this.contextMenuStripSkill.ResumeLayout(false);
            this.contextMenuStripTalent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.ListView listViewTalents;
        private System.Windows.Forms.Label labelTalents;
        private System.Windows.Forms.ListView listViewSkills;
        private System.Windows.Forms.Label labelSkill;
        private System.Windows.Forms.ListView listViewStat;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.TextBox textBoxTips;
        private System.Windows.Forms.Label labelTips;
        private System.Windows.Forms.ListView listViewCareer;
        private System.Windows.Forms.Label labelCareer;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStat;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItemStat;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItemStat;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItemStat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCareer;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItemCareer;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItemCareer;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItemCareer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSkill;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItemSkill;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItemSkill;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItemSkill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTalent;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItemTalent;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItemTalent;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItemTalent;
    }
}
