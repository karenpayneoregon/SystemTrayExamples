namespace SystemTrayApp.Forms
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
            this.CloseWithOkWindowButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResultsListView = new System.Windows.Forms.ListView();
            this.ActionsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InformationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CloseWithOkWindowButton
            // 
            this.CloseWithOkWindowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseWithOkWindowButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseWithOkWindowButton.Location = new System.Drawing.Point(12, 273);
            this.CloseWithOkWindowButton.Name = "CloseWithOkWindowButton";
            this.CloseWithOkWindowButton.Size = new System.Drawing.Size(89, 23);
            this.CloseWithOkWindowButton.TabIndex = 1;
            this.CloseWithOkWindowButton.Text = "OK";
            this.CloseWithOkWindowButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(486, 273);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ResultsListView
            // 
            this.ResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionsColumn,
            this.InformationColumn,
            this.ActionDateTime});
            this.ResultsListView.FullRowSelect = true;
            this.ResultsListView.Location = new System.Drawing.Point(9, 6);
            this.ResultsListView.MultiSelect = false;
            this.ResultsListView.Name = "ResultsListView";
            this.ResultsListView.Size = new System.Drawing.Size(565, 249);
            this.ResultsListView.TabIndex = 3;
            this.ResultsListView.UseCompatibleStateImageBehavior = false;
            this.ResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // ActionsColumn
            // 
            this.ActionsColumn.Text = "Actions";
            // 
            // InformationColumn
            // 
            this.InformationColumn.Text = "Information";
            // 
            // ActionDateTime
            // 
            this.ActionDateTime.Text = "Time";
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 308);
            this.Controls.Add(this.ResultsListView);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CloseWithOkWindowButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Example window";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseWithOkWindowButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ListView ResultsListView;
        private System.Windows.Forms.ColumnHeader ActionsColumn;
        private System.Windows.Forms.ColumnHeader InformationColumn;
        private System.Windows.Forms.ColumnHeader ActionDateTime;
    }
}