namespace DigitalDairy
{
    partial class DigitalDiary
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
            this.groupBox1LogIn = new System.Windows.Forms.GroupBox();
            this.label1UserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2Password = new System.Windows.Forms.Label();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.button1Login = new System.Windows.Forms.Button();
            this.groupBox1LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1LogIn
            // 
            this.groupBox1LogIn.Controls.Add(this.button1Login);
            this.groupBox1LogIn.Controls.Add(this.textBox2Password);
            this.groupBox1LogIn.Controls.Add(this.label2Password);
            this.groupBox1LogIn.Controls.Add(this.textBox1);
            this.groupBox1LogIn.Controls.Add(this.label1UserName);
            this.groupBox1LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1LogIn.Location = new System.Drawing.Point(82, 43);
            this.groupBox1LogIn.Name = "groupBox1LogIn";
            this.groupBox1LogIn.Size = new System.Drawing.Size(494, 268);
            this.groupBox1LogIn.TabIndex = 0;
            this.groupBox1LogIn.TabStop = false;
            this.groupBox1LogIn.Text = "Log In";
            // 
            // label1UserName
            // 
            this.label1UserName.AutoSize = true;
            this.label1UserName.Location = new System.Drawing.Point(28, 79);
            this.label1UserName.Name = "label1UserName";
            this.label1UserName.Size = new System.Drawing.Size(144, 29);
            this.label1UserName.TabIndex = 0;
            this.label1UserName.Text = "User Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2Password
            // 
            this.label2Password.AutoSize = true;
            this.label2Password.Location = new System.Drawing.Point(28, 146);
            this.label2Password.Name = "label2Password";
            this.label2Password.Size = new System.Drawing.Size(128, 29);
            this.label2Password.TabIndex = 2;
            this.label2Password.Text = "Password";
            this.label2Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2Password
            // 
            this.textBox2Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Password.Location = new System.Drawing.Point(197, 146);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.PasswordChar = '*';
            this.textBox2Password.Size = new System.Drawing.Size(251, 30);
            this.textBox2Password.TabIndex = 4;
            // 
            // button1Login
            // 
            this.button1Login.Location = new System.Drawing.Point(197, 204);
            this.button1Login.Name = "button1Login";
            this.button1Login.Size = new System.Drawing.Size(110, 45);
            this.button1Login.TabIndex = 5;
            this.button1Login.Text = "LogIn";
            this.button1Login.UseVisualStyleBackColor = true;
            this.button1Login.Click += new System.EventHandler(this.button1Login_Click);
            // 
            // DigitalDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 351);
            this.Controls.Add(this.groupBox1LogIn);
            this.Name = "DigitalDiary";
            this.Text = "Digital Diary";
            this.groupBox1LogIn.ResumeLayout(false);
            this.groupBox1LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1LogIn;
        private System.Windows.Forms.Label label2Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1UserName;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Button button1Login;
    }
}

