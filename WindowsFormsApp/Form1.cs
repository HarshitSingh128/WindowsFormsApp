using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text == "admin123")
            {
                MessageBox.Show("Login Success");

            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
