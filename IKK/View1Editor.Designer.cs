﻿namespace IKK
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
            this.navMenu1 = new IKK_controls.NavMenu();
            this.ilMenu = new System.Windows.Forms.ImageList(this.components);
            this.split = new System.Windows.Forms.SplitContainer();
            this.viewContainer1 = new IKK_controls.ViewContainer();
            this.view3Edit1 = new IKK.View3Edit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.viewContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu1
            // 
            this.navMenu1.AllowCollapse = false;
            this.navMenu1.Collapsed = true;
            this.navMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu1.ItemIcons = this.ilMenu;
            this.navMenu1.Items = "Kilépés;Szerkesztés;Eszközök";
            this.navMenu1.Location = new System.Drawing.Point(0, 24);
            this.navMenu1.Name = "navMenu1";
            this.navMenu1.SelectedItem = "Szerkesztés";
            this.navMenu1.Size = new System.Drawing.Size(60, 476);
            this.navMenu1.TabIndex = 0;
            this.navMenu1.SelectedItemChanged += new System.EventHandler(this.navMenu1_SelectedItemChanged);
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
            this.split.Panel1.Controls.Add(this.viewContainer1);
            this.split.Panel1MinSize = 0;
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.richTextBox1);
            this.split.Panel2MinSize = 0;
            this.split.Size = new System.Drawing.Size(840, 476);
            this.split.SplitterDistance = 150;
            this.split.TabIndex = 1;
            // 
            // viewContainer1
            // 
            this.viewContainer1.Controls.Add(this.view3Edit1);
            this.viewContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewContainer1.Location = new System.Drawing.Point(0, 0);
            this.viewContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.viewContainer1.Name = "viewContainer1";
            this.viewContainer1.Size = new System.Drawing.Size(150, 476);
            this.viewContainer1.TabIndex = 0;
            // 
            // view3Edit1
            // 
            this.view3Edit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view3Edit1.Location = new System.Drawing.Point(0, 0);
            this.view3Edit1.Margin = new System.Windows.Forms.Padding(0);
            this.view3Edit1.Name = "view3Edit1";
            this.view3Edit1.Padding = new System.Windows.Forms.Padding(8);
            this.view3Edit1.Size = new System.Drawing.Size(150, 476);
            this.view3Edit1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(686, 476);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "A rózsa vörös,\nAz ibolya kék...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            // 
            // View1Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split);
            this.Controls.Add(this.navMenu1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "View1Editor";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.viewContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IKK_controls.NavMenu navMenu1;
        private System.Windows.Forms.ImageList ilMenu;
        private System.Windows.Forms.SplitContainer split;
        private IKK_controls.ViewContainer viewContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private View3Edit view3Edit1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
    }
}
