internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Primo o no primo");

        Console.WriteLine("Ingrese un numero");
        int num = Convert.ToInt32(Console.ReadLine());

        int res = Primo(num);

        if(res == 1)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No primo");
        }
    }

    static int Primo(int n)
    {
       if(n == 1)
        {
            return 0;
        }
       if(n == 2)
        {
            return 1;
        }
       if(n % 2 == 0)
        {
            return 0;
        }
        else
        {
           for(int i = 3; i<= Math.Sqrt(n); i += 2)
            {
                if(n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}