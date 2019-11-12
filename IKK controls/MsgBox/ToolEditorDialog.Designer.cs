namespace IKK_controls
{
    partial class ToolEditorDialog
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
            this.tbSettings = new IKK_controls.Tb();
            this.toolCard = new IKK_controls.ToolCard();
            this.btnSave = new IKK_controls.Btn();
            this.SuspendLayout();
            // 
            // tbSettings
            // 
            this.tbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSettings.Location = new System.Drawing.Point(17, 133);
            this.tbSettings.Margin = new System.Windows.Forms.Padding(8);
            this.tbSettings.Multiline = true;
            this.tbSettings.Name = "tbSettings";
            this.tbSettings.Secret = false;
            this.tbSettings.Size = new System.Drawing.Size(350, 165);
            this.tbSettings.TabIndex = 0;
            // 
            // toolCard
            // 
            this.toolCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolCard.Location = new System.Drawing.Point(17, 17);
            this.toolCard.Margin = new System.Windows.Forms.Padding(8);
            this.toolCard.Name = "toolCard";
            this.toolCard.Size = new System.Drawing.Size(350, 100);
            this.toolCard.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(267, 314);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Raised = true;
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // ToolEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.toolCard);
            this.Controls.Add(this.tbSettings);
            this.MinimizeBox = false;
            this.Name = "ToolEditorDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eszköz beállítása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tb tbSettings;
        private ToolCard toolCard;
        private Btn btnSave;
    }
}