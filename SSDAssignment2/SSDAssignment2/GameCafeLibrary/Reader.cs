using System;

using System.Net;
//using GameCafeLibrary;
using System.Collections.Generic;

namespace GameCafeLibrary
{
    public class Reader
    {
        private static string GetData(string TableName)
        {
            string URL = @"https://cobbgamescafe.000webhostapp.com/GetData.php?table=";
            WebClient wc = new WebClient();
            string webData = wc.DownloadString(URL + TableName);
            return webData;

        }

        private static string GetBookings(string where)
        {
            string URL = @"https://cobbgamescafe.000webhostapp.com/GetBookings.php?where=";
            WebClient wc = new WebClient();
            string webData = wc.DownloadString(URL + where);
            return webData;
        }

        public static string GetPlayerType()
        {
            return GetData("PlayerType");
        }

        private static string FormatDate(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day;
        }

        //1$1$Computer1$^2$1$Computer2$^
        public static List<HardwareData> GetAllHardware()
        {
            string allData = GetData("Hardware");
            if (allData.Length > 0)
            {
                bool finished = false;
                List<HardwareData> listOfHardware = new List<HardwareData>();
                while (!finished)
                {
                    // id
                    int breakIndex = allData.IndexOf('$');
                    int id = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // hardware type
                    breakIndex = allData.IndexOf('$');
                    int hardwareType = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // hardware name
                    breakIndex = allData.IndexOf('^');
                    string hardwareName = allData.Substring(0, breakIndex - 1);
                    allData = allData.Remove(0, breakIndex + 1);

                    listOfHardware.Add(new HardwareData { ID = id, HardwareType = hardwareType, Name = hardwareName, Booked = false });

                    finished = (allData.Length == 0);
                }
                return listOfHardware;
            }
            return null;
        }

        //1$Portal$1$2007-10-10$1$1$^2$Cuphead$2$2017-09-29$2$2$^3$Dark souls$1$2011-09-22$1$1$^
        public static List<SoftwareData> GetAllSoftware()
        {
            string allData = GetData("Software");
            if (allData.Length > 0)
            {
                bool finished = false;
                List<SoftwareData> listofSoftware = new List<SoftwareData>();
                while (!finished)
                {
                    // id
                    int breakIndex = allData.IndexOf('$');
                    int id = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // name
                    breakIndex = allData.IndexOf('$');
                    string name = allData.Substring(0, breakIndex);
                    allData = allData.Remove(0, breakIndex + 1);

                    // PEGI ID
                    breakIndex = allData.IndexOf('$');
                    int pegi = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // release date (year)
                    breakIndex = allData.IndexOf('-');
                    int year = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // release date (month)
                    breakIndex = allData.IndexOf('-');
                    int month = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // release date (day)
                    breakIndex = allData.IndexOf('$');
                    int day = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // Number of players
                    breakIndex = allData.IndexOf('$');
                    int numPlayers = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // Player type ID
                    breakIndex = allData.IndexOf('^');
                    int playersID = int.Parse(allData.Substring(0, breakIndex - 1));
                    allData = allData.Remove(0, breakIndex + 1);

                    listofSoftware.Add(new SoftwareData { ID = id, Name = name, PegiAge = pegi, ReleaseDate = new DateTime(year, month, day), NumOfPlayers = numPlayers, PlayerTypeID = playersID, Booked = false });

                    finished = (allData.Length == 0);
                }

                return listofSoftware;
            }
            return null;
        }






        private string FormatString(out string substring, ref string data, int breakIndex)
        {
            substring = data.Substring(0, breakIndex);
            data.Remove(0, breakIndex + 1);
            return substring;
        }

        public static List<BookingData> PHPGetBookingsByDate(DateTime Date)
        { 
            string dateString = FormatDate(Date);
            string allData = GetBookings(dateString);

            if (allData.Length > 0)
            {
                bool finished = false;
                List<BookingData> listOfBookings = new List<BookingData>();
                while (!finished)
                {
                    // id
                    int breakIndex = allData.IndexOf('$');
                    int id = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // name
                    breakIndex = allData.IndexOf('$');
                    string name = allData.Substring(0, breakIndex);
                    allData = allData.Remove(0, breakIndex + 1);
                    //string name;
                    //FormatString(out name, ref allData, breakIndex);

                    // attenders
                    breakIndex = allData.IndexOf('$');
                    int attenders = int.Parse(allData.Substring(0, breakIndex));
                    allData = allData.Remove(0, breakIndex + 1);

                    // hardware
                    breakIndex = allData.IndexOf('$');
                    string hardware = allData.Substring(0, breakIndex);
                    allData = allData.Remove(0, breakIndex + 1);

                    // software
                    breakIndex = allData.IndexOf('$');
                    string software = allData.Substring(0, breakIndex);
                    allData = allData.Remove(0, breakIndex + 1);

                    // don't want the date
                    breakIndex = allData.IndexOf('$');
                    allData = allData.Remove(0, breakIndex + 1);

                    // only want the hours
                    breakIndex = allData.IndexOf('^');
                    int hours = int.Parse(allData.Substring(0, 2));
                    allData = allData.Remove(0, breakIndex + 1);

                    listOfBookings.Add(new BookingData { ID = id, Name = name, Attenders = attenders, Hardware = hardware, Software = software, DateBooked = Date, HoursBooked = hours });

                    finished = (allData.Length == 0);
                }

                return listOfBookings;
            }

            return null;
        }
    }
}
