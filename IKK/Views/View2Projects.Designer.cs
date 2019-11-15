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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmiOpenSelected = new IKK_controls.NavMenuItem();
            this.projectSelected = new IKK_controls.ProjectCard();
            this.nmiOpenFile = new IKK_controls.NavMenuItem();
            this.nmiNew = new IKK_controls.NavMenuItem();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSectionLocal = new IKK_controls.Lbl();
            this.lblSectionOnline = new IKK_controls.Lbl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmiOpenSelected);
            this.panel1.Controls.Add(this.projectSelected);
            this.panel1.Controls.Add(this.nmiOpenFile);
            this.panel1.Controls.Add(this.nmiNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 500);
            this.panel1.TabIndex = 0;
            // 
            // nmiOpenSelected
            // 
            this.nmiOpenSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiOpenSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiOpenSelected.Icon = null;
            this.nmiOpenSelected.Location = new System.Drawing.Point(0, 152);
            this.nmiOpenSelected.Margin = new System.Windows.Forms.Padding(0);
            this.nmiOpenSelected.Name = "nmiOpenSelected";
            this.nmiOpenSelected.Selected = false;
            this.nmiOpenSelected.Size = new System.Drawing.Size(300, 60);
            this.nmiOpenSelected.TabIndex = 3;
            this.nmiOpenSelected.Text = "Írás";
            // 
            // projectSelected
            // 
            this.projectSelected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projectSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectSelected.Location = new System.Drawing.Point(25, 16);
            this.projectSelected.Margin = new System.Windows.Forms.Padding(16);
            this.projectSelected.Name = "projectSelected";
            this.projectSelected.Selected = false;
            this.projectSelected.Size = new System.Drawing.Size(250, 120);
            this.projectSelected.TabIndex = 2;
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
            // flp
            // 
            this.flp.Controls.Add(this.lblSectionLocal);
            this.flp.Controls.Add(this.lblSectionOnline);
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.Margin = new System.Windows.Forms.Padding(0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(600, 500);
            this.flp.TabIndex = 1;
            this.flp.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Paint);
            // 
            // lblSectionLocal
            // 
            this.lblSectionLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionLocal.Location = new System.Drawing.Point(8, 8);
            this.lblSectionLocal.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblSectionLocal.Name = "lblSectionLocal";
            this.lblSectionLocal.Size = new System.Drawing.Size(600, 44);
            this.lblSectionLocal.TabIndex = 0;
            this.lblSectionLocal.Text = "Legutóbbi művek";
            // 
            // lblSectionOnline
            // 
            this.lblSectionOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSectionOnline.Location = new System.Drawing.Point(8, 60);
            this.lblSectionOnline.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblSectionOnline.Name = "lblSectionOnline";
            this.lblSectionOnline.Size = new System.Drawing.Size(600, 44);
            this.lblSectionOnline.TabIndex = 1;
            this.lblSectionOnline.Text = "Művek a felhőben";
            // 
            // View2Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "View2Projects";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private IKK_controls.NavMenuItem nmiNew;
        private IKK_controls.NavMenuItem nmiOpenFile;
        private IKK_controls.Lbl lblSectionLocal;
        private IKK_controls.Lbl lblSectionOnline;
        private IKK_controls.ProjectCard projectSelected;
        private IKK_controls.NavMenuItem nmiOpenSelected;
    }
}
