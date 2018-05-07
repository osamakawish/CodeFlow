namespace CodeFlow
{
    partial class MainForm
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.MainInfoPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ProjectnamePanel = new System.Windows.Forms.Panel();
            this.ProjectnameLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ContentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CodeButton = new System.Windows.Forms.Button();
            this.CodeflowButton = new System.Windows.Forms.Button();
            this.MemberButton = new System.Windows.Forms.Button();
            this.ClassButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainInfoPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ProjectnamePanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.ContentsPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadingLabel.Font = new System.Drawing.Font("Alegreya Sans SC ExtraBold", 24F, System.Drawing.FontStyle.Bold);
            this.HeadingLabel.Location = new System.Drawing.Point(0, 0);
            this.HeadingLabel.Margin = new System.Windows.Forms.Padding(3);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(671, 100);
            this.HeadingLabel.TabIndex = 3;
            this.HeadingLabel.Text = "Heading";
            this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainInfoPanel
            // 
            this.MainInfoPanel.Controls.Add(this.MainPanel);
            this.MainInfoPanel.Controls.Add(this.ProjectnamePanel);
            this.MainInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainInfoPanel.Location = new System.Drawing.Point(0, 28);
            this.MainInfoPanel.Name = "MainInfoPanel";
            this.MainInfoPanel.Size = new System.Drawing.Size(1000, 100);
            this.MainInfoPanel.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.HeadingLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(329, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(671, 100);
            this.MainPanel.TabIndex = 1;
            // 
            // ProjectnamePanel
            // 
            this.ProjectnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProjectnamePanel.Controls.Add(this.ProjectnameLabel);
            this.ProjectnamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProjectnamePanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectnamePanel.Name = "ProjectnamePanel";
            this.ProjectnamePanel.Size = new System.Drawing.Size(329, 100);
            this.ProjectnamePanel.TabIndex = 0;
            // 
            // ProjectnameLabel
            // 
            this.ProjectnameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectnameLabel.Location = new System.Drawing.Point(0, 0);
            this.ProjectnameLabel.Name = "ProjectnameLabel";
            this.ProjectnameLabel.Size = new System.Drawing.Size(329, 100);
            this.ProjectnameLabel.TabIndex = 0;
            this.ProjectnameLabel.Text = "Go to File > Project to Open or Create a project.";
            this.ProjectnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.ContentsPanel);
            this.HeaderPanel.Controls.Add(this.MenuPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 128);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1000, 688);
            this.HeaderPanel.TabIndex = 5;
            // 
            // ContentsPanel
            // 
            this.ContentsPanel.AutoScroll = true;
            this.ContentsPanel.Controls.Add(this.AddButton);
            this.ContentsPanel.Controls.Add(this.button5);
            this.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentsPanel.Location = new System.Drawing.Point(329, 0);
            this.ContentsPanel.Name = "ContentsPanel";
            this.ContentsPanel.Size = new System.Drawing.Size(671, 688);
            this.ContentsPanel.TabIndex = 1;
            this.ContentsPanel.SizeChanged += new System.EventHandler(this.ContentsPanel_SizeChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.Font = new System.Drawing.Font("Alegreya Sans", 40F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(665, 112);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Alegreya Sans", 20F);
            this.button5.Location = new System.Drawing.Point(3, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(665, 112);
            this.button5.TabIndex = 4;
            this.button5.Text = "Test";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MenuPanel.Controls.Add(this.CodeButton);
            this.MenuPanel.Controls.Add(this.CodeflowButton);
            this.MenuPanel.Controls.Add(this.MemberButton);
            this.MenuPanel.Controls.Add(this.ClassButton);
            this.MenuPanel.Controls.Add(this.DirectoryButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(329, 688);
            this.MenuPanel.TabIndex = 0;
            // 
            // CodeButton
            // 
            this.CodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CodeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CodeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CodeButton.FlatAppearance.BorderSize = 12;
            this.CodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeButton.Location = new System.Drawing.Point(0, 573);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(329, 143);
            this.CodeButton.TabIndex = 4;
            this.CodeButton.Text = "Code";
            this.CodeButton.UseVisualStyleBackColor = false;
            this.CodeButton.Visible = false;
            // 
            // CodeflowButton
            // 
            this.CodeflowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CodeflowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CodeflowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CodeflowButton.FlatAppearance.BorderSize = 12;
            this.CodeflowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeflowButton.Location = new System.Drawing.Point(0, 430);
            this.CodeflowButton.Name = "CodeflowButton";
            this.CodeflowButton.Size = new System.Drawing.Size(329, 143);
            this.CodeflowButton.TabIndex = 3;
            this.CodeflowButton.Text = "Codeflow";
            this.CodeflowButton.UseVisualStyleBackColor = false;
            this.CodeflowButton.Visible = false;
            // 
            // MemberButton
            // 
            this.MemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MemberButton.FlatAppearance.BorderSize = 12;
            this.MemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemberButton.Location = new System.Drawing.Point(0, 287);
            this.MemberButton.Name = "MemberButton";
            this.MemberButton.Size = new System.Drawing.Size(329, 143);
            this.MemberButton.TabIndex = 2;
            this.MemberButton.Text = "Field";
            this.MemberButton.UseVisualStyleBackColor = false;
            this.MemberButton.Visible = false;
            // 
            // ClassButton
            // 
            this.ClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClassButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClassButton.FlatAppearance.BorderSize = 12;
            this.ClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassButton.Location = new System.Drawing.Point(0, 144);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(329, 143);
            this.ClassButton.TabIndex = 1;
            this.ClassButton.Text = "Class";
            this.ClassButton.UseVisualStyleBackColor = false;
            this.ClassButton.Visible = false;
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DirectoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DirectoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DirectoryButton.FlatAppearance.BorderSize = 12;
            this.DirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DirectoryButton.Location = new System.Drawing.Point(0, 0);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(329, 144);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Directory";
            this.DirectoryButton.UseVisualStyleBackColor = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1000, 28);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "Menu Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appearanceToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem});
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.appearanceToolStripMenuItem.Text = "Theme";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Checked = true;
            this.lightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 816);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MainInfoPanel);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Alegreya Sans", 12F);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Code Flow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainInfoPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ProjectnamePanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ContentsPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Panel MainInfoPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.FlowLayoutPanel ContentsPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button CodeButton;
        private System.Windows.Forms.Button CodeflowButton;
        private System.Windows.Forms.Button MemberButton;
        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel ProjectnamePanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appearanceToolStripMenuItem;
        private System.Windows.Forms.Label ProjectnameLabel;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
    }
}

