//Two Sum usando fuerza bruta con 2 bucles para entender el funcionamiento
internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4 };
        int target = 5;

        int pos1 = -1;
        int pos2 = -1;

        int f = array.Length - 1;
        for (int i = 0; i <= f; i++)
        {
            for (int j = i + 1; j <= f; j++)
            {
                if (array[i] + array[j] == target)
                {
                    pos1 = i;
                    pos2 = j;
                    break;  
                }
            }
        }

        if (pos1 != -1 && pos2 != -1)
            Console.WriteLine($"Los números son {array[pos1]} y {array[pos2]}");
        else
            Console.WriteLine("No se encontró pareja");
    }
}
