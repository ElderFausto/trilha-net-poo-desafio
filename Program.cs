using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone iphone = new Iphone("5581996341285", "Iphone 15 Pro Max", "001970-01-010000-0", 256);
Console.WriteLine("Iphone 15 Pro Max");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Call of Duty");

Console.WriteLine("\n");
Console.WriteLine("-------------------------------------------");

Console.WriteLine("Nokia G60 5G");
Smartphone nokia = new Nokia("5581990574135", "Nokia G60 5G", "001977-01-018000-0", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Free Fire");