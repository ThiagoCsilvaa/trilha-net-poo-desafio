namespace DesafioPOO.Models
{
    // Classe Iphone que herda de Smartphone
    // Implementa o método InstalarAplicativo de forma específica
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone, que chama o construtor da classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método abstrato da classe base
        // Instala um aplicativo específico no iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}
