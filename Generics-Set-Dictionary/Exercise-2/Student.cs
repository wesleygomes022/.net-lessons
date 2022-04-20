using System;

namespace TestProj
{
    class Student
    {
        public int RA { get; set; }
        public char Course { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student temp = obj as Student;
            return RA.Equals(temp.RA);
        }

        public override int GetHashCode()
        {
            return RA.GetHashCode();
        }
    }
}
