using PhoneServices.BLL.Abstract;
using PhoneServices.DL.Abstract;
using PhoneServices.DL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneServices.BLL.Concrete
{
    public class TelefonKameralıFactory : ITelefonFactory
    {
        public ITelefonA GetTelefonA()
        {
            return new TelefonKameralıA();
        }

        public ITelefonB GetTelefonB()
        {
            return new TelefonKameralıB();
        }
    }
}
