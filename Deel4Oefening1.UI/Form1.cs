using System;
using System.Windows.Forms;

namespace Deel4Oefening1.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonVoegToe_Click(object sender, System.EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.AddBoete(int.Parse(textBoxBetalingsnr.Text), int.Parse(textBoxSpelersnr.Text), dateTimePickerDatum.Value, decimal.Parse(textBoxBedrag.Text));
            LoadData();
        }

        private void LoadData()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            dataGridView1.DataSource = client.GetBoetes();
        }
    }
}
