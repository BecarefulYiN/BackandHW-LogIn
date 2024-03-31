using System.DirectoryServices.ActiveDirectory;
using System.Web;

namespace LogInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public String _email = "example@gmail.com";
        public String _password = "1234";
        public int _countOfInvail = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPasswords.Text;

                //1.when email and password are null send error message
                //2. when email and passsword are incorrect send error message ("Please enter again")
                //3. when more than one sent message about ("Enter vaild email or password")

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all input ....", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (email.Equals(_email) && password.Equals(_password))
                    {
                        MessageBox.Show("LogIn successful");
                        _countOfInvail = 0;
                        Application.Exit();
                    }
                    else
                    {
                        while (!email.Equals(_email) || !password.Equals(_password))
                        {
                            if (_countOfInvail == 0)
                            {
                                MessageBox.Show("Plese enter again");
                                _countOfInvail++;
                                txtEmail.Text = "";
                                txtPasswords.Text = "";
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Enter the vaild email or passwords");
                                txtEmail.Text = "";
                                txtPasswords.Text = "";
                                return;
                            }
                        }
                    }
                }



            }
            catch
            {
                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPasswords.Text = "";
            txtEmail.Text = "";

        }
    }
}
