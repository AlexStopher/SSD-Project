using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace GameCafeLibrary
{
    public static class Writer
    {
        private const string URL = @"http://cobbgamescafe.000webhostapp.com";

        private static string FormatDate(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day + "%20" + date.Hour + ":" + date.Minute + ":" + date.Second;
        }

        public static string AddHardware(HardwareData data)
        {
            int HardwareType = data.HardwareType;
            string Name = data.Name;

            string phpLocation = @"/AddHardware.php?";
            string HardwareTypeURL = @"type="+HardwareType.ToString();
            string NameURL = @"name=" + Name;
            string FullURL = URL + phpLocation + HardwareTypeURL + "&" + NameURL;
            return AddData(FullURL);
        }

        public static string AddSoftware(SoftwareData data)
        {
            string Name = data.Name;
            int PegiRatingID = data.PegiAge;
            string ReleaseDate = data.FormatDate();
            int PlayerCount = data.NumOfPlayers;
            int PlayerTypeID = data.PlayerTypeID;

            string phpLocation = @"/AddSoftware.php?";
            string nameURL = @"name="+Name;
            string pegiURL = @"rating=" + PegiRatingID.ToString();
            string releaseURL = @"date=" + ReleaseDate;
            string playerCountURL = @"players=" + PlayerCount.ToString();
            string TypeURL = @"type=" +PlayerTypeID.ToString();

            string FullURL = URL + phpLocation + nameURL + "&" + pegiURL + "&" + releaseURL + "&" + playerCountURL + "&" + TypeURL; ;
            return AddData(FullURL);            

        }

        public static string AddMember(MemberData data)
        {
            string Name = data.Name;
            string DateOfBirth = data.FormatDate();
            string TelephoneNumber = data.PhoneNumber;
            int MemberType = data.MemberTypeID;
            string password = data.Password;
            string username = data.Username;

            string phpLocation = @"/AddUser.php?";
            string nameURL = @"name=" + Name;
            string dobURL = @"dob=" + DateOfBirth;
            string phoneURL = @"telephone=" + TelephoneNumber;
            string typeURL = @"type=" + MemberType;
            string passURL = @"pass=" + password;
            string userURL = @"username=" + username;
            string FullURL = URL + phpLocation + nameURL + "&" + dobURL + "&" + phoneURL + "&" + typeURL + "&" + passURL + "&" + userURL;
            return AddData(FullURL);
            
        }

        public static string AddBooking(BookingData data)
        {

            string phpLocation = @"/AddBooking.php?";
            string idURL = @"id=" + data.ID;
            string nameURL = @"name=" + Reader.GetIDByUserName(data.Name);
            string atendeesURL = @"atendees=" + data.Attenders;
            string hardwareURL = @"hardware=" + data.Hardware;
            string softwareURL = @"software=" + data.Software;
            string timeURL = @"time=" + FormatDate(data.DateBooked);
            string durationURL = @"duration=" + data.HoursBooked;
            string FullURL = URL + phpLocation + idURL + "&" + nameURL + "&" + atendeesURL + "&" + hardwareURL + "&" + softwareURL + "&" + timeURL + "&" + durationURL;
            return AddData(FullURL);

        }

        private static string AddData(string PhPURL)
        {
            WebClient wc = new WebClient();
            string webData = wc.DownloadString(PhPURL);
            return webData;
        }

    }
}
