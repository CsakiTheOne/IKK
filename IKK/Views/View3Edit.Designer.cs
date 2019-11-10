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
            this.lblLabel = new IKK_controls.Lbl();
            this.cbLabel = new System.Windows.Forms.ComboBox();
            this.lblCreateTime = new IKK_controls.Lbl();
            this.tbCreateTime = new IKK_controls.Tb();
            this.lblIdInfo = new IKK_controls.Lbl();
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
            this.tbTitle.TextChanged += new System.EventHandler(this.valuesChanged);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(17, 86);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(41, 13);
            this.lblLabel.TabIndex = 4;
            this.lblLabel.Text = "Címke:";
            // 
            // cbLabel
            // 
            this.cbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLabel.FormattingEnabled = true;
            this.cbLabel.Items.AddRange(new object[] {
            "egyszerú szöveg",
            "líra",
            "epika",
            "eszköz csomag"});
            this.cbLabel.Location = new System.Drawing.Point(16, 102);
            this.cbLabel.Name = "cbLabel";
            this.cbLabel.Size = new System.Drawing.Size(268, 21);
            this.cbLabel.TabIndex = 5;
            this.cbLabel.SelectedIndexChanged += new System.EventHandler(this.valuesChanged);
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.Location = new System.Drawing.Point(17, 437);
            this.lblCreateTime.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(89, 13);
            this.lblCreateTime.TabIndex = 6;
            this.lblCreateTime.Text = "Készítés dátuma:";
            // 
            // tbCreateTime
            // 
            this.tbCreateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCreateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbCreateTime.Location = new System.Drawing.Point(16, 458);
            this.tbCreateTime.Margin = new System.Windows.Forms.Padding(8);
            this.tbCreateTime.Name = "tbCreateTime";
            this.tbCreateTime.ReadOnly = true;
            this.tbCreateTime.Secret = false;
            this.tbCreateTime.Size = new System.Drawing.Size(268, 26);
            this.tbCreateTime.TabIndex = 7;
            // 
            // lblIdInfo
            // 
            this.lblIdInfo.AutoSize = true;
            this.lblIdInfo.Location = new System.Drawing.Point(17, 134);
            this.lblIdInfo.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblIdInfo.Name = "lblIdInfo";
            this.lblIdInfo.Size = new System.Drawing.Size(16, 13);
            this.lblIdInfo.TabIndex = 8;
            this.lblIdInfo.Text = "...";
            // 
            // View3Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIdInfo);
            this.Controls.Add(this.tbCreateTime);
            this.Controls.Add(this.lblCreateTime);
            this.Controls.Add(this.cbLabel);
            this.Controls.Add(this.lblLabel);
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
        private IKK_controls.Lbl lblLabel;
        private System.Windows.Forms.ComboBox cbLabel;
        private IKK_controls.Lbl lblCreateTime;
        private IKK_controls.Tb tbCreateTime;
        private IKK_controls.Lbl lblIdInfo;
    }
}
