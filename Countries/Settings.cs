
namespace lab4
{
    /// <summary>
    /// Абстрактный класс, с функциями настройки приложения
    /// </summary>
    public abstract class Settings
    {
        /// <summary>
        /// Функция настроки языка
        /// </summary>
        public abstract void Language();
        /// <summary>
        /// Функция настроки валююты
        /// </summary>
        public abstract void FormMoney();
        /// <summary>
        /// Функция настроки телефона
        /// </summary>
        public abstract void PhoneCode();
        /// <summary>
        /// Функция настроки соглашения
        /// </summary>
        public abstract void Agreement();
        /// <summary>
        /// Функция настроки производителя
        /// </summary>
        public abstract void Manufacturer();
        /// <summary>
        /// Функция настроки сети
        /// </summary>
        public abstract void Network();
        /// <summary>
        /// Функция настроки помощи
        /// </summary>
        public abstract void SupportInfo();
        /// <summary>
        /// Функция настроки ограничений
        /// </summary>
        public abstract void Limitations();
        /// <summary>
        /// Функция настроки версии
        /// </summary>
        public abstract void Version();
        /// <summary>
        /// Функция настроки страны
        /// </summary>
        public abstract void Country();

    }
}
