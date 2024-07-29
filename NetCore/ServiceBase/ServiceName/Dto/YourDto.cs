using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;
using LSG.Framework.DataTransfertObjects;

namespace CompanyName.ProjectName.ServiceName.Dto
{

    public enum ReportProjectDtoStates
    {
        [EnumMemberAttribute]
        Update = 0,
        [EnumMemberAttribute]
        WithOutPrograms = 1,
        [EnumMemberAttribute]
        GenericError = 2,
        [EnumMemberAttribute]
        Inserted = 3,
        [EnumMemberAttribute]
        MissingFields = 4,
        [EnumMemberAttribute]
        NewInsert = 5,
        [EnumMemberAttribute]
        Closed = 6
    }
    
    [ExcludeFromCodeCoverage]
    public class YourDto : DtoBase
    {
        private  string? _name;

        private string? _surname;

        public string? Name
        {
            get { return _name; }
    
            set{
                _name = value;
                base.NotifyPropertyChanged("Name");
            }
        }


        public string? SurName
        {
            get { return _surname; }

            set
            {
                _surname = value;
                base.NotifyPropertyChanged("SurName");
            }
        }

    }







}
