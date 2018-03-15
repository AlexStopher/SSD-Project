using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCafeLibrary
{
    public class BookingData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Attenders { get; set; }
        public string Hardware { get; set; }
        public string Software { get; set; }
        public DateTime DateBooked { get; set; }
        public int HoursBooked { get; set; }
    }
}
