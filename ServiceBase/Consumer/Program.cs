using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CompanyName.ProjectName.ServiceName.Dto;
using CompanyName.ProjectName.Services;
using CompanyName.ProjectName.ServiceName.MessageTransfert;


namespace CompanyName.ProjectName.ServiceName.Consumer
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            MessageRequest<YourDto> messageRequest = new MessageRequest<YourDto>();
            messageRequest.Entity = new YourDto() { Name = "Nome", Temperatura = 10 };
            YourService s = new YourService();
            var a = s.GetMessage(messageRequest);
        }
    }
}
