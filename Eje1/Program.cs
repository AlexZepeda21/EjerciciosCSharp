//Escribir un programa que pida nombre y ead y muestre Hola {nombre} tienes {edad} años.

Console.WriteLine("Hola cual es tu nombre?");
string nombre = Console.ReadLine();
Console.WriteLine("Cual es tu edad?");
string edad = Console.ReadLine();

Console.WriteLine("Hola " + nombre + " tienes " + edad + " años");