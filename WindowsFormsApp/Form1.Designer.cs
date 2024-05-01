namespace WindowsFormsApp
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
            this.Username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(157, 79);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "UserName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(157, 144);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(147, 276);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(114, 39);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(343, 276);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(182, 34);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cancel;
    }
}