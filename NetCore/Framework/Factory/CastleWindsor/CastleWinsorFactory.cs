using Castle.Windsor.Configuration.Interpreters;
using Castle.Windsor;
namespace LSG.Framework.Factory.CastleWindsor
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
