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
            if(n <= 0) //caso base da recursão, a função não chama a si mesma
            {
                return;
            }
            else
            {
                Regressive(n - 1); //caso recursivo, a função chama a si mesmo
            }
        }
    }
}