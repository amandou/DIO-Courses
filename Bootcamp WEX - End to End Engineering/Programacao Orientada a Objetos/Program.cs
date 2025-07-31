using DesafioPOO.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Nokia celularAndroid = new Nokia(numero: "011 0000000", modelo: "N2", imei: "00000", memoria: 64);
Iphone celularIOS = new Iphone(numero: "011 0000000", modelo: "N2", imei: "00000", memoria: 64);

celularAndroid.InstalarAplicativo("Angry Birds");
celularIOS.InstalarAplicativo("Plant vs Zombies");

celularAndroid.Ligar();
celularIOS.ReceberLigacao();