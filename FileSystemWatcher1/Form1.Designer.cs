namespace FileSystemWatcher1
{
    partial class Form1
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
            this.StartWatchingButton = new System.Windows.Forms.Button();
            this.DirectoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartWatchingButton
            // 
            this.StartWatchingButton.Location = new System.Drawing.Point(12, 12);
            this.StartWatchingButton.Name = "StartWatchingButton";
            this.StartWatchingButton.Size = new System.Drawing.Size(75, 23);
            this.StartWatchingButton.TabIndex = 0;
            this.StartWatchingButton.Text = "Start";
            this.StartWatchingButton.UseVisualStyleBackColor = true;
            this.StartWatchingButton.Click += new System.EventHandler(this.StartWatchingButton_Click);
            // 
            // DirectoryNameTextBox
            // 
            this.DirectoryNameTextBox.Location = new System.Drawing.Point(93, 12);
            this.DirectoryNameTextBox.Name = "DirectoryNameTextBox";
            this.DirectoryNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.DirectoryNameTextBox.TabIndex = 1;
            this.DirectoryNameTextBox.Text = "C:\\OED\\WatchThis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 224);
            this.Controls.Add(this.DirectoryNameTextBox);
            this.Controls.Add(this.StartWatchingButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartWatchingButton;
        private System.Windows.Forms.TextBox DirectoryNameTextBox;
    }
}

