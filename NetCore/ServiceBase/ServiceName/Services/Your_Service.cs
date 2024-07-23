using CompanyName.ProjectName.ServiceName.BackServices;
using CompanyName.ProjectName.ServiceName.Dto;
using LSG.Infrastructure.Framework.BaseClasses;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using System.Diagnostics.CodeAnalysis;
using CompanyName.ProjectName.ServiceName.Repository.DbSql;
using CompanyName.ProjectName.ServiceName.Repository.DbContext;


namespace CompanyName.ProjectName.Services
{
    public class Your_Service : ServiceBase
    {
        [ExcludeFromCodeCoverage]  
        public MessageResponse<YourDto> GetMessage(MessageRequest<YourDto> messageRequest)  
        {
            using (Your_IDbRepository repository = CastleFactory<Your_IDbRepository>("components.xml"))
            {
                repository.get_person_name();
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

        public void TestContextRepository()
        {
            IAppDbContextRepository repository = CastleFactory<IAppDbContextRepository>("components.xml");
            repository.AddPerson();
            repository.Save();
        }
    }
}
