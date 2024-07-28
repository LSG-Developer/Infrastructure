
using LSG.Framework.Service.Base;

namespace LSG.Framework.Factory.Infrastructure.Framework.Consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyService myService = new MyService();
            myService.ServiceMethode();
        }
    }

    public class MyService : ServiceBase
    {
        public void ServiceMethode()
        {
            IMyRepository repo = CastleFactory<IMyRepository>("components.xml");
            repo.do_something();
        }
    }

    public interface IMyRepository
    {
        void do_something();
    }

    public class MyRepository : IMyRepository
    {
        public void do_something()
        {
            Console.WriteLine("Castle Windsor 1");
            Console.ReadLine();
        }
    }


}
