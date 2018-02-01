namespace WindowsFormsApp1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitBooking = new System.Windows.Forms.Button();
            this.BookingComfirmationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(124, 46);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(370, 31);
            this.Title.TabIndex = 2;
            this.Title.Text = "Super Duper Booking System";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(200, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // SubmitBooking
            // 
            this.SubmitBooking.Location = new System.Drawing.Point(78, 243);
            this.SubmitBooking.Name = "SubmitBooking";
            this.SubmitBooking.Size = new System.Drawing.Size(119, 55);
            this.SubmitBooking.TabIndex = 7;
            this.SubmitBooking.Text = "Make booking";
            this.SubmitBooking.UseVisualStyleBackColor = true;
            this.SubmitBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingComfirmationLabel
            // 
            this.BookingComfirmationLabel.AutoSize = true;
            this.BookingComfirmationLabel.Location = new System.Drawing.Point(78, 336);
            this.BookingComfirmationLabel.Name = "BookingComfirmationLabel";
            this.BookingComfirmationLabel.Size = new System.Drawing.Size(78, 13);
            this.BookingComfirmationLabel.TabIndex = 8;
            this.BookingComfirmationLabel.Text = "Booking made!";
            this.BookingComfirmationLabel.Visible = false;
            this.BookingComfirmationLabel.Click += new System.EventHandler(this.BookingComfirmationLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 443);
            this.Controls.Add(this.BookingComfirmationLabel);
            this.Controls.Add(this.SubmitBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "User Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitBooking;
        private System.Windows.Forms.Label BookingComfirmationLabel;
    }
}

