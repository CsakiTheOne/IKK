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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pSidebar = new System.Windows.Forms.Panel();
            this.nmiRefresh = new IKK_controls.NavMenuItem();
            this.nmiOpenFile = new IKK_controls.NavMenuItem();
            this.nmiNew = new IKK_controls.NavMenuItem();
            this.pLatestProjects = new System.Windows.Forms.Panel();
            this.flpLatest = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLatestProjects = new IKK_controls.Lbl();
            this.tableLayoutPanel.SuspendLayout();
            this.pSidebar.SuspendLayout();
            this.pLatestProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel.Controls.Add(this.pSidebar, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pLatestProjects, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pSidebar
            // 
            this.pSidebar.Controls.Add(this.nmiRefresh);
            this.pSidebar.Controls.Add(this.nmiOpenFile);
            this.pSidebar.Controls.Add(this.nmiNew);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSidebar.Location = new System.Drawing.Point(600, 0);
            this.pSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(300, 500);
            this.pSidebar.TabIndex = 0;
            // 
            // nmiRefresh
            // 
            this.nmiRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.nmiRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiRefresh.Icon = global::IKK.Properties.Resources.sharp_refresh_white_48dp;
            this.nmiRefresh.Location = new System.Drawing.Point(0, 0);
            this.nmiRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.nmiRefresh.Name = "nmiRefresh";
            this.nmiRefresh.Selected = false;
            this.nmiRefresh.Size = new System.Drawing.Size(300, 60);
            this.nmiRefresh.TabIndex = 2;
            this.nmiRefresh.Text = "Frissítés";
            this.nmiRefresh.Click += new System.EventHandler(this.nmiRefresh_Click);
            // 
            // nmiOpenFile
            // 
            this.nmiOpenFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nmiOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiOpenFile.Icon = global::IKK.Properties.Resources.sharp_folder_open_white_48dp;
            this.nmiOpenFile.Location = new System.Drawing.Point(0, 380);
            this.nmiOpenFile.Margin = new System.Windows.Forms.Padding(0);
            this.nmiOpenFile.Name = "nmiOpenFile";
            this.nmiOpenFile.Selected = false;
            this.nmiOpenFile.Size = new System.Drawing.Size(300, 60);
            this.nmiOpenFile.TabIndex = 1;
            this.nmiOpenFile.Text = "Megnyitás fájlból";
            this.nmiOpenFile.Click += new System.EventHandler(this.nmiOpenFile_Click);
            // 
            // nmiNew
            // 
            this.nmiNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nmiNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiNew.Icon = global::IKK.Properties.Resources.sharp_add_white_48dp;
            this.nmiNew.Location = new System.Drawing.Point(0, 440);
            this.nmiNew.Margin = new System.Windows.Forms.Padding(0);
            this.nmiNew.Name = "nmiNew";
            this.nmiNew.Selected = false;
            this.nmiNew.Size = new System.Drawing.Size(300, 60);
            this.nmiNew.TabIndex = 0;
            this.nmiNew.Text = "Új projekt";
            this.nmiNew.Click += new System.EventHandler(this.nmiNew_Click);
            // 
            // pLatestProjects
            // 
            this.pLatestProjects.Controls.Add(this.flpLatest);
            this.pLatestProjects.Controls.Add(this.lblLatestProjects);
            this.pLatestProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLatestProjects.Location = new System.Drawing.Point(0, 0);
            this.pLatestProjects.Margin = new System.Windows.Forms.Padding(0);
            this.pLatestProjects.Name = "pLatestProjects";
            this.pLatestProjects.Size = new System.Drawing.Size(600, 500);
            this.pLatestProjects.TabIndex = 1;
            // 
            // flpLatest
            // 
            this.flpLatest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLatest.Location = new System.Drawing.Point(0, 68);
            this.flpLatest.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flpLatest.Name = "flpLatest";
            this.flpLatest.Size = new System.Drawing.Size(600, 432);
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
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "View2Projects";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.pSidebar.ResumeLayout(false);
            this.pLatestProjects.ResumeLayout(false);
            this.pLatestProjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel pSidebar;
        private IKK_controls.NavMenuItem nmiNew;
        private IKK_controls.NavMenuItem nmiOpenFile;
        private IKK_controls.NavMenuItem nmiRefresh;
        private System.Windows.Forms.Panel pLatestProjects;
        private IKK_controls.Lbl lblLatestProjects;
        private System.Windows.Forms.FlowLayoutPanel flpLatest;
    }
}
