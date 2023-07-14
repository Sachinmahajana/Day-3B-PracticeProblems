namespace Day_3B_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Day 3b Practice Problems");
            Console.WriteLine("\n1:Constructor\n2:AcessModifier");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    new Constructors();
                    new Constructors(10, 20);
                    break;
                case 2:
                    AcessModifier acc = new AcessModifier();
                    acc.Numbers(10, 20);
                    acc.Numb(50, 60);
                    break;
            }
            Console.ReadLine();
        }
    }
}