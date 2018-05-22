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

namespace HardwareSoftwareBrowsing
{
    public partial class HardSoftForm : Form
    {
        ///////////////
        // DUMMY DATA
        ///////////////
        enum HardwareTypes { XboxOne, PS4, PC };
        struct DummyHardware
        {
            public int ID { get; set; }
            public HardwareTypes Type { get; set; }
            public bool Booked { get; set; }
        };

        enum PlayerNum { Singleplayer, Online, Splitscreen, Cooperative };
        struct DummySoftware
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int PegiAge { get; set; }
            public DateTime ReleaseDate { get; set; }
            public PlayerNum Players { get; set; }
            public bool Booked { get; set; }
        }
        List<DummyHardware> dummyHardware;
        List<DummySoftware> dummySoftware;


        ///////////////
        // SETUP
        ///////////////
        public HardSoftForm()
        {
            InitializeComponent();
            SetupData();
            //PrintHardwareList(Reader.GetAllHardware());
            //PrintSoftwareList(Reader.GetAllSoftware());
        }

        // setup dummy data
        private void SetupData()
        {
            // dummy hardware
            #region
            dummyHardware = new List<DummyHardware>();

            int i, j, k;

            for (i = 0; i < 11; i++)
            {
                dummyHardware.Add(new DummyHardware
                {
                    ID = i,
                    Type = HardwareTypes.XboxOne,
                    Booked = false
                });
            }

            for (j = 0; j < 11; j++)
            {
                dummyHardware.Add(new DummyHardware
                {
                    ID = i + j,
                    Type = HardwareTypes.PS4,
                    Booked = false
                });
            }

            for (k = 0; k < 11; k++)
            {
                dummyHardware.Add(new DummyHardware
                {
                    ID = i + j + k,
                    Type = HardwareTypes.PC,
                    Booked = false
                });
            }

            Random rnd = new Random();
            for (int l = 0; l < 10; l++)
            {
                int index = rnd.Next(1, i + j + k - 1);
                dummyHardware[index] = new DummyHardware{ ID = dummyHardware[index].ID, Type = dummyHardware[index].Type, Booked = true};
            }
            #endregion

            // dummy software
            #region
            dummySoftware = new List<DummySoftware>();

            dummySoftware.Add(new DummySoftware
            {
                ID = 0,
                Name = "Grand Theft Auto V",
                PegiAge = 18,
                ReleaseDate = new DateTime(2014, 11, 8),
                Players = PlayerNum.Singleplayer,
                Booked = false
            });

            dummySoftware.Add(new DummySoftware
            {
                ID = 0,
                Name = "Grand Theft Auto Online",
                PegiAge = 18,
                ReleaseDate = new DateTime(2014, 11, 8),
                Players = PlayerNum.Online,
                Booked = true
            });

            dummySoftware.Add(new DummySoftware
            {
                ID = 0,
                Name = "Mortal Kombat X",
                PegiAge = 18,
                ReleaseDate = new DateTime(2015, 4, 14),
                Players = PlayerNum.Splitscreen,
                Booked = false
            });
            #endregion
        }


        ///////////////
        // METHODS
        ///////////////
        private void PrintHardwareList(List<HardwareData> hardware)
        {
            while (HardwareList.Items.Count > 0) HardwareList.Items.Remove(HardwareList.Items[0]);

            foreach(HardwareData hardwareItem in hardware)
            {
                ListViewItem item = new ListViewItem(hardwareItem.ID.ToString());
                item.SubItems.Add(hardwareItem.HardwareType.ToString());
                item.SubItems.Add(hardwareItem.Name);
                string booked = "Free";
                if (hardwareItem.Booked) booked = "Booked";
                item.SubItems.Add(booked);
                HardwareList.Items.Add(item);
            }
        }

        private void PrintSoftwareList(List<SoftwareData> software)
        {
            while (SoftwareList.Items.Count > 0) SoftwareList.Items.Remove(SoftwareList.Items[0]);

            foreach(SoftwareData softwareItem in software)
            {
                ListViewItem item = new ListViewItem($"{softwareItem.ID.ToString()}");
                item.SubItems.Add(softwareItem.Name);
                item.SubItems.Add(softwareItem.PegiAge.ToString());
                item.SubItems.Add(softwareItem.ReleaseDate.Date.ToShortDateString());
                item.SubItems.Add(softwareItem.NumOfPlayers.ToString());
                item.SubItems.Add(softwareItem.PlayerTypeID.ToString());
                string booked = "Free";
                if (softwareItem.Booked) booked = "Booked";
                item.SubItems.Add(booked);
                SoftwareList.Items.Add(item);
            }
        }
    }
}
