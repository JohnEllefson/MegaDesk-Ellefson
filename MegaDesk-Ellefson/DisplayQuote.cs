using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Ellefson
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public void display(DeskQuote deskQuote)
        {
            Desk desk = deskQuote.getDesk();

            // Display order details
            displayNameLabel.Text = deskQuote.getCustomerName();
            displayDateLabel.Text = deskQuote.getQuoteDate().ToString("MM/dd/yyyy");
            displayRushOrderLabel.Text = deskQuote.getProductionTime().ToString();

            // Display desk specifications
            displayWidthLabel.Text = desk.getWidth().ToString() + "in";
            displayDepthLabel.Text = desk.getDepth().ToString() + "in";
            displayNumDrawers.Text = desk.getDrawersNum().ToString();
            displayMaterialLabel.Text = desk.getMaterial().ToString();

            // Display total cost
            displayQuoteTotalLabel.Text = "$" + deskQuote.calcTotalCost().ToString();
        }

        private void BackArrowPicture_Click(object sender, EventArgs e)
        {
            MainMenu viewMenu = new MainMenu();
            viewMenu.Show();
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMenu = new MainMenu();
            viewMenu.Show();
            Close();
        }
    }
}
