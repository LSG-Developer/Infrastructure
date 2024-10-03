using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net;
using LSG.Framework.Logging;

namespace CompanyName.ProjectName.ServiceName.Repository.Loggers
{
    public class Log4Net : ILogger
    {
        private readonly ILog _log;

        public Log4Net(string configFileName)
        {
            // Carica la configurazione da un file specificato
            XmlConfigurator.Configure(new System.IO.FileInfo(configFileName));
            _log = LogManager.GetLogger(typeof(Log4Net));
        }



        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            _log.Info(message);
        }

        public void Warn(string message)
        {
            _log.Info(message);
        }
    }
}
