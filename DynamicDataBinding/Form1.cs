using DynamicDataBinding.Model;
using DynamicDataBinding.Services;
using System.CodeDom;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DynamicDataBinding
{
    public partial class Form1 : Form
    {
        GlobleServices services = new GlobleServices();
        public Form1()
        {
            InitializeComponent();
            LoadFormContain();

            Control control = panel1.Controls[3];
            DataBindingServices.BindDataWithControl(ref control);
        }

        private void LoadFormContain()
        {
            BasicComponent basicComponent = new BasicComponent();

            this.panel1.Controls.Add(basicComponent);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFileName = saveFileDialog1.FileName;
            }

            FormModel model = (FormModel)DataBindingServices._source.DataSource;
            FileServices.SaveFile(sFileName, model);
        }

        private void LoadFile_Click(object sender, EventArgs e)
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

            FormModel readData = FileServices.readFile(sFileName);

            DataBindingServices._source.DataSource = readData;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DataBindingServices._source.DataSource = new FormModel();
        }
    }
}