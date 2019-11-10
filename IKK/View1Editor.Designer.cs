namespace IKK
{
    partial class View1Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View1Editor));
            this.navMenu = new IKK_controls.NavMenu();
            this.ilMenu = new System.Windows.Forms.ImageList(this.components);
            this.split = new System.Windows.Forms.SplitContainer();
            this.viewContainer = new IKK_controls.ViewContainer();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.AllowCollapse = false;
            this.navMenu.Collapsed = true;
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu.ItemIcons = this.ilMenu;
            this.navMenu.Items = "Kilépés;Szerkesztés;Eszközök";
            this.navMenu.Location = new System.Drawing.Point(0, 24);
            this.navMenu.Name = "navMenu";
            this.navMenu.SelectedItem = "Szerkesztés";
            this.navMenu.Size = new System.Drawing.Size(60, 476);
            this.navMenu.TabIndex = 0;
            this.navMenu.SelectedItemChanged += new System.EventHandler(this.navMenu1_SelectedItemChanged);
            // 
            // ilMenu
            // 
            this.ilMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMenu.ImageStream")));
            this.ilMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMenu.Images.SetKeyName(0, "sharp_arrow_back_white_48dp.png");
            this.ilMenu.Images.SetKeyName(1, "sharp_edit_white_48dp.png");
            this.ilMenu.Images.SetKeyName(2, "sharp_extension_white_48dp.png");
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(60, 24);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.viewContainer);
            this.split.Panel1MinSize = 0;
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.rtb);
            this.split.Panel2MinSize = 0;
            this.split.Size = new System.Drawing.Size(840, 476);
            this.split.SplitterDistance = 25;
            this.split.TabIndex = 1;
            // 
            // viewContainer
            // 
            this.viewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewContainer.Location = new System.Drawing.Point(0, 0);
            this.viewContainer.Margin = new System.Windows.Forms.Padding(0);
            this.viewContainer.Name = "viewContainer";
            this.viewContainer.Size = new System.Drawing.Size(25, 476);
            this.viewContainer.TabIndex = 0;
            // 
            // rtb
            // 
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtb.Location = new System.Drawing.Point(0, 0);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(811, 476);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "A rózsa vörös,\nAz ibolya kék...";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.megnyitásToolStripMenuItem,
            this.mentésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadProjectToolStripMenuItem.Text = "LoadProject();";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // View1Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split);
            this.Controls.Add(this.navMenu);
            this.Controls.Add(this.menuStrip);
            this.Name = "View1Editor";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IKK_controls.NavMenu navMenu;
        private System.Windows.Forms.ImageList ilMenu;
        private System.Windows.Forms.SplitContainer split;
        private IKK_controls.ViewContainer viewContainer;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
    }
}
