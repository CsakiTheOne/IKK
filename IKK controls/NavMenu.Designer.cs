namespace IKK_controls
{
    partial class NavMenu
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.nmiMenuTitle = new IKK_controls.NavMenuItem();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.Location = new System.Drawing.Point(0, 60);
            this.flp.Margin = new System.Windows.Forms.Padding(0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(250, 340);
            this.flp.TabIndex = 1;
            // 
            // nmiMenuTitle
            // 
            this.nmiMenuTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.nmiMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiMenuTitle.Icon = global::IKK_controls.Properties.Resources.sharp_menu_open_white_48dp;
            this.nmiMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.nmiMenuTitle.Margin = new System.Windows.Forms.Padding(0);
            this.nmiMenuTitle.Name = "nmiMenuTitle";
            this.nmiMenuTitle.Selected = false;
            this.nmiMenuTitle.Size = new System.Drawing.Size(250, 60);
            this.nmiMenuTitle.TabIndex = 0;
            this.nmiMenuTitle.Text = null;
            this.nmiMenuTitle.Click += new System.EventHandler(this.nmiMenuTitle_Click);
            // 
            // NavMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp);
            this.Controls.Add(this.nmiMenuTitle);
            this.Name = "NavMenu";
            this.Size = new System.Drawing.Size(250, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NavMenu_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private NavMenuItem nmiMenuTitle;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}
