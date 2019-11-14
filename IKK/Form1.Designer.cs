namespace IKK
{
    partial class FormMain
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
            this.pNotifArea = new System.Windows.Forms.Panel();
            this.flpNotifArea = new System.Windows.Forms.FlowLayoutPanel();
            this.viewContainerMain = new IKK_controls.ViewContainer();
            this.btnNotifClear = new IKK_controls.Btn();
            this.lbl1 = new IKK_controls.Lbl();
            this.cardBottom = new IKK_controls.Card();
            this.btnNotifOpen = new IKK_controls.Btn();
            this.pNotifArea.SuspendLayout();
            this.cardBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNotifArea
            // 
            this.pNotifArea.Controls.Add(this.btnNotifClear);
            this.pNotifArea.Controls.Add(this.flpNotifArea);
            this.pNotifArea.Controls.Add(this.lbl1);
            this.pNotifArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.pNotifArea.Location = new System.Drawing.Point(684, 0);
            this.pNotifArea.Margin = new System.Windows.Forms.Padding(0);
            this.pNotifArea.Name = "pNotifArea";
            this.pNotifArea.Size = new System.Drawing.Size(300, 531);
            this.pNotifArea.TabIndex = 2;
            this.pNotifArea.Visible = false;
            // 
            // flpNotifArea
            // 
            this.flpNotifArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpNotifArea.Location = new System.Drawing.Point(0, 91);
            this.flpNotifArea.Margin = new System.Windows.Forms.Padding(0);
            this.flpNotifArea.Name = "flpNotifArea";
            this.flpNotifArea.Size = new System.Drawing.Size(300, 440);
            this.flpNotifArea.TabIndex = 1;
            // 
            // viewContainerMain
            // 
            this.viewContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewContainerMain.Location = new System.Drawing.Point(0, 0);
            this.viewContainerMain.Name = "viewContainerMain";
            this.viewContainerMain.Size = new System.Drawing.Size(684, 531);
            this.viewContainerMain.TabIndex = 0;
            // 
            // btnNotifClear
            // 
            this.btnNotifClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifClear.FlatAppearance.BorderSize = 0;
            this.btnNotifClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNotifClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnNotifClear.Location = new System.Drawing.Point(8, 53);
            this.btnNotifClear.Margin = new System.Windows.Forms.Padding(8);
            this.btnNotifClear.Name = "btnNotifClear";
            this.btnNotifClear.Raised = false;
            this.btnNotifClear.Size = new System.Drawing.Size(284, 30);
            this.btnNotifClear.TabIndex = 2;
            this.btnNotifClear.Text = "Összes értesítés törlése";
            this.btnNotifClear.UseVisualStyleBackColor = true;
            this.btnNotifClear.Click += new System.EventHandler(this.btnNotifClear_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(8, 8);
            this.lbl1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 37);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Értesítések";
            // 
            // cardBottom
            // 
            this.cardBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBottom.Controls.Add(this.btnNotifOpen);
            this.cardBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardBottom.Location = new System.Drawing.Point(0, 531);
            this.cardBottom.Margin = new System.Windows.Forms.Padding(8);
            this.cardBottom.Name = "cardBottom";
            this.cardBottom.Padding = new System.Windows.Forms.Padding(8);
            this.cardBottom.Size = new System.Drawing.Size(984, 30);
            this.cardBottom.TabIndex = 1;
            // 
            // btnNotifOpen
            // 
            this.btnNotifOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifOpen.FlatAppearance.BorderSize = 0;
            this.btnNotifOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNotifOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnNotifOpen.Location = new System.Drawing.Point(684, 0);
            this.btnNotifOpen.Margin = new System.Windows.Forms.Padding(8);
            this.btnNotifOpen.Name = "btnNotifOpen";
            this.btnNotifOpen.Raised = false;
            this.btnNotifOpen.Size = new System.Drawing.Size(300, 30);
            this.btnNotifOpen.TabIndex = 0;
            this.btnNotifOpen.Text = "Nincs új értesítés";
            this.btnNotifOpen.UseVisualStyleBackColor = true;
            this.btnNotifOpen.Click += new System.EventHandler(this.btnNotifOpen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.viewContainerMain);
            this.Controls.Add(this.pNotifArea);
            this.Controls.Add(this.cardBottom);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormMain";
            this.Text = "IKK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pNotifArea.ResumeLayout(false);
            this.pNotifArea.PerformLayout();
            this.cardBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IKK_controls.Card cardBottom;
        private IKK_controls.ViewContainer viewContainerMain;
        private IKK_controls.Btn btnNotifOpen;
        private System.Windows.Forms.Panel pNotifArea;
        private IKK_controls.Lbl lbl1;
        private IKK_controls.Btn btnNotifClear;
        private System.Windows.Forms.FlowLayoutPanel flpNotifArea;
    }
}

