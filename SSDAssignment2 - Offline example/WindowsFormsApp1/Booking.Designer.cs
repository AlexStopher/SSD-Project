namespace WindowsFormsApp1
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.SubmitBookingButton = new System.Windows.Forms.Button();
            this.CheckSlotsButton = new System.Windows.Forms.Button();
            this.EventCalendar = new System.Windows.Forms.MonthCalendar();
            this.SelectPlatformComboBox = new System.Windows.Forms.ComboBox();
            this.LengthOfBookingComboBox = new System.Windows.Forms.ComboBox();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.SelectGameComboBox = new System.Windows.Forms.ComboBox();
            this.NoOfPeopleComboBox = new System.Windows.Forms.ComboBox();
            this.BookingGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectDatePicker = new System.Windows.Forms.DateTimePicker();
            this.InsertBookingNameTextBox = new System.Windows.Forms.TextBox();
            this.BookingLabel = new System.Windows.Forms.Label();
            this.EventGroupBox = new System.Windows.Forms.GroupBox();
            this.EventButtonsGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.EventBookButton = new System.Windows.Forms.Button();
            this.SelectEventComboBox = new System.Windows.Forms.ComboBox();
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfTicketsSubtractButton = new System.Windows.Forms.Button();
            this.NumberOfTicketsAddButton = new System.Windows.Forms.Button();
            this.EventBannerPictureBox = new System.Windows.Forms.PictureBox();
            this.EventBannerImageList = new System.Windows.Forms.ImageList(this.components);
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BookingGroupBox.SuspendLayout();
            this.EventGroupBox.SuspendLayout();
            this.EventButtonsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventBannerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitBookingButton
            // 
            this.SubmitBookingButton.Location = new System.Drawing.Point(167, 234);
            this.SubmitBookingButton.Name = "SubmitBookingButton";
            this.SubmitBookingButton.Size = new System.Drawing.Size(145, 36);
            this.SubmitBookingButton.TabIndex = 7;
            this.SubmitBookingButton.Text = "Confirm booking information";
            this.SubmitBookingButton.UseVisualStyleBackColor = true;
            this.SubmitBookingButton.Click += new System.EventHandler(this.SubmitBooking_Click);
            // 
            // CheckSlotsButton
            // 
            this.CheckSlotsButton.Location = new System.Drawing.Point(6, 234);
            this.CheckSlotsButton.Name = "CheckSlotsButton";
            this.CheckSlotsButton.Size = new System.Drawing.Size(155, 36);
            this.CheckSlotsButton.TabIndex = 8;
            this.CheckSlotsButton.Text = "Check Open Slots";
            this.CheckSlotsButton.UseVisualStyleBackColor = true;
            // 
            // EventCalendar
            // 
            this.EventCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.EventCalendar.Location = new System.Drawing.Point(5, 8);
            this.EventCalendar.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.EventCalendar.Name = "EventCalendar";
            this.EventCalendar.TabIndex = 10;
            // 
            // SelectPlatformComboBox
            // 
            this.SelectPlatformComboBox.FormattingEnabled = true;
            this.SelectPlatformComboBox.Items.AddRange(new object[] {
            "PC",
            "XBONE",
            "PS4"});
            this.SelectPlatformComboBox.Location = new System.Drawing.Point(6, 176);
            this.SelectPlatformComboBox.Name = "SelectPlatformComboBox";
            this.SelectPlatformComboBox.Size = new System.Drawing.Size(306, 21);
            this.SelectPlatformComboBox.TabIndex = 12;
            this.SelectPlatformComboBox.Text = "Select platform";
            // 
            // LengthOfBookingComboBox
            // 
            this.LengthOfBookingComboBox.FormattingEnabled = true;
            this.LengthOfBookingComboBox.Items.AddRange(new object[] {
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours"});
            this.LengthOfBookingComboBox.Location = new System.Drawing.Point(6, 149);
            this.LengthOfBookingComboBox.Name = "LengthOfBookingComboBox";
            this.LengthOfBookingComboBox.Size = new System.Drawing.Size(306, 21);
            this.LengthOfBookingComboBox.TabIndex = 13;
            this.LengthOfBookingComboBox.Text = "Length of booking";
            // 
            // TimeBox
            // 
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00"});
            this.TimeBox.Location = new System.Drawing.Point(6, 122);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(306, 21);
            this.TimeBox.TabIndex = 15;
            this.TimeBox.Text = "Start time";
            // 
            // SelectGameComboBox
            // 
            this.SelectGameComboBox.FormattingEnabled = true;
            this.SelectGameComboBox.Items.AddRange(new object[] {
            "Grand Theft Auto",
            "Mortal Kombat",
            "Call of Duty",
            "League of Legends",
            "Counter Strike",
            "Crash Bandicoot"});
            this.SelectGameComboBox.Location = new System.Drawing.Point(6, 203);
            this.SelectGameComboBox.Name = "SelectGameComboBox";
            this.SelectGameComboBox.Size = new System.Drawing.Size(306, 21);
            this.SelectGameComboBox.TabIndex = 20;
            this.SelectGameComboBox.Text = "Select game";
            // 
            // NoOfPeopleComboBox
            // 
            this.NoOfPeopleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfPeopleComboBox.FormattingEnabled = true;
            this.NoOfPeopleComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NoOfPeopleComboBox.Location = new System.Drawing.Point(6, 95);
            this.NoOfPeopleComboBox.Name = "NoOfPeopleComboBox";
            this.NoOfPeopleComboBox.Size = new System.Drawing.Size(306, 21);
            this.NoOfPeopleComboBox.TabIndex = 22;
            this.NoOfPeopleComboBox.Text = "Number of users";
            // 
            // BookingGroupBox
            // 
            this.BookingGroupBox.Controls.Add(this.SelectDatePicker);
            this.BookingGroupBox.Controls.Add(this.InsertBookingNameTextBox);
            this.BookingGroupBox.Controls.Add(this.BookingLabel);
            this.BookingGroupBox.Controls.Add(this.NoOfPeopleComboBox);
            this.BookingGroupBox.Controls.Add(this.TimeBox);
            this.BookingGroupBox.Controls.Add(this.LengthOfBookingComboBox);
            this.BookingGroupBox.Controls.Add(this.SelectGameComboBox);
            this.BookingGroupBox.Controls.Add(this.SubmitBookingButton);
            this.BookingGroupBox.Controls.Add(this.CheckSlotsButton);
            this.BookingGroupBox.Controls.Add(this.SelectPlatformComboBox);
            this.BookingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingGroupBox.Location = new System.Drawing.Point(84, 89);
            this.BookingGroupBox.Name = "BookingGroupBox";
            this.BookingGroupBox.Size = new System.Drawing.Size(318, 280);
            this.BookingGroupBox.TabIndex = 24;
            this.BookingGroupBox.TabStop = false;
            // 
            // SelectDatePicker
            // 
            this.SelectDatePicker.Location = new System.Drawing.Point(6, 69);
            this.SelectDatePicker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.SelectDatePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.SelectDatePicker.Name = "SelectDatePicker";
            this.SelectDatePicker.Size = new System.Drawing.Size(306, 20);
            this.SelectDatePicker.TabIndex = 25;
            this.SelectDatePicker.DropDown += new System.EventHandler(this.SelectDatePicker_DropDown);
            // 
            // InsertBookingNameTextBox
            // 
            this.InsertBookingNameTextBox.Location = new System.Drawing.Point(6, 44);
            this.InsertBookingNameTextBox.Name = "InsertBookingNameTextBox";
            this.InsertBookingNameTextBox.Size = new System.Drawing.Size(306, 20);
            this.InsertBookingNameTextBox.TabIndex = 24;
            this.InsertBookingNameTextBox.Text = "Insert booking name";
            // 
            // BookingLabel
            // 
            this.BookingLabel.AutoSize = true;
            this.BookingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingLabel.Location = new System.Drawing.Point(117, 16);
            this.BookingLabel.Name = "BookingLabel";
            this.BookingLabel.Size = new System.Drawing.Size(97, 25);
            this.BookingLabel.TabIndex = 23;
            this.BookingLabel.Text = "Booking";
            // 
            // EventGroupBox
            // 
            this.EventGroupBox.Controls.Add(this.EventButtonsGroupBox);
            this.EventGroupBox.Controls.Add(this.EventBannerPictureBox);
            this.EventGroupBox.Controls.Add(this.EventCalendar);
            this.EventGroupBox.Location = new System.Drawing.Point(409, 89);
            this.EventGroupBox.Name = "EventGroupBox";
            this.EventGroupBox.Size = new System.Drawing.Size(411, 374);
            this.EventGroupBox.TabIndex = 25;
            this.EventGroupBox.TabStop = false;
            // 
            // EventButtonsGroupBox
            // 
            this.EventButtonsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EventButtonsGroupBox.Controls.Add(this.NumberOfTicketsTextBox);
            this.EventButtonsGroupBox.Controls.Add(this.EventBookButton);
            this.EventButtonsGroupBox.Controls.Add(this.SelectEventComboBox);
            this.EventButtonsGroupBox.Controls.Add(this.TeamNameTextBox);
            this.EventButtonsGroupBox.Controls.Add(this.NumberOfTicketsSubtractButton);
            this.EventButtonsGroupBox.Controls.Add(this.NumberOfTicketsAddButton);
            this.EventButtonsGroupBox.Location = new System.Drawing.Point(244, 8);
            this.EventButtonsGroupBox.Name = "EventButtonsGroupBox";
            this.EventButtonsGroupBox.Size = new System.Drawing.Size(161, 162);
            this.EventButtonsGroupBox.TabIndex = 26;
            this.EventButtonsGroupBox.TabStop = false;
            // 
            // NumberOfTicketsTextBox
            // 
            this.NumberOfTicketsTextBox.Location = new System.Drawing.Point(35, 41);
            this.NumberOfTicketsTextBox.Name = "NumberOfTicketsTextBox";
            this.NumberOfTicketsTextBox.Size = new System.Drawing.Size(94, 20);
            this.NumberOfTicketsTextBox.TabIndex = 12;
            this.NumberOfTicketsTextBox.TabStop = false;
            this.NumberOfTicketsTextBox.Text = "0";
            this.NumberOfTicketsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EventBookButton
            // 
            this.EventBookButton.Location = new System.Drawing.Point(9, 94);
            this.EventBookButton.Name = "EventBookButton";
            this.EventBookButton.Size = new System.Drawing.Size(146, 23);
            this.EventBookButton.TabIndex = 16;
            this.EventBookButton.Text = "Book";
            this.EventBookButton.UseVisualStyleBackColor = true;
            // 
            // SelectEventComboBox
            // 
            this.SelectEventComboBox.FormattingEnabled = true;
            this.SelectEventComboBox.Items.AddRange(new object[] {
            "HoI4 DLC release MP fight",
            "PUBG Anniversary"});
            this.SelectEventComboBox.Location = new System.Drawing.Point(8, 14);
            this.SelectEventComboBox.Name = "SelectEventComboBox";
            this.SelectEventComboBox.Size = new System.Drawing.Size(147, 21);
            this.SelectEventComboBox.TabIndex = 11;
            this.SelectEventComboBox.Text = "Select event";
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Location = new System.Drawing.Point(9, 67);
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.TeamNameTextBox.TabIndex = 15;
            this.TeamNameTextBox.Text = "Team Name (Optional)";
            this.TeamNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberOfTicketsSubtractButton
            // 
            this.NumberOfTicketsSubtractButton.Location = new System.Drawing.Point(9, 41);
            this.NumberOfTicketsSubtractButton.Name = "NumberOfTicketsSubtractButton";
            this.NumberOfTicketsSubtractButton.Size = new System.Drawing.Size(20, 20);
            this.NumberOfTicketsSubtractButton.TabIndex = 13;
            this.NumberOfTicketsSubtractButton.Text = "-";
            this.NumberOfTicketsSubtractButton.UseVisualStyleBackColor = true;
            this.NumberOfTicketsSubtractButton.Click += new System.EventHandler(this.NumberOfTicketsSubtractButton_Click);
            // 
            // NumberOfTicketsAddButton
            // 
            this.NumberOfTicketsAddButton.Location = new System.Drawing.Point(135, 41);
            this.NumberOfTicketsAddButton.Name = "NumberOfTicketsAddButton";
            this.NumberOfTicketsAddButton.Size = new System.Drawing.Size(20, 20);
            this.NumberOfTicketsAddButton.TabIndex = 14;
            this.NumberOfTicketsAddButton.Text = "+";
            this.NumberOfTicketsAddButton.UseVisualStyleBackColor = true;
            this.NumberOfTicketsAddButton.Click += new System.EventHandler(this.NumberOfTicketsAddButton_Click);
            // 
            // EventBannerPictureBox
            // 
            this.EventBannerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EventBannerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EventBannerPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventBannerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EventBannerPictureBox.Image")));
            this.EventBannerPictureBox.InitialImage = null;
            this.EventBannerPictureBox.Location = new System.Drawing.Point(5, 187);
            this.EventBannerPictureBox.Name = "EventBannerPictureBox";
            this.EventBannerPictureBox.Size = new System.Drawing.Size(400, 181);
            this.EventBannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventBannerPictureBox.TabIndex = 17;
            this.EventBannerPictureBox.TabStop = false;
            // 
            // EventBannerImageList
            // 
            this.EventBannerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EventBannerImageList.ImageStream")));
            this.EventBannerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.EventBannerImageList.Images.SetKeyName(0, "PUBGEventBanner.jpg");
            this.EventBannerImageList.Images.SetKeyName(1, "HoI4EventBanner.jpg");
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.InitialImage = null;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 13);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(167, 70);
            this.LogoPictureBox.TabIndex = 26;
            this.LogoPictureBox.TabStop = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 631);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.EventGroupBox);
            this.Controls.Add(this.BookingGroupBox);
            this.Name = "Booking";
            this.Text = "User Interface";
            this.BookingGroupBox.ResumeLayout(false);
            this.BookingGroupBox.PerformLayout();
            this.EventGroupBox.ResumeLayout(false);
            this.EventButtonsGroupBox.ResumeLayout(false);
            this.EventButtonsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventBannerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SubmitBookingButton;
        private System.Windows.Forms.Button CheckSlotsButton;
        private System.Windows.Forms.MonthCalendar EventCalendar;
        private System.Windows.Forms.ComboBox SelectPlatformComboBox;
        private System.Windows.Forms.ComboBox LengthOfBookingComboBox;
        private System.Windows.Forms.ComboBox TimeBox;
        private System.Windows.Forms.ComboBox SelectGameComboBox;
        private System.Windows.Forms.ComboBox NoOfPeopleComboBox;
        private System.Windows.Forms.GroupBox BookingGroupBox;
        private System.Windows.Forms.Label BookingLabel;
        private System.Windows.Forms.TextBox InsertBookingNameTextBox;
        private System.Windows.Forms.DateTimePicker SelectDatePicker;
        private System.Windows.Forms.GroupBox EventGroupBox;
        private System.Windows.Forms.Button NumberOfTicketsAddButton;
        private System.Windows.Forms.Button NumberOfTicketsSubtractButton;
        private System.Windows.Forms.TextBox NumberOfTicketsTextBox;
        private System.Windows.Forms.ComboBox SelectEventComboBox;
        private System.Windows.Forms.Button EventBookButton;
        private System.Windows.Forms.TextBox TeamNameTextBox;
        private System.Windows.Forms.ImageList EventBannerImageList;
        private System.Windows.Forms.PictureBox EventBannerPictureBox;
        private System.Windows.Forms.GroupBox EventButtonsGroupBox;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

