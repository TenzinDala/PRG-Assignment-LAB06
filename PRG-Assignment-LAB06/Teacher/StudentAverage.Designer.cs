namespace PRG_Assignment_LAB06.Teacher
{
    partial class StudentAverage
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
            this.groupBoxStudentDetails = new System.Windows.Forms.GroupBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblTitleAverage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentDetails
            // 
            this.groupBoxStudentDetails.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBoxStudentDetails.Controls.Add(this.lblAverage);
            this.groupBoxStudentDetails.Controls.Add(this.lblTitleAverage);
            this.groupBoxStudentDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStudentDetails.Name = "groupBoxStudentDetails";
            this.groupBoxStudentDetails.Size = new System.Drawing.Size(749, 426);
            this.groupBoxStudentDetails.TabIndex = 0;
            this.groupBoxStudentDetails.TabStop = false;
            this.groupBoxStudentDetails.Text = "Student Details";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(19, 88);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(225, 31);
            this.lblAverage.TabIndex = 1;
            this.lblAverage.Text = "Student Average : ";
            // 
            // lblTitleAverage
            // 
            this.lblTitleAverage.AutoSize = true;
            this.lblTitleAverage.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAverage.Location = new System.Drawing.Point(15, 25);
            this.lblTitleAverage.Name = "lblTitleAverage";
            this.lblTitleAverage.Size = new System.Drawing.Size(268, 41);
            this.lblTitleAverage.TabIndex = 0;
            this.lblTitleAverage.Text = "Student Average";
            // 
            // StudentAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxStudentDetails);
            this.Name = "StudentAverage";
            this.Text = "StudentAverage";
            this.groupBoxStudentDetails.ResumeLayout(false);
            this.groupBoxStudentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentDetails;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTitleAverage;
        private System.Windows.Forms.Label lblAverage;
    }
}