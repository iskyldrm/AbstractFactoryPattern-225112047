using PhoneServices.DL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneServices.BLL.Abstract
{
    public interface ITelefonFactory
    {
        public ITelefonA GetTelefonA();
        public ITelefonB GetTelefonB();
    }
}
