using Microsoft.VisualBasic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 8, 4 };

        /* int[] ordenado = BubbleSort(array);
        Console.WriteLine(string.Join(", ", ordenado));
        */
        int[] ordenado = SelectionSort(array);
        Console.WriteLine(string.Join(", ", ordenado));

    }
    static int[] BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int n = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = n;
                }
            }
        }

        return array;
    }
    static int[] SelectionSort(int[] array)
    {

        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndice = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndice])
                {
                    minIndice = j;
                }
            }
            int VarTemporal = array[i];
            array[i] = array[minIndice];
            array[minIndice] = VarTemporal;
        }
        return array;
    }
}