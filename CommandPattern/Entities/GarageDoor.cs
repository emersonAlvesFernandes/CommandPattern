using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Entities
{
    public class Gate : Device
    {
        public Gate(Location location) : base(location)
        {
        }

        public string Open()
        {            
            Console.WriteLine($"{Location.Name} DOOR OPEN");
            return $"{Location.Name} DOOR OPEN";
        }

        public string Close()
        {
            Console.WriteLine($"{Location.Name} DOOR CLOSE");
            return $"{Location.Name} DOOR CLOSE";
        }
    }
}
