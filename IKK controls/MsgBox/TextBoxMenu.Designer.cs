namespace IKK_controls
{
    partial class TextBoxMenu
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
            this.card = new IKK_controls.Card();
            this.lblErrors = new IKK_controls.Lbl();
            this.card.SuspendLayout();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.card.Controls.Add(this.lblErrors);
            this.card.Location = new System.Drawing.Point(0, 0);
            this.card.Margin = new System.Windows.Forms.Padding(8);
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(8);
            this.card.Size = new System.Drawing.Size(192, 47);
            this.card.TabIndex = 0;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(16, 16);
            this.lblErrors.Margin = new System.Windows.Forms.Padding(8);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(158, 13);
            this.lblErrors.TabIndex = 0;
            this.lblErrors.Text = "A műben nincs semmi probléma.";
            // 
            // TextBoxMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextBoxMenu";
            this.Opacity = 0.8D;
            this.Text = "TextBoxMenu";
            this.TopMost = true;
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Card card;
        private Lbl lblErrors;
    }
}