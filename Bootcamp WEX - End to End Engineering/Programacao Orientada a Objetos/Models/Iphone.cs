namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Iphone - Instalando aplicativo {nomeApp}");
        }

        public override void Ligar()
        {
            Console.WriteLine("Iphone - Ligando...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Iphone - Recebendo ligação...");
        }
    }
}