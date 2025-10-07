using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Turnio
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=ZAOA\\SQLEXPRESS;Initial Catalog=TurnioDB;Integrated Security=True;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Listbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Books (Title, Author, Price, Condition) VALUES (@Title, @Author, @Price, @Condition)", conn);
                cmd.Parameters.AddWithValue("@Title", Titletxtbx.Text);
                cmd.Parameters.AddWithValue("@Author", Authtxtbx.Text);
                cmd.Parameters.AddWithValue("@Price", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@Condition", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CoverPhotobtn_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to choose an image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // allowed types

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Load selected image into PictureBox
                pictureBox1.Image = Image.FromFile(ofd.FileName);

                // Optional: Store the file path if needed
                string imagePath = ofd.FileName;
            }
        }

        private void Turniobtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void TSellbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Close();
        }
    }
}
