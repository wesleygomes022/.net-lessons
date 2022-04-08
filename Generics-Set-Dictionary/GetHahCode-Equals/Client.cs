using System;

namespace TestProj
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            Client temp = obj as Client;
            return Name.Equals(temp.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
