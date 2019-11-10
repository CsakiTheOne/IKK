namespace IKK_controls
{
    partial class ProjectCard
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
            this.pbLabel = new System.Windows.Forms.PictureBox();
            this.lblDesc = new IKK_controls.Lbl();
            this.lblLabel = new IKK_controls.Lbl();
            this.lblTitle = new IKK_controls.Lbl();
            ((System.ComponentModel.ISupportInitialize)(this.pbLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLabel
            // 
            this.pbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLabel.Image = global::IKK_controls.Properties.Resources.sharp_label_white_48dp;
            this.pbLabel.Location = new System.Drawing.Point(3, 97);
            this.pbLabel.Name = "pbLabel";
            this.pbLabel.Size = new System.Drawing.Size(20, 20);
            this.pbLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLabel.TabIndex = 1;
            this.pbLabel.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Location = new System.Drawing.Point(8, 29);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(234, 61);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Mú első sorai\r\nNéhány eszköz leírása\r\nMég több szöveg\r\nNagyon sok szöveg";
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel.Location = new System.Drawing.Point(26, 97);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(216, 20);
            this.lblLabel.TabIndex = 2;
            this.lblLabel.Text = "címke";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cím";
            // 
            // ProjectCard
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.pbLabel);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProjectCard";
            this.Size = new System.Drawing.Size(250, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pbLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lbl lblTitle;
        private System.Windows.Forms.PictureBox pbLabel;
        private Lbl lblLabel;
        private Lbl lblDesc;
    }
}
