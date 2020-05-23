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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnNewQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuote form = new AddQuote(this);
            form.Show();
        }

        private void BtnViewQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes form = new ViewAllQuotes(this);
            form.Show();
        }

        private void BtnSearchQuotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuotes form = new SearchQuotes(this);
            form.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainMenu.ActiveForm.Close();
            Application.Exit();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
