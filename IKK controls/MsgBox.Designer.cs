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
            this.lblText = new IKK_controls.Lbl();
            this.lblTitle = new IKK_controls.Lbl();
            this.btn3 = new IKK_controls.Btn();
            this.btn2 = new IKK_controls.Btn();
            this.btn1 = new IKK_controls.Btn();
            this.pBox = new System.Windows.Forms.Panel();
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
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn3.Location = new System.Drawing.Point(133, 212);
            this.btn3.Margin = new System.Windows.Forms.Padding(8);
            this.btn3.Name = "btn3";
            this.btn3.Raised = false;
            this.btn3.Size = new System.Drawing.Size(100, 30);
            this.btn3.TabIndex = 2;
            this.btn3.Text = ".";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn2.Location = new System.Drawing.Point(249, 212);
            this.btn2.Margin = new System.Windows.Forms.Padding(8);
            this.btn2.Name = "btn2";
            this.btn2.Raised = false;
            this.btn2.Size = new System.Drawing.Size(100, 30);
            this.btn2.TabIndex = 1;
            this.btn2.Text = ".";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(365, 212);
            this.btn1.Margin = new System.Windows.Forms.Padding(8);
            this.btn1.Name = "btn1";
            this.btn1.Raised = false;
            this.btn1.Size = new System.Drawing.Size(100, 30);
            this.btn1.TabIndex = 0;
            this.btn1.Text = ".";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Controls.Add(this.btn3);
            this.pBox.Controls.Add(this.lblText);
            this.pBox.Controls.Add(this.btn2);
            this.pBox.Controls.Add(this.pHead);
            this.pBox.Controls.Add(this.btn1);
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Margin = new System.Windows.Forms.Padding(0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(484, 261);
            this.pBox.TabIndex = 5;
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

        private Btn btn1;
        private Btn btn2;
        private Btn btn3;
        private System.Windows.Forms.Panel pHead;
        private Lbl lblTitle;
        private Lbl lblText;
        private System.Windows.Forms.Panel pBox;
    }
}