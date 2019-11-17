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
            this.tb = new IKK_controls.Tb();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weboldalKészítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartsdNyomvaAzF1etToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
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
            this.split.Panel2.Controls.Add(this.tb);
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
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.Black;
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb.ForeColor = System.Drawing.Color.White;
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Margin = new System.Windows.Forms.Padding(8);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Secret = false;
            this.tb.Size = new System.Drawing.Size(811, 476);
            this.tb.TabIndex = 0;
            this.tb.Click += new System.EventHandler(this.tb_Click);
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_KeyUp);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.tartsdNyomvaAzF1etToolStripMenuItem});
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
            this.mentésToolStripMenuItem,
            this.weboldalKészítéseToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // weboldalKészítéseToolStripMenuItem
            // 
            this.weboldalKészítéseToolStripMenuItem.Name = "weboldalKészítéseToolStripMenuItem";
            this.weboldalKészítéseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.weboldalKészítéseToolStripMenuItem.Text = "Weboldal készítése";
            this.weboldalKészítéseToolStripMenuItem.Click += new System.EventHandler(this.weboldalKészítéseToolStripMenuItem_Click);
            // 
            // tartsdNyomvaAzF1etToolStripMenuItem
            // 
            this.tartsdNyomvaAzF1etToolStripMenuItem.Name = "tartsdNyomvaAzF1etToolStripMenuItem";
            this.tartsdNyomvaAzF1etToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.tartsdNyomvaAzF1etToolStripMenuItem.Text = "Tartsd nyomva az F1-et";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.split.Panel2.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private IKK_controls.Tb tb;
        private System.Windows.Forms.ToolStripMenuItem weboldalKészítéseToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem tartsdNyomvaAzF1etToolStripMenuItem;
    }
}
