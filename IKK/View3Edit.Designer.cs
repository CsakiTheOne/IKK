namespace IKK
{
    partial class View3Edit
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
            this.lblTitle = new IKK_controls.Lbl();
            this.tbTitle = new IKK_controls.Tb();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mű címe:";
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTitle.Location = new System.Drawing.Point(16, 44);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(8);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Secret = false;
            this.tbTitle.Size = new System.Drawing.Size(268, 26);
            this.tbTitle.TabIndex = 1;
            // 
            // View3Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "View3Edit";
            this.Size = new System.Drawing.Size(300, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IKK_controls.Lbl lblTitle;
        private IKK_controls.Tb tbTitle;
    }
}
