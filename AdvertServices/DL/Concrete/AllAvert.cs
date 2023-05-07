using AdvertServices.DL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.DL.Concrete
{
    public class AllAvert : Advert
    {
        public AllAvert(Location location):base(AdvertType.Genel,location)
        {

        }
        public override void Yapıcı()
        {
            Console.WriteLine("Herkes için reklamı yayınlandı");
        }
    }
}
