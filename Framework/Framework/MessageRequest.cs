using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSG.Infrastructure.Framework.BaseClasses.MessageTransfert;


namespace LSG.Infrastructure.Framework.MessageTransfert
{
        public class MessageRequest<T> : MessageRequestBase
        {
            public List<T> ListOfEntity { get; set; }
            public T Entity { get; set; }
        }
}
