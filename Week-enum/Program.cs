

namespace Week_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weekdays[] days = (Weekdays[])Enum.GetValues(typeof(Weekdays));
            foreach (Weekdays day in days)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("please enter your name");
            string name= Console.ReadLine();
            Console.WriteLine("please enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("please enter your birtday");
            int birthday=Convert.ToInt32( Console.ReadLine());
            User user = new User(name, surname, days[birthday-1]);

        }
    }
}