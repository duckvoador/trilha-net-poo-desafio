using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("125855", "Modelo 1", "444444", "64");
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

System.Console.WriteLine("---------------------------");

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("125855", "Modelo 2", "44445844", "128");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
