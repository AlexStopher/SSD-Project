using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCafeLibrary
{
    public class MemberData
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int MemberTypeID { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string FormatDate()
        {
            return $"{DateOfBirth.Year.ToString()}-{DateOfBirth.Month.ToString()}-{DateOfBirth.Day.ToString()}";
        }
        public string FormatToTable()
        {
            string formattedDate = FormatDate();
            return $"{Name} {formattedDate} {PhoneNumber} {MemberTypeID.ToString()} {Password} {Username}";
        }
    }
}
