using System;
using System.Collections.Generic;

namespace TestProj.Entities
{
    class Log
    {
        public string Name { get; set; }
        public string Time { get; set; }

        public Log(string name, string time)
        {
            Name = name;
            Time = time;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Log temp = obj as Log;
            return Name.Equals(temp.Name);
        }
    }
}
