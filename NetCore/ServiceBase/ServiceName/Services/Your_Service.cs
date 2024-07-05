using CompanyName.ProjectName.ServiceName.BackServices;
using CompanyName.ProjectName.ServiceName.Dto;
using CompanyName.ProjectName.ServiceName.Repository;
using LSG.Infrastructure.Framework.BaseClasses;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using System.Diagnostics.CodeAnalysis;
using System.Data;



namespace CompanyName.ProjectName.Services
{
    public class Your_Service : ServiceBase
    {
        [ExcludeFromCodeCoverage]  
        public MessageResponse<YourDto> GetMessage(MessageRequest<YourDto> messageRequest)  
        {
            using (Your_IDbRepository repository = base.CastleFactory<Your_IDbRepository>())
            using (IDbConnection dbConnection = base.CastleFactory<IDbConnection>())
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
