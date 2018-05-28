using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Entities
{
    public class Light : Device
    {        
        public Light(Location location)
            :base(location)
        {

        }
        
        public string On()
        {            
            Console.WriteLine($"{Location.Name} LIGHT ON");
            return $"{Location.Name} LIGHT ON";
        }

        public string Off()
        {
            Console.WriteLine($"{Location.Name} LIGHT OFF");
            return $"{Location.Name} LIGHT OFF";
        }
    }
}
