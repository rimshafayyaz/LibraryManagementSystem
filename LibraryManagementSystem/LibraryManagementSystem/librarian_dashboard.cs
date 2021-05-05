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
    public partial class Librarian_Dashboard : Form
    {
        private const string V = " ";
        private const string V1 = "Approximate_Return";

        public Librarian_Dashboard()
        {
            InitializeComponent();
            returngri();
            data_grid_issue_function();
            //data_grid_returned_function();
            alltransaction();
            abc();
            deletestudent_combo();
            editbook_combo();
            editbook_function();
            dashboard_panel.Visible = true;
            personal_panel.Visible = false;
            students_panel.Visible = false;
            books_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            penalty_panel.Visible = false;
            edit_password_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }
       /* public void latedays()
        {
            SqlConnection con10 = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            con10.Open();
            SqlCommand cmd8 = con10.CreateCommand();
            cmd8.CommandType = CommandType.Text;
           
            cmd8.CommandText = "update B_IssueReturn set latedays='" + noofdays.ToString() + "' where BCode=@a ";
            cmd8.Parameters.AddWithValue("@a", BCode_issuecombo.Text);
            cmd8.ExecuteNonQuery();
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            books_panel.Visible = true;
            students_panel.Visible = false;
            dashboard_panel.Visible = false;
            personal_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students_panel.Visible = true;
            dashboard_panel.Visible = false;
            personal_panel.Visible = false;
            books_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        private void Personal_Info_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();
            label11.Text = librarian_login.SetValueForText1;


            SqlCommand Cmd = new SqlCommand("select L_ID,L_Name,S_Contact,L_Email,L_Address from Librarian_Data inner join L_Login_Data on Librarian_Data.L_ID=L_Login_Data.LID  where L_Login_Data.LID =@a", Con);
            Cmd.Parameters.AddWithValue("@a", label11.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                label11.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                label12.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                label13.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                label14.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                label15.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();

            }
            else
            {
                MessageBox.Show("This Book is not available.\nEnter Correct 'Book Code' to search data");
                return;
            }
            Con.Close();
            personal_panel.Visible = true;
            dashboard_panel.Visible = false;
            students_panel.Visible = false;
            books_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
            //panel2.Visible = false;

            //this.Hide();
            //new librarian_personalinfo().Show();



        }

        private void Issue_Books_Click(object sender, EventArgs e)
        {
            transaction_Panel.Visible = true;
            issuedbooks_panel.Visible = false;
            students_panel.Visible = false;
            dashboard_panel.Visible = false;
            personal_panel.Visible = false;
            books_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            
        }

        private void Return_Books_Click(object sender, EventArgs e)
        {
           
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void next_Click(object sender, EventArgs e)
        {

            if (add_student.Checked)
            {
                add_student_panel.Visible = true;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
            if (edit_students.Checked)
            {
                edit_student_panel.Visible = true;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
            if (del_students.Checked)
            {
                student_delete_panel.Visible = true;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
            if (view_students.Checked)
            {
                data_grid_function();
                all_students_panel.Visible = true;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void personalpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (add_book.Checked)
            {
                add_book_panel.Visible = true;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                students_panel.Visible = false;
                books_panel.Visible = false;
                book_del_panel.Visible = false;
                edi_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
            if (edit_book.Checked)
            {
                edi_book_panel.Visible = true;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                students_panel.Visible = false;
                books_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
            if (delete_book.Checked)
            {
                book_del_panel.Visible = true;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                students_panel.Visible = false;
                edi_book_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
            if (all_book.Checked)
            {
                data_grid_populate_function();
                all_books_panel.Visible = true;
                book_del_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                students_panel.Visible = false;
                edi_book_panel.Visible = false;
                add_book_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }

        }

        public void editbook_function()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            con.Open();
            deletebook_combobox.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select B_Code from Book_Data";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                deletebook_combobox.Items.Add(item["B_Code"].ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select *from Book_Data where B_Code=@a  ", Con);
            Cmd.Parameters.AddWithValue("@a", deletebook_combobox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                BCode_delbox.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                BName_delbox.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                BAuthor_delbox.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                del_publication.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                BSub_delbox.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                BCopies_delbox.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                BAvailable_delbox.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            else
            {
                MessageBox.Show("This data is not available.\nEnter correct name to search data");
                return;
            }
            Con.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("Delete from Book_Data where  B_Code=@a ", Con);
            Cmd.Parameters.AddWithValue("@a", BCode_delbox.Text);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Book Record Deleted Successfully!");
            BCode_delbox.Text = " ";
            BName_delbox.Text = " ";
            BAuthor_delbox.Text = " ";
            //del_publication.Text = " ";
            BSub_delbox.Text = " ";
            BCopies_delbox.Text = " ";
            BAvailable_delbox.Text = " ";
            //data_grid_populate_karna_function();
            Cmd.Dispose();
            Con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            books_panel.Visible = true;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            students_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }
        public void editbook_combo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            con.Open();
            editbook_combobox.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select B_Code from Book_Data";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                editbook_combobox.Items.Add(item["B_Code"].ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select *from Book_Data where B_Code=@a  ", Con);
            Cmd.Parameters.AddWithValue("@a", editbook_combobox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                BCode_editbox.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                BName_editbox.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                BAuthor_editbox.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                editbook_publication.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                BSub_editbox.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                BCopies_editbox.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                BAvailable_editbox.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            else
            {
                MessageBox.Show("This data is not available.\nEnter correct name to search data");
                return;
            }
            Con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("Update Book_Data set B_Code =@a,B_Name=@b,B_Author=@c,B_Publication=@d,B_Subject=@e,B_Copies=@f,B_Available=@g where B_Code=@a", Con);
            Cmd.Parameters.AddWithValue("@a", BCode_editbox.Text);
            Cmd.Parameters.AddWithValue("@b", BName_editbox.Text);
            Cmd.Parameters.AddWithValue("@c", BAuthor_editbox.Text);
            Cmd.Parameters.AddWithValue("@d", editbook_publication.Text);
            Cmd.Parameters.AddWithValue("@e", BSub_editbox.Text);
            Cmd.Parameters.AddWithValue("@f", BCopies_editbox.Text);
            Cmd.Parameters.AddWithValue("@g", BAvailable_editbox.Text);
            Cmd.ExecuteNonQuery();

            MessageBox.Show("Book Record Updated Successfully!");
            BCode_editbox.Text = " ";
            BName_editbox.Text = " ";
            BAuthor_editbox.Text = " ";
            
            BSub_editbox.Text = " ";
            BCopies_editbox.Text = " ";
            BAvailable_editbox.Text = " ";
            //data_grid_populate_karna_function();
            Cmd.Dispose();
            Con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            books_panel.Visible = true;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            students_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string B_Code = code_textBox.Text;
                string B_Name = name_textBox.Text;
                string B_Author = author_textBox.Text;
                string B_Publication = addbook_publication.Text;
                string B_Subject = subject_textBox.Text;
                string B_Copies = copies_textBox.Text;
                string B_Available = Available_textBox.Text;

                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Insert into Book_Data values (@a,@b,@c,@d,@e,@f,@g)", Con);
                Cmd.Parameters.AddWithValue("@a", B_Code);
                Cmd.Parameters.AddWithValue("@b", B_Name);
                Cmd.Parameters.AddWithValue("@c", B_Author);
                Cmd.Parameters.AddWithValue("@d", B_Publication);
                Cmd.Parameters.AddWithValue("@e", B_Subject);
                Cmd.Parameters.AddWithValue("@f", B_Copies);
                Cmd.Parameters.AddWithValue("@g", B_Available);

                Cmd.ExecuteNonQuery();
                MessageBox.Show("New Book Record Added Successfully!");
                code_textBox.Text = " ";
                name_textBox.Text = " ";
                author_textBox.Text = " ";
                subject_textBox.Text = " ";
                copies_textBox.Text = " ";
                Available_textBox.Text = " ";

                Cmd.Dispose();
                Con.Close();
            }
            catch
            {
                MessageBox.Show(this, "Invalid Book Code. It must be unique for each Book", "Book Addition Failed", MessageBoxButtons.OK);

            }
        }

        private void backbutton_Click_1(object sender, EventArgs e)
        {
            books_panel.Visible = true;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            students_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Books_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        private void data_grid_populate_function()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select *from Book_Data", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            Books_Grid.DataSource = null;
            Books_Grid.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string B_Code = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string B_Name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string B_Author = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string B_Publication = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string B_Subject = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string B_Copies = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string B_Available = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                
                DataGridViewRow abc = new DataGridViewRow();
                abc.CreateCells(Books_Grid);
                abc.Cells[0].Value = B_Code;
                abc.Cells[1].Value = B_Name;
                abc.Cells[2].Value = B_Author;
                abc.Cells[3].Value = B_Publication;
                abc.Cells[4].Value = B_Subject;
                abc.Cells[5].Value = B_Copies;
                abc.Cells[6].Value = B_Available;

                Books_Grid.Rows.Add(abc);
            }

            Cmd.Dispose();
            Con.Close();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string S_Registraion = SReg_textBox.Text;
                string S_Name = SName_textBox.Text;
                string S_Depertment = SDep_textBox.Text;
                string S_Semester = SSem_textBox.Text;
                string S_Contact = SCon_textBox.Text;
                string S_Email = SEmail_textBox.Text;
                string S_Address = SAddr_textBox.Text;
                string S_Username = SUser_textbox.Text;
                string S_Password = SPassword_textbox.Text;
                SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Insert into Student_Data values (@a,@b,@c,@d,@e,@f,@g)", Con);
                Cmd.Parameters.AddWithValue("@a", S_Registraion);
                Cmd.Parameters.AddWithValue("@b", S_Name);
                Cmd.Parameters.AddWithValue("@c", S_Depertment);
                Cmd.Parameters.AddWithValue("@d", S_Semester);
                Cmd.Parameters.AddWithValue("@e", S_Contact);
                Cmd.Parameters.AddWithValue("@f", S_Email);
                Cmd.Parameters.AddWithValue("@g", S_Address);
                Cmd.ExecuteNonQuery();


                SqlCommand Cmd1 = new SqlCommand("Insert into S_Login_Data values (@a,@b,@c)", Con);
                Cmd1.Parameters.AddWithValue("@a", S_Registraion);
                Cmd1.Parameters.AddWithValue("@b", S_Username);
                Cmd1.Parameters.AddWithValue("@c", S_Password);
                Cmd1.ExecuteNonQuery();

                MessageBox.Show("New Student Record Added Successfully!");
                SReg_textBox.Text = " ";
                SName_textBox.Text = " ";
                SDep_textBox.Text = " ";
                SSem_textBox.Text = " ";
                SCon_textBox.Text = " ";
                SEmail_textBox.Text = " ";
                SAddr_textBox.Text = " ";
                SUser_textbox.Text = " ";
                SPassword_textbox.Text = " ";
                //data_grid_populate_karna_function();
                //red();
                Cmd.Dispose();
                Con.Close();
            }
            catch
            {
                MessageBox.Show(this, "Invalid Registrartion Noumber. It must be unique for each student", "Student Addition Failed", MessageBoxButtons.OK);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            students_panel.Visible = true;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        public void abc()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            con.Open();
            //edit_combobox.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select S_Reg from Student_Data";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                edit_combobox.Items.Add(item["S_Reg"].ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void Search_edit_Button_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();
            //con.Close();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Student_Data where S_Reg =@a";
            cmd.Parameters.AddWithValue("@a", edit_combobox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                SReg_editbox.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                SName_editbox.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                SDep_editbox.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                SSems_editbox.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                SContact_editbox.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                SEmail_editbox.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                SAddr_editbox.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            else
            {
                MessageBox.Show("This Book is not available.\nEnter Correct 'Book Code' to search data");
                return;
            }
            
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void Edit_Save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("Update Student_Data set S_Reg =@a,S_Name=@b,S_Department=@c,S_Semester=@d,S_Contact=@e,S_Email=@f,S_Address=@g where S_Reg=@a", Con);

            Cmd.Parameters.AddWithValue("@a", SReg_editbox.Text);
            Cmd.Parameters.AddWithValue("@b", SName_editbox.Text);
            Cmd.Parameters.AddWithValue("@c", SDep_editbox.Text);
            Cmd.Parameters.AddWithValue("@d", SSems_editbox.Text);
            Cmd.Parameters.AddWithValue("@e", SContact_editbox.Text);
            Cmd.Parameters.AddWithValue("@f", SEmail_editbox.Text);
            Cmd.Parameters.AddWithValue("@g", SAddr_editbox.Text);
            Cmd.ExecuteNonQuery();

            MessageBox.Show("Student Record Updated Successfully!");
            SReg_editbox.Text = " ";
            SName_editbox.Text = " ";
            SDep_editbox.Text = " ";
            SSems_editbox.Text = " ";
            SContact_editbox.Text = " ";
            SEmail_editbox.Text = " ";
            SAddr_editbox.Text = " ";
            //data_grid_populate_karna_function();
            Cmd.Dispose();
            Con.Close();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            students_panel.Visible = true;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        public void deletestudent_combo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            con.Open();
            deletestudent_combobox.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select S_Reg from Student_Data";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                deletestudent_combobox.Items.Add(item["S_Reg"].ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Search_studel_Button_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select *from Student_Data where S_Reg =@a", Con);
            Cmd.Parameters.AddWithValue("@a", deletestudent_combobox.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                SReg_delbox.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                SName_delbox.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                SDep_delbox.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                SSem_delbox.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                SCon_delbox.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                SEmail_delbox.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                SAddr_delbox.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }
            else
            {
                MessageBox.Show("This Book is not available.\nEnter Correct 'Book Code' to search data");
                return;
            }
            Con.Close();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("Delete from Student_Data where  S_Reg=@a ", Con);
            Cmd.Parameters.AddWithValue("@a", SReg_delbox.Text);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Student Record Deleted Successfully!");
            SReg_delbox.Text = " ";
            SName_delbox.Text = " ";
            SDep_delbox.Text = " ";
            SSem_delbox.Text = " ";
            SCon_delbox.Text = " ";
            SEmail_delbox.Text = " ";
            SAddr_delbox.Text = " ";
            //data_grid_populate_karna_function();
            Cmd.Dispose();
            Con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            students_panel.Visible = true;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }
        private void data_grid_function()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            SqlCommand Cmd = new SqlCommand("select *from Student_Data", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            student_grid.DataSource = null;
            student_grid.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string S_Name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string S_Reg = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string S_Dep = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string S_Sem = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string S_Con = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string S_Email = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string S_Addr = ds.Tables[0].Rows[i].ItemArray[6].ToString();

                DataGridViewRow abc = new DataGridViewRow();
                abc.CreateCells(student_grid);
                abc.Cells[0].Value = S_Name;
                abc.Cells[1].Value = S_Reg;
                abc.Cells[2].Value = S_Dep;
                abc.Cells[3].Value = S_Sem;
                abc.Cells[4].Value = S_Con;
                abc.Cells[5].Value = S_Email;
                abc.Cells[6].Value = S_Addr;

                student_grid.Rows.Add(abc);
            }
        }
        private void data_grid_issue_function()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();

            
            SqlCommand Cmd = new SqlCommand("select *from B_IssueReturn where returndate=''", Con);
            //SqlCommand Cmd2 = new SqlCommand("select DATEDIFF(DD,Approximate_return,GETDATE()) as latedays from B_IssueReturn", Con);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            //SqlDataAdapter adapter2 = new SqlDataAdapter(Cmd2);
            DataSet ds = new DataSet();
            //DataSet ds2 = new DataSet();
            adapter.Fill(ds);
            //adapter.Fill(ds2);

            issue_data_grid.DataSource = null;
            issue_data_grid.Rows.Clear();
            for (int i = 0 ;( i < ds.Tables[0].Rows.Count); i++)
            {
                string B_Code = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string B_Name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string S_Reg = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string S_Name = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string L_ID = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string L_Name = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string Issue_Date = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                string Return_Date = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                string Approximate_Date = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                string late_days = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                string penalty = ds.Tables[0].Rows[i].ItemArray[10].ToString();

                DataGridViewRow abc = new DataGridViewRow();
                abc.CreateCells(issue_data_grid);
                abc.Cells[0].Value = B_Code;
                abc.Cells[1].Value = B_Name;
                abc.Cells[2].Value = S_Reg;
                abc.Cells[3].Value = S_Name;
                abc.Cells[4].Value = L_ID;
                abc.Cells[5].Value = L_Name;
                abc.Cells[6].Value = Issue_Date;
                abc.Cells[7].Value = Return_Date;
                abc.Cells[8].Value = Approximate_Date;
                abc.Cells[9].Value = late_days;
                abc.Cells[10].Value = penalty;
                issue_data_grid.Rows.Add(abc);
            }
            
            Cmd.Dispose();
            Con.Close();
            
            /*
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            con.Open();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("BCode");
            dt.Columns.Add("BName");
            dt.Columns.Add("SRegNo");
            dt.Columns.Add("SName");
            dt.Columns.Add("LID");
            dt.Columns.Add("LName");
            dt.Columns.Add("issuedate");
            dt.Columns.Add("returndate");
            dt.Columns.Add("Approximate_Return");
            dt.Columns.Add("latedays");

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select *from B_IssueReturn ";
            cmd1.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt);

            foreach(DataRow dr1 in dt.Rows)
            {
                DataRow dr = dt.NewRow();
                dr["BCode"] = dr1["BCode"].ToString();
                dr["BName"] = dr1["BName"].ToString();
                dr["SRegNo"] = dr1["SRegNo"].ToString();
                dr["SName"] = dr1["SName"].ToString();
                dr["LID"] = dr1["LID"].ToString();
                dr["LName"] = dr1["LName"].ToString();
                dr["issuedate"] = dr1["issuedate"].ToString();
                dr["returndate"] = dr1["returndate"].ToString();
                dr["Approximate_Return"] = dr1["Approximate_Return"].ToString();


                //string d1 = DateTime.Parse(System.DateTime.Now.ToShortDateString().ToString("yyyy/MM/dd"));
                DateTime d1 = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
                DateTime d2 = Convert.ToDateTime(dr1["Approximate_Return"].ToString());

                DateTime dat= dr1["Approximate_Return"]
                d2 =DateTime.Parse("yyyy/MM/dd");
                if (d1>d2)
                {
                    TimeSpan t = d1 - d2;
                    double noofdays = t.TotalDays;
                    dr["latedays"] = noofdays.ToString();
                    
                }
                else
                {
                    dr["latedays"] = "0";
                }
                dt.Rows.Add(dr);
            }
            issue_data_grid.DataSource = dt;
            issue_data_grid.ReadOnly = true;*/
            //issue_data_grid.DataSource=*/
        }

        /*private void data_grid_returned_function()
        {
            SqlConnection Con1 = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con1.Open();


            SqlCommand Cmd1 = new SqlCommand("select *from B_IssueReturn where returndate=''", Con1);
            //SqlCommand Cmd2 = new SqlCommand("select DATEDIFF(DD,Approximate_return,GETDATE()) as latedays from B_IssueReturn", Con);
            SqlDataAdapter adapter1 = new SqlDataAdapter(Cmd1);
            //SqlDataAdapter adapter2 = new SqlDataAdapter(Cmd2);
            DataSet ds1 = new DataSet();
            //DataSet ds2 = new DataSet();
            adapter1.Fill(ds1);
            //adapter.Fill(ds2);

            data_grid_returned.DataSource = null;
            data_grid_returned.Rows.Clear();
            for (int i = 0; (i < ds1.Tables[0].Rows.Count); i++)
            {
                string BCode = ds1.Tables[0].Rows[i].ItemArray[0].ToString();
                string BName = ds1.Tables[0].Rows[i].ItemArray[1].ToString();
                string SReg = ds1.Tables[0].Rows[i].ItemArray[2].ToString();
                string SName = ds1.Tables[0].Rows[i].ItemArray[3].ToString();
                string LID = ds1.Tables[0].Rows[i].ItemArray[4].ToString();
                string LName = ds1.Tables[0].Rows[i].ItemArray[5].ToString();
                string IssueDate = ds1.Tables[0].Rows[i].ItemArray[6].ToString();
                string ReturnDate = ds1.Tables[0].Rows[i].ItemArray[7].ToString();
                string ApproximateDate = ds1.Tables[0].Rows[i].ItemArray[8].ToString();
                string latedays = ds1.Tables[0].Rows[i].ItemArray[9].ToString();
                string penalty = ds1.Tables[0].Rows[i].ItemArray[10].ToString();

                DataGridViewRow abcd = new DataGridViewRow();
                abcd.CreateCells(data_grid_returned);
                abcd.Cells[0].Value = BCode;
                abcd.Cells[1].Value = BName;
                abcd.Cells[2].Value = SReg;
                abcd.Cells[3].Value = SName;
                abcd.Cells[4].Value = LID;
                abcd.Cells[5].Value = LName;
                abcd.Cells[6].Value = IssueDate;
                abcd.Cells[7].Value = ReturnDate;
                abcd.Cells[8].Value = ApproximateDate;
                abcd.Cells[9].Value = latedays;
                abcd.Cells[10].Value = penalty;
               data_grid_returned.Rows.Add(abcd);
            }

            Cmd1.Dispose();
            Con1.Close();
        }*/

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_book_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            students_panel.Visible = true;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            books_panel.Visible = true;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            students_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;

        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            edit_password_panel.Visible = true;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            students_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            penalty_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }

        private void Librarian_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();
            int count = 0;
            SqlCommand Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText="select *from L_Penalty";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                SqlCommand Cmd1 = Con.CreateCommand();
                Cmd1.CommandType = CommandType.Text;
                Cmd1.CommandText = "Insert into L_Penalty values('"+Penalty_textbox.Text+"')";
                Cmd1.ExecuteNonQuery();
                MessageBox.Show(this, "Penalty price updated successfully", "Price Updation", MessageBoxButtons.OK);
            }
            else
            {
                SqlCommand Cmd1 = Con.CreateCommand();
                Cmd1.CommandType = CommandType.Text;
                Cmd1.CommandText = "Update L_Penalty set Penalty ='" + Penalty_textbox.Text + "'";
                Cmd1.ExecuteNonQuery();
                MessageBox.Show(this, "Penalty price updated successfully", "Price Updation", MessageBoxButtons.OK);
            }



        }

        private void penalty_btn_Click(object sender, EventArgs e)
        {
            penalty_panel.Visible = true;
            return_books_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            students_panel.Visible = false;
            dashboard_panel.Visible = false;
            personal_panel.Visible = false;
            books_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            student_delete_panel.Visible = false;
            all_students_panel.Visible = false;
            edit_password_panel.Visible = false;
            alltransaction_panel.Visible = false;
            transaction_Panel.Visible = false;
        }
        private void returngri()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();
            SqlCommand cmd5 = Con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select *from B_IssueReturn where returndate NOT LIKE '%1900-01-01%'";
            cmd5.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            da.Fill(dt);
            return_grid.DataSource = dt;
        }
        public void alltransaction()
        {
            SqlConnection Con = new SqlConnection("Data Source=DESKTOP-ULMTKBS\\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
            Con.Open();
            SqlCommand cmd5 = Con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select * from B_IssueReturn ";
            cmd5.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            da.Fill(dt);
            alltransaction_grid.DataSource = dt;

        }

        private void alltransactionbutton_Click(object sender, EventArgs e)
        {
            if (issuetransaction.Checked)
            {
                issuedbooks_panel.Visible = true;
                add_student_panel.Visible = false;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                edit_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
           /*
               if (returnedtransaction.Checked)
            {
                returngri();
                return_books_panel.Visible = true;
                edit_student_panel.Visible = false;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                student_delete_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                alltransaction_panel.Visible = false;
                transaction_Panel.Visible = false;
            }*/
            if (alltransation.Checked)
            {
                alltransaction_panel.Visible = true;
                student_delete_panel.Visible = false;
                students_panel.Visible = false;
                books_panel.Visible = false;
                personal_panel.Visible = false;
                dashboard_panel.Visible = false;
                edi_book_panel.Visible = false;
                book_del_panel.Visible = false;
                add_book_panel.Visible = false;
                all_books_panel.Visible = false;
                add_student_panel.Visible = false;
                edit_student_panel.Visible = false;
                all_students_panel.Visible = false;
                issuedbooks_panel.Visible = false;
                return_books_panel.Visible = false;
                edit_password_panel.Visible = false;
                penalty_panel.Visible = false;
                transaction_Panel.Visible = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            transaction_Panel.Visible = true;
            alltransaction_panel.Visible = false;
            student_delete_panel.Visible = false;
            students_panel.Visible = false;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            transaction_Panel.Visible = true;
            alltransaction_panel.Visible = false;
            student_delete_panel.Visible = false;
            students_panel.Visible = false;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            transaction_Panel.Visible = true;
            alltransaction_panel.Visible = false;
            student_delete_panel.Visible = false;
            students_panel.Visible = false;
            books_panel.Visible = false;
            personal_panel.Visible = false;
            dashboard_panel.Visible = false;
            edi_book_panel.Visible = false;
            book_del_panel.Visible = false;
            add_book_panel.Visible = false;
            all_books_panel.Visible = false;
            add_student_panel.Visible = false;
            edit_student_panel.Visible = false;
            all_students_panel.Visible = false;
            issuedbooks_panel.Visible = false;
            return_books_panel.Visible = false;
            edit_password_panel.Visible = false;
            penalty_panel.Visible = false;
        }

        private void transaction_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

