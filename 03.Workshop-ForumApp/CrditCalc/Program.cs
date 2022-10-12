namespace CrditCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much credits do you need?");
            int inputCredits = int.Parse(Console.ReadLine());

            int creditDailyCurr = 10;
            int crditConst = 5;
            int creditTotal = 127;
            int daysNeeded = 0;

            while (creditTotal <= inputCredits)
            {
                creditTotal += crditConst + creditDailyCurr;
                daysNeeded++;
                creditDailyCurr++;
            }

            Console.WriteLine("Days needed:" + daysNeeded);
            Console.WriteLine("Which is " + daysNeeded/30 + " months");
        }
    }
}