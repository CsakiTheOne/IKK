namespace IKK
{
    partial class View2Projects
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
            this.flpLatest = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLatestProjects = new IKK_controls.Lbl();
            this.cardManageSelected = new IKK_controls.Card();
            this.btnSync = new IKK_controls.Btn();
            this.btnEdit = new IKK_controls.Btn();
            this.lblSelected = new IKK_controls.Lbl();
            this.nmiOpenFile = new IKK_controls.NavMenuItem();
            this.nmiNew = new IKK_controls.NavMenuItem();
            this.btnAdd = new IKK_controls.Btn();
            this.cardManageSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpLatest
            // 
            this.flpLatest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLatest.Location = new System.Drawing.Point(0, 60);
            this.flpLatest.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flpLatest.Name = "flpLatest";
            this.flpLatest.Size = new System.Drawing.Size(650, 440);
            this.flpLatest.TabIndex = 1;
            // 
            // lblLatestProjects
            // 
            this.lblLatestProjects.AutoSize = true;
            this.lblLatestProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLatestProjects.Location = new System.Drawing.Point(8, 8);
            this.lblLatestProjects.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblLatestProjects.Name = "lblLatestProjects";
            this.lblLatestProjects.Size = new System.Drawing.Size(321, 44);
            this.lblLatestProjects.TabIndex = 0;
            this.lblLatestProjects.Text = "Legutóbbi művek:";
            // 
            // cardManageSelected
            // 
            this.cardManageSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cardManageSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardManageSelected.Controls.Add(this.btnSync);
            this.cardManageSelected.Controls.Add(this.btnEdit);
            this.cardManageSelected.Controls.Add(this.lblSelected);
            this.cardManageSelected.Location = new System.Drawing.Point(650, 60);
            this.cardManageSelected.Margin = new System.Windows.Forms.Padding(0);
            this.cardManageSelected.Name = "cardManageSelected";
            this.cardManageSelected.Padding = new System.Windows.Forms.Padding(8);
            this.cardManageSelected.Size = new System.Drawing.Size(250, 140);
            this.cardManageSelected.TabIndex = 2;
            this.cardManageSelected.Visible = false;
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSync.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSync.Location = new System.Drawing.Point(16, 91);
            this.btnSync.Margin = new System.Windows.Forms.Padding(8);
            this.btnSync.Name = "btnSync";
            this.btnSync.Raised = true;
            this.btnSync.Size = new System.Drawing.Size(216, 30);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Feltöltés";
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.Location = new System.Drawing.Point(16, 45);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Raised = true;
            this.btnEdit.Size = new System.Drawing.Size(216, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Szerkesztés";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(16, 16);
            this.lblSelected.Margin = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(110, 13);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.Text = "Válassz egy projektet!";
            // 
            // nmiOpenFile
            // 
            this.nmiOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiOpenFile.Icon = global::IKK.Properties.Resources.sharp_folder_open_white_48dp;
            this.nmiOpenFile.Location = new System.Drawing.Point(650, 380);
            this.nmiOpenFile.Margin = new System.Windows.Forms.Padding(0);
            this.nmiOpenFile.Name = "nmiOpenFile";
            this.nmiOpenFile.Selected = false;
            this.nmiOpenFile.Size = new System.Drawing.Size(250, 60);
            this.nmiOpenFile.TabIndex = 1;
            this.nmiOpenFile.Text = "Megnyitás fájlból";
            this.nmiOpenFile.Click += new System.EventHandler(this.nmiOpenFile_Click);
            // 
            // nmiNew
            // 
            this.nmiNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiNew.Icon = global::IKK.Properties.Resources.sharp_add_white_48dp;
            this.nmiNew.Location = new System.Drawing.Point(650, 440);
            this.nmiNew.Margin = new System.Windows.Forms.Padding(0);
            this.nmiNew.Name = "nmiNew";
            this.nmiNew.Selected = false;
            this.nmiNew.Size = new System.Drawing.Size(250, 60);
            this.nmiNew.TabIndex = 0;
            this.nmiNew.Text = "Új projekt";
            this.nmiNew.Click += new System.EventHandler(this.nmiNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(337, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Raised = true;
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // View2Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cardManageSelected);
            this.Controls.Add(this.nmiOpenFile);
            this.Controls.Add(this.flpLatest);
            this.Controls.Add(this.nmiNew);
            this.Controls.Add(this.lblLatestProjects);
            this.Name = "View2Projects";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.cardManageSelected.ResumeLayout(false);
            this.cardManageSelected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IKK_controls.NavMenuItem nmiNew;
        private IKK_controls.NavMenuItem nmiOpenFile;
        private IKK_controls.Lbl lblLatestProjects;
        private System.Windows.Forms.FlowLayoutPanel flpLatest;
        private IKK_controls.Card cardManageSelected;
        private IKK_controls.Lbl lblSelected;
        private IKK_controls.Btn btnAdd;
        private IKK_controls.Btn btnEdit;
        private IKK_controls.Btn btnSync;
    }
}
