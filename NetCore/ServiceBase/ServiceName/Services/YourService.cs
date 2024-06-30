using CompanyName.ProjectName.ServiceName.BackServices;
using CompanyName.ProjectName.ServiceName.Dto;
using CompanyName.ProjectName.ServiceName.Repository;
using LSG.Infrastructure.Framework.BaseClasses;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using System.Diagnostics.CodeAnalysis;
 

namespace CompanyName.ProjectName.Services
{
    public class YourService : ServiceBase
    {




        [ExcludeFromCodeCoverage]  
        public MessageResponse<YourDto> GetMessage(MessageRequest<YourDto> messageRequest)  
        {
            using (IYourRepository repository = base.CastleFactory<IYourRepository>())
            { 
            
                string message = BackServiceName.MethodName(repository);
                MessageResponse<YourDto> messageResponse = new MessageResponse<YourDto>();   
                messageResponse.Entity = new YourDto() {Name="Luigi",SurName="Santagada" }; 
                messageResponse.Message = message; 
                return messageResponse;   
            }
        }


        public string GetMessage()
        {
            return "Hello word!!!";
        }
    }
}
