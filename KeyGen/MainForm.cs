using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           txtSerial.Text =  syscontroller.generateHashKey(txtSystemID.Text, txtComputerName.Text);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            string[] data = Clipboard.GetText().Split(' ');
            if (data.Length>=2)
            {
                txtComputerName.Text = data[0];
                txtSystemID.Text = data[1];
            }
            
            
        }
    }

   
}
