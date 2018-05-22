namespace HardwareSoftwareBrowsing
{
    partial class HardSoftForm
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
            this.HardwareList = new System.Windows.Forms.ListView();
            this.HardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HardBooked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoftwareList = new System.Windows.Forms.ListView();
            this.SoftID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Game = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoftBooked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.NumPlayers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HardwareName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HardwareList
            // 
            this.HardwareList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HardID,
            this.Type,
            this.HardwareName,
            this.HardBooked});
            this.HardwareList.FullRowSelect = true;
            this.HardwareList.GridLines = true;
            this.HardwareList.Location = new System.Drawing.Point(6, 23);
            this.HardwareList.Name = "HardwareList";
            this.HardwareList.Size = new System.Drawing.Size(302, 565);
            this.HardwareList.TabIndex = 0;
            this.HardwareList.UseCompatibleStateImageBehavior = false;
            this.HardwareList.View = System.Windows.Forms.View.Details;
            // 
            // HardID
            // 
            this.HardID.Text = "Hardware ID";
            this.HardID.Width = 75;
            // 
            // Type
            // 
            this.Type.Text = "Hardware type";
            this.Type.Width = 85;
            // 
            // HardBooked
            // 
            this.HardBooked.Text = "Booked?";
            // 
            // SoftwareList
            // 
            this.SoftwareList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SoftID,
            this.Game,
            this.Age,
            this.Date,
            this.NumPlayers,
            this.PlayerType,
            this.SoftBooked});
            this.SoftwareList.FullRowSelect = true;
            this.SoftwareList.GridLines = true;
            this.SoftwareList.Location = new System.Drawing.Point(319, 23);
            this.SoftwareList.Name = "SoftwareList";
            this.SoftwareList.Size = new System.Drawing.Size(609, 565);
            this.SoftwareList.TabIndex = 1;
            this.SoftwareList.UseCompatibleStateImageBehavior = false;
            this.SoftwareList.View = System.Windows.Forms.View.Details;
            // 
            // SoftID
            // 
            this.SoftID.Text = "Software ID";
            this.SoftID.Width = 75;
            // 
            // Game
            // 
            this.Game.Text = "Game";
            this.Game.Width = 106;
            // 
            // Age
            // 
            this.Age.Text = "PEGI rating";
            this.Age.Width = 73;
            // 
            // Date
            // 
            this.Date.Text = "Release date";
            this.Date.Width = 82;
            // 
            // PlayerType
            // 
            this.PlayerType.Text = "Multiplayer type";
            this.PlayerType.Width = 100;
            // 
            // SoftBooked
            // 
            this.SoftBooked.Text = "Booked?";
            // 
            // listGroup
            // 
            this.listGroup.Controls.Add(this.label1);
            this.listGroup.Controls.Add(this.dateTime);
            this.listGroup.Controls.Add(this.HardwareList);
            this.listGroup.Controls.Add(this.SoftwareList);
            this.listGroup.Location = new System.Drawing.Point(9, 13);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(936, 597);
            this.listGroup.TabIndex = 2;
            this.listGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Games";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(6, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(83, 20);
            this.dateTime.TabIndex = 2;
            this.dateTime.Text = "Consoles";
            // 
            // NumPlayers
            // 
            this.NumPlayers.Text = "No. of players";
            this.NumPlayers.Width = 100;
            // 
            // HardwareName
            // 
            this.HardwareName.Text = "Name";
            this.HardwareName.Width = 75;
            // 
            // HardSoftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 612);
            this.Controls.Add(this.listGroup);
            this.Name = "HardSoftForm";
            this.Text = "Hardware and software";
            this.listGroup.ResumeLayout(false);
            this.listGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView HardwareList;
        private System.Windows.Forms.ColumnHeader HardID;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader HardBooked;
        private System.Windows.Forms.ListView SoftwareList;
        private System.Windows.Forms.ColumnHeader SoftID;
        private System.Windows.Forms.ColumnHeader Game;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader PlayerType;
        private System.Windows.Forms.ColumnHeader SoftBooked;
        private System.Windows.Forms.GroupBox listGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.ColumnHeader NumPlayers;
        private System.Windows.Forms.ColumnHeader HardwareName;
    }
}

