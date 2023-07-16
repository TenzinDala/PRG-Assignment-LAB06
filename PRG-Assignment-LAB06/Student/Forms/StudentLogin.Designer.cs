namespace PRG_Assignment_LAB06.Student
{
    partial class StudentLogin
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
            this.textBoxStudentPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStudentPassword
            // 
            this.textBoxStudentPassword.Location = new System.Drawing.Point(317, 324);
            this.textBoxStudentPassword.Name = "textBoxStudentPassword";
            this.textBoxStudentPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(297, 254);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(143, 33);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(317, 196);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 9;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentID.Location = new System.Drawing.Point(297, 137);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(151, 33);
            this.lblStudentID.TabIndex = 8;
            this.lblStudentID.Text = "Student ID";
            // 
            // textBoxStudentUserName
            // 
            this.textBoxStudentUserName.Location = new System.Drawing.Point(317, 93);
            this.textBoxStudentUserName.Name = "textBoxStudentUserName";
            this.textBoxStudentUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentUserName.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(297, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(155, 33);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "UserName";
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Location = new System.Drawing.Point(317, 384);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(112, 32);
            this.btnStudentLogin.TabIndex = 12;
            this.btnStudentLogin.Text = "Login";
            this.btnStudentLogin.UseVisualStyleBackColor = true;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentLogin);
            this.Controls.Add(this.textBoxStudentPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.textBoxStudentUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox textBoxStudentUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnStudentLogin;
    }
}