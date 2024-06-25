using Castle.Windsor.Configuration.Interpreters;
using Castle.Windsor;
using System.IO;

namespace LSG.Infrastructure.Framework.Factory
{
    internal class CastleWinsorFactory<T> 
    {      
        public static T Create()
        {
            try
            {
                string configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "components.xml");

                IWindsorContainer container = new WindsorContainer(new XmlInterpreter(configFilePath));

                return container.Resolve<T>();
            }
            catch 
            {
                throw;
            }
        }
    }
}
