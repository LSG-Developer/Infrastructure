﻿using System.ComponentModel;

namespace LSG.Framework.Factory.Infrastructure.Framework.BaseClasses
{
    public abstract class DtoBase //: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
