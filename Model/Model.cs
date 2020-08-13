using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : INotifyPropertyChanged
    {
        private int _EmployeeId;
        private string _EmployeeName;
        private string _City;
        private string _MailId;
        public int EmployeeId
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                _EmployeeId = value;
                OnPropertyChanged("EmployeeId");
            }
        }
        public string EmployeeName
        {
            get
            {
                return _EmployeeName;
            }
            set
            {
                _EmployeeName = value;
                OnPropertyChanged("EmployeeName");
            }
        }
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
                OnPropertyChanged("City");
            }
        }
        public string MailId
        {
            get
            {
                return _MailId;
            }
            set
            {
                _MailId = value;
                OnPropertyChanged("MailId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

      
    

