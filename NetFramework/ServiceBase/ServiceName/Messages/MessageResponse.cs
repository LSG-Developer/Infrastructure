using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSG.Framework.Factory.Infrastructure.Framework.BaseClasses.MessageTransfert;


namespace CompanyName.ProjectName.ServiceName.MessageTransfert

{
        public class MessageResponse<T> : MessageResponseBase
        {
            public List<T> ListOfEntity {get;set;}
            public T Entity { get; set; }
        }
}
