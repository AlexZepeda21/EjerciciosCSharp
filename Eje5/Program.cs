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
        if(res == 2)
        {
            Dictionary<int, int> FibonnaciList = new Dictionary<int, int>();
            int n = 1;
            while (n != 0)
            { 
                Console.WriteLine("Escriba un numero x, 0 para salir");
                n = Convert.ToInt32(Console.ReadLine());

                if (FibonnaciList.ContainsKey(n))
                {
                    Console.WriteLine($"Fibonacci({n}) = {FibonnaciList[n]}");
                }
                if (n == 0)
                {
                    Console.WriteLine("fibonacci(0) = 0");
                    FibonnaciList.Add(0, 0);
                }
                if (n == 1)
                {
                Console.WriteLine("fibonacci(1) = 1");
                    FibonnaciList.Add(1, 1);
                }
                else
                {
                    int response = Fibonacci(n, FibonnaciList);

                    FibonnaciList.Add(n, response);
                    Console.WriteLine(response);                }

            }
        }
    }

    static int Fibonacci(int n, Dictionary<int, int> memo)
    {
        if (memo.ContainsKey(n))
            return memo[n];

        if (n == 0) return 0;
        if (n == 1) return 1;

        int result = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);
        memo[n] = result;
        return result;
    }
}
