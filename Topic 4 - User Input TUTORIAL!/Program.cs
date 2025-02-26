namespace Topic_4___User_Input_TUTORIAL_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int age;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine();
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age); // TryParse method
            Console.WriteLine("Your age is: " + age);

        }
    }
}
