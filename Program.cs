using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"977885522",modelo:"Modelo 2023",imei:"556622114488", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero:"944772233",modelo:"Modelo IPhone 15SX",imei:"224455112255", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
