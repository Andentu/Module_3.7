namespace Module_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var PersonName = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Your name is {PersonName} and age is {age}");
            Console.Write("\nEnter your birthdate: ");
            var birthday = Console.ReadLine();
            Console.WriteLine($"Your birthdate is {birthday}");

            Console.WriteLine("Press enter...");
            Console.ReadKey();


        }
    }
}