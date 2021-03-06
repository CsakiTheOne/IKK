﻿namespace IKK
{
    partial class View1Login
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
            this.cardLogin = new IKK_controls.Card();
            this.pLogin = new System.Windows.Forms.Panel();
            this.btnModeOffline = new IKK_controls.Btn();
            this.btnModeDebug = new IKK_controls.Btn();
            this.btnModeNet = new IKK_controls.Btn();
            this.tbPass = new IKK_controls.Tb();
            this.tbEmail = new IKK_controls.Tb();
            this.lblPass = new IKK_controls.Lbl();
            this.lblName = new IKK_controls.Lbl();
            this.lblTitle = new IKK_controls.Lbl();
            this.btnPass = new IKK_controls.Btn();
            this.btnReg = new IKK_controls.Btn();
            this.btnLogin = new IKK_controls.Btn();
            this.lblVersion = new IKK_controls.Lbl();
            this.cardLogin.SuspendLayout();
            this.pLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardLogin
            // 
            this.cardLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cardLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardLogin.Controls.Add(this.pLogin);
            this.cardLogin.Location = new System.Drawing.Point(0, 90);
            this.cardLogin.Margin = new System.Windows.Forms.Padding(8);
            this.cardLogin.Name = "cardLogin";
            this.cardLogin.Padding = new System.Windows.Forms.Padding(8);
            this.cardLogin.Size = new System.Drawing.Size(900, 320);
            this.cardLogin.TabIndex = 0;
            // 
            // pLogin
            // 
            this.pLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pLogin.Controls.Add(this.btnModeOffline);
            this.pLogin.Controls.Add(this.btnModeDebug);
            this.pLogin.Controls.Add(this.btnModeNet);
            this.pLogin.Controls.Add(this.tbPass);
            this.pLogin.Controls.Add(this.tbEmail);
            this.pLogin.Controls.Add(this.lblPass);
            this.pLogin.Controls.Add(this.lblName);
            this.pLogin.Controls.Add(this.lblTitle);
            this.pLogin.Controls.Add(this.btnPass);
            this.pLogin.Controls.Add(this.btnReg);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Location = new System.Drawing.Point(299, -1);
            this.pLogin.Margin = new System.Windows.Forms.Padding(0);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(300, 320);
            this.pLogin.TabIndex = 1;
            // 
            // btnModeOffline
            // 
            this.btnModeOffline.FlatAppearance.BorderSize = 0;
            this.btnModeOffline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModeOffline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnModeOffline.Location = new System.Drawing.Point(206, 60);
            this.btnModeOffline.Margin = new System.Windows.Forms.Padding(8);
            this.btnModeOffline.Name = "btnModeOffline";
            this.btnModeOffline.Raised = false;
            this.btnModeOffline.Size = new System.Drawing.Size(80, 30);
            this.btnModeOffline.TabIndex = 23;
            this.btnModeOffline.Text = "Offline mód";
            this.btnModeOffline.UseVisualStyleBackColor = true;
            this.btnModeOffline.Click += new System.EventHandler(this.btnModeOffline_Click);
            // 
            // btnModeDebug
            // 
            this.btnModeDebug.FlatAppearance.BorderSize = 0;
            this.btnModeDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModeDebug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnModeDebug.Location = new System.Drawing.Point(110, 60);
            this.btnModeDebug.Margin = new System.Windows.Forms.Padding(8);
            this.btnModeDebug.Name = "btnModeDebug";
            this.btnModeDebug.Raised = false;
            this.btnModeDebug.Size = new System.Drawing.Size(80, 30);
            this.btnModeDebug.TabIndex = 22;
            this.btnModeDebug.Text = "Teszt mód";
            this.btnModeDebug.UseVisualStyleBackColor = true;
            this.btnModeDebug.Visible = false;
            this.btnModeDebug.Click += new System.EventHandler(this.btnModeDebug_Click);
            // 
            // btnModeNet
            // 
            this.btnModeNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnModeNet.FlatAppearance.BorderSize = 0;
            this.btnModeNet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModeNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModeNet.Location = new System.Drawing.Point(14, 60);
            this.btnModeNet.Margin = new System.Windows.Forms.Padding(8);
            this.btnModeNet.Name = "btnModeNet";
            this.btnModeNet.Raised = true;
            this.btnModeNet.Size = new System.Drawing.Size(80, 30);
            this.btnModeNet.TabIndex = 21;
            this.btnModeNet.Text = "Internet";
            this.btnModeNet.UseVisualStyleBackColor = false;
            this.btnModeNet.Click += new System.EventHandler(this.btnModeNet_Click);
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPass.Location = new System.Drawing.Point(8, 190);
            this.tbPass.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.tbPass.MaxLength = 30;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '●';
            this.tbPass.Secret = true;
            this.tbPass.Size = new System.Drawing.Size(284, 26);
            this.tbPass.TabIndex = 20;
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(8, 127);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(8);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Secret = false;
            this.tbEmail.Size = new System.Drawing.Size(284, 26);
            this.tbEmail.TabIndex = 19;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(8, 169);
            this.lblPass.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(239, 13);
            this.lblPass.TabIndex = 18;
            this.lblPass.Text = "Jelszó (hosszú klikk a jelszó mutatáshoz)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(8, 106);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "E-mail";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(8, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 44);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Betöltés...";
            // 
            // btnPass
            // 
            this.btnPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnPass.Location = new System.Drawing.Point(8, 216);
            this.btnPass.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.btnPass.Name = "btnPass";
            this.btnPass.Raised = false;
            this.btnPass.Size = new System.Drawing.Size(284, 24);
            this.btnPass.TabIndex = 15;
            this.btnPass.Text = "Elfelejtettem a jelszavam";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnReg.Location = new System.Drawing.Point(67, 273);
            this.btnReg.Margin = new System.Windows.Forms.Padding(8);
            this.btnReg.Name = "btnReg";
            this.btnReg.Raised = false;
            this.btnReg.Size = new System.Drawing.Size(100, 30);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "Regisztrálás";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(183, 273);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Raised = true;
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Bejelentkezés";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVersion.Location = new System.Drawing.Point(350, 479);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(200, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "...";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // View1Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cardLogin);
            this.Name = "View1Login";
            this.cardLogin.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private IKK_controls.Card cardLogin;
        private System.Windows.Forms.Panel pLogin;
        private IKK_controls.Tb tbPass;
        private IKK_controls.Tb tbEmail;
        private IKK_controls.Lbl lblPass;
        private IKK_controls.Lbl lblName;
        private IKK_controls.Lbl lblTitle;
        private IKK_controls.Btn btnPass;
        private IKK_controls.Btn btnReg;
        private IKK_controls.Btn btnLogin;
        private IKK_controls.Btn btnModeOffline;
        private IKK_controls.Btn btnModeDebug;
        private IKK_controls.Btn btnModeNet;
        private IKK_controls.Lbl lblVersion;
    }
}
