namespace Final_Project_Individual
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skills_international = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.clear1btn = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // skills_international
            // 
            this.skills_international.AutoSize = true;
            this.skills_international.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.skills_international.Location = new System.Drawing.Point(306, 197);
            this.skills_international.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skills_international.Name = "skills_international";
            this.skills_international.Size = new System.Drawing.Size(442, 56);
            this.skills_international.TabIndex = 6;
            this.skills_international.Text = "Skills International";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.loginbtn);
            this.GroupBox1.Controls.Add(this.clear1btn);
            this.GroupBox1.Controls.Add(this.passwordtxt);
            this.GroupBox1.Controls.Add(this.usernametxt);
            this.GroupBox1.Controls.Add(this.password);
            this.GroupBox1.Controls.Add(this.username);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.Location = new System.Drawing.Point(315, 257);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Size = new System.Drawing.Size(403, 298);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Login";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(298, 248);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(68, 28);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // clear1btn
            // 
            this.clear1btn.Location = new System.Drawing.Point(34, 248);
            this.clear1btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear1btn.Name = "clear1btn";
            this.clear1btn.Size = new System.Drawing.Size(68, 28);
            this.clear1btn.TabIndex = 7;
            this.clear1btn.Text = "Clear";
            this.clear1btn.UseVisualStyleBackColor = true;
            this.clear1btn.Click += new System.EventHandler(this.clear1btn_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.passwordtxt.Location = new System.Drawing.Point(176, 129);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(191, 30);
            this.passwordtxt.TabIndex = 6;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(176, 77);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(191, 30);
            this.usernametxt.TabIndex = 5;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.password.Location = new System.Drawing.Point(31, 129);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(97, 23);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(31, 77);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(101, 23);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(414, 20);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(166, 176);
            this.PictureBox.TabIndex = 4;
            this.PictureBox.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.exitbtn.Location = new System.Drawing.Point(315, 560);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(68, 29);
            this.exitbtn.TabIndex = 7;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 609);
            this.Controls.Add(this.skills_international);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.exitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Login - Skills International";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label skills_international;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button loginbtn;
        internal System.Windows.Forms.Button clear1btn;
        internal System.Windows.Forms.TextBox passwordtxt;
        internal System.Windows.Forms.TextBox usernametxt;
        internal System.Windows.Forms.Label password;
        internal System.Windows.Forms.Label username;
        internal System.Windows.Forms.PictureBox PictureBox;
        internal System.Windows.Forms.Button exitbtn;
    }
}

