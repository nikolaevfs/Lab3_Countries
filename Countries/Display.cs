

namespace lab4
{
    public class Display
    {
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
