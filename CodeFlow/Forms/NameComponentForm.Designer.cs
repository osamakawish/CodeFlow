namespace CodeFlow.Forms
{
    partial class NameComponentForm
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
            this.RequestLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RequestLabel
            // 
            this.RequestLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestLabel.Location = new System.Drawing.Point(0, 0);
            this.RequestLabel.Name = "RequestLabel";
            this.RequestLabel.Size = new System.Drawing.Size(698, 149);
            this.RequestLabel.TabIndex = 0;
            this.RequestLabel.Text = "Please provide a name for your ";
            this.RequestLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(209, 367);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(200, 3, 200, 3);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(280, 44);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(109, 171);
            this.InputBox.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.InputBox.MaxLength = 60;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(480, 31);
            this.InputBox.TabIndex = 3;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 228);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(674, 52);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Error Label";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameComponentForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 520);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RequestLabel);
            this.Font = new System.Drawing.Font("Alegreya Sans", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NameComponentForm";
            this.Text = "NameComponentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RequestLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}