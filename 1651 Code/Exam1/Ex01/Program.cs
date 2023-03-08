

namespace Exam
{
    class ex01test{
        public static void Main(String[] args)
        {
            Temperature t = new Temperature();
            Console.WriteLine("Please enter Fahrenheit value: ");
           
            double ftemp = Convert.ToDouble(Console.ReadLine());
            if(ftemp == 0)
            {
                Console.WriteLine("Press any key to continue... ");                
            }
            else
            {
                t.setFahrenheit(ftemp);
                Console.WriteLine(t);
            }
            

        }
    }
}
