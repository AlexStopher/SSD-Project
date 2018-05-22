using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCafeLibrary
{
    public class SoftwareData
    {
        //enum PlayerNum { Singleplayer, Online, Splitscreen, Cooperative };
        public int ID { get; set; }
        public string Name { get; set; }
        public int PegiAge { get; set; }
        public DateTime ReleaseDate { get; set; }
        //public PlayerNum Players { get; set; }
        public int NumOfPlayers { get; set; }
        public int PlayerTypeID { get; set; }
        public int HardwareType { get; set; }
        public bool Booked { get; set; }
        public string FormatDate()
        {
            return $"{ReleaseDate.Year.ToString()}-{ReleaseDate.Month.ToString()}-{ReleaseDate.Day.ToString()}";
        }
    }
}
