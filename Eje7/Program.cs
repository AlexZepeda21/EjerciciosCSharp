//Revertir el arreglo sin usar ningun tipo de variable temporal
internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int[] response = Invertir(array);

        Console.WriteLine(string.Join(",", response));
    }

    static int[] Invertir(int[] array)
    {
        int i = 0;
        int d = array.Length - 1;

        while (i < d)
        {
            array[i] = array[i] + array[d];
            array[d] = array[i] - array[d];
            array[i] = array[i] - array[d];

            i++;
            d--;
        }
        return array;
    }
}
