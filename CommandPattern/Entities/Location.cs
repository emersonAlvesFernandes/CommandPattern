using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Entities
{
    public class Location
    {

        public Location(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public new string ToString => Name.ToString();
    }
}
