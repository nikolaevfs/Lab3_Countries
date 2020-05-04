using System;

namespace lab4
{
    class ChinaSetting : Settings
    {
        public override void Language()
        {
            Console.WriteLine("语言数据上传");
        }
        public override void FormMoney()
        {
            Console.WriteLine("资金数据已上传");
        }
        public override void PhoneCode()
        {
            Console.WriteLine("電話代碼詳細信息已上傳");
        }
        public override void Agreement()
        {
            Console.WriteLine("协议数据已上传");
        }
        public override void Manufacturer()
        {
            Console.WriteLine("製造商數據已上傳");
        }
        public override void Network()
        {
            Console.WriteLine("網絡數據上傳");
        }
        public override void SupportInfo()
        {
            Console.WriteLine("支持数据上传");
        }
        public override void Limitations()
        {
            Console.WriteLine("上傳限制數據");
        }
        public override void Country()
        {
            Console.WriteLine("國家數據上傳");
        }
        public override void Version()
        {
            Console.WriteLine("版本数据上传");
        }
    }
}

