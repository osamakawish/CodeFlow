using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFlow.Forms
{
    public partial class ProjectOpener : Form
    {
        /// <summary>
        /// True if a file is open. False otherwise.
        /// </summary>
        private bool fileOpen;

        /// <summary>
        /// Form for opening and saving projects.
        /// </summary>
        /// <param name="fileOpen">True if a file is open in the main form. False otherwise.</param>
        public ProjectOpener(bool fileOpen)
        {
            InitializeComponent();

            this.fileOpen = fileOpen;
            if (!fileOpen) { SaveFileButton.Hide(); }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }
    }
}
