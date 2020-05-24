using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Porter
{
    public partial class SearchQuotes : Form
    {
        Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial))
                                                 .Cast<DesktopMaterial>()
                                                 .ToList();

            com1SurfaceMaterial.DataSource = materials;
            com1SurfaceMaterial.SelectedIndex = -1;

            List<Delivery> rushorder = Enum.GetValues(typeof(Delivery))
                .Cast<Delivery>()
                .ToList();

            CmbDelivery.DataSource = rushorder;
            CmbDelivery.SelectedIndex = -1;

            loadGrid();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // load existing quotes 
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.Drawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    DeliveryType = d.Shipping,
                    QuoteAmount = d.Total.ToString("c")
                }).ToList();
            }
        }

        private void loadGrid(DesktopMaterial desktopMaterial)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // load existing quotes 
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.Drawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    DeliveryType = d.Shipping,
                    QuoteAmount = d.Total.ToString("c")
                })
                .Where(q => q.SurfaceMaterial == desktopMaterial)
                .ToList();
            }
        }


        private void com1SurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

            //CmbDelivery.SelectedIndex = -1;
            ComboBox combo = (ComboBox)sender;
 
            if(combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((DesktopMaterial)combo.SelectedValue);
            }
        }


        private void loadGrid(Delivery shipping)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                // load existing quotes 
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.Drawers,
                    SurfaceMaterial = d.Desk.DesktopMaterial,
                    DeliveryType = d.Shipping,
                    QuoteAmount = d.Total.ToString("c")
                })
                .Where(q => q.DeliveryType == shipping)
                .ToList();
            }
        }

        private void CmbDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            com1SurfaceMaterial.SelectedIndex = -1;

            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((Delivery)combo.SelectedValue);
            }
            

        }
    }
}
