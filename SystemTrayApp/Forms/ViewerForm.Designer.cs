namespace SystemTrayApp
{
    partial class ViewerForm
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
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseWindowButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseWindowButton.Location = new System.Drawing.Point(296, 162);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(75, 23);
            this.CloseWindowButton.TabIndex = 1;
            this.CloseWindowButton.Text = "Close";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 197);
            this.Controls.Add(this.CloseWindowButton);
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example window";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseWindowButton;
    }
}