using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Assistant
{
    public partial class Login : Form
    {
        int movX, movY;
        bool isMoving;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sysController.CheckCreatePath();
            init_Form();
        }

        private void init_Form()
        {
            txtProcessorID.ReadOnly = true;
            txtRegistrationName.ReadOnly = true;

                string owner = System.Security.Principal.WindowsIdentity.GetCurrent().Owner.ToString();
                txtProcessorID.Text = owner;
            txtRegistrationName.Text = Environment.UserName;

        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;

        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            movX = e.X;
            movY = e.Y;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            string hashKey = sysController.generateHashKey(txtProcessorID.Text, Environment.UserName);
            if (hashKey== txtSerialNumber.Text)
            {
                sysController.registered(hashKey);
                MessageBox.Show("You Are Successfully Registered!");
                this.Hide();
                MainForm obj = new MainForm();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Serial Number!");
            }
                       
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = txtRegistrationName.Text + " " + txtProcessorID.Text;
            Clipboard.SetText(data);
            MessageBox.Show("Copied To Clipboard");
        }

        private bool checkIfValid()
        {
            if (sysController.checkIfRegistered())
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
