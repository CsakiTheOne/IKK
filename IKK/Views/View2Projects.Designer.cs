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
            this.nmiRefresh = new IKK_controls.NavMenuItem();
            this.nmiOpenFile = new IKK_controls.NavMenuItem();
            this.nmiNew = new IKK_controls.NavMenuItem();
            this.flpLatest = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLatestProjects = new IKK_controls.Lbl();
            this.SuspendLayout();
            // 
            // nmiRefresh
            // 
            this.nmiRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiRefresh.Icon = global::IKK.Properties.Resources.sharp_refresh_white_48dp;
            this.nmiRefresh.Location = new System.Drawing.Point(650, 0);
            this.nmiRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.nmiRefresh.Name = "nmiRefresh";
            this.nmiRefresh.Selected = false;
            this.nmiRefresh.Size = new System.Drawing.Size(250, 60);
            this.nmiRefresh.TabIndex = 2;
            this.nmiRefresh.Text = "Frissítés";
            this.nmiRefresh.Click += new System.EventHandler(this.nmiRefresh_Click);
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
            // View2Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nmiRefresh);
            this.Controls.Add(this.nmiOpenFile);
            this.Controls.Add(this.flpLatest);
            this.Controls.Add(this.nmiNew);
            this.Controls.Add(this.lblLatestProjects);
            this.Name = "View2Projects";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IKK_controls.NavMenuItem nmiNew;
        private IKK_controls.NavMenuItem nmiOpenFile;
        private IKK_controls.NavMenuItem nmiRefresh;
        private IKK_controls.Lbl lblLatestProjects;
        private System.Windows.Forms.FlowLayoutPanel flpLatest;
    }
}
