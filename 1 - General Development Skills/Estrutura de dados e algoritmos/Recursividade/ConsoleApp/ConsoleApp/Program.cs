namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regressive(5);

            Console.ReadLine();
        }

        public static void Regressive(int n)
        {
            Console.WriteLine(n);
            if(n <= 0)
            {
                return;
            }
            else
            {
                Regressive(n - 1);
            }
        }
    }
}