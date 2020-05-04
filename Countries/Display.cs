

namespace lab4
{
    /// <summary>
    /// Для выполнения настроек
    /// </summary>
    public class Display
    {
        /// <summary>
        /// Функция выполняет настройки
        /// </summary>
        /// <param name="Setting">Настройки страны</param>
        public Display(Settings Setting)
        {
            Setting.Language();
            Setting.FormMoney();
            Setting.PhoneCode();
            Setting.Agreement();
            Setting.Manufacturer();
            Setting.Network();
            Setting.SupportInfo();
            Setting.Limitations();
            Setting.Country();
            Setting.Version();
        }
    }
}
