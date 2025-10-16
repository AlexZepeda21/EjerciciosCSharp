using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Xml.Linq;

internal class Program {
    static void Main(string[] args) {

        Console.WriteLine("Conversor decimal a binario y viceversa");
        Console.WriteLine("1: Desea convertir de decimal a binario");
        Console.WriteLine("2: Desea convertir de binario a decimal");
        int opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {
            Console.WriteLine("Ingrese el decimal");
            int varDecimal = Convert.ToInt32(Console.ReadLine());
            string response = DecimalBinario(varDecimal);
            Console.WriteLine(response);
        }
        else
        {
            Console.WriteLine("Ingrese el binario");
            string binario = Console.ReadLine();
            string response = BinarioDecimal(binario);
            Console.WriteLine(response);
        }
    }

    //Decimal a binario
    static string DecimalBinario(int num)
    {
        string binario = "";
        string response = "";

        while (num > 0)
        {
            int save = num % 2;
            binario += save.ToString();
            num = num / 2;
        }

        for (int i = binario.Length - 1; i >= 0; i--)
        {
            response += binario[i];
        }

        return response;
    }

    //binario a Decimal
    static string BinarioDecimal(string num)
    {
        int potencia = num.Length - 1;
        int response = 0;
        int varDecimal = 0;

        for (int i = 0; i <= num.Length - 1; i++) {
            int bit = num[i] - '0';
            response = bit * (int)Math.Pow(2, potencia);
            varDecimal += response;
            potencia--;
        }
        return Convert.ToString(varDecimal);
    }

}