using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertServices.DL.Abstract
{
    public enum AdvertType
    {
        Youtube,
        Google,
        Genel
    }
    public enum Location
    {
        HERYER, USA, INDIA
    }
    public abstract class Advert
    {
        public Advert(AdvertType advert, Location location)
        {
            this.advert = advert;
            this.location = location;
        }

        public abstract void Yapıcı();

        AdvertType advert = 0;
        Location location = 0;

        AdvertType getAdvert()
        {
            return advert;
        }

        void setModel(AdvertType advert)
        {
            this.advert = advert;
        }

        Location getLocation()
        {
            return location;
        }

        void setLocation(Location location)
        {
            this.location = location;
        }
        public override string ToString()
        {
            return location +" bölgesi için "+ advert;
        }
    }
}
