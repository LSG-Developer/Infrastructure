﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LSG.Framework.Factory.Infrastructure.Framework.BaseClasses;

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
            IMyRepository repo = base.CastleFactory<IMyRepository>();
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
