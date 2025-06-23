using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
System.Console.WriteLine("Nokia Criado com sucesso!");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 256);
System.Console.WriteLine("Iphone Criado com sucesso!");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
