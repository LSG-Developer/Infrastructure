﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSG.Framework.Factory.Infrastructure.Framework.BaseClasses;
using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;

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
        private string name;
  
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                base.NotifyPropertyChanged("Name");
            }
        }
        public int Temperatura { get; set; }
        public int Umidità { get; set; }
        public int MovimentoTellurico { get; set; }
        public int CoordinateTerrestri { get; set; }
    }







}
