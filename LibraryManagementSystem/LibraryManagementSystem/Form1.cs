using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked)
                {
                    new librarian_login().Show();
                    this.Hide();

                }
                else if (radioButton2.Checked)
                {
                    new student_login().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(this, "Choose any one from the buttons", "Error Message ", MessageBoxButtons.OK);

                }
            }
            catch
            {
                MessageBox.Show(this, "Choose any one from the buttons", "Error Message ", MessageBoxButtons.OK);
            }

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
