namespace WinFormsApp2
{
    partial class Login
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
            loginLabel1 = new Label();
            loginLabel2 = new Label();
            loginLabel3 = new Label();
            loginLabel4 = new Label();
            logTextBox1 = new TextBox();
            logTextBox2 = new TextBox();
            logInButton = new Button();
            checkBox1 = new CheckBox();
            loginLinkedLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // loginLabel1
            // 
            loginLabel1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel1.Location = new Point(99, 49);
            loginLabel1.Name = "loginLabel1";
            loginLabel1.Size = new Size(147, 25);
            loginLabel1.TabIndex = 12;
            loginLabel1.Text = "Log in to App";
            loginLabel1.Click += loginLabel1_Click;
            // 
            // loginLabel2
            // 
            loginLabel2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel2.Location = new Point(50, 120);
            loginLabel2.Name = "loginLabel2";
            loginLabel2.Size = new Size(248, 22);
            loginLabel2.TabIndex = 13;
            loginLabel2.Text = "Email or username";
            loginLabel2.Click += loginLabel2_Click;
            // 
            // loginLabel3
            // 
            loginLabel3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel3.Location = new Point(50, 198);
            loginLabel3.Name = "loginLabel3";
            loginLabel3.Size = new Size(248, 20);
            loginLabel3.TabIndex = 14;
            loginLabel3.Text = "Password";
            loginLabel3.Click += loginLabel3_Click;
            // 
            // loginLabel4
            // 
            loginLabel4.AutoSize = true;
            loginLabel4.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLabel4.Location = new Point(85, 377);
            loginLabel4.Name = "loginLabel4";
            loginLabel4.Size = new Size(161, 15);
            loginLabel4.TabIndex = 20;
            loginLabel4.Text = "Don't have an account?";
            loginLabel4.Click += loginLabel4_Click;
            // 
            // logTextBox1
            // 
            logTextBox1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logTextBox1.Location = new Point(50, 145);
            logTextBox1.Name = "logTextBox1";
            logTextBox1.PlaceholderText = "Email or username";
            logTextBox1.Size = new Size(248, 30);
            logTextBox1.TabIndex = 15;
            logTextBox1.TextChanged += logTextBox1_TextChanged;
            // 
            // logTextBox2
            // 
            logTextBox2.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logTextBox2.Location = new Point(50, 221);
            logTextBox2.Name = "logTextBox2";
            logTextBox2.PlaceholderText = "Password";
            logTextBox2.Size = new Size(248, 30);
            logTextBox2.TabIndex = 16;
            logTextBox2.TextChanged += logTextBox2_TextChanged;
            // 
            // logInButton
            // 
            logInButton.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInButton.Location = new Point(67, 292);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(212, 55);
            logInButton.TabIndex = 18;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(50, 268);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 18);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginLinkedLabel1
            // 
            loginLinkedLabel1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLinkedLabel1.Location = new Point(111, 392);
            loginLinkedLabel1.Name = "loginLinkedLabel1";
            loginLinkedLabel1.Size = new Size(119, 20);
            loginLinkedLabel1.TabIndex = 19;
            loginLinkedLabel1.TabStop = true;
            loginLinkedLabel1.Text = "Sign up for App";
            loginLinkedLabel1.LinkClicked += loginLinkedLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(349, 461);
            Controls.Add(loginLabel1);
            Controls.Add(loginLabel2);
            Controls.Add(loginLabel3);
            Controls.Add(loginLabel4);
            Controls.Add(logTextBox1);
            Controls.Add(logTextBox2);
            Controls.Add(checkBox1);
            Controls.Add(logInButton);
            Controls.Add(loginLinkedLabel1);
            Name = "Login";
            Text = "App";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label loginLabel1;
        private System.Windows.Forms.Label loginLabel2;
        private System.Windows.Forms.Label loginLabel3;
        private System.Windows.Forms.Label loginLabel4;
        private System.Windows.Forms.TextBox logTextBox1;
        private System.Windows.Forms.TextBox logTextBox2;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel loginLinkedLabel1;
    }
}