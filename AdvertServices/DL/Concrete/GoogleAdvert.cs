using AdvertServices.DL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.DL.Concrete
{
    public class GoogleAdvert : Advert
    {
        public GoogleAdvert(Location location):base(AdvertType.Google,location)
        {

        }
        public override void Yapıcı()
        {
            Console.WriteLine("Google reklamı yayınlandı");
        }
    }
}
