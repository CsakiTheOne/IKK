namespace IKK_controls
{
    partial class FormReader
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReader));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cardContent = new IKK_controls.Card();
            this.lblContent = new IKK_controls.Lbl();
            this.lblTitle = new IKK_controls.Lbl();
            this.navMenu1 = new IKK_controls.NavMenu();
            this.cardContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sharp_view_day_white_48dp.png");
            this.imageList1.Images.SetKeyName(1, "sharp_expand_more_white_48dp.png");
            // 
            // cardContent
            // 
            this.cardContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardContent.AutoSize = true;
            this.cardContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardContent.Controls.Add(this.lblContent);
            this.cardContent.Controls.Add(this.lblTitle);
            this.cardContent.Location = new System.Drawing.Point(92, 17);
            this.cardContent.Margin = new System.Windows.Forms.Padding(8);
            this.cardContent.Name = "cardContent";
            this.cardContent.Padding = new System.Windows.Forms.Padding(8);
            this.cardContent.Size = new System.Drawing.Size(600, 84);
            this.cardContent.TabIndex = 1;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(16, 61);
            this.lblContent.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(16, 13);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Betöltés...";
            // 
            // navMenu1
            // 
            this.navMenu1.AllowCollapse = true;
            this.navMenu1.Collapsed = true;
            this.navMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navMenu1.ItemIcons = this.imageList1;
            this.navMenu1.Items = "Olvasás;Részletek";
            this.navMenu1.Location = new System.Drawing.Point(0, 0);
            this.navMenu1.Name = "navMenu1";
            this.navMenu1.SelectedItem = "Olvasás";
            this.navMenu1.Size = new System.Drawing.Size(60, 361);
            this.navMenu1.TabIndex = 0;
            this.navMenu1.SelectedItemChanged += new System.EventHandler(this.navMenu1_SelectedItemChanged);
            // 
            // FormReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.navMenu1);
            this.Controls.Add(this.cardContent);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormReader";
            this.ShowIcon = false;
            this.Text = "IKK olvasó";
            this.cardContent.ResumeLayout(false);
            this.cardContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavMenu navMenu1;
        private System.Windows.Forms.ImageList imageList1;
        private Card cardContent;
        private Lbl lblContent;
        private Lbl lblTitle;
    }
}