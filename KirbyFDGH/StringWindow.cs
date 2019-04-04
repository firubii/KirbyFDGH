using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KirbyFDGH
{
    public partial class StringWindow : Form
    {
        public string input;

        public StringWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = inputString.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
