namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementado: Todas as propriedades faltantes de acordo com o diagrama foram implementadas!
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }
        
        public Smartphone(string numero)
        {
            Numero = numero;
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            // Implementado: Os parâmetros do construtor para as propriedades foram passados.
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}