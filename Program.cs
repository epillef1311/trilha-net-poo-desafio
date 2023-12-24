using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "9949192", modelo:"Modelo X25S1", imei:"1235213", memoria:128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Subway surfers");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "8548143", modelo:"Modelo I2023", imei:"7895213", memoria:64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tetris");
// TODO: Realizar os testes com as classes Nokia e Iphone