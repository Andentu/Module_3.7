namespace Module_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите ваше имя: ");
            var PersonName = Console.ReadLine();
            Console.Write("Укажите, сколько вам лет: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите вашу дату рождения в формате 01.01.2000 г.");
            var birthday = Console.ReadLine();
            Console.WriteLine("Вас зовут {0}. Вы родились {1} и на данный момент вам {2} лет.", PersonName, birthday, age);

            Console.WriteLine(" Press enter...");
            Console.ReadKey();
        }
    }
}