using System;

namespace GLEntitySystem
{
    class ComponentFlagException : Exception
    {
        public ComponentFlagException(string message) : base(message) { }
    }
}