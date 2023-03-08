namespace Homework
{
    class Student : Person
    {
        private int numCourses{ get; set; }
        private string[] courses{ get; set; }
        private int[] grades{ get; set; }

        public Student()
        {
            this.Name = "";
            this.Address = "";            
            

        }

        public Student(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public void AddCourseGrade(string course, int grade)
        {
            
        }

        // public void PrintGrades()
        // {
        //     foreach(int grade in grades)
        //     {
        //         Console.WriteLine(grade);
        //     }
        // }

        // public double GetAverageGrade()
        // {

        // }    

    //     public override string ToString()
    //     {
    //         return "Name " + this.Name + "Address: " + this.Address;
    //     }
    }
}