

namespace DesafioPOO.Models
{
    // Implementado: Iphone herda a classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public Iphone(string numero) : base(numero)
        {
        }

        // Implementado: Método "InstalarAplicativo" foi sobrescrito para iphone!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no seu Iphone!");
        }
    }
}