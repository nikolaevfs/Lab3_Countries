using System;

namespace lab4
{
    /// <summary>
    /// Класс, в котором функции по настроке приложения
    /// </summary>
    class RussianSetting : Settings
    {
        public override void Language()
        {
            Console.WriteLine("Данные о языке загружены");
        }
        public override void FormMoney()
        {
            Console.WriteLine("Данные о деньгах загружены");
        }
        public override void PhoneCode()
        {
            Console.WriteLine("Данные о коде телефона загружены");
        }
        public override void Agreement()
        {
            Console.WriteLine("Данные о соглашении загружены");
        }
        public override void Manufacturer()
        {
            Console.WriteLine("Данные о производителе загружены");
        }
        public override void Network()
        {
            Console.WriteLine("Данные о сети загружены");
        }
        public override void SupportInfo()
        {
            Console.WriteLine("Данные об поддержке загружены");
        }
        public override void Limitations()
        {
            Console.WriteLine("Данные об ограничениях загружены");
        }
        public override void Country()
        {
            Console.WriteLine("Данные о стране загружены");
        }
        public override void Version()
        {
            Console.WriteLine("Данные о версии загружены");
        }
    }
}
