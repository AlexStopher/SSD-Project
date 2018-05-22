namespace CalendarUI
{
    partial class CalendarForm
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
            this.calendarComponent = new System.Windows.Forms.MonthCalendar();
            this.dateTimeDisplay = new System.Windows.Forms.GroupBox();
            this.bookingsList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameOfBooker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumOfAtendees = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hardware = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Software = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = new System.Windows.Forms.Label();
            this.hardSoftList = new System.Windows.Forms.Button();
            this.dateTimeDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarComponent
            // 
            this.calendarComponent.Location = new System.Drawing.Point(18, 18);
            this.calendarComponent.Name = "calendarComponent";
            this.calendarComponent.TabIndex = 0;
            this.calendarComponent.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarComponent_DateChanged);
            // 
            // dateTimeDisplay
            // 
            this.dateTimeDisplay.AutoSize = true;
            this.dateTimeDisplay.Controls.Add(this.bookingsList);
            this.dateTimeDisplay.Controls.Add(this.dateTime);
            this.dateTimeDisplay.Location = new System.Drawing.Point(18, 192);
            this.dateTimeDisplay.Name = "dateTimeDisplay";
            this.dateTimeDisplay.Size = new System.Drawing.Size(578, 234);
            this.dateTimeDisplay.TabIndex = 2;
            this.dateTimeDisplay.TabStop = false;
            this.dateTimeDisplay.Text = "groupBox1";
            // 
            // bookingsList
            // 
            this.bookingsList.AllowColumnReorder = true;
            this.bookingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameOfBooker,
            this.NumOfAtendees,
            this.Hardware,
            this.Software,
            this.Time,
            this.Duration});
            this.bookingsList.FullRowSelect = true;
            this.bookingsList.GridLines = true;
            this.bookingsList.Location = new System.Drawing.Point(6, 23);
            this.bookingsList.Name = "bookingsList";
            this.bookingsList.Size = new System.Drawing.Size(566, 192);
            this.bookingsList.TabIndex = 1;
            this.bookingsList.UseCompatibleStateImageBehavior = false;
            this.bookingsList.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // NameOfBooker
            // 
            this.NameOfBooker.Text = "Name";
            this.NameOfBooker.Width = 100;
            // 
            // NumOfAtendees
            // 
            this.NumOfAtendees.Text = "No. attenders";
            this.NumOfAtendees.Width = 80;
            // 
            // Hardware
            // 
            this.Hardware.Text = "Hardware booked";
            this.Hardware.Width = 100;
            // 
            // Software
            // 
            this.Software.Text = "Software booked";
            this.Software.Width = 95;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 75;
            // 
            // Duration
            // 
            this.Duration.Text = "Duration";
            this.Duration.Width = 75;
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(6, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(83, 20);
            this.dateTime.TabIndex = 0;
            this.dateTime.Text = "Bookings";
            // 
            // hardSoftList
            // 
            this.hardSoftList.Location = new System.Drawing.Point(398, 18);
            this.hardSoftList.Name = "hardSoftList";
            this.hardSoftList.Size = new System.Drawing.Size(91, 23);
            this.hardSoftList.TabIndex = 3;
            this.hardSoftList.Text = "Check listings";
            this.hardSoftList.UseVisualStyleBackColor = true;
            this.hardSoftList.Click += new System.EventHandler(this.hardSoftList_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 415);
            this.Controls.Add(this.hardSoftList);
            this.Controls.Add(this.dateTimeDisplay);
            this.Controls.Add(this.calendarComponent);
            this.Name = "CalendarForm";
            this.Text = "Calendar of bookings";
            this.dateTimeDisplay.ResumeLayout(false);
            this.dateTimeDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarComponent;
        private System.Windows.Forms.GroupBox dateTimeDisplay;
        private System.Windows.Forms.ListView bookingsList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameOfBooker;
        private System.Windows.Forms.ColumnHeader NumOfAtendees;
        private System.Windows.Forms.ColumnHeader Hardware;
        private System.Windows.Forms.ColumnHeader Software;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.Button hardSoftList;
    }
}

