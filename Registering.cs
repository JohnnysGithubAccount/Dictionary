using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dictionary
{
    public partial class Registering : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\UsingSpace\Programing Languages Learning\C# Programming\HCMUTE Projects\DataStructureAndAlgorithm\Dictionary\DictionaryApplication.mdf"";Integrated Security=True;Connect Timeout=30");

        public Registering()
        {
            InitializeComponent();
        }

        public string checkPassword(string pass)
        {
            if (pass.Length < 8)
            {
                return "Your password length is less than 8 characters";
            }
            if (!pass.Any(char.IsUpper))
            {
                Console.Write("this is terrible");
                return "Your password need atleast one uppercase letter";
            }
            if (pass.Contains(" "))
            {
                return "There should not be any space in your password";
            }
            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();
            foreach (char ch in specialChArray)
            {
                if (pass.Contains(ch.ToString()))
                {
                    return "";
                }
            }
            return "Need at leat on special character in your password";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (registering_showpass.Checked)
            {
                registering_password.PasswordChar = '\0';
            }
            else
            {
                registering_password.PasswordChar = '*';
            }
        }

        private void registering_name_TextChanged(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
        }

        private void registering_signInBtn_Click(object sender, EventArgs e)
        {
            Form1 login_form = new Form1("");
            login_form.Show();
            this.Hide();
        }

        private void registering_signUpBtn_Click(object sender, EventArgs e)
        {
            if (registering_name.Text == ""
                || registering_password.Text == ""
                || registering_email.Text == "")
            {
                MessageBox.Show(
                    "Please fill in all the blanks",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
            }
            else if (checkPassword(registering_password.Text) != "")
            {
                MessageBox.Show(
                    checkPassword(registering_password.Text),
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string userEmail = "SELECT COUNT(id) FROM account " +
                            "WHERE email = @email";
                        using (SqlCommand cmd = new SqlCommand(userEmail, connect))
                        {
                            cmd.Parameters.AddWithValue("@email", registering_email.Text);
                            int count = (int)cmd.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(
                                    "Your account has already existed",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO account " +
                                    "(userID, username, email, password, date_register) " +
                                    "VALUES(@userID, @username, @email, @password, @dateReg)";
                                using (SqlCommand insertingCmd = new SqlCommand(insertData, connect))
                                {
                                    insertingCmd.Parameters.AddWithValue("@userID", 2000);
                                    insertingCmd.Parameters.AddWithValue("@username", registering_name.Text);
                                    insertingCmd.Parameters.AddWithValue("@email", registering_email.Text);
                                    insertingCmd.Parameters.AddWithValue("@password", registering_password.Text);
                                    insertingCmd.Parameters.AddWithValue("@dateReg", today);

                                    insertingCmd.ExecuteNonQuery();
                                    MessageBox.Show(
                                        "Register Successfully!",
                                        "Information Message",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1(registering_email.Text);
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error: " + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Registering_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
