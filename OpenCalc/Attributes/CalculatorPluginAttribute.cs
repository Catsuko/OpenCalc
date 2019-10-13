using System;

namespace OpenCalc
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CalculatorPluginAttribute : Attribute
    {
        public CalculatorPluginAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
    }
}
