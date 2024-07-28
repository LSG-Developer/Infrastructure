using Castle.Windsor.Configuration.Interpreters;
using Castle.Windsor;
using System.IO;
using System;



namespace LSG.Framework.Factory.Infrastructure.Framework.Utils
{
        internal static class IoC
        {
            //private static IWindsorContainer _container =
            //    new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));

            public static T Resolve<T>()
            {
                try
                {
                string configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "components.xml");

                IWindsorContainer container = new WindsorContainer(new XmlInterpreter(configFilePath));

                return container.Resolve<T>();
                }
                catch (Exception exc)
                {
                    throw;
                }
            }
    
        }

}
       


