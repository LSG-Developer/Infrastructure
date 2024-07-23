using CompanyName.ProjectName.ServiceName.Dto;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using CompanyName.ProjectName.Services;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;


namespace CompanyName.ProjectName.ServiceName.Consumer
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            MessageRequest<YourDto> messageRequest = new MessageRequest<YourDto>();
            messageRequest.Entity = new YourDto() { Name = "Nome", SurName="Santagada" };
            messageRequest.Entity.PropertyChanged += Dto_PropertyChanged;
            messageRequest.Entity.Name = "aaaa";


            Your_Service your_Service = new Your_Service();


            //var a = your_Service.GetMessage(messageRequest);

            your_Service.TestContextRepository();


            Console.WriteLine("end of program!!");
            Console.ReadLine();
        }

        private static void Dto_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                Console.WriteLine("La proprietà Name è cambiata!");
            }
        }
    }
}
