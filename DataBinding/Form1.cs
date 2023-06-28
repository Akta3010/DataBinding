using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        Model sourceObject = new Model();
        private static BindingSource bindingSource = new BindingSource();
 
        public Form1()
        {
            InitializeComponent();

            bindingSource.DataSource = sourceObject;

            TextDataBinding();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = saveFileDialog1.FileName;
            }

            XmlSerializer xs = new XmlSerializer(typeof(Model));
            using (FileStream fs = new FileStream(sFileName, FileMode.Create))
            {
                xs.Serialize(fs, sourceObject);
                fs.Close();
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = openFileDialog1.FileName;
            }

            Model readData = readFile(sFileName);
            sourceObject = readData;
            bindingSource.DataSource = sourceObject;
            //string textval = textBox1.Text;
        }

        private void TextDataBinding()
        {
            textBox1.DataBindings.Add("Text", bindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static Model readFile(string path)
        {
            Model data = null;

            XmlSerializer xs = new XmlSerializer(typeof(Model));
            FileStream fs1 = new FileStream(path, FileMode.Open, FileAccess.Read);

            try
            {
                data = (Model)xs.Deserialize(fs1);
            }
            catch (Exception ex)
            {

            }

            fs1.Close();

            return data;
        }
    }
}