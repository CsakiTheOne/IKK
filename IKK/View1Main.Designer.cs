namespace IKK
{
    partial class View1Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View1Main));
            this.navMenu1 = new IKK_controls.NavMenu();
            this.ilMenu = new System.Windows.Forms.ImageList(this.components);
            this.viewContainer1 = new IKK_controls.ViewContainer();
            this.view2Front1 = new IKK.View2Front();
            this.viewContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu1
            // 
            this.navMenu1.AllowCollapse = true;
            this.navMenu1.Collapsed = false;
            this.navMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu1.ItemIcons = this.ilMenu;
            this.navMenu1.Items = "Főoldal;Profil;Verses fal;Művek";
            this.navMenu1.Location = new System.Drawing.Point(0, 0);
            this.navMenu1.Name = "navMenu1";
            this.navMenu1.SelectedItem = "Főoldal";
            this.navMenu1.Size = new System.Drawing.Size(250, 500);
            this.navMenu1.TabIndex = 3;
            this.navMenu1.SelectedItemChanged += new System.EventHandler(this.navMenu1_SelectedItemChanged);
            // 
            // ilMenu
            // 
            this.ilMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMenu.ImageStream")));
            this.ilMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMenu.Images.SetKeyName(0, "sharp_dashboard_white_48dp.png");
            this.ilMenu.Images.SetKeyName(1, "sharp_account_box_white_48dp.png");
            this.ilMenu.Images.SetKeyName(2, "sharp_view_day_white_48dp.png");
            this.ilMenu.Images.SetKeyName(3, "sharp_folder_open_white_48dp.png");
            // 
            // viewContainer1
            // 
            this.viewContainer1.Controls.Add(this.view2Front1);
            this.viewContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewContainer1.Location = new System.Drawing.Point(250, 0);
            this.viewContainer1.Name = "viewContainer1";
            this.viewContainer1.Size = new System.Drawing.Size(650, 500);
            this.viewContainer1.TabIndex = 4;
            // 
            // view2Front1
            // 
            this.view2Front1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view2Front1.Location = new System.Drawing.Point(0, 0);
            this.view2Front1.Margin = new System.Windows.Forms.Padding(0);
            this.view2Front1.Name = "view2Front1";
            this.view2Front1.Padding = new System.Windows.Forms.Padding(8);
            this.view2Front1.Size = new System.Drawing.Size(650, 500);
            this.view2Front1.TabIndex = 0;
            // 
            // View1Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewContainer1);
            this.Controls.Add(this.navMenu1);
            this.Name = "View1Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.viewContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private IKK_controls.NavMenu navMenu1;
        private System.Windows.Forms.ImageList ilMenu;
        private IKK_controls.ViewContainer viewContainer1;
        private View2Front view2Front1;
    }
}
