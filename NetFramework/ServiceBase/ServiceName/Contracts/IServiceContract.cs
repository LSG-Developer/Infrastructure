using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using CompanyName.ProjectName.ServiceName.Dto;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Web;

namespace CompanyName.ProjectName.ServiceName.Contracts
{

    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "GetMessage")]
        MessageResponse<YourDto> GetMessage(MessageRequest<YourDto> messageRequest);
    }

}
