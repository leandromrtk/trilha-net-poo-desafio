using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone("81993804343", "14-pro", "003994993", 160);

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Console.WriteLine("Especificações:");
Console.WriteLine($"Modelo: {iphone.Modelo}, Memória RAM {iphone.Memoria}GB ");

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Cap-Cut");

Console.WriteLine("\n");


Smartphone nokia = new Nokia("81933456712", "Lumia", "3332223434", 8);
Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Console.WriteLine("Especificações:");
Console.WriteLine($"Modelo: {nokia.Modelo}, Memória RAM {nokia.Memoria}GB ");

nokia.Ligar();
nokia.InstalarAplicativo("Facebook");