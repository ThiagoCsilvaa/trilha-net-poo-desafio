using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Cria um objeto Nokia e atribui à variável do tipo Smartphone
        Smartphone nokia = new Nokia(numero: "9999-9999", modelo: "Nokia", imei: "123456789", memoria: 64);

        // Testa os métodos do smartphone
        nokia.Ligar();                   // Mostra "Ligando..."
        nokia.ReceberLigacao();          // Mostra "Recebendo ligação..."
        nokia.InstalarAplicativo("Jogo da Cobrinha"); // Mostra "Instalando Jogo da Cobrinha no Nokia..."

        Console.WriteLine("-----------------------------");

        // Cria um objeto iPhone e atribui à variável do tipo Smartphone
        Smartphone iphone = new Iphone(numero: "8888-8888", modelo: "iPhone 16", imei: "987654321", memoria: 256);

        // Testa os métodos do smartphone
        iphone.Ligar();                   // Mostra "Ligando..."
        iphone.ReceberLigacao();          // Mostra "Recebendo ligação..."
        iphone.InstalarAplicativo("WhatsApp"); // Mostra "Instalando WhatsApp no iPhone..."
    }
}
