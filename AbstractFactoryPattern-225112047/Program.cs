
using AdvertServices.BLL;
using AdvertServices.DL.Abstract;
using PhoneServices.BLL.Abstract;
using PhoneServices.BLL.Concrete;
using PhoneServices.DL.Concrete;

//Seneryomuzda bir telefon bayinin telefon servisinden istediği telefon modelini ürettirebilmesi

bas3:
Console.WriteLine("Senaryo tercihinizi seçin: (1: phoneservices 2:advertservices)");
var choice = Console.ReadLine();

if (choice == "1")
{
    bayi bayi = new bayi();

    bayi.getPhone();
}
else if (choice == "2")
{
    reklam reklam = new reklam();
    reklam.getAdvert();
}
else
{
    goto bas3;
}





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

class reklam
{
    IAdvertFactory advertFactory = new IAdvertFactory();
    public void getAdvert()
    {
        while (true)
        {
            string response = "";
        bas:
            Console.Write("bölge:");
            var location = Console.ReadLine();
            Console.Write("reklam:");
            var advert = Console.ReadLine();
            

            if (location == "h")
            {
                advertFactory = new IndiaAdvertFactory();
                Console.WriteLine(getsubadvert(advertFactory, advert, Location.INDIA)); 
            }
            else if (location == "a")
            {
                Console.WriteLine(getsubadvert(advertFactory, advert, Location.USA));
            }
            else if (location == "g")
            {
                Console.WriteLine(getsubadvert(advertFactory, advert, Location.HERYER));
            }
            else
            {
                goto bas;
            }

        }
    }

    public string getsubadvert(IAdvertFactory advertFactory,string advert,Location location)
    {
        string response = "";

        bas2:

        if (advert == "y")
        {
            response = advertFactory.buildCar(AdvertType.Youtube,location).ToString();
        }
        else if (advert == "g")
        {
            response = advertFactory.buildCar(AdvertType.Google, location).ToString();
        }
        else if (advert == "a")
        {
            response = advertFactory.buildCar(AdvertType.Genel, location).ToString();
        }
        else
        {
            goto bas2;
        }

        return response + " reklamı getirildi.";
    }
}