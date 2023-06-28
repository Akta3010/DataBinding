using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicDataBinding.Model
{
    public class FormModel : INotifyPropertyChanged
    {
        string name { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Name"));
            }
        }

        int age { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Age"));
            }
        }

        string gender { get; set; }
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Gender"));
            }
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        #endregion
    }
}
