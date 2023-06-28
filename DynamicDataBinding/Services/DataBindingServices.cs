using DynamicDataBinding.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDataBinding.Services
{
    internal class DataBindingServices
    {
        public static BindingSource _source;

        public DataBindingServices() { 
            _source = new BindingSource();
            _source.DataSource = new FormModel();
        }

        public static void BindDataWithControl(ref Control controlele)
        {
            foreach (Control control in controlele.Controls)
            {
                if (control != null)
                {
                    if (control is TextBox)
                    {
                        control.DataBindings.Add(new Binding("Text", _source, control.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    }
                    if (control is ComboBox)
                    {
                        control.DataBindings.Add(new Binding("SelectedItem", _source, control.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    }
                }
            }

        }
    }
}
