namespace Homework
{
    class Teacher : Person
    {
        private int numCourses;
        private string[] courses;

        public Teacher()
        {
            this.numCourses = 0;
            this.courses = new string[5];
        }

        public Teacher(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        // public bool AddCourse(string course)
        // {

        // }

        // public bool RemoveCourse(string course)
        // {

        // }

        // public override string ToString()
        // {
        //     return base.ToString();
        // }
    }   
}