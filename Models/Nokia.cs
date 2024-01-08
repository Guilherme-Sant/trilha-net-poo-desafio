namespace DesafioPOO.Models
{
    // Implementado: Nokia herda a classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public Nokia(string numero) : base(numero)
        {
        }

        // TODO: Implementado: Método "InstalarAplicativo" foi sobrescrito para Nokia!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}, no seu Nokia!");
        }
    }
}