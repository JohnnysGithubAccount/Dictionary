using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\UsingSpace\Programing Languages Learning\C# Programming\HCMUTE Projects\DataStructureAndAlgorithm\Dictionary\DictionaryApplication.mdf"";Integrated Security=True;Connect Timeout=30");
        private string email;
        public Form1(string email)
        {
            this.email = email;
            InitializeComponent();
            login_email.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
            
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_signInBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (login_email.Text == ""
                || login_password.Text == "")
                {
                    MessageBox.Show(
                        "Please fill in all the blanks",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }   
                else
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM account WHERE " +
                            "email = @email " +
                            "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@email", login_email.Text);
                            cmd.Parameters.AddWithValue("@password", login_password.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count == 1)
                            {
                                string email = table.Rows[0]["email"].ToString();
                                string id = table.Rows[0]["userID"].ToString();
                                string username = table.Rows[0]["username"].ToString();
                                MessageBox.Show(
                                    "Login sucessfully",
                                    "Information Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                //manager - 1000; user - 2000
                                if (id == "2000")
                                {
                                    Main mainFormUser = new Main(email);
                                    mainFormUser.Show();
                                    this.Hide();
                                }
                                else if (id == "1000")
                                {
                                    MainManagingForm mainFormManager = new MainManagingForm();
                                    mainFormManager.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "Unidentified account",
                                        "Error Message",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Wrong password",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error " + ex,
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void login_signUpBtn_Click(object sender, EventArgs e)
        {
            Registering registering = new Registering();
            registering.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
