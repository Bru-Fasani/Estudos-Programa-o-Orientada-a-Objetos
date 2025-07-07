using App_POO.Models;

Console.WriteLine("Smartphone Samsung:");
Smartphone Samsung = new Samsung(numero: "123456", modelo: "Galaxy M62", imei: "xxxxx", memoria: 64);
Samsung.Ligar();
Samsung.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: " 16 Pro Max", imei: "xxxxxxx", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Strava");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Xiaomi:");
Smartphone xiaomi = new Xiaomi(numero: "2725", modelo: "Poco x7 pro", imei: "xxxxxxx", memoria: 512);
xiaomi.ReceberLigacao();
xiaomi.InstalarAplicativo("Instagram");