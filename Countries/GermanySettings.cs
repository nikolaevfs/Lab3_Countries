using System;


namespace lab4
{
    class GermanySetting : Settings
    {
        public override void Language()
        {
            Console.WriteLine("Sprachdaten hochgeladen");
        }
        public override void FormMoney()
        {
            Console.WriteLine("Gelddaten hochgeladen");
        }
        public override void PhoneCode()
        {
            Console.WriteLine("Telefoncode - Details hochgeladen");
        }
        public override void Agreement()
        {
            Console.WriteLine("Vertragsdaten hochgeladen");
        }
        public override void Manufacturer()
        {
            Console.WriteLine("Herstellerdaten hochgeladen");
        }
        public override void Network()
        {
            Console.WriteLine("Netzwerkdaten hochgeladen");
        }
        public override void SupportInfo()
        {
            Console.WriteLine("Supportdaten hochgeladen");
        }
        public override void Limitations()
        {
            Console.WriteLine("Einschränkungsdaten hochgeladen");
        }
        public override void Country()
        {
            Console.WriteLine("Länderdaten hochgeladen");
        }
        public override void Version()
        {
            Console.WriteLine("Versionsdaten hochgeladen");
        }
    }
}
