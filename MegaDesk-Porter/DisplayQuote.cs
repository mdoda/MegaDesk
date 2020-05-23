using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Porter
{
    public partial class DisplayQuote : Form
    {
        private Form _mainMenu;

        public DisplayQuote()
        {
        }

        public DisplayQuote(Form mainMenu, DeskQuote deskquote)
        {
            InitializeComponent();
            
            _mainMenu = mainMenu;

            TxtCustomerName.Text = deskquote.CustomerName;
            NumWidth.Value = deskquote.Desk.Width;
            NumDepth.Value = deskquote.Desk.Depth;
            NumDrawers.Value = deskquote.Desk.Drawers;
            TxtSurfaceMaterial.Text = deskquote.Desk.DesktopMaterial.ToString();
            TxtDelivery.Text = deskquote.Shipping.ToString();
            TxtTotal.Text = deskquote.Total.ToString("c");
            

        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainMenu.Show();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
