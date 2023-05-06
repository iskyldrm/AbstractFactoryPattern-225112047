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
    public class TelefonTusluFactory : ITelefonFactory
    {
        public ITelefonA GetTelefonA()
        {
            return new TelefonTusluA();
        }

        public ITelefonB GetTelefonB()
        {
            return new TelefonTusluB();
        }
    }
}
