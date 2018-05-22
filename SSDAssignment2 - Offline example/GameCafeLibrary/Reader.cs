using System;

using System.Net;
//using GameCafeLibrary;
using System.Collections.Generic;

namespace GameCafeLibrary
{
    public class Reader
    {
        ///////////////////////////
        //  PULLING FROM DATABASE
        ///////////////////////////
        public static int GetIDByUserName(string Name)
        {
            string URL = @"https://cobbgamescafe.000webhostapp.com/GetID.php?table=User&name=";
            string nameURL = Name.Replace(" ", "%20");
            WebClient wc = new WebClient();
            string webData = wc.DownloadString(URL + nameURL);
            return int.Parse(webData);
        }

        public static int GetColumnCount(string Table)
        {
            string URL = @"https://cobbgamescafe.000webhostapp.com/GetColumnCount.php?table=";
            WebClient wc = new WebClient();
            string webData = wc.DownloadString(URL + Table);
            return int.Parse(webData);
        }

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

        //returns success of login attempt and sets membertypeID to user's membertype
        public static bool LoginAttempt(string username, string password, out int MembertypeID)
        {
            string URL = @"https://cobbgamescafe.000webhostapp.com/Login.php?Uname=";
            WebClient wc = new WebClient();
            string webData = wc.DownloadString(URL + username + "&Pword=" + password);
            return int.TryParse(webData, out MembertypeID);
        }

        public static string GetPlayerType()
        {
            return GetData("PlayerType");
        }

        ///////////////////////////
        //  UTILITY
        ///////////////////////////

        private static string FormatDate(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day;
        }

        private static int IntFromAllData(ref string allData, char breakChar = '$')
        {
            int breakIndex = allData.IndexOf(breakChar);
            int toReturn = int.Parse(allData.Substring(0, breakIndex));
            allData = allData.Remove(0, breakIndex + 1);
            return toReturn;
        }

        private static string StringFromAllData(ref string allData, char breakChar = '$')
        {
            int breakIndex = allData.IndexOf(breakChar);
            string toReturn = allData.Substring(0, breakIndex);
            allData = allData.Remove(0, breakIndex + 1);
            return toReturn;
        }

        ///////////////////////////
        //  PUBLIC READER METHODS
        ///////////////////////////

        //1$1$Computer1$^
        // id/type/name
        public static List<HardwareData> GetAllHardware()
        {
            string allData = GetData("Hardware");
            if (allData.Length > 0)
            {
                bool finished = false;
                List<HardwareData> listOfHardware = new List<HardwareData>();
                while (!finished)
                {
                    int id = IntFromAllData(ref allData);
                    int hardwareType = IntFromAllData(ref allData);
                    string hardwareName = StringFromAllData(ref allData);
                    allData = allData.Remove(0, 2);

                    listOfHardware.Add(new HardwareData { ID = id, HardwareType = hardwareType, Name = hardwareName, Booked = false });

                    finished = (allData.Length == 0);
                }
                return listOfHardware;
            }
            return null;
        }

        public static List<SoftwareData> GetAllSoftware()
        {
            string allData = GetData("Software");
            if (allData.Length > 0)
            {
                bool finished = false;
                List<SoftwareData> listofSoftware = new List<SoftwareData>();
                while (!finished)
                {
                    int id = IntFromAllData(ref allData);
                    string name = StringFromAllData(ref allData);
                    int pegi = IntFromAllData(ref allData);
                    int year = IntFromAllData(ref allData, '-');
                    int month = IntFromAllData(ref allData, '-');
                    int day = IntFromAllData(ref allData); ;
                    int numPlayers = IntFromAllData(ref allData); ;
                    int playersID = IntFromAllData(ref allData);
                    allData = allData.Remove(0, 1); // because of '^'

                    listofSoftware.Add(new SoftwareData { ID = id, Name = name, PegiAge = pegi, ReleaseDate = new DateTime(year, month, day), NumOfPlayers = numPlayers, PlayerTypeID = playersID, Booked = false });

                    finished = (allData.Length == 0);
                }

                return listofSoftware;
            }
            return null;
        }

        //"1$John Doe$0$Computer1$Portal$2018-02-14 00:00:00$30000$^
        // id/name/atendees/hardware/software/date/length
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
                    int id = IntFromAllData(ref allData);
                    string name = StringFromAllData(ref allData);
                    int attenders = IntFromAllData(ref allData);
                    int hardware = IntFromAllData(ref allData);
                    int software = IntFromAllData(ref allData);
                    string uselessDate = StringFromAllData(ref allData);
                    int hours = IntFromAllData(ref allData);
                    allData = allData.Remove(0, 1); // because of '^'

                    listOfBookings.Add(new BookingData { ID = id, Name = name, Attenders = attenders, Hardware = hardware, Software = software, DateBooked = Date, HoursBooked = hours });

                    finished = (allData.Length == 0);
                }

                return listOfBookings;
            }
            return null;
        }

        // 1$Overwatch Contenders$2018-04-18$13:00:00$8$^
        public static List<EventData> GetAllEvents()
        {
            string allData = GetData("Event");
            
            if (allData.Length > 0)
            {
                bool finished = false;
                List<EventData> listOfEvents = new List<EventData>();
                while (!finished)
                {
                    int id = IntFromAllData(ref allData, '$');
                    string name = StringFromAllData(ref allData, '$');
                    int year = IntFromAllData(ref allData, '-');
                    int month = IntFromAllData(ref allData, '-');
                    int day = IntFromAllData(ref allData, '$');
                    int hour = IntFromAllData(ref allData, ':');
                    allData = allData.Remove(0, allData.IndexOf('$') + 1);
                    int tickets = IntFromAllData(ref allData, '$');
                    allData = allData.Remove(0, 1); // because of '^'

                    listOfEvents.Add(new EventData { Name = name, Date = new DateTime(year, month, day, hour, 0, 0), TicketsRemaining = tickets });
                    finished = (allData.Length == 0);
                }

                return listOfEvents;
            }

            return null;
        }
    }
}
