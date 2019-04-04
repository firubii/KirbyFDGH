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
    public partial class DropDownWindow : Form
    {
        public string input;
        public string[] options;

        public DropDownWindow()
        {
            InitializeComponent();
        }

        private void DropDownWindow_Load(object sender, EventArgs e)
        {
            inputItem.Items.AddRange(options);
            inputItem.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = inputItem.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
