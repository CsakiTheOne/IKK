namespace IKK_controls
{
    partial class MsgBox
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
            this.pHead = new System.Windows.Forms.Panel();
            this.lblTitle = new IKK_controls.Lbl();
            this.lblText = new IKK_controls.Lbl();
            this.pBox = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pHead.SuspendLayout();
            this.pBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHead
            // 
            this.pHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHead.Controls.Add(this.lblTitle);
            this.pHead.Location = new System.Drawing.Point(8, 8);
            this.pHead.Margin = new System.Windows.Forms.Padding(0);
            this.pHead.Name = "pHead";
            this.pHead.Size = new System.Drawing.Size(466, 62);
            this.pHead.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cím";
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Location = new System.Drawing.Point(16, 78);
            this.lblText.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(449, 126);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Szöveg";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Controls.Add(this.flpButtons);
            this.pBox.Controls.Add(this.lblText);
            this.pBox.Controls.Add(this.pHead);
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Margin = new System.Windows.Forms.Padding(0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(484, 261);
            this.pBox.TabIndex = 5;
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(8, 207);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(466, 49);
            this.flpButtons.TabIndex = 5;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pHead.ResumeLayout(false);
            this.pHead.PerformLayout();
            this.pBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pHead;
        private Lbl lblTitle;
        private Lbl lblText;
        private System.Windows.Forms.Panel pBox;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
    }
}