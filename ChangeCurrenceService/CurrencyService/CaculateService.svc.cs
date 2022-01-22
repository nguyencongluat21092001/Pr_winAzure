using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CaculateService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CaculateService.svc or CaculateService.svc.cs at the Solution Explorer and start debugging.
    public class CaculateService : ICaculateService
    {
        public  Int32 Change (Int32 Number, Int32 Ratio)
        {
            return Number * Ratio;
        }
    }
}
