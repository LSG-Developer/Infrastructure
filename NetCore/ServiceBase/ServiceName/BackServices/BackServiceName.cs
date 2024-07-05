using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyName.ProjectName.ServiceName.Repository;
using LSG.Infrastructure.Framework.BaseClasses;


namespace CompanyName.ProjectName.ServiceName.BackServices
{
    public class BackServiceName : ServiceBase
    {
        public static string MethodName(Your_IDbRepository repository)
        {
            //throw new ArgumentException("Attenzione:il messaggio è vuoto");
            string message = repository.GetMessage();
            if (message == "")
            {
                throw new ArgumentException("Attenzione:il messaggio è vuoto");
            }
            switch (message)
            {
                case "Hello Word":
                    return "Messaggio corretto";
                case "Hello word":
                    return "Messaggio corretto";
                case "hello Word":
                    return "Messaggio corretto";
                default:
                    return "Messaggio ambiguo";
            }
        }
    }
}
