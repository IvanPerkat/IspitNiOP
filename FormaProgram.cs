using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IspitNiOP
{
    public partial class FormaProgram : Form
    {
        public FormaProgram()
        {
            InitializeComponent();

            comboBoxProgram.Items.Add("Notepad");
            comboBoxProgram.Items.Add("Paint");
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (comboBoxProgram.SelectedItem.ToString() == "Notepad")
            {
                Process.Start("notepad.exe");
            }

            else if (comboBoxProgram.SelectedItem.ToString() == "Paint") 
            {
                Process.Start("mspaint.exe");
            }
        }

        private void checkBoxShowProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowProgram.Checked) 
            {
                groupBox1.Visible = false;
            }

            else if (!checkBoxShowProgram.Checked)
            {
                groupBox1.Visible = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxProgramName.Clear();
            textBoxProgramDescription.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Odaberite neko dugme";
            string caption = "Obavještenje"; 

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText formaText = new FormaText();
            DialogResult result = formaText.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxProgramName.Text = formaText.programName;
                textBoxProgramDescription.Text = formaText.programDescription;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Da li ste sigurni da želite zatvoriti aplikaciju?";
            string caption = "Potvrda";

            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, button);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
