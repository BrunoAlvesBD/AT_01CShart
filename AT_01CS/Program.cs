namespace AT_01CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //validação de entrada para o numero inteiro
            string entrada;
            int num = 0;
            while (true)
            {
                Console.WriteLine("Informe o número: ");
                entrada = Console.ReadLine();
                try
                {
                    num = int.Parse(entrada);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Valor inválido, digite um numero inteiro!");
                }

            }
        //sequencia de Fibonacci
            double n1 = 0;
            double n2 = 1;
            double n3 = 0;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i < num; i++) {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.WriteLine(n3);
        
            }
        }
    }
}
