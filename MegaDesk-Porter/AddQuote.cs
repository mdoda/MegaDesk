using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Porter
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            CmbSurfaceMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
        }

        private void CmbSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGetQuote_Click(object sender, EventArgs e)
        {

            String DeliveryTest = CmbDelivery.Text;
            Console.WriteLine(DeliveryTest);
            if (DeliveryTest == "")
            {
                MessageBox.Show("Please select a shipping option");
            }

            try
            {
                String nameTest = TxtCustomerName.ToString();
                
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
    }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu reopen = new MainMenu();
            reopen.Show();

        }
    }
}
