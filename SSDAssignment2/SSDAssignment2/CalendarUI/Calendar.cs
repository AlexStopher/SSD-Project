using System;
using System.Collections.Generic;
using System.Windows.Forms;

using HardwareSoftwareBrowsing;
using GameCafeLibrary;

namespace CalendarUI
{
    public partial class CalendarForm : Form
    {
        // dummy setup
        struct DummyBooking
        {
            public DateTime date { get; set; }
            public int ID { get; set; }
            public string Name { get; set; }
            public int Attenders { get; set; }
            public string Hardware { get; set; }
            public string Software { get; set; }
            public string Time { get; set; }
            public float Duration { get; set; }
        }
        List<DummyBooking> dummyBookings = new List<DummyBooking>();


        ////////////
        // SETUP
        ////////////
        HardSoftForm hardSoftListForm;
        List<BookingData> bookings = new List<BookingData>();

        // Constructor
        public CalendarForm()
        {
            InitializeComponent();
            SetupData();
            //bookings = GetBookingsFromTableByDate(new DateTime(2018, 2, 14));
            PrintList(GetBookingsForDate(calendarComponent.TodayDate));
        }

        // Creates dummy data
        private void SetupData()
        {
            dummyBookings.Add(new DummyBooking
            {
                date = new DateTime( 2018, 2, 6 ),
                ID = 1,
                Name =  "John",
                Attenders =  1,
                Hardware = "XBone 1",
                Software = "Grand Theft Auto V",
                Time = "15.00",
                Duration = 1.0f
            });

            dummyBookings.Add(new DummyBooking
            {
                date = new DateTime(2018, 2, 6),
                ID = 2,
                Name = "Harry",
                Attenders = 4,
                Hardware = "PS4 1",
                Software = "Mortal Kombat X",
                Time = "12.00",
                Duration = 2.0f
            });

            dummyBookings.Add(new DummyBooking
            {
                date = new DateTime(2018, 2, 6),
                ID = 3,
                Name = "Harry",
                Attenders = 4,
                Hardware = "PS4 2",
                Software = "Mortal Kombat X",
                Time = "12.00",
                Duration = 2.0f
            });

            dummyBookings.Add(new DummyBooking
            {
                date = new DateTime(2018, 2, 7),
                ID = 1,
                Name = "Jessica",
                Attenders = 1,
                Hardware = "PC 1",
                Software = "League of Legends",
                Time = "11.00",
                Duration = 1.5f
            });

            dummyBookings.Add(new DummyBooking
            {
                date = new DateTime(2018, 2, 7),
                ID = 2,
                Name = "Bill",
                Attenders = 1,
                Hardware = "PC 2",
                Software = "Counter Strike: Global Offensive",
                Time = "11.30",
                Duration = 1.0f
            });

            dummyBookings.Add(new DummyBooking
            {
                date = new DateTime(2018, 2, 7),
                ID = 3,
                Name = "Arnold",
                Attenders = 2,
                Hardware = "PS4 1",
                Software = "Dead Nation",
                Time = "17.00",
                Duration = 2.0f
            });
        }


        ////////////
        // METHODS
        ////////////
        // returns a list of bookings that are booked for the specified date
        private List<BookingData> GetBookingsForDate(DateTime dateProvided)
        {
            return Reader.PHPGetBookingsByDate(dateProvided);
        }

        // prints list of bookings provided to the bookings list view
        private void PrintList(List<BookingData> bookings)
        {
            while (bookingsList.Items.Count != 0) bookingsList.Items.Remove(bookingsList.Items[0]);
            if (bookings == null) return;

            foreach (BookingData booking in bookings)
            {
                ListViewItem item = new ListViewItem($"{booking.ID.ToString()}");
                item.SubItems.Add(booking.Name);
                item.SubItems.Add($"{booking.Attenders}");
                item.SubItems.Add(booking.Hardware);
                item.SubItems.Add(booking.Software);
                item.SubItems.Add(booking.DateBooked.ToShortDateString());
                item.SubItems.Add($"{booking.HoursBooked} hours");
                bookingsList.Items.Add(item);
            }
        }


        ////////////
        // EVENTS
        ////////////
        // Event when the user clicks on a different date on the calendar
        private void calendarComponent_DateChanged(object sender, DateRangeEventArgs e)
        {
            PrintList(GetBookingsForDate(e.Start));
        }

        private void hardSoftList_Click(object sender, EventArgs e)
        {
            hardSoftListForm = new HardSoftForm();
            hardSoftListForm.Show();
        }
    }
}
