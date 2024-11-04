using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IspitNiOP
{
    public partial class FormaText : Form
    {
        public string programName => textBoxProgramName.Text;
        public string programDescription => textBoxProgramDescription.Text;

        public FormaText()
        {
            InitializeComponent();
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
