using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Classes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomAttribute : Attribute
    {
        private int _number;
        public string Name { get; set; }

        public CustomAttribute(int number)
        {
            _number = number;
        }
    }
}
