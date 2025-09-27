internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un valor");
        Console.WriteLine("1 : Iterativo");
        Console.WriteLine("2 : Fibonacci Recursivo");
        int res = Convert.ToInt32(Console.ReadLine());

        if (res == 1)
        {
            Console.WriteLine("Ingrese un número para calcular Fibonacci:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Fibonacci(0) = 0");
            }
            else if (n == 1)
            {
                Console.WriteLine("Fibonacci(1) = 1");
            }
            else
            {
                int a = 0;
                int b = 1;

                Console.WriteLine("Secuencia:");
                Console.WriteLine($"0 Fibonacci {a}");
                Console.WriteLine($"1 Fibonacci {b}");

                for (int i = 2; i <= n; i++)
                {
                    int resultado = a + b;
                    a = b;
                    b = resultado;
                    Console.WriteLine($"{i} Fibonacci {b}");
                }

                Console.WriteLine($"El Fibonacci en la posición {n} es {b}");
            }
        }
    }
}
