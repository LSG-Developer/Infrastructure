
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using CompanyName.ProjectName.ServiceName.Dto;

namespace CompanyName.ProjectName.ServiceName.Contracts
{
    public interface IYour_ServiceContract
    {
        MessageResponse<YourDto> GetMessage(MessageRequest<YourDto> messageRequest);
        string GetMessage();
        public void TestContextRepository();
    }

}
