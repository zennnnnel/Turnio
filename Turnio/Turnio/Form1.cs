using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnio
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=ZAOA\\SQLEXPRESS;Initial Catalog=TurnioDB;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Turniobtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Make sure app doesn't exit when this form closes
            form1.Show();

        }

        private void TSellbtn_Click(object sender, EventArgs e)
        {
            // SIGN IN First
            Form4 form4 = new Form4();

            // Make sure app doesn't exit when this form closes
            form4.Show();
            this.Hide();

            // When Form4 is closed, then close this form too
            form4.FormClosed += (s, args) => this.Close();
        }

        private void Sellbtn_Click(object sender, EventArgs e)
        {
            //SIGN IN First
            Form4 form4 = new Form4();

            // Make sure app doesn't exit when this form closes
            form4.Show();
            this.Hide();

            // When Form4 is closed, then close this form too
            form4.FormClosed += (s, args) => this.Close();
        }

    }
}
