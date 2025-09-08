namespace DesafioPOO.Models
{
    // Classe abstrata que representa um smartphone genérico
    // Não pode ser instanciada diretamente
    public abstract class Smartphone
    {
        // Número do telefone, público para acesso externo
        public string Numero { get; set; }
        // Modelo do smartphone, privado (apenas dentro da classe)
        private string Modelo { get; set; }
        // IMEI do smartphone, privado (apenas dentro da classe)
        private string IMEI { get; set; }
        // Memória do smartphone, privada
        private int Memoria { get; set; }
        // Construtor que inicializa as propriedades do smartphone
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Método para ligar o smartphone
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        // Método para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato para instalar aplicativos
        // Cada classe filha precisa implementar seu próprio comportamento
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
