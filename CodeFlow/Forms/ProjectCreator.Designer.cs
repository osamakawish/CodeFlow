namespace CodeFlow.Forms
{
    partial class ProjectCreator
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
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.FolderLocationLabel = new System.Windows.Forms.Label();
            this.ProjectnameLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ProjectnameInput = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.Description = "Select the folder where you want to create the project.";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SubmitButton.Font = new System.Drawing.Font("Alegreya Sans", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SubmitButton.Location = new System.Drawing.Point(13, 140);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(979, 72);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(13, 55);
            this.FolderSelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(152, 38);
            this.FolderSelectButton.TabIndex = 1;
            this.FolderSelectButton.Text = "Select Folder";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // FolderLocationLabel
            // 
            this.FolderLocationLabel.Location = new System.Drawing.Point(173, 55);
            this.FolderLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FolderLocationLabel.Name = "FolderLocationLabel";
            this.FolderLocationLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FolderLocationLabel.Size = new System.Drawing.Size(819, 38);
            this.FolderLocationLabel.TabIndex = 2;
            this.FolderLocationLabel.Text = "Folder Location";
            this.FolderLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectnameLabel
            // 
            this.ProjectnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProjectnameLabel.Location = new System.Drawing.Point(13, 14);
            this.ProjectnameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectnameLabel.Name = "ProjectnameLabel";
            this.ProjectnameLabel.Size = new System.Drawing.Size(152, 31);
            this.ProjectnameLabel.TabIndex = 3;
            this.ProjectnameLabel.Text = "Project Name";
            this.ProjectnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(13, 98);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(979, 37);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Error Label";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectnameInput
            // 
            this.ProjectnameInput.AsciiOnly = true;
            this.ProjectnameInput.Location = new System.Drawing.Point(178, 14);
            this.ProjectnameInput.Name = "ProjectnameInput";
            this.ProjectnameInput.Size = new System.Drawing.Size(814, 31);
            this.ProjectnameInput.TabIndex = 6;
            // 
            // ProjectCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 226);
            this.Controls.Add(this.ProjectnameInput);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ProjectnameLabel);
            this.Controls.Add(this.FolderLocationLabel);
            this.Controls.Add(this.FolderSelectButton);
            this.Controls.Add(this.SubmitButton);
            this.Font = new System.Drawing.Font("Alegreya Sans", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProjectCreator";
            this.Text = "ProjectCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.Label FolderLocationLabel;
        private System.Windows.Forms.Label ProjectnameLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.MaskedTextBox ProjectnameInput;
    }
}