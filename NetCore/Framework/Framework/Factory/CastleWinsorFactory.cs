using Castle.Windsor.Configuration.Interpreters;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System.IO;
using System.Data;

namespace LSG.Infrastructure.Framework.Factory
{
    internal class CastleWinsorFactory<T> 
    {
        public static T Create(string castle_file_name)
        {
            try
            {
                string configFilePath = Path.Combine(Directory.GetCurrentDirectory(), castle_file_name);

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
