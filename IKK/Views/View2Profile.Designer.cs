﻿namespace IKK
{
    partial class View2Profile
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
            this.nmiRefresh = new IKK_controls.NavMenuItem();
            this.lblEmail = new IKK_controls.Lbl();
            this.tbEmail = new IKK_controls.Tb();
            this.nmiLogout = new IKK_controls.NavMenuItem();
            this.tbName = new IKK_controls.Tb();
            this.tbAbout = new IKK_controls.Tb();
            this.lblName = new IKK_controls.Lbl();
            this.lblAbout = new IKK_controls.Lbl();
            this.lblOther = new IKK_controls.Lbl();
            this.btnUpdate = new IKK_controls.Btn();
            this.tbPassOld = new IKK_controls.Tb();
            this.tbPassNew = new IKK_controls.Tb();
            this.lblPassOld = new IKK_controls.Lbl();
            this.lblPassNew = new IKK_controls.Lbl();
            this.btnPass = new IKK_controls.Btn();
            this.SuspendLayout();
            // 
            // nmiRefresh
            // 
            this.nmiRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiRefresh.Icon = global::IKK.Properties.Resources.sharp_refresh_white_48dp;
            this.nmiRefresh.Location = new System.Drawing.Point(650, 0);
            this.nmiRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.nmiRefresh.Name = "nmiRefresh";
            this.nmiRefresh.Selected = false;
            this.nmiRefresh.Size = new System.Drawing.Size(250, 60);
            this.nmiRefresh.TabIndex = 2;
            this.nmiRefresh.Text = "Frissítés";
            this.nmiRefresh.Click += new System.EventHandler(this.nmiRefresh_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 23);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(85, 16);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(8);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Secret = false;
            this.tbEmail.Size = new System.Drawing.Size(300, 26);
            this.tbEmail.TabIndex = 4;
            // 
            // nmiLogout
            // 
            this.nmiLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nmiLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nmiLogout.Icon = null;
            this.nmiLogout.Location = new System.Drawing.Point(650, 440);
            this.nmiLogout.Margin = new System.Windows.Forms.Padding(0);
            this.nmiLogout.Name = "nmiLogout";
            this.nmiLogout.Selected = false;
            this.nmiLogout.Size = new System.Drawing.Size(250, 60);
            this.nmiLogout.TabIndex = 5;
            this.nmiLogout.Text = "Kijelentkezés";
            this.nmiLogout.Click += new System.EventHandler(this.nmiLogout_Click);
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(85, 58);
            this.tbName.Margin = new System.Windows.Forms.Padding(8);
            this.tbName.Name = "tbName";
            this.tbName.Secret = false;
            this.tbName.Size = new System.Drawing.Size(300, 26);
            this.tbName.TabIndex = 4;
            // 
            // tbAbout
            // 
            this.tbAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAbout.Location = new System.Drawing.Point(85, 100);
            this.tbAbout.Margin = new System.Windows.Forms.Padding(8);
            this.tbAbout.Multiline = true;
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Secret = false;
            this.tbAbout.Size = new System.Drawing.Size(300, 78);
            this.tbAbout.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 65);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Név:";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(16, 107);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(54, 13);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "Magadról:";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(16, 203);
            this.lblOther.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(57, 13);
            this.lblOther.TabIndex = 6;
            this.lblOther.Text = "Egyéb infó";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(225, 194);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Raised = true;
            this.btnUpdate.Size = new System.Drawing.Size(160, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Változtatások mentése";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbPassOld
            // 
            this.tbPassOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassOld.Location = new System.Drawing.Point(85, 240);
            this.tbPassOld.Margin = new System.Windows.Forms.Padding(8);
            this.tbPassOld.Name = "tbPassOld";
            this.tbPassOld.PasswordChar = '●';
            this.tbPassOld.Secret = true;
            this.tbPassOld.Size = new System.Drawing.Size(300, 26);
            this.tbPassOld.TabIndex = 8;
            // 
            // tbPassNew
            // 
            this.tbPassNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassNew.Location = new System.Drawing.Point(85, 282);
            this.tbPassNew.Margin = new System.Windows.Forms.Padding(8);
            this.tbPassNew.Name = "tbPassNew";
            this.tbPassNew.PasswordChar = '●';
            this.tbPassNew.Secret = true;
            this.tbPassNew.Size = new System.Drawing.Size(300, 26);
            this.tbPassNew.TabIndex = 9;
            // 
            // lblPassOld
            // 
            this.lblPassOld.AutoSize = true;
            this.lblPassOld.Location = new System.Drawing.Point(16, 247);
            this.lblPassOld.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblPassOld.Name = "lblPassOld";
            this.lblPassOld.Size = new System.Drawing.Size(61, 13);
            this.lblPassOld.TabIndex = 10;
            this.lblPassOld.Text = "Régi jelszó:";
            // 
            // lblPassNew
            // 
            this.lblPassNew.AutoSize = true;
            this.lblPassNew.Location = new System.Drawing.Point(16, 289);
            this.lblPassNew.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblPassNew.Name = "lblPassNew";
            this.lblPassNew.Size = new System.Drawing.Size(49, 13);
            this.lblPassNew.TabIndex = 11;
            this.lblPassNew.Text = "Új jelszó:";
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPass.Location = new System.Drawing.Point(225, 324);
            this.btnPass.Margin = new System.Windows.Forms.Padding(8);
            this.btnPass.Name = "btnPass";
            this.btnPass.Raised = true;
            this.btnPass.Size = new System.Drawing.Size(160, 30);
            this.btnPass.TabIndex = 12;
            this.btnPass.Text = "Jelszó változtatása";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // View2Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblPassNew);
            this.Controls.Add(this.lblPassOld);
            this.Controls.Add(this.tbPassNew);
            this.Controls.Add(this.tbPassOld);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.nmiLogout);
            this.Controls.Add(this.tbAbout);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.nmiRefresh);
            this.Name = "View2Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IKK_controls.NavMenuItem nmiRefresh;
        private IKK_controls.Lbl lblEmail;
        private IKK_controls.Tb tbEmail;
        private IKK_controls.NavMenuItem nmiLogout;
        private IKK_controls.Tb tbName;
        private IKK_controls.Tb tbAbout;
        private IKK_controls.Lbl lblName;
        private IKK_controls.Lbl lblAbout;
        private IKK_controls.Lbl lblOther;
        private IKK_controls.Btn btnUpdate;
        private IKK_controls.Tb tbPassOld;
        private IKK_controls.Tb tbPassNew;
        private IKK_controls.Lbl lblPassOld;
        private IKK_controls.Lbl lblPassNew;
        private IKK_controls.Btn btnPass;
    }
}
