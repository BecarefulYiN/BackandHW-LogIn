
namespace LogInForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Email = new Label();
            label2 = new Label();
            txtPasswords = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(251, 139);
            Email.Name = "Email";
            Email.Size = new Size(46, 20);
            Email.TabIndex = 0;
            Email.Text = "Email";
            Email.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 191);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Passwords";
            // 
            // txtPasswords
            // 
            txtPasswords.Location = new Point(333, 188);
            txtPasswords.Name = "txtPasswords";
            txtPasswords.Size = new Size(222, 27);
            txtPasswords.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(333, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 27);
            txtEmail.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(274, 277);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(444, 277);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 36);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtPasswords);
            Controls.Add(label2);
            Controls.Add(Email);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Email;
        private Label label2;
        private TextBox txtPasswords;
        private TextBox txtEmail;
        private Button btnLogin;
        private Button btnClear;
    }
}
