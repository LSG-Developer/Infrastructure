using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSG.Infrastructure.Framework.BaseClasses.MessageTransfert;


namespace Infrastructure.Framework.MessageTransfert
{
        public class MessageResponse<T> : MessageResponseBase
        {
            public List<T> ListOfEntity {get;set;}
            public T Entity { get; set; }
        }
}
