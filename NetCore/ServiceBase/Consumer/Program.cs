using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using CompanyName.ProjectName.ServiceName.Dto;
using CompanyName.ProjectName.Services;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using System.ComponentModel;


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


            Your_Service s = new Your_Service();


            var a = s.GetMessage(messageRequest);

            s.TestContextRepository();


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
