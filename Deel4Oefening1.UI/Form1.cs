using System.Windows.Forms;

namespace Deel4Oefening1.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            dataGridView1.DataSource = client.GetBoetes();
        }
    }
}
