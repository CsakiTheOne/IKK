namespace IKK_controls
{
    partial class NotifCard
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
            this.pbResize = new System.Windows.Forms.PictureBox();
            this.pbDismiss = new System.Windows.Forms.PictureBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDesc = new IKK_controls.Lbl();
            this.lblTitle = new IKK_controls.Lbl();
            this.lblTop = new IKK_controls.Lbl();
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDismiss)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResize
            // 
            this.pbResize.Image = global::IKK_controls.Properties.Resources.sharp_expand_more_white_48dp;
            this.pbResize.Location = new System.Drawing.Point(252, 8);
            this.pbResize.Margin = new System.Windows.Forms.Padding(8);
            this.pbResize.Name = "pbResize";
            this.pbResize.Size = new System.Drawing.Size(16, 16);
            this.pbResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResize.TabIndex = 3;
            this.pbResize.TabStop = false;
            this.pbResize.Click += new System.EventHandler(this.resize);
            // 
            // pbDismiss
            // 
            this.pbDismiss.Image = global::IKK_controls.Properties.Resources.sharp_close_white_48dp;
            this.pbDismiss.Location = new System.Drawing.Point(276, 8);
            this.pbDismiss.Margin = new System.Windows.Forms.Padding(8);
            this.pbDismiss.Name = "pbDismiss";
            this.pbDismiss.Size = new System.Drawing.Size(16, 16);
            this.pbDismiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDismiss.TabIndex = 3;
            this.pbDismiss.TabStop = false;
            this.pbDismiss.Click += new System.EventHandler(this.pbDismiss_Click);
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButtons.Location = new System.Drawing.Point(0, 80);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(300, 30);
            this.flpButtons.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(8, 50);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(167, 26);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "The description of the notification.\r\nLine 2 of the description.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(8, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Notification Title";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTop.Location = new System.Drawing.Point(8, 8);
            this.lblTop.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(76, 13);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "sender • 00:00";
            // 
            // NotifCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.pbResize);
            this.Controls.Add(this.pbDismiss);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTop);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.Name = "NotifCard";
            this.Size = new System.Drawing.Size(300, 110);
            this.Click += new System.EventHandler(this.resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDismiss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lbl lblTop;
        private Lbl lblTitle;
        private Lbl lblDesc;
        private System.Windows.Forms.PictureBox pbDismiss;
        private System.Windows.Forms.PictureBox pbResize;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
    }
}
