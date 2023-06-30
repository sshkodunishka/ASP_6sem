using Ninject.Modules;
using Ninject.Web.Common;
using PhoneDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab3.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            //Bind<IRepository<PhoneNote>>().To<JSON_DB.PhoneRepository>(); //--для каждого требования внедрения 
            //.InTransientScope()(по умолчанию)

            //Bind<IRepository<PhoneNote>>().To<JSON_DB.PhoneRepository>().InSingletonScope(); //Объект класса будет создан один
            //раз и будет использоваться повторно.

            //Bind<IRepository<PhoneNote>>().To<JSON_DB.PhoneRepository>().InThreadScope(); //Один объект на поток.

            //Bind<IRepository<PhoneNote>>().To<JSON_DB.PhoneRepository>().InRequestScope(); //Один объект будет на каждый web-запрос

            //Bind<IRepository<PhoneNote>>().To<MSSQL.PhoneRepository>(); //--для каждого требования внедрения 
            //.InTransientScope()(по умолчанию)

            //Bind<IRepository<PhoneNote>>().To<MSSQL.PhoneRepository>().InSingletonScope(); //Объект класса будет создан один
            //раз и будет использоваться повторно.

            //Bind<IRepository<PhoneNote>>().To<MSSQL.PhoneRepository>().InThreadScope(); //Один объект на поток.

            Bind<IRepository<PhoneNote>>().To<MSSQL.PhoneRepository>().InRequestScope(); //Один объект будет на каждый web-запрос
        }
    }
}