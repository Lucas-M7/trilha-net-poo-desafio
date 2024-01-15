namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            numero = "1086437691";
            modelo = "Tijolão";
            imei = "1337187981";
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