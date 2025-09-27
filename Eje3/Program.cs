
    Console.WriteLine("Escriba un numero");
    int n = Convert.ToInt32(Console.ReadLine());
    Contar(n);

static void Contar(int num)
{
    if (num == 0)
    {
        return;
    }
    else
    {
        Console.WriteLine(num);
        Contar(num - 1);
    }
}