namespace IKK_controls
{
    partial class MsgBoxDialog
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
            this.pBox = new System.Windows.Forms.Panel();
            this.flpBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblDesc = new IKK_controls.Lbl();
            this.lblTitle = new IKK_controls.Lbl();
            this.pBox.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Controls.Add(this.lblDesc);
            this.pBox.Controls.Add(this.flpBtns);
            this.pBox.Controls.Add(this.pHeader);
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Margin = new System.Windows.Forms.Padding(0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(400, 200);
            this.pBox.TabIndex = 0;
            // 
            // flpBtns
            // 
            this.flpBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBtns.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBtns.Location = new System.Drawing.Point(0, 152);
            this.flpBtns.Margin = new System.Windows.Forms.Padding(0);
            this.flpBtns.Name = "flpBtns";
            this.flpBtns.Size = new System.Drawing.Size(398, 46);
            this.flpBtns.TabIndex = 4;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lblTitle);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(398, 64);
            this.pHeader.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Location = new System.Drawing.Point(16, 72);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(366, 80);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Üzenet";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(17, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MsgBox";
            // 
            // MsgBoxDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.pBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBoxDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBoxDialog";
            this.pBox.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBox;
        private Lbl lblDesc;
        private System.Windows.Forms.FlowLayoutPanel flpBtns;
        private System.Windows.Forms.Panel pHeader;
        private Lbl lblTitle;
    }
}