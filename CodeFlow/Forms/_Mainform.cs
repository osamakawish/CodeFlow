using CodeFlow.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeFlow
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Allows to get info for naming a new namespace or file.
        /// </summary>
        public string NameTransfer { get; set; }
        /// <summary>
        /// The set of taken names.
        /// </summary>
        private HashSet<String> TakenNames { get; }

        /// <summary>
        /// The main form of the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Deal with clicks on each menu button.
            foreach (var control in MenuPanel.Controls)
            {
                Button button = (Button)control;
                button.Click += (s, e) => MenuButtonClick(s, e);
            }

            TakenNames = new HashSet<string>();
        }

        /// <summary>
        /// Event raised for selecting a menu button.
        /// </summary>
        /// <param name="s">The button that sent the click.</param>
        /// <param name="e"></param>
        private void MenuButtonClick(object s, EventArgs e)
        {
            Button button = (Button)s;
            
            // Request name for it.
            new NameComponentForm(this).ShowDialog();
        }

        internal void AddFlowComponent(object sender, string name)
        {
            AddName(name); 
            // Also need to add button and do anything else when adding new flow component.
        }

        /// <summary>
        /// Adds to the list of taken names.
        /// </summary>
        /// <param name="name"></param>
        internal void AddName(string name) => TakenNames.Add(name);

        /// <summary>
        /// Returns true iff the name has been used for a class, method, namesace, etc.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal bool IsTakenName(string name)
        {
            return TakenNames.Contains(name);
        }

        private void ContentsPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in ContentsPanel.Controls)
            {
                control.Width = ContentsPanel.Width - control.Margin.Left - control.Margin.Right;
            }
        }

        private void ProjectnameButton_Click(object sender, EventArgs e)
        {
            new ProjectOpener().ShowDialog();
        }
    }
}
