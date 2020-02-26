namespace IKK_controls
{
    partial class Post
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.lblText = new IKK_controls.Lbl();
            this.pBtns = new System.Windows.Forms.Panel();
            this.btnOpen = new IKK_controls.Btn();
            this.btnLike = new IKK_controls.Btn();
            this.lblTime = new IKK_controls.Lbl();
            this.lblUsername = new IKK_controls.Lbl();
            this.flp.SuspendLayout();
            this.pBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoSize = true;
            this.flp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flp.Controls.Add(this.lblText);
            this.flp.Controls.Add(this.pBtns);
            this.flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp.Location = new System.Drawing.Point(0, 32);
            this.flp.Margin = new System.Windows.Forms.Padding(0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(430, 66);
            this.flp.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.Location = new System.Drawing.Point(8, 8);
            this.lblText.Margin = new System.Windows.Forms.Padding(8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(62, 20);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Szöveg";
            // 
            // pBtns
            // 
            this.pBtns.Controls.Add(this.btnOpen);
            this.pBtns.Controls.Add(this.btnLike);
            this.pBtns.Location = new System.Drawing.Point(0, 36);
            this.pBtns.Margin = new System.Windows.Forms.Padding(0);
            this.pBtns.Name = "pBtns";
            this.pBtns.Size = new System.Drawing.Size(430, 30);
            this.pBtns.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnOpen.Location = new System.Drawing.Point(206, 0);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Raised = false;
            this.btnOpen.Size = new System.Drawing.Size(100, 30);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Mű megnyitása";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Visible = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnLike
            // 
            this.btnLike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnLike.Location = new System.Drawing.Point(322, 0);
            this.btnLike.Margin = new System.Windows.Forms.Padding(8);
            this.btnLike.Name = "btnLike";
            this.btnLike.Raised = false;
            this.btnLike.Size = new System.Drawing.Size(100, 30);
            this.btnLike.TabIndex = 0;
            this.btnLike.Text = "0 ♥";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Location = new System.Drawing.Point(191, 8);
            this.lblTime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(189, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(8, 8);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(157, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Felhasználónév";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Post";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 64);
            this.Size = new System.Drawing.Size(430, 162);
            this.Load += new System.EventHandler(this.Post_Load);
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.pBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lbl lblUsername;
        private Lbl lblText;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Panel pBtns;
        private Btn btnOpen;
        private Btn btnLike;
        private Lbl lblTime;
    }
}
