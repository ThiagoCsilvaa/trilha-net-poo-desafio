namespace DesafioPOO.Models
{
    // Classe Nokia que herda de Smartphone
    // Implementa o método InstalarAplicativo de forma específica
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia, que chama o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método abstrato da classe base
        // Instala um aplicativo específico no Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}
