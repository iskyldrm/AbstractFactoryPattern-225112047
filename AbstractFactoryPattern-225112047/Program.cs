
using PhoneServices.BLL.Abstract;
using PhoneServices.BLL.Concrete;
using PhoneServices.DL.Concrete;

//Seneryomuzda bir telefon bayinin telefon servisinden istediği telefon modelini ürettirebilmesi


bayi bayi = new bayi();

bayi.getPhone();

class bayi
{
    public ITelefonFactory _factory { get; set; }
    
    public void getPhone()
    {
        while (true)
        {
            string response = "";
            bas:
            Console.Write("Still:");
            var still = Console.ReadLine();
            Console.Write("Model:");
            var model = Console.ReadLine();

            if (still == "k")
            {
                _factory = new TelefonKameralıFactory();
            }
            else if (still == "t")
            {
                _factory = new TelefonTusluFactory();
            }
            else
            {
                goto bas;
            }
            bas2:
            if (model == "b")
            {
                response = _factory.GetTelefonB().ToString();
            }
            else if (model == "a")
            {
                response = _factory.GetTelefonA().ToString();
            }
            else
            {
                goto bas2;
            }

            Console.WriteLine(response + " Telefonu getirildi.");
        }
    }
}