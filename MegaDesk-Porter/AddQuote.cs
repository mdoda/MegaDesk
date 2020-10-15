using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_Porter
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>()
                .ToList();

            List<Delivery> rushorder = Enum.GetValues(typeof(Delivery))
                .Cast<Delivery>()
                .ToList();

            CmbSurfaceMaterial.DataSource = materials;
            CmbSurfaceMaterial.SelectedIndex = -1;

            
            CmbDelivery.DataSource = rushorder;
            CmbDelivery.SelectedIndex = -1;

            _mainMenu = mainMenu;
        }

        public void BtnGetQuote_Click(object sender, EventArgs e)
        {

            var desk = new Desk
            {
                Depth = NumDepth.Value,
                Width = NumWidth.Value,
                Drawers = (int)NumDrawers.Value,
                DesktopMaterial = (DesktopMaterial)CmbSurfaceMaterial.SelectedValue

            };

            DeskQuote deskQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = TxtCustomerName.Text,
                QuoteDate = DateTime.Now,
                Shipping = (Delivery)CmbDelivery.SelectedValue

            };
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
