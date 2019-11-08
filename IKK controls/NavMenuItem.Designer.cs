namespace IKK_controls
{
    partial class NavMenuItem
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
            this.components = new System.ComponentModel.Container();
            this.ttText = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ttText
            // 
            this.ttText.AutomaticDelay = 0;
            this.ttText.AutoPopDelay = 5000;
            this.ttText.InitialDelay = 0;
            this.ttText.ReshowDelay = 0;
            // 
            // NavMenuItem
            // 
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(250, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttText;
    }
}
