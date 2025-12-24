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
        public string InputText;

        public DropDownWindow(string[] options)
        {
            InitializeComponent();

            inputItem.Items.AddRange(options);
        }

        private void DropDownWindow_Load(object sender, EventArgs e)
        {
            inputItem.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputText = inputItem.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
