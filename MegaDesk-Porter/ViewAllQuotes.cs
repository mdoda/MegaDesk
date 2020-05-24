using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Porter
{
    public partial class ViewAllQuotes : Form
    {
        Form _mainMenu;

        public ViewAllQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
