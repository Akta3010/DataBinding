using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDataBinding.Services
{
    internal class GlobleServices
    {
        public static DataBindingServices bindingServices = null;
        public GlobleServices() {
            bindingServices = new DataBindingServices();
        }
    }
}
