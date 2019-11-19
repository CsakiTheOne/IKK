namespace IKK
{
    partial class View2Front
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pCenter = new System.Windows.Forms.Panel();
            this.cardQuote = new IKK_controls.Card();
            this.lblQuote = new IKK_controls.Lbl();
            this.cardSearch = new IKK_controls.Card();
            this.btnSearch = new IKK_controls.Btn();
            this.tbSearch = new IKK_controls.Tb();
            this.lblSearch = new IKK_controls.Lbl();
            this.tableLayoutPanel1.SuspendLayout();
            this.pCenter.SuspendLayout();
            this.cardQuote.SuspendLayout();
            this.cardSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pCenter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pCenter
            // 
            this.pCenter.Controls.Add(this.cardQuote);
            this.pCenter.Controls.Add(this.cardSearch);
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(180, 0);
            this.pCenter.Margin = new System.Windows.Forms.Padding(0);
            this.pCenter.Name = "pCenter";
            this.pCenter.Padding = new System.Windows.Forms.Padding(8);
            this.pCenter.Size = new System.Drawing.Size(540, 500);
            this.pCenter.TabIndex = 0;
            // 
            // cardQuote
            // 
            this.cardQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardQuote.Controls.Add(this.lblQuote);
            this.cardQuote.Location = new System.Drawing.Point(16, 16);
            this.cardQuote.Margin = new System.Windows.Forms.Padding(8);
            this.cardQuote.Name = "cardQuote";
            this.cardQuote.Padding = new System.Windows.Forms.Padding(8);
            this.cardQuote.Size = new System.Drawing.Size(508, 100);
            this.cardQuote.TabIndex = 1;
            // 
            // lblQuote
            // 
            this.lblQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuote.Location = new System.Drawing.Point(8, 8);
            this.lblQuote.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(490, 82);
            this.lblQuote.TabIndex = 0;
            this.lblQuote.Text = "Offline módban nincs internet.\r\n- Csáktornyai Ádám József";
            // 
            // cardSearch
            // 
            this.cardSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardSearch.Controls.Add(this.btnSearch);
            this.cardSearch.Controls.Add(this.tbSearch);
            this.cardSearch.Controls.Add(this.lblSearch);
            this.cardSearch.Location = new System.Drawing.Point(16, 132);
            this.cardSearch.Margin = new System.Windows.Forms.Padding(8);
            this.cardSearch.Name = "cardSearch";
            this.cardSearch.Padding = new System.Windows.Forms.Padding(8);
            this.cardSearch.Size = new System.Drawing.Size(508, 60);
            this.cardSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(390, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Raised = true;
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Keresés";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearch.Location = new System.Drawing.Point(222, 16);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Secret = false;
            this.tbSearch.Size = new System.Drawing.Size(152, 26);
            this.tbSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.Location = new System.Drawing.Point(16, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(198, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Felhasználók keresése:";
            // 
            // View2Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "View2Front";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Load += new System.EventHandler(this.View2Front_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pCenter.ResumeLayout(false);
            this.cardQuote.ResumeLayout(false);
            this.cardSearch.ResumeLayout(false);
            this.cardSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pCenter;
        private IKK_controls.Card cardSearch;
        private IKK_controls.Lbl lblSearch;
        private IKK_controls.Tb tbSearch;
        private IKK_controls.Btn btnSearch;
        private IKK_controls.Card cardQuote;
        private IKK_controls.Lbl lblQuote;
    }
}
