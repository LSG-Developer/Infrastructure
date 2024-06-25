using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LSG.Infrastructure.Framework.BaseClasses;

namespace LSG.Infrastructure.Framework.Consumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            qwer f = new qwer();
            f.qwe();
        }
    }

    public class qwer : ServiceBase
    {
        public void qwe()
        {
            IMyService ii = base.CastleFactory<IMyService>();
            ii.DoSomething();
        }
    }


    public interface IMyService
    {
        void DoSomething();
    }

    public class MyService : IMyService
    {
        public void DoSomething()
        {
            Console.WriteLine("Castle Windsor 1");
            Console.ReadLine();
        }
    }


}
