using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCafeLibrary
{
    public class HardwareData
    {
        //enum HardwareTypes { XboxOne, PS4, PC };
        public int ID { get; set; }
        //public HardwareTypes Type { get; set; }
        public int HardwareType { get; set; }
        public string Name { get; set; }
        public bool Booked { get; set; }
    }
}
