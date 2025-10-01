//Recursión

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicios de recursividad");
        Console.WriteLine("1 = Eje1 Combinación");
        string response = Console.ReadLine();
        switch (response)
        {
            case "1" :
                Console.WriteLine("Ingrese n");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese r");
                int r = Convert.ToInt32(Console.ReadLine());

                int resultado = CombinacionRecursiva(5, 2);
                Console.WriteLine($"Resultado final: {resultado}");

                break;
        }
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * Factorial(n - 1);
    }

    static int Eje1Combinacion(int n, int r)
    {
        int FacNumero = Factorial(n);
        int FacRango = Factorial(r);
        int FacRestante = Factorial(n - r);

        return FacNumero / (FacRango * FacRestante);
    }

    static int CombinacionRecursiva(int r, int n, int nivel = 0)
    {
        // Indentación visual según el nivel de recursión
        string indent = new string(' ', nivel * 2);

        Console.WriteLine($"{indent}Llamada: C({r},{n})");

        // Caso imposible
        if (n > r)
        {
            Console.WriteLine($"{indent}→ Imposible (n > r) → 0");
            return 0;
        }

        // Casos base
        if (n == 0 || n == r)
        {
            Console.WriteLine($"{indent}→ Caso base (n==0 o n==r) → 1");
            return 1;
        }

        // Paso recursivo
        int incluir = CombinacionRecursiva(r - 1, n - 1, nivel + 1);
        int noIncluir = CombinacionRecursiva(r - 1, n, nivel + 1);

        int resultado = incluir + noIncluir;

        Console.WriteLine($"{indent}Resultado C({r},{n}) = {incluir} + {noIncluir} = {resultado}");

        return resultado;
    }

    static int Eje2(int n)
    {
        return n;
    }
}