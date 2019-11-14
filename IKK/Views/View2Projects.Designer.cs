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
            this.nmiNew = new IKK_controls.NavMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nmiOpen = new IKK_controls.NavMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
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
            this.panel1.Controls.Add(this.nmiOpen);
            this.panel1.Controls.Add(this.nmiNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(630, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 500);
            this.panel1.TabIndex = 0;
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
            this.nmiNew.Size = new System.Drawing.Size(270, 60);
            this.nmiNew.TabIndex = 0;
            this.nmiNew.Text = "Új projekt";
            this.nmiNew.Click += new System.EventHandler(this.nmiNew_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(630, 500);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // nmiOpen
            // 
            this.nmiOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nmiOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiOpen.Icon = global::IKK.Properties.Resources.sharp_folder_open_white_48dp;
            this.nmiOpen.Location = new System.Drawing.Point(0, 380);
            this.nmiOpen.Margin = new System.Windows.Forms.Padding(0);
            this.nmiOpen.Name = "nmiOpen";
            this.nmiOpen.Selected = false;
            this.nmiOpen.Size = new System.Drawing.Size(270, 60);
            this.nmiOpen.TabIndex = 1;
            this.nmiOpen.Text = "Megnyitás";
            this.nmiOpen.Click += new System.EventHandler(this.nmiOpen_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private IKK_controls.NavMenuItem nmiNew;
        private IKK_controls.NavMenuItem nmiOpen;
    }
}
