using System;
using System.Collections.Generic;

internal class TwoSum
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int target = 5;

        var resultado = TwooSum(array, target);

        if (resultado != null)
            Console.WriteLine($"Los números son {array[resultado[0]]} y {array[resultado[1]]} en posiciones {resultado[0]} y {resultado[1]}");
        else
            Console.WriteLine("No se encontró pareja");
    }

    static int[] TwooSum(int[] array, int target)
    {
        Dictionary<int, int> mapa = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            int complemento = target - array[i];

            if (mapa.ContainsKey(complemento))
            {
                return new int[] { mapa[complemento], i };
            }
            if (!mapa.ContainsKey(array[i]))
            {
                mapa[array[i]] = i;
            }
        }

        return null; 
    }
}
