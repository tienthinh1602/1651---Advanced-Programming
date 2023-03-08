namespace Homework
{
    /*
    * A test driver for Person and its subclasses.
    */
    public class TestPerson {
        public static void Main(String[] args) {

            Console.WriteLine();  
            /* Test Student class */
            Student s1 = new Student("Tan Ah Teck", "1 Happy Ave");
            Console.WriteLine(s1);       

            // s1.AddCourseGrade("IM101", 97);
            // s1.AddCourseGrade("IM102", 68);
            // s1.PrintGrades();
            // Console.WriteLine("Average is " + s1.GetAverageGrade());
            
            // /* Test Teacher class */
            // Teacher t1 = new Teacher("Paul Tan", "8 sunset way");
            Console.WriteLine();
            // Console.WriteLine(t1);
            // String[] courses = {"IM101", "IM102", "IM101"};
            // for (String course: courses) {
            //     if (t1.AddCourse(course)) {
            //         Console.WriteLine(course + " added.");
            //     } else {
            //         Console.WriteLine(course + " cannot be added.");
            //     }
            // }
            // for (String course: courses) {
            //     if (t1.RemoveCourse(course)) {
            //         Console.WriteLine(course + " removed.");
            //     } else {
            //         Console.WriteLine(course + " cannot be removed.");
            //     }
            // }
            Console.WriteLine();        
        }
    }

}