using DesafioPOO.Models;

class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "1199999-9999", modelo: "Modelo 1", imei: "111101111", memoria: 128);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "1191111-1111", modelo: "Iphone 15", imei: "00001000", memoria: 64);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
    }
}