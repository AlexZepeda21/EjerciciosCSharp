//Factorial(iterativo y recursivo).



//Mi solución de forma iterativa

//Console.WriteLine("Ingrese un numero x");
//string response = Console.ReadLine();

//int numero = 0;

//numero = Convert.ToInt32(response);
//int factorial = numero;

//for (int i = 1; i<numero; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine("El factorial del numero es " + factorial);



//Solución mas optima de forma iterativa

//Console.WriteLine("Ingrese un numero x");
//string r = Console.ReadLine();

//int n = Convert.ToInt32(r);
//int factorial = 1;

//for (int i = 2; i <= n; i++)
//{
//    factorial *= i;
//}

//Console.WriteLine("El factorial de " + n + " es " + factorial);


//Solución de forma recursiva

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero");
        string r = Console.ReadLine();

        int n = Convert.ToInt32(r);

        int resultado = Factorial(n);

        Console.WriteLine(resultado);
       
    }
    static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

}
