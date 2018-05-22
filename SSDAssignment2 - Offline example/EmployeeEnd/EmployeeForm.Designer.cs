namespace EmployeeEnd
{
    partial class EmployeeForm
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
            this.addMembersContainer = new System.Windows.Forms.GroupBox();
            this.newMember_PhoneBox = new System.Windows.Forms.TextBox();
            this.newMember_PhoneText = new System.Windows.Forms.Label();
            this.newMember_DoBBox = new System.Windows.Forms.DateTimePicker();
            this.newMember_Button = new System.Windows.Forms.Button();
            this.newMember_DoBText = new System.Windows.Forms.Label();
            this.newMember_UserBox = new System.Windows.Forms.TextBox();
            this.newMember_UserText = new System.Windows.Forms.Label();
            this.newMember_NameBox = new System.Windows.Forms.TextBox();
            this.newMember_NameText = new System.Windows.Forms.Label();
            this.addNewHardwareContainer = new System.Windows.Forms.GroupBox();
            this.newHardware_Button = new System.Windows.Forms.Button();
            this.newHardware_PlatformBox = new System.Windows.Forms.ComboBox();
            this.newHardware_PlatformText = new System.Windows.Forms.Label();
            this.newSoftware_Container = new System.Windows.Forms.GroupBox();
            this.newSoftware_UploadButton = new System.Windows.Forms.Button();
            this.newSoftware_PlatformBox = new System.Windows.Forms.ComboBox();
            this.newSoftware_PlatformText = new System.Windows.Forms.Label();
            this.newSoftware_TypeBox = new System.Windows.Forms.ComboBox();
            this.newSoftware_TypeText = new System.Windows.Forms.Label();
            this.newSoftware_PlayersBox = new System.Windows.Forms.TextBox();
            this.newSoftware_PlayersText = new System.Windows.Forms.Label();
            this.newSoftware_ReleaseBox = new System.Windows.Forms.DateTimePicker();
            this.newSoftware_ReleaseText = new System.Windows.Forms.Label();
            this.newSoftware_PegiBox = new System.Windows.Forms.ComboBox();
            this.newSoftware_PegiText = new System.Windows.Forms.Label();
            this.newSoftware_NameBox = new System.Windows.Forms.TextBox();
            this.newSoftware_NameText = new System.Windows.Forms.Label();
            this.CheckBookingsButton = new System.Windows.Forms.Button();
            this.addMembersContainer.SuspendLayout();
            this.addNewHardwareContainer.SuspendLayout();
            this.newSoftware_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMembersContainer
            // 
            this.addMembersContainer.Controls.Add(this.newMember_PhoneBox);
            this.addMembersContainer.Controls.Add(this.newMember_PhoneText);
            this.addMembersContainer.Controls.Add(this.newMember_DoBBox);
            this.addMembersContainer.Controls.Add(this.newMember_Button);
            this.addMembersContainer.Controls.Add(this.newMember_DoBText);
            this.addMembersContainer.Controls.Add(this.newMember_UserBox);
            this.addMembersContainer.Controls.Add(this.newMember_UserText);
            this.addMembersContainer.Controls.Add(this.newMember_NameBox);
            this.addMembersContainer.Controls.Add(this.newMember_NameText);
            this.addMembersContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembersContainer.Location = new System.Drawing.Point(12, 12);
            this.addMembersContainer.Name = "addMembersContainer";
            this.addMembersContainer.Size = new System.Drawing.Size(215, 226);
            this.addMembersContainer.TabIndex = 0;
            this.addMembersContainer.TabStop = false;
            this.addMembersContainer.Text = "Add new member";
            // 
            // newMember_PhoneBox
            // 
            this.newMember_PhoneBox.Location = new System.Drawing.Point(84, 102);
            this.newMember_PhoneBox.Name = "newMember_PhoneBox";
            this.newMember_PhoneBox.Size = new System.Drawing.Size(120, 22);
            this.newMember_PhoneBox.TabIndex = 9;
            this.newMember_PhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newMember_PhoneBox_KeyPress);
            // 
            // newMember_PhoneText
            // 
            this.newMember_PhoneText.AutoSize = true;
            this.newMember_PhoneText.Location = new System.Drawing.Point(7, 105);
            this.newMember_PhoneText.Name = "newMember_PhoneText";
            this.newMember_PhoneText.Size = new System.Drawing.Size(47, 16);
            this.newMember_PhoneText.TabIndex = 8;
            this.newMember_PhoneText.Text = "Phone";
            // 
            // newMember_DoBBox
            // 
            this.newMember_DoBBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.newMember_DoBBox.Location = new System.Drawing.Point(84, 75);
            this.newMember_DoBBox.Name = "newMember_DoBBox";
            this.newMember_DoBBox.Size = new System.Drawing.Size(120, 22);
            this.newMember_DoBBox.TabIndex = 7;
            // 
            // newMember_Button
            // 
            this.newMember_Button.Location = new System.Drawing.Point(10, 196);
            this.newMember_Button.Name = "newMember_Button";
            this.newMember_Button.Size = new System.Drawing.Size(119, 23);
            this.newMember_Button.TabIndex = 6;
            this.newMember_Button.Text = "Upload member";
            this.newMember_Button.UseVisualStyleBackColor = true;
            this.newMember_Button.Click += new System.EventHandler(this.newMember_Button_Click);
            // 
            // newMember_DoBText
            // 
            this.newMember_DoBText.AutoSize = true;
            this.newMember_DoBText.Location = new System.Drawing.Point(7, 78);
            this.newMember_DoBText.Name = "newMember_DoBText";
            this.newMember_DoBText.Size = new System.Drawing.Size(35, 16);
            this.newMember_DoBText.TabIndex = 4;
            this.newMember_DoBText.Text = "DoB";
            // 
            // newMember_UserBox
            // 
            this.newMember_UserBox.Location = new System.Drawing.Point(84, 47);
            this.newMember_UserBox.Name = "newMember_UserBox";
            this.newMember_UserBox.Size = new System.Drawing.Size(120, 22);
            this.newMember_UserBox.TabIndex = 3;
            // 
            // newMember_UserText
            // 
            this.newMember_UserText.AutoSize = true;
            this.newMember_UserText.Location = new System.Drawing.Point(7, 50);
            this.newMember_UserText.Name = "newMember_UserText";
            this.newMember_UserText.Size = new System.Drawing.Size(71, 16);
            this.newMember_UserText.TabIndex = 2;
            this.newMember_UserText.Text = "Username";
            // 
            // newMember_NameBox
            // 
            this.newMember_NameBox.Location = new System.Drawing.Point(84, 19);
            this.newMember_NameBox.Name = "newMember_NameBox";
            this.newMember_NameBox.Size = new System.Drawing.Size(120, 22);
            this.newMember_NameBox.TabIndex = 1;
            // 
            // newMember_NameText
            // 
            this.newMember_NameText.AutoSize = true;
            this.newMember_NameText.Location = new System.Drawing.Point(7, 22);
            this.newMember_NameText.Name = "newMember_NameText";
            this.newMember_NameText.Size = new System.Drawing.Size(45, 16);
            this.newMember_NameText.TabIndex = 0;
            this.newMember_NameText.Text = "Name";
            // 
            // addNewHardwareContainer
            // 
            this.addNewHardwareContainer.Controls.Add(this.newHardware_Button);
            this.addNewHardwareContainer.Controls.Add(this.newHardware_PlatformBox);
            this.addNewHardwareContainer.Controls.Add(this.newHardware_PlatformText);
            this.addNewHardwareContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewHardwareContainer.Location = new System.Drawing.Point(233, 12);
            this.addNewHardwareContainer.Name = "addNewHardwareContainer";
            this.addNewHardwareContainer.Size = new System.Drawing.Size(222, 226);
            this.addNewHardwareContainer.TabIndex = 1;
            this.addNewHardwareContainer.TabStop = false;
            this.addNewHardwareContainer.Text = "Add new hardware";
            // 
            // newHardware_Button
            // 
            this.newHardware_Button.Location = new System.Drawing.Point(6, 196);
            this.newHardware_Button.Name = "newHardware_Button";
            this.newHardware_Button.Size = new System.Drawing.Size(122, 23);
            this.newHardware_Button.TabIndex = 2;
            this.newHardware_Button.Text = "Upload hardware";
            this.newHardware_Button.UseVisualStyleBackColor = true;
            this.newHardware_Button.Click += new System.EventHandler(this.newHardware_Button_Click);
            // 
            // newHardware_PlatformBox
            // 
            this.newHardware_PlatformBox.FormattingEnabled = true;
            this.newHardware_PlatformBox.Items.AddRange(new object[] {
            "Computer",
            "XBox One",
            "PlayStation 4"});
            this.newHardware_PlatformBox.Location = new System.Drawing.Point(70, 17);
            this.newHardware_PlatformBox.Name = "newHardware_PlatformBox";
            this.newHardware_PlatformBox.Size = new System.Drawing.Size(121, 24);
            this.newHardware_PlatformBox.TabIndex = 1;
            // 
            // newHardware_PlatformText
            // 
            this.newHardware_PlatformText.AutoSize = true;
            this.newHardware_PlatformText.Location = new System.Drawing.Point(7, 22);
            this.newHardware_PlatformText.Name = "newHardware_PlatformText";
            this.newHardware_PlatformText.Size = new System.Drawing.Size(57, 16);
            this.newHardware_PlatformText.TabIndex = 0;
            this.newHardware_PlatformText.Text = "Platform";
            // 
            // newSoftware_Container
            // 
            this.newSoftware_Container.Controls.Add(this.newSoftware_UploadButton);
            this.newSoftware_Container.Controls.Add(this.newSoftware_PlatformBox);
            this.newSoftware_Container.Controls.Add(this.newSoftware_PlatformText);
            this.newSoftware_Container.Controls.Add(this.newSoftware_TypeBox);
            this.newSoftware_Container.Controls.Add(this.newSoftware_TypeText);
            this.newSoftware_Container.Controls.Add(this.newSoftware_PlayersBox);
            this.newSoftware_Container.Controls.Add(this.newSoftware_PlayersText);
            this.newSoftware_Container.Controls.Add(this.newSoftware_ReleaseBox);
            this.newSoftware_Container.Controls.Add(this.newSoftware_ReleaseText);
            this.newSoftware_Container.Controls.Add(this.newSoftware_PegiBox);
            this.newSoftware_Container.Controls.Add(this.newSoftware_PegiText);
            this.newSoftware_Container.Controls.Add(this.newSoftware_NameBox);
            this.newSoftware_Container.Controls.Add(this.newSoftware_NameText);
            this.newSoftware_Container.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSoftware_Container.Location = new System.Drawing.Point(462, 13);
            this.newSoftware_Container.Name = "newSoftware_Container";
            this.newSoftware_Container.Size = new System.Drawing.Size(229, 225);
            this.newSoftware_Container.TabIndex = 2;
            this.newSoftware_Container.TabStop = false;
            this.newSoftware_Container.Text = "Add new software";
            // 
            // newSoftware_UploadButton
            // 
            this.newSoftware_UploadButton.Location = new System.Drawing.Point(6, 195);
            this.newSoftware_UploadButton.Name = "newSoftware_UploadButton";
            this.newSoftware_UploadButton.Size = new System.Drawing.Size(122, 23);
            this.newSoftware_UploadButton.TabIndex = 3;
            this.newSoftware_UploadButton.Text = "Upload software";
            this.newSoftware_UploadButton.UseVisualStyleBackColor = true;
            this.newSoftware_UploadButton.Click += new System.EventHandler(this.newSoftware_UploadButton_Click);
            // 
            // newSoftware_PlatformBox
            // 
            this.newSoftware_PlatformBox.FormattingEnabled = true;
            this.newSoftware_PlatformBox.Items.AddRange(new object[] {
            "Computer",
            "XBox One",
            "PlayStation 4"});
            this.newSoftware_PlatformBox.Location = new System.Drawing.Point(99, 162);
            this.newSoftware_PlatformBox.Name = "newSoftware_PlatformBox";
            this.newSoftware_PlatformBox.Size = new System.Drawing.Size(121, 24);
            this.newSoftware_PlatformBox.TabIndex = 4;
            // 
            // newSoftware_PlatformText
            // 
            this.newSoftware_PlatformText.AutoSize = true;
            this.newSoftware_PlatformText.Location = new System.Drawing.Point(6, 165);
            this.newSoftware_PlatformText.Name = "newSoftware_PlatformText";
            this.newSoftware_PlatformText.Size = new System.Drawing.Size(57, 16);
            this.newSoftware_PlatformText.TabIndex = 3;
            this.newSoftware_PlatformText.Text = "Platform";
            // 
            // newSoftware_TypeBox
            // 
            this.newSoftware_TypeBox.FormattingEnabled = true;
            this.newSoftware_TypeBox.Items.AddRange(new object[] {
            "Singleplayer",
            "Co-op",
            "Co-op (2+ players)",
            "Competitive (Couch)",
            "Competitive (Online)"});
            this.newSoftware_TypeBox.Location = new System.Drawing.Point(99, 132);
            this.newSoftware_TypeBox.Name = "newSoftware_TypeBox";
            this.newSoftware_TypeBox.Size = new System.Drawing.Size(121, 24);
            this.newSoftware_TypeBox.TabIndex = 15;
            // 
            // newSoftware_TypeText
            // 
            this.newSoftware_TypeText.AutoSize = true;
            this.newSoftware_TypeText.Location = new System.Drawing.Point(6, 137);
            this.newSoftware_TypeText.Name = "newSoftware_TypeText";
            this.newSoftware_TypeText.Size = new System.Drawing.Size(57, 16);
            this.newSoftware_TypeText.TabIndex = 14;
            this.newSoftware_TypeText.Text = "MP type";
            // 
            // newSoftware_PlayersBox
            // 
            this.newSoftware_PlayersBox.Location = new System.Drawing.Point(99, 105);
            this.newSoftware_PlayersBox.Name = "newSoftware_PlayersBox";
            this.newSoftware_PlayersBox.Size = new System.Drawing.Size(120, 22);
            this.newSoftware_PlayersBox.TabIndex = 13;
            // 
            // newSoftware_PlayersText
            // 
            this.newSoftware_PlayersText.AutoSize = true;
            this.newSoftware_PlayersText.Location = new System.Drawing.Point(6, 108);
            this.newSoftware_PlayersText.Name = "newSoftware_PlayersText";
            this.newSoftware_PlayersText.Size = new System.Drawing.Size(77, 16);
            this.newSoftware_PlayersText.TabIndex = 12;
            this.newSoftware_PlayersText.Text = "No. players";
            // 
            // newSoftware_ReleaseBox
            // 
            this.newSoftware_ReleaseBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.newSoftware_ReleaseBox.Location = new System.Drawing.Point(99, 77);
            this.newSoftware_ReleaseBox.Name = "newSoftware_ReleaseBox";
            this.newSoftware_ReleaseBox.Size = new System.Drawing.Size(120, 22);
            this.newSoftware_ReleaseBox.TabIndex = 11;
            // 
            // newSoftware_ReleaseText
            // 
            this.newSoftware_ReleaseText.AutoSize = true;
            this.newSoftware_ReleaseText.Location = new System.Drawing.Point(6, 80);
            this.newSoftware_ReleaseText.Name = "newSoftware_ReleaseText";
            this.newSoftware_ReleaseText.Size = new System.Drawing.Size(90, 16);
            this.newSoftware_ReleaseText.TabIndex = 10;
            this.newSoftware_ReleaseText.Text = "Release date";
            // 
            // newSoftware_PegiBox
            // 
            this.newSoftware_PegiBox.FormattingEnabled = true;
            this.newSoftware_PegiBox.Items.AddRange(new object[] {
            "3",
            "7",
            "12",
            "16",
            "18",
            "Not rated by PEGI"});
            this.newSoftware_PegiBox.Location = new System.Drawing.Point(99, 44);
            this.newSoftware_PegiBox.Name = "newSoftware_PegiBox";
            this.newSoftware_PegiBox.Size = new System.Drawing.Size(121, 24);
            this.newSoftware_PegiBox.TabIndex = 4;
            // 
            // newSoftware_PegiText
            // 
            this.newSoftware_PegiText.AutoSize = true;
            this.newSoftware_PegiText.Location = new System.Drawing.Point(6, 49);
            this.newSoftware_PegiText.Name = "newSoftware_PegiText";
            this.newSoftware_PegiText.Size = new System.Drawing.Size(39, 16);
            this.newSoftware_PegiText.TabIndex = 3;
            this.newSoftware_PegiText.Text = "PEGI";
            // 
            // newSoftware_NameBox
            // 
            this.newSoftware_NameBox.Location = new System.Drawing.Point(99, 16);
            this.newSoftware_NameBox.Name = "newSoftware_NameBox";
            this.newSoftware_NameBox.Size = new System.Drawing.Size(120, 22);
            this.newSoftware_NameBox.TabIndex = 11;
            // 
            // newSoftware_NameText
            // 
            this.newSoftware_NameText.AutoSize = true;
            this.newSoftware_NameText.Location = new System.Drawing.Point(6, 21);
            this.newSoftware_NameText.Name = "newSoftware_NameText";
            this.newSoftware_NameText.Size = new System.Drawing.Size(45, 16);
            this.newSoftware_NameText.TabIndex = 10;
            this.newSoftware_NameText.Text = "Name";
            // 
            // CheckBookingsButton
            // 
            this.CheckBookingsButton.Location = new System.Drawing.Point(582, 245);
            this.CheckBookingsButton.Name = "CheckBookingsButton";
            this.CheckBookingsButton.Size = new System.Drawing.Size(108, 23);
            this.CheckBookingsButton.TabIndex = 3;
            this.CheckBookingsButton.Text = "Check bookings";
            this.CheckBookingsButton.UseVisualStyleBackColor = true;
            this.CheckBookingsButton.Click += new System.EventHandler(this.CheckBookingsButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 276);
            this.Controls.Add(this.CheckBookingsButton);
            this.Controls.Add(this.newSoftware_Container);
            this.Controls.Add(this.addNewHardwareContainer);
            this.Controls.Add(this.addMembersContainer);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.addMembersContainer.ResumeLayout(false);
            this.addMembersContainer.PerformLayout();
            this.addNewHardwareContainer.ResumeLayout(false);
            this.addNewHardwareContainer.PerformLayout();
            this.newSoftware_Container.ResumeLayout(false);
            this.newSoftware_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addMembersContainer;
        private System.Windows.Forms.Label newMember_NameText;
        private System.Windows.Forms.TextBox newMember_NameBox;
        private System.Windows.Forms.TextBox newMember_UserBox;
        private System.Windows.Forms.Label newMember_UserText;
        private System.Windows.Forms.Label newMember_DoBText;
        private System.Windows.Forms.Button newMember_Button;
        private System.Windows.Forms.DateTimePicker newMember_DoBBox;
        private System.Windows.Forms.Label newMember_PhoneText;
        private System.Windows.Forms.GroupBox addNewHardwareContainer;
        private System.Windows.Forms.ComboBox newHardware_PlatformBox;
        private System.Windows.Forms.Label newHardware_PlatformText;
        private System.Windows.Forms.Button newHardware_Button;
        private System.Windows.Forms.TextBox newMember_PhoneBox;
        private System.Windows.Forms.GroupBox newSoftware_Container;
        private System.Windows.Forms.ComboBox newSoftware_PegiBox;
        private System.Windows.Forms.Label newSoftware_PegiText;
        private System.Windows.Forms.TextBox newSoftware_NameBox;
        private System.Windows.Forms.Label newSoftware_NameText;
        private System.Windows.Forms.DateTimePicker newSoftware_ReleaseBox;
        private System.Windows.Forms.Label newSoftware_ReleaseText;
        private System.Windows.Forms.TextBox newSoftware_PlayersBox;
        private System.Windows.Forms.Label newSoftware_PlayersText;
        private System.Windows.Forms.Button newSoftware_UploadButton;
        private System.Windows.Forms.ComboBox newSoftware_PlatformBox;
        private System.Windows.Forms.Label newSoftware_PlatformText;
        private System.Windows.Forms.ComboBox newSoftware_TypeBox;
        private System.Windows.Forms.Label newSoftware_TypeText;
        private System.Windows.Forms.Button CheckBookingsButton;
    }
}