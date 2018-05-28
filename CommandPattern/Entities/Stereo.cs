using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Entities
{
    public class Stereo : Device
    {
        public Stereo(Location location) : base(location)
        {

        }

        public string On()
        {            
            Console.WriteLine($"{Location.Name} DEVICE ON");
            return $"{Location.Name} ON";
        }

        public string Off()
        {
            Console.WriteLine($"{Location.Name} DEVICE OFF");
            return $"{Location.Name} ON";
        }

        public string SetCd()
        {            
            Console.WriteLine($"{Location.Name} stereo CD set");
            return $"{Location.Name} Ostereo CD set";
        }

        public string SetVolume(int value)
        {
            Console.WriteLine($"{Location.Name} Stereo volume: {value}");
            return $"{Location.Name} Stereo volume: {value}";            
        }
    }
}
