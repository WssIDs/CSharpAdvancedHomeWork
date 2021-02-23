using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10._1.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class MainAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
