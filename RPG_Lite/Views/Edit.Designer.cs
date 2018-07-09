namespace RPG_Lite.Views
{
    partial class Edit
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
            this.splitContainerEdit = new System.Windows.Forms.SplitContainer();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEdit)).BeginInit();
            this.splitContainerEdit.Panel2.SuspendLayout();
            this.splitContainerEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerEdit
            // 
            this.splitContainerEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEdit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerEdit.IsSplitterFixed = true;
            this.splitContainerEdit.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEdit.Name = "splitContainerEdit";
            this.splitContainerEdit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEdit.Panel2
            // 
            this.splitContainerEdit.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainerEdit.Panel2.Controls.Add(this.buttonAccept);
            this.splitContainerEdit.Size = new System.Drawing.Size(184, 221);
            this.splitContainerEdit.SplitterDistance = 172;
            this.splitContainerEdit.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancel.Location = new System.Drawing.Point(93, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAccept.Location = new System.Drawing.Point(12, 10);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Zatwierdź";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 221);
            this.Controls.Add(this.splitContainerEdit);
            this.MinimumSize = new System.Drawing.Size(200, 260);
            this.Name = "Edit";
            this.Text = "Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_FormClosed);
            this.splitContainerEdit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEdit)).EndInit();
            this.splitContainerEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
    }
}