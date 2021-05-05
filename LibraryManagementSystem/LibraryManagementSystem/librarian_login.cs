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

namespace LibraryManagementSystem
{
    public partial class librarian_login : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";

        public librarian_login()
        {
            InitializeComponent();
            password_textBox.UseSystemPasswordChar = true;
            //password_textBox.PasswordChar = '*';
            //password_textBox.MaxLength = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {

                SetValueForText1 = LID_textBox.Text;
                SetValueForText2 = username_textBox.Text;
                SetValueForText3 = password_textBox.Text;

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from L_Login_Data where LID=@a and L_Username=@b and L_Password=@c ", con);
                cmd.Parameters.AddWithValue("@a", SetValueForText1);
                cmd.Parameters.AddWithValue("@b", SetValueForText2);
                cmd.Parameters.AddWithValue("@c", SetValueForText3);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                if (dataset.Tables[0].Rows.Count > 0)
                {
                    //librarian_personalinfo p2 = new librarian_personalinfo();
                    Librarian_Dashboard ss = new Librarian_Dashboard();
                    ss.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this, " Incorrect id, username or password! ", "Login Failed", MessageBoxButtons.OK);
                }

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show(this, " Incorrect id, username or password! ", "Login Failed", MessageBoxButtons.OK);

            }
        }

        private void librarian_login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_Password_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (L_Password_Check.Checked)
            {
                var L_Password_Check = (CheckBox)sender;
                L_Password_Check.Text = "View";
                password_textBox.UseSystemPasswordChar = false;


            }
            else
            {
                var L_Password_Check = (CheckBox)sender;
                L_Password_Check.Text = "View";
                password_textBox.UseSystemPasswordChar = true;


            }
        }

        private void LID_textBox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
