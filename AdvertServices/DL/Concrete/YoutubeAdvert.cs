using AdvertServices.DL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.DL.Concrete
{
    public class YoutubeAdvert : Advert
    {
        public YoutubeAdvert(Location location):base(AdvertType.Youtube,location)
        {

        }
        public override void Yapıcı()
        {
            Console.WriteLine("Youtube reklamı yayınlandı");
        }
    }
}
