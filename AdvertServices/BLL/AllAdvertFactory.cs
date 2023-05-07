using AdvertServices.DL.Abstract;
using AdvertServices.DL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.BLL
{
    public class AllAdvertFactory : IAdvertFactory
    {
        public static Advert buildCar(AdvertType type)
        {
            Advert advert = null;
            switch (type)
            {
                case AdvertType.Youtube:
                    advert = new YoutubeAdvert(Location.HERYER);
                    break;

                case AdvertType.Google:
                    advert = new GoogleAdvert(Location.HERYER);
                    break;

                case AdvertType.Genel:
                    advert = new AllAvert(Location.HERYER);
                    break;

                default:
                    break;

            }
            return advert;
        }
    }
}
