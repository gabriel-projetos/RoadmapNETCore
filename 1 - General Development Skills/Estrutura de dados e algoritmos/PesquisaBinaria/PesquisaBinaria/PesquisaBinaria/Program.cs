namespace PesquisaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var itens = new List<int> { 1, 4, 5, 6, 8, 9, 11 };

            var valor = 5;
            var position = PesquisaBinaria(itens, valor);

            Console.WriteLine($"O Valor {valor} na lista {string.Join(", ", itens)} se encontra na posição {position + 1}");


            Console.WriteLine(itens.BinarySearch(5));
            Console.ReadLine();
        }
        
        public static int PesquisaBinaria(List<int> list, int valor)
        {
            int inicio = 0;
            int fim = list.Count - 1;
            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (list[meio] == valor)
                {
                    return meio;
                }
                
                if (valor < list[meio])
                {
                    fim = meio - 1;
                }
                else
                {
                    inicio = meio + 1;
                }
            }
            return -1;
        }
    }
}