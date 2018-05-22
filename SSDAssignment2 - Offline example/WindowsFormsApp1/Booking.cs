using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using GameCafeLibrary;

namespace WindowsFormsApp1
{
    public partial class Booking : Form
    {
        private static System.Timers.Timer _bannerTimer;
        private float _timerSeconds = 5;
        private int _imageIndex = 0;
        //private List<Image> _eventBanners;

        private List<EventData> _events;

        public Booking()
        {
            InitializeComponent();
            SelectDatePicker.MinDate = DateTime.Now;
            EventCalendar.MinDate = DateTime.Now;

            // events
            //_events = Reader.GetAllEvents();
            
            // calendar event dates and dropdown
            //foreach(EventData eventD in _events)
            //{
            //    SelectEventComboBox.Items.Add(eventD.Name);
            //    EventCalendar.AddBoldedDate(eventD.Date);
            //}

            //_eventBanners = new List<Image>();
            //DirectoryInfo dir = new DirectoryInfo(@"..\SSDAssignment2\Images");
            //foreach(var file in dir.GetFiles())
            //{
            //    if (file.Name.Contains("eventBanner")) _eventBanners.Add(Image.FromFile(file.Name));
            //}

            // event banner
            _bannerTimer = new System.Timers.Timer();
            _bannerTimer.Interval = (int)(_timerSeconds * 1000);
            _bannerTimer.Elapsed += ChangeBanner;
            _bannerTimer.AutoReset = true;
            _bannerTimer.Enabled = true;

            // software box
            //List<string> nameList = new List<string>();
            //foreach (SoftwareData game in Reader.GetAllSoftware()) nameList.Add(game.Name);
            //SelectGameComboBox.DataSource = nameList;

            //foreach (SoftwareData game in Reader.GetAllSoftware()) SelectGameComboBox.Items.Add(game.Name);
            SelectGameComboBox.Text = "Select game";
        }

        private void ChangeBanner(object sender, EventArgs e)
        {
            _imageIndex++;
            if (_imageIndex > EventBannerImageList.Images.Count - 1) _imageIndex = 0;
            EventBannerPictureBox.Image = EventBannerImageList.Images[_imageIndex];

            //if (_imageIndex > _eventBanners.Count - 1) _imageIndex = 0;
            //EventBannerPictureBox.Image = _eventBanners[_imageIndex];
        }

        private void CheckBookingsButton_Click_1(object sender, EventArgs e)
        {
            //if pressed etc. 

            //Use data taken from the dates to show all bookings 

            //dataGridView1.Visible = true;
        }

        private void SubmitBooking_Click(object sender, EventArgs e)
        {
            //Take information from the combo boxes and store it in strings. This will then be used to check against the database 
            //To see if the booking can be made or not

            //string Platform = comboBox1.GetItemText(comboBox1.SelectedItem);
            //int id = Reader.GetColumnCount("Booking") + 1;
            int Platform = SelectPlatformComboBox.SelectedIndex + 1;
            string TimeLength = LengthOfBookingComboBox.GetItemText(LengthOfBookingComboBox.SelectedItem);
            int Software = SelectGameComboBox.SelectedIndex + 1;
            int NoOfPeople = int.Parse(NoOfPeopleComboBox.GetItemText(NoOfPeopleComboBox.SelectedItem));

            DateTime Date = EventCalendar.SelectionStart;
            int Time = TimeBox.SelectedIndex + 1;



            //Code for button on click event
            //This is where the values stored in the date picker will be used to push through to the data base

            /*
            If - datepicker date != database values
                add to database
                confirm success

            else
                Send message to user that dates are unavailable
                    Maybe suggest closest date available?
            */

            //BookingData newBooking = new BookingData { ID = id, Name = null, Attenders = NoOfPeople, Hardware = Platform, Software = Software, DateBooked = Date, HoursBooked = Time };
            // Debug
            //BookingData newBooking = new BookingData { ID = id, Name = "John Doe", Attenders = NoOfPeople, Hardware = Platform, Software = Software, DateBooked = new DateTime(2018, 3, 22, 15, 30, 0), HoursBooked = Time };
            BookingData newBooking = new BookingData { ID = 0, Name = "John Doe", Attenders = NoOfPeople, Hardware = Platform, Software = Software, DateBooked = new DateTime(2018, 3, 22, 15, 30, 0), HoursBooked = Time };

            //If successful
            if (Platform != null && TimeLength != "" && Time != null && Software != null && NoOfPeople != null)
            {
                bool IsDuplicate = false;

                //for(int i = 0; i < dataGridView2.RowCount - 1; i++)
                //{                

                //    if (Time == dataGridView2.Rows[i].Cells[3].Value.ToString())
                //    {
                //        IsDuplicate = true;
                //    }
                //}

                if (IsDuplicate == false)
                {
                    //dataGridView2.Rows.Insert(dataGridView2.RowCount - 1, Platform, TimeLength, Date.ToShortDateString(), Time, Software, NoOfPeople);
                    //string error = Writer.AddBooking(newBooking);
                    MessageBox.Show("Booking has been made!", "Booking check", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Duplicate booking, choose another time.", "Booking check", MessageBoxButtons.OK);
            }
        }

        private void SelectDatePicker_DropDown(object sender, EventArgs e)
        {
            SelectDatePicker.MinDate = DateTime.Now;
        }

        private void NumberOfTicketsAddButton_Click(object sender, EventArgs e)
        {
            int tickets = int.Parse(NumberOfTicketsTextBox.Text);
            if (tickets < 100) tickets++;
            NumberOfTicketsTextBox.Text = tickets.ToString();
        }

        private void NumberOfTicketsSubtractButton_Click(object sender, EventArgs e)
        {
            int tickets = int.Parse(NumberOfTicketsTextBox.Text);
            if (tickets > 0) tickets--;
            NumberOfTicketsTextBox.Text = tickets.ToString();
        }

        // test method
        private void listView1_Click(object sender, EventArgs e)
        {

        }
    }
}
