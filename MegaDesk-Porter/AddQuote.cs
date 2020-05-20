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
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                .ToList();

            List<Delivery> rushorder = Enum.GetValues(typeof(Delivery))
                .Cast<Delivery>()
                .ToList();

            CmbSurfaceMaterial.DataSource = materials;
            CmbDelivery.DataSource = rushorder;
        }

        public void BtnGetQuote_Click(object sender, EventArgs e)
        {
            String DeliveryTest = CmbDelivery.Text;
            String NameTest = TxtCustomerName.Text;

            if (DeliveryTest == "")
            {
                MessageBox.Show("Please select a shipping option");
                
            }

            else if (NameTest == "") {
                    MessageBox.Show("Please enter something in the Customer Name field");
                }
            
            else {

                var desk = new Desk
                {
                    Depth = NumDepth.Value,
                    Width = NumWidth.Value,
                    Drawers = (int)NumDrawers.Value,
                    DesktopMaterial = (DesktopMaterial)CmbSurfaceMaterial.SelectedValue

                };

                var deskQuote = new DeskQuote
                {
                    Desk = desk,
                    CustomerName = TxtCustomerName.Text,
                    QuoteDate = DateTime.Now,
                    Shipping = (Delivery)CmbDelivery.SelectedValue
                };

                var displayQuote = new DisplayQuote();
                
                var price = deskQuote.GetQuote();

                this.Close();

                displayQuote. = NumDepth.Value;
                displayQuote.Show();
                
                
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

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
