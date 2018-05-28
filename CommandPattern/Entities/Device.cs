using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Entities
{
    public class Device
    {
        public Location Location { get; }

        public Device(Location location)
        {
            this.Location = location;
        }
    }
}
