using System.Windows.Forms;

namespace Sekiro_Save_Manager.Forms
{
    public partial class EditDialog : Form
    {
        public EditDialog(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
        }

        public string Value => textBox1.Text;
    }
}