using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11910725179", modelo: "Nokia Tijolinho", imei: "1153265479", memoria: 2);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "11986959009", modelo: "iPhone 11", imei: "26549866", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");