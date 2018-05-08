using CodeFlow.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeFlow
{
    public enum ComponentLayer { Project, Class, Field, Code }

    public partial class MainForm : Form
    {
        /// <summary>
        /// Path to the project.
        /// </summary>
        public string path;
        /// <summary>
        /// The set of taken names for components in the project.
        /// </summary>
        private HashSet<String> TakenNames { get; }
        /// <summary>
        /// The layer going into the project.
        /// </summary>
        private ComponentLayer currentLayer = ComponentLayer.Project;

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
            
            // Request name for the new component.
            new NameComponentDialog(this, button.Text).ShowDialog();
        }

        /// <summary>
        /// Adds a flow component to the contents panel, and updates remaining data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        internal void AddFlowComponent(object sender, string name)
        {
            AddName(name);
            // Also need to add button and do anything else when adding new flow component.
            // - Add a box for the flow component in the contents section.
        }

        /// <summary>
        /// Adds to the list of taken names.
        /// </summary>
        /// <param name="name">Another name that is now taken.</param>
        internal void AddName(string name) => TakenNames.Add(name);

        /// <summary>
        /// Returns true if the name has been used for a class, method, namesace, etc. False otherwise.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal bool IsTakenName(string name) => TakenNames.Contains(name);

        private void ContentsPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control control in ContentsPanel.Controls)
            {
                control.Width = ContentsPanel.Width - control.Margin.Left - control.Margin.Right;
            }
        }

        /// <summary>
        /// Names the project and updates variables.
        /// </summary>
        /// <param name="text"></param>
        internal void SetProject(string text)
        {
            ProjectnameLabel.Text = text;
            SaveMenuItem.Enabled = true;
        }

        private void ProjectnameButton_Click(object sender, EventArgs e) 
            => new ProjectOpener(false).ShowDialog();

        private void CreateProjectItem_Click(object sender, EventArgs e) 
            => new ProjectCreator(this, false).ShowDialog();

        private void ContentsPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            // Make sure 
        }
    }
}
