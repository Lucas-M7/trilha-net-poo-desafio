using System.Security.AccessControl;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            numero = "01010001";
            modelo = "XR";
            imei = "110010011";
            memoria = 64;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            nomeApp = "Dio";
            Console.WriteLine($"Instalando {nomeApp} app");
        }
    }
}