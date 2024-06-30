
using System.Collections.Generic;

using LSG.Infrastructure.Framework.BaseClasses.MessageTransfert;


namespace CompanyName.ProjectName.ServiceName.MessageTransfert
{
    public class MessageRequest<T> : MessageRequestBase
    {
        public List<T>? ListOfEntity { get; set; }
        public T? Entity { get; set; }
    }
}
