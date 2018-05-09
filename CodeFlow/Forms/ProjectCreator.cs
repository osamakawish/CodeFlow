using System;
using System.IO;
using System.Windows.Forms;

namespace CodeFlow.Forms
{
    public partial class ProjectCreator : Form
    {
        /// <summary>
        /// True if a file is already open. False otherwise.
        /// </summary>
        private bool fileOpen;
        /// <summary>
        /// The form that opened this dialog.
        /// </summary>
        private MainForm MainForm;

        /// <summary>
        /// Form for creating a new project.
        /// </summary>
        /// <param name="fileOpen">True if a project is open in the main window. False otherwise.</param>
        public ProjectCreator(MainForm form, bool fileOpen)
        {
            InitializeComponent();
            MainForm = form; this.fileOpen = fileOpen;
        }

        /// <summary>
        /// For selecting an empty folder in which to initiate the project.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FolderLocationLabel.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Returns true if the path provided corresponds to an empty directory, and false otherwise.
        /// </summary>
        /// <param name="selectedPath">Path of the directory.</param>
        /// <returns></returns>
        private bool IsEmptyDirectory(string selectedPath) => 
            Directory.GetFileSystemEntries(selectedPath).Length == 0;

        /// <summary>
        /// Creates directories for the project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string path = FolderBrowserDialog.SelectedPath;
            //try
            //{
                if (IsEmptyDirectory(path))
                {
                    string fullpath = $"{path}\\{ProjectnameInput.Text}\\Project";
                    Directory.CreateDirectory(fullpath);
                    MainForm.SetProject(path, ProjectnameInput.Text);

                    // Make sure to add a new file here too.

                    // If fileOpen, then make sure to open a new window instead of just closing this.
                    Close();
                }
                else
                {
                    ErrorLabel.Text = "Directory must be empty.";
                }
            //}
            //catch (Exception ex)
            //{
            //    ErrorLabel.Text = "The process to create the project or directory has failed.:" +
            //        ex.ToString();
            //}
        }
    }
}
