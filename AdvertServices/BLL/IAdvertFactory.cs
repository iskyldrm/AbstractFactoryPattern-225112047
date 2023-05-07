using AdvertServices.DL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.BLL
{
    public class IAdvertFactory
    {
        public Advert buildCar(AdvertType type, Location location)
        {
            Advert advert = null;

            switch (location)
            {
                case Location.USA:
                    advert = USAAdvertFactory.buildCar(type);
                    break;

                case Location.INDIA:
                    advert = IndiaAdvertFactory.buildCar(type);
                    break;

                default:
                    advert = AllAdvertFactory.buildCar(type);
                    break;

            }

            return advert;
        }
    }
}
