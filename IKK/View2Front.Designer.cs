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
            this.split = new System.Windows.Forms.SplitContainer();
            this.card1 = new IKK_controls.Card();
            this.lbl1 = new IKK_controls.Lbl();
            this.lbl2 = new IKK_controls.Lbl();
            this.card2 = new IKK_controls.Card();
            this.lbl3 = new IKK_controls.Lbl();
            this.tb1 = new IKK_controls.Tb();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl4 = new IKK_controls.Lbl();
            this.tb2 = new IKK_controls.Tb();
            this.btn1 = new IKK_controls.Btn();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(8, 8);
            this.split.Margin = new System.Windows.Forms.Padding(0);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.card1);
            this.split.Panel1MinSize = 300;
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.card2);
            this.split.Panel2MinSize = 300;
            this.split.Size = new System.Drawing.Size(884, 484);
            this.split.SplitterDistance = 300;
            this.split.TabIndex = 0;
            // 
            // card1
            // 
            this.card1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card1.Controls.Add(this.lbl2);
            this.card1.Controls.Add(this.lbl1);
            this.card1.Location = new System.Drawing.Point(8, 8);
            this.card1.Margin = new System.Windows.Forms.Padding(8);
            this.card1.Name = "card1";
            this.card1.Padding = new System.Windows.Forms.Padding(8);
            this.card1.Size = new System.Drawing.Size(284, 100);
            this.card1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(16, 16);
            this.lbl1.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(91, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Mai idézet";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 44);
            this.lbl2.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "...";
            // 
            // card2
            // 
            this.card2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card2.Controls.Add(this.btn1);
            this.card2.Controls.Add(this.tb2);
            this.card2.Controls.Add(this.lbl4);
            this.card2.Controls.Add(this.checkBox1);
            this.card2.Controls.Add(this.tb1);
            this.card2.Controls.Add(this.lbl3);
            this.card2.Location = new System.Drawing.Point(8, 8);
            this.card2.Margin = new System.Windows.Forms.Padding(8);
            this.card2.Name = "card2";
            this.card2.Padding = new System.Windows.Forms.Padding(8);
            this.card2.Size = new System.Drawing.Size(564, 140);
            this.card2.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.Location = new System.Drawing.Point(16, 16);
            this.lbl3.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(186, 20);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Napi idézet beküldése";
            // 
            // tb1
            // 
            this.tb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb1.Location = new System.Drawing.Point(16, 44);
            this.tb1.Margin = new System.Windows.Forms.Padding(8);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Secret = false;
            this.tb1.Size = new System.Drawing.Size(530, 40);
            this.tb1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 107);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(46, 107);
            this.lbl4.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(62, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Más alkotó:";
            // 
            // tb2
            // 
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb2.Location = new System.Drawing.Point(116, 100);
            this.tb2.Margin = new System.Windows.Forms.Padding(8);
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Secret = false;
            this.tb2.Size = new System.Drawing.Size(150, 26);
            this.tb2.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn1.Location = new System.Drawing.Point(446, 98);
            this.btn1.Margin = new System.Windows.Forms.Padding(8);
            this.btn1.Name = "btn1";
            this.btn1.Raised = true;
            this.btn1.Size = new System.Drawing.Size(100, 30);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Beküldés";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // ViewFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.split);
            this.Name = "ViewFront";
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split;
        private IKK_controls.Card card1;
        private IKK_controls.Lbl lbl2;
        private IKK_controls.Lbl lbl1;
        private IKK_controls.Card card2;
        private IKK_controls.Lbl lbl3;
        private IKK_controls.Tb tb1;
        private IKK_controls.Btn btn1;
        private IKK_controls.Tb tb2;
        private IKK_controls.Lbl lbl4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
