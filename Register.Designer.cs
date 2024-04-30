namespace WinFormsApp2
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            signupLabel1 = new Label();
            signupLabel2 = new Label();
            signupLabel3 = new Label();
            signupLabel4 = new Label();
            signupLabel5 = new Label();
            signupLabel6 = new Label();
            regTextBox1 = new TextBox();
            regTextBox2 = new TextBox();
            regTextBox3 = new TextBox();
            regTextBox4 = new TextBox();
            signUpButton = new Button();
            signupLinkedLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // signupLabel1
            // 
            signupLabel1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel1.Location = new Point(136, 32);
            signupLabel1.Name = "signupLabel1";
            signupLabel1.Size = new Size(82, 25);
            signupLabel1.TabIndex = 12;
            signupLabel1.Text = "Sign up to App";
            signupLabel1.Click += signupLabel1_Click;
            // 
            // signupLabel2
            // 
            signupLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel2.Location = new Point(50, 83);
            signupLabel2.Name = "signupLabel2";
            signupLabel2.Size = new Size(184, 22);
            signupLabel2.TabIndex = 23;
            signupLabel2.Text = "Full Name";
            signupLabel2.Click += signupLabel2_Click;
            // 
            // signupLabel3
            // 
            signupLabel3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel3.Location = new Point(50, 141);
            signupLabel3.Name = "signupLabel3";
            signupLabel3.Size = new Size(248, 22);
            signupLabel3.TabIndex = 13;
            signupLabel3.Text = "Email address";
            signupLabel3.Click += signupLabel3_Click;
            // 
            // signupLabel4
            // 
            signupLabel4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel4.Location = new Point(50, 199);
            signupLabel4.Name = "signupLabel4";
            signupLabel4.Size = new Size(168, 22);
            signupLabel4.TabIndex = 21;
            signupLabel4.Text = "Username";
            signupLabel4.Click += signupLabel4_Click;
            // 
            // signupLabel5
            // 
            signupLabel5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLabel5.Location = new Point(50, 257);
            signupLabel5.Name = "signupLabel5";
            signupLabel5.Size = new Size(248, 20);
            signupLabel5.TabIndex = 14;
            signupLabel5.Text = "Password";
            signupLabel5.Click += signupLabel5_Click;
            // 
            // signupLabel6
            // 
            signupLabel6.AutoSize = true;
            signupLabel6.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupLabel6.Location = new Point(85, 410);
            signupLabel6.Name = "signupLabel6";
            signupLabel6.Size = new Size(175, 15);
            signupLabel6.TabIndex = 20;
            signupLabel6.Text = "Already have an account?";
            signupLabel6.Click += signupLabel6_Click;
            // 
            // regTextBox1
            // 
            regTextBox1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regTextBox1.Location = new Point(50, 108);
            regTextBox1.Name = "regTextBox1";
            regTextBox1.PlaceholderText = "Name";
            regTextBox1.Size = new Size(248, 30);
            regTextBox1.TabIndex = 24;
            regTextBox1.TextChanged += regTextBox1_TextChanged;
            // 
            // regTextBox2
            // 
            regTextBox2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regTextBox2.Location = new Point(50, 166);
            regTextBox2.Name = "regTextBox2";
            regTextBox2.PlaceholderText = "name@domain.com";
            regTextBox2.Size = new Size(248, 30);
            regTextBox2.TabIndex = 15;
            regTextBox2.TextChanged += regTextBox2_TextChanged;
            // 
            // regTextBox3
            // 
            regTextBox3.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regTextBox3.Location = new Point(50, 224);
            regTextBox3.Name = "regTextBox3";
            regTextBox3.PlaceholderText = "Username";
            regTextBox3.Size = new Size(248, 30);
            regTextBox3.TabIndex = 22;
            regTextBox3.TextChanged += regTextBox3_TextChanged;
            // 
            // regTextBox4
            // 
            regTextBox4.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            regTextBox4.Location = new Point(50, 280);
            regTextBox4.Name = "regTextBox4";
            regTextBox4.PlaceholderText = "Create a password";
            regTextBox4.Size = new Size(248, 30);
            regTextBox4.TabIndex = 16;
            regTextBox4.TextChanged += regTextBox4_TextChanged;
            // 
            // signUpButton
            // 
            signUpButton.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signUpButton.Location = new Point(67, 325);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(212, 55);
            signUpButton.TabIndex = 18;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // signupLinkedLabel1
            // 
            signupLinkedLabel1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupLinkedLabel1.Location = new Point(127, 425);
            signupLinkedLabel1.Name = "signupLinkedLabel1";
            signupLinkedLabel1.Size = new Size(91, 20);
            signupLinkedLabel1.TabIndex = 19;
            signupLinkedLabel1.TabStop = true;
            signupLinkedLabel1.Text = "Log in here.";
            signupLinkedLabel1.LinkClicked += signupLinkedLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(349, 461);
            Controls.Add(signupLabel1);
            Controls.Add(signupLabel2);
            Controls.Add(signupLabel3);
            Controls.Add(signupLabel4);
            Controls.Add(signupLabel5);
            Controls.Add(signupLabel6);
            Controls.Add(regTextBox1);
            Controls.Add(regTextBox2);
            Controls.Add(regTextBox3);
            Controls.Add(regTextBox4);
            Controls.Add(signUpButton);
            Controls.Add(signupLinkedLabel1);
            Name = "Register";
            Text = "App";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label signupLabel1;
        private System.Windows.Forms.Label signupLabel2;
        private System.Windows.Forms.Label signupLabel3;
        private System.Windows.Forms.Label signupLabel4;
        private System.Windows.Forms.Label signupLabel5;
        private System.Windows.Forms.Label signupLabel6;
        private System.Windows.Forms.TextBox regTextBox1;
        private System.Windows.Forms.TextBox regTextBox2;
        private System.Windows.Forms.TextBox regTextBox3;
        private System.Windows.Forms.TextBox regTextBox4;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.LinkLabel signupLinkedLabel1;
    }
}