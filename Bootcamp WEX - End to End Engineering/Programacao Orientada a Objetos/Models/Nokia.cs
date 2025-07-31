namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Nokia - Instalando aplicativo {nomeApp}");
        }

        public override void Ligar()
        {
            Console.WriteLine("Nokia - Ligando...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Nokia - Recebendo ligação...");
        }
    }
}