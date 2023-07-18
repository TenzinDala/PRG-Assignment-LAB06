namespace PRG_Assignment_LAB06.Student
{
    partial class Question1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question1));
            this.lblTitleQ1 = new System.Windows.Forms.Label();
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.BarQ1 = new System.Windows.Forms.ProgressBar();
            this.lblTimeQ1 = new System.Windows.Forms.Label();
            this.picboxQ1 = new System.Windows.Forms.PictureBox();
            this.radio3Question1 = new System.Windows.Forms.RadioButton();
            this.radio2Question1 = new System.Windows.Forms.RadioButton();
            this.radio1Question1 = new System.Windows.Forms.RadioButton();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.btnQ1Submit = new System.Windows.Forms.Button();
            this.btnQ1Next = new System.Windows.Forms.Button();
            this.TimerQ1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxQ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQ1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleQ1
            // 
            this.lblTitleQ1.AutoSize = true;
            this.lblTitleQ1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleQ1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitleQ1.Location = new System.Drawing.Point(21, 20);
            this.lblTitleQ1.Name = "lblTitleQ1";
            this.lblTitleQ1.Size = new System.Drawing.Size(229, 48);
            this.lblTitleQ1.TabIndex = 0;
            this.lblTitleQ1.Text = "Question #1";
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.Controls.Add(this.BarQ1);
            this.groupBoxQ1.Controls.Add(this.lblTimeQ1);
            this.groupBoxQ1.Controls.Add(this.picboxQ1);
            this.groupBoxQ1.Controls.Add(this.radio3Question1);
            this.groupBoxQ1.Controls.Add(this.radio2Question1);
            this.groupBoxQ1.Controls.Add(this.radio1Question1);
            this.groupBoxQ1.Controls.Add(this.lblQuestion1);
            this.groupBoxQ1.Location = new System.Drawing.Point(29, 71);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Size = new System.Drawing.Size(693, 362);
            this.groupBoxQ1.TabIndex = 2;
            this.groupBoxQ1.TabStop = false;
            this.groupBoxQ1.Text = "Question 1";
            // 
            // BarQ1
            // 
            this.BarQ1.Location = new System.Drawing.Point(378, 304);
            this.BarQ1.Maximum = 10;
            this.BarQ1.Name = "BarQ1";
            this.BarQ1.Size = new System.Drawing.Size(262, 43);
            this.BarQ1.TabIndex = 6;
            // 
            // lblTimeQ1
            // 
            this.lblTimeQ1.AutoSize = true;
            this.lblTimeQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeQ1.Location = new System.Drawing.Point(34, 318);
            this.lblTimeQ1.Name = "lblTimeQ1";
            this.lblTimeQ1.Size = new System.Drawing.Size(154, 29);
            this.lblTimeQ1.TabIndex = 5;
            this.lblTimeQ1.Text = "Time Left => ";
            // 
            // picboxQ1
            // 
            this.picboxQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxQ1.Image = ((System.Drawing.Image)(resources.GetObject("picboxQ1.Image")));
            this.picboxQ1.Location = new System.Drawing.Point(11, 53);
            this.picboxQ1.Name = "picboxQ1";
            this.picboxQ1.Size = new System.Drawing.Size(263, 90);
            this.picboxQ1.TabIndex = 4;
            this.picboxQ1.TabStop = false;
            // 
            // radio3Question1
            // 
            this.radio3Question1.AutoSize = true;
            this.radio3Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3Question1.Location = new System.Drawing.Point(39, 258);
            this.radio3Question1.Name = "radio3Question1";
            this.radio3Question1.Size = new System.Drawing.Size(182, 33);
            this.radio3Question1.TabIndex = 3;
            this.radio3Question1.TabStop = true;
            this.radio3Question1.Text = "C) Result = 15";
            this.radio3Question1.UseVisualStyleBackColor = true;
            // 
            // radio2Question1
            // 
            this.radio2Question1.AutoSize = true;
            this.radio2Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2Question1.Location = new System.Drawing.Point(39, 210);
            this.radio2Question1.Name = "radio2Question1";
            this.radio2Question1.Size = new System.Drawing.Size(113, 33);
            this.radio2Question1.TabIndex = 2;
            this.radio2Question1.TabStop = true;
            this.radio2Question1.Text = "B) 1000";
            this.radio2Question1.UseVisualStyleBackColor = true;
            // 
            // radio1Question1
            // 
            this.radio1Question1.AutoSize = true;
            this.radio1Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1Question1.Location = new System.Drawing.Point(39, 160);
            this.radio1Question1.Name = "radio1Question1";
            this.radio1Question1.Size = new System.Drawing.Size(86, 33);
            this.radio1Question1.TabIndex = 1;
            this.radio1Question1.TabStop = true;
            this.radio1Question1.Text = "A) 15";
            this.radio1Question1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestion1.Location = new System.Drawing.Point(6, 16);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(615, 29);
            this.lblQuestion1.TabIndex = 0;
            this.lblQuestion1.Text = "What is the output of the following C# code snippet?";
            // 
            // btnQ1Submit
            // 
            this.btnQ1Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1Submit.Location = new System.Drawing.Point(86, 465);
            this.btnQ1Submit.Name = "btnQ1Submit";
            this.btnQ1Submit.Size = new System.Drawing.Size(118, 43);
            this.btnQ1Submit.TabIndex = 7;
            this.btnQ1Submit.Text = "Submit";
            this.btnQ1Submit.UseVisualStyleBackColor = true;
            this.btnQ1Submit.Click += new System.EventHandler(this.btnQ1Submit_Click);
            // 
            // btnQ1Next
            // 
            this.btnQ1Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1Next.Location = new System.Drawing.Point(465, 465);
            this.btnQ1Next.Name = "btnQ1Next";
            this.btnQ1Next.Size = new System.Drawing.Size(111, 42);
            this.btnQ1Next.TabIndex = 8;
            this.btnQ1Next.Text = "Next";
            this.btnQ1Next.UseVisualStyleBackColor = true;
            this.btnQ1Next.Click += new System.EventHandler(this.btnQ1Next_Click);
            // 
            // TimerQ1
            // 
            this.TimerQ1.Interval = 1000;
            this.TimerQ1.Tick += new System.EventHandler(this.TimerQ1_Tick);
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 557);
            this.Controls.Add(this.btnQ1Submit);
            this.Controls.Add(this.btnQ1Next);
            this.Controls.Add(this.groupBoxQ1);
            this.Controls.Add(this.lblTitleQ1);
            this.Name = "Question1";
            this.Text = "Question1";
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxQ1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleQ1;
        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.RadioButton radio3Question1;
        private System.Windows.Forms.RadioButton radio2Question1;
        private System.Windows.Forms.RadioButton radio1Question1;
        private System.Windows.Forms.PictureBox picboxQ1;
        private System.Windows.Forms.ProgressBar BarQ1;
        private System.Windows.Forms.Label lblTimeQ1;
        private System.Windows.Forms.Button btnQ1Submit;
        private System.Windows.Forms.Button btnQ1Next;
        private System.Windows.Forms.Timer TimerQ1;
    }
}