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
            CmbDelivery.DataSource = rushorder;

            _mainMenu = mainMenu;
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

                DeskQuote deskQuote = new DeskQuote
                {
                    Desk = desk,
                    CustomerName = TxtCustomerName.Text,
                    QuoteDate = DateTime.Now,
                    Shipping = (Delivery)CmbDelivery.SelectedValue
                    
                };

                deskQuote.Total = deskQuote.GetQuote();


                AddQuoteToFile(deskQuote);

                //Serialize deskQuote into a string

                //Write deskQuote to JSON file

                var displayQuote = new DisplayQuote(_mainMenu,deskQuote);

                
                displayQuote.Show();
                

                this.Close();
                
                
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
        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            var quotesFile = @"quotes.json";
            List<DeskQuote> deskquotes = new List<DeskQuote>();

            //Read already existing quotes
            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();

                    if (quotes.Length > 0)
                    {
                        //Deserialize quotes
                        deskquotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
            //Add to file
            deskquotes.Add(deskQuote);

            //Save to file
            SaveQuotes(deskquotes);
        }

        private void SaveQuotes(List<DeskQuote> quotes)
        {
            var quotesFile = @"quotes.json";

            //Reserialize (quotes)
            var serializedQuotes = JsonConvert.SerializeObject(quotes);

            File.WriteAllText(quotesFile, serializedQuotes);
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
