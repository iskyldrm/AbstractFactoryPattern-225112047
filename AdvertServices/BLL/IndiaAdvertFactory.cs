using AdvertServices.DL.Abstract;
using AdvertServices.DL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.BLL
{
    public class IndiaAdvertFactory : IAdvertFactory
    {
        public static Advert buildCar(AdvertType type)
        {
            Advert advert = null;
            switch (type)
            {
                case AdvertType.Youtube:
                    advert = new YoutubeAdvert(Location.INDIA);
                    break;

                case AdvertType.Google:
                    advert = new GoogleAdvert(Location.INDIA);
                    break;

                case AdvertType.Genel:
                    advert = new AllAvert(Location.INDIA);
                    break;

                default:
                    break;

            }
            return advert;
        }
    }
}
