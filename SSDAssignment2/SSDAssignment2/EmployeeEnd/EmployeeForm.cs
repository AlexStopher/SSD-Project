using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameCafeLibrary;

namespace EmployeeEnd
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void newMember_Button_Click(object sender, EventArgs e)
        {
            MemberData newMember = new MemberData { Name = newMember_NameBox.Text,
                DateOfBirth = newMember_DoBBox.Value,
                PhoneNumber = newMember_PhoneBox.Text.Trim(),
                MemberTypeID = 1,
                Password = "Password",
                Username = newMember_UserBox.Text };

            Writer.AddMember(newMember);
        }

        private void newHardware_Button_Click(object sender, EventArgs e)
        {
            int id = Reader.GetAllHardware().Count + 1;
            int type;
            switch (newHardware_PlatformBox.Text)
            {
                case "Computer": type = 1; break;
                case "XBox One": type = 2; break;
                case "PlayStation 4": type = 3; break;
                default: type = -1; break;
            }
            if (type == -1) return;

            HardwareData newHardware = new HardwareData { ID = id,
                HardwareType = type,
                Name = $"{newHardware_PlatformBox.Text}{id}",
                Booked = false
            };

            Writer.AddHardware(newHardware);
        }

        private void newSoftware_UploadButton_Click(object sender, EventArgs e)
        {
            int PegiID = 1;
            switch (newSoftware_PegiBox.Text)
            {
                case "3": PegiID = 1; break;
                case "7": PegiID = 2; break;
                case "12": PegiID = 3; break;
                case "16": PegiID = 4; break;
                case "18": PegiID = 5; break;
            }

            int players;
            if (!int.TryParse(newSoftware_PlayersBox.Text, out players)) players = 1;

            SoftwareData newSoftware = new SoftwareData
            {
                Name = newSoftware_NameBox.Text,
                PegiAge = PegiID,
                ReleaseDate = newSoftware_ReleaseBox.Value,
                NumOfPlayers = players,
                PlayerTypeID = newSoftware_TypeBox.SelectedIndex + 1,
                HardwareType = newSoftware_PlatformBox.SelectedIndex + 1
            };

            Writer.AddSoftware(newSoftware);
        }

        private void newMember_PhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // prevents letters from being typed into the phone box
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch)) e.Handled = true;
        }
    }
}
