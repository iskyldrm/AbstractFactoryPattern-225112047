using AdvertServices.DL.Abstract;
using AdvertServices.DL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.BLL
{
    public class USAAdvertFactory : IAdvertFactory
    {
        public static Advert buildCar(AdvertType type)
        {
            Advert advert = null;
            switch (type)
            {
                case AdvertType.Youtube:
                    advert = new YoutubeAdvert(Location.USA);
                    break;

                case AdvertType.Google:
                    advert = new GoogleAdvert(Location.USA);
                    break;

                case AdvertType.Genel:
                    advert = new AllAvert(Location.USA);
                    break;

                default:
                    break;

            }
            return advert;
        }
    }
}
