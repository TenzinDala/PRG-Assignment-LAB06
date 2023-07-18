namespace PRG_Assignment_LAB06.Teacher
{
    partial class TeacherLogin
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.textBoxTeacherUserName = new System.Windows.Forms.TextBox();
            this.textBoxTeacherPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(293, 66);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 33);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // textBoxTeacherUserName
            // 
            this.textBoxTeacherUserName.Location = new System.Drawing.Point(313, 131);
            this.textBoxTeacherUserName.Name = "textBoxTeacherUserName";
            this.textBoxTeacherUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacherUserName.TabIndex = 1;
            // 
            // textBoxTeacherPassword
            // 
            this.textBoxTeacherPassword.Location = new System.Drawing.Point(313, 266);
            this.textBoxTeacherPassword.Name = "textBoxTeacherPassword";
            this.textBoxTeacherPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacherPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(293, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 33);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTeacherLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLogin.Location = new System.Drawing.Point(313, 330);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(123, 41);
            this.btnTeacherLogin.TabIndex = 6;
            this.btnTeacherLogin.Text = "SignIn";
            this.btnTeacherLogin.UseVisualStyleBackColor = false;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // TeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeacherLogin);
            this.Controls.Add(this.textBoxTeacherPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBoxTeacherUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "TeacherLogin";
            this.Text = "TeacherLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox textBoxTeacherUserName;
        private System.Windows.Forms.TextBox textBoxTeacherPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnTeacherLogin;
    }
}