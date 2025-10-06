using Ej1ProductosLinq;

internal class Program
{
    static void Main(string[] args)
    {
        List<Producto> products = new List<Producto>
        {
            new Producto{Nombre = "Manzana", Categoria= "fruta", Precio = 10.0},
            new Producto{Nombre = "Platano", Categoria = "fruta", Precio = 10.0},
            new Producto{Nombre = "Rabano", Categoria = "verdura", Precio = 5.0},
            new Producto{Nombre = "Berro", Categoria = "verdura", Precio = 5.0}

        };
        var agrupados = products
           .GroupBy(p => p.Categoria)
           .Select(g => new
           {
               Categoria = g.Key,
               Subtotal = g.Sum(p => p.Precio)
           });

        // Mostrar resultados
        foreach (var grupo in agrupados)
        {
            Console.WriteLine($"{grupo.Categoria}: {grupo.Subtotal}");
        }
    }
}