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
    public partial class NameComponentForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private MainForm form;

        public NameComponentForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            string text = InputBox.Text; int length = text.Length;
            bool containsDigits = false;
            if (length == 0) { return; }

            char ch = text[0];
            FirstCharacter(ch);

            for (int i = 1; i < length; i++)
            {
                ch = text[i];
                if (!containsDigits && char.IsDigit(ch)) { containsDigits = true; }
                
                AcceptableCharacters(ch);
                NamingCriterion(ch, containsDigits);
            }
        }

        /// <summary>
        /// Makes sure the first character is a letter.
        /// </summary>
        private void FirstCharacter(char ch)
        {
            if (!char.IsLetter(ch))
            {
                InputBox.Clear();
                Error("First character must be a letter.");
            }
        }

        /// <summary>
        /// Only accepts legal names for variables/classes.
        /// </summary>
        /// <param name="ch"></param>
        private void NamingCriterion(char ch, bool hasDigits)
        {
            if (char.IsLetter(ch) && hasDigits)
            {
                RemoveLastChar(InputBox);
                Error("Letters cannot come after digits.");
            }
        }

        /// <summary>
        /// Permits only acceptable characters in the input.
        /// </summary>
        /// <param name="ch"></param>
        private void AcceptableCharacters(char ch)
        {
            if (!(char.IsDigit(ch) || char.IsLetter(ch) || ch == '_'))
            {
                RemoveLastChar(InputBox);
                Error("Name can only contain letters, digits, or underscores.");
            }
        }

        private void Error(string v) => ErrorLabel.Text = v;

        private void RemoveLastChar(TextBox textBox)
        {
            textBox.Text = textBox.Text.Remove(InputBox.TextLength - 1);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string name = InputBox.Text;
            if (!form.IsTakenName(name)) {
                // Adds the name to the list of taken names.
                form.AddFlowComponent(sender, name);
                Close();
            }
            else
            {
                Error("That name is taken. Please provide a different name.");
            }
        }
    }
}
