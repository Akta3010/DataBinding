using DynamicDataBinding.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DynamicDataBinding.Services
{
    internal class FileServices
    {
        public static void SaveFile(string path, FormModel data) 
        {
            XmlSerializer xs = new XmlSerializer(typeof(FormModel));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                xs.Serialize(fs, data);
                fs.Close();
            }
        }

        public static FormModel readFile(string path)
        {
            FormModel data = null;

            XmlSerializer xs = new XmlSerializer(typeof(FormModel));
            FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);

            try
            {
                data = (FormModel)xs.Deserialize(fs1);
            }
            catch (Exception ex)
            {

            }

            fs1.Close();

            return data;
        }
    }
}
