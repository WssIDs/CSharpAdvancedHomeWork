using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5._2
{
    public class City
    {
        public string Name { get; set; }
        public string ZipCode { get; set; }

        public Neighborhood Neighborhood { get; set; }
    }
}
