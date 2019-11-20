namespace IKK
{
    partial class View2Feed
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
            this.panel = new System.Windows.Forms.Panel();
            this.flpPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.cardShare = new IKK_controls.Card();
            this.btnShareProject = new IKK_controls.Btn();
            this.btnShare = new IKK_controls.Btn();
            this.tbShare = new IKK_controls.Tb();
            this.nmiRefresh = new IKK_controls.NavMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.cardShare.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.nmiRefresh, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.flpPosts);
            this.panel.Controls.Add(this.cardShare);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(195, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(8);
            this.panel.Size = new System.Drawing.Size(455, 500);
            this.panel.TabIndex = 0;
            // 
            // flpPosts
            // 
            this.flpPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpPosts.AutoScroll = true;
            this.flpPosts.Location = new System.Drawing.Point(17, 167);
            this.flpPosts.Name = "flpPosts";
            this.flpPosts.Size = new System.Drawing.Size(420, 333);
            this.flpPosts.TabIndex = 1;
            // 
            // cardShare
            // 
            this.cardShare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardShare.Controls.Add(this.btnShareProject);
            this.cardShare.Controls.Add(this.btnShare);
            this.cardShare.Controls.Add(this.tbShare);
            this.cardShare.Location = new System.Drawing.Point(16, 16);
            this.cardShare.Margin = new System.Windows.Forms.Padding(8);
            this.cardShare.Name = "cardShare";
            this.cardShare.Padding = new System.Windows.Forms.Padding(8);
            this.cardShare.Size = new System.Drawing.Size(423, 140);
            this.cardShare.TabIndex = 0;
            // 
            // btnShareProject
            // 
            this.btnShareProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShareProject.FlatAppearance.BorderSize = 0;
            this.btnShareProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShareProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShareProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnShareProject.Location = new System.Drawing.Point(189, 92);
            this.btnShareProject.Margin = new System.Windows.Forms.Padding(8);
            this.btnShareProject.Name = "btnShareProject";
            this.btnShareProject.Raised = false;
            this.btnShareProject.Size = new System.Drawing.Size(100, 30);
            this.btnShareProject.TabIndex = 2;
            this.btnShareProject.Text = "Mű csatolása";
            this.btnShareProject.UseVisualStyleBackColor = true;
            // 
            // btnShare
            // 
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnShare.FlatAppearance.BorderSize = 0;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShare.Location = new System.Drawing.Point(305, 92);
            this.btnShare.Margin = new System.Windows.Forms.Padding(8);
            this.btnShare.Name = "btnShare";
            this.btnShare.Raised = true;
            this.btnShare.Size = new System.Drawing.Size(100, 30);
            this.btnShare.TabIndex = 1;
            this.btnShare.Text = "Megosztás";
            this.btnShare.UseVisualStyleBackColor = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // tbShare
            // 
            this.tbShare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbShare.Location = new System.Drawing.Point(16, 16);
            this.tbShare.Margin = new System.Windows.Forms.Padding(8);
            this.tbShare.Multiline = true;
            this.tbShare.Name = "tbShare";
            this.tbShare.Secret = false;
            this.tbShare.Size = new System.Drawing.Size(389, 60);
            this.tbShare.TabIndex = 0;
            // 
            // nmiRefresh
            // 
            this.nmiRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiRefresh.Icon = global::IKK.Properties.Resources.sharp_refresh_white_48dp;
            this.nmiRefresh.Location = new System.Drawing.Point(650, 0);
            this.nmiRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.nmiRefresh.Name = "nmiRefresh";
            this.nmiRefresh.Selected = false;
            this.nmiRefresh.Size = new System.Drawing.Size(250, 60);
            this.nmiRefresh.TabIndex = 1;
            this.nmiRefresh.Text = "Frissítés";
            this.nmiRefresh.Click += new System.EventHandler(this.nmiRefresh_Click);
            // 
            // View2Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "View2Feed";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.cardShare.ResumeLayout(false);
            this.cardShare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel;
        private IKK_controls.NavMenuItem nmiRefresh;
        private IKK_controls.Card cardShare;
        private IKK_controls.Btn btnShare;
        private IKK_controls.Tb tbShare;
        private IKK_controls.Btn btnShareProject;
        private System.Windows.Forms.FlowLayoutPanel flpPosts;
    }
}
