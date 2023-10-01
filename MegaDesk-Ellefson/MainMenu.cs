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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            // Try to make a new form object
            try
            {
                AddQuote addQuoteForm = new AddQuote();
                addQuoteForm.Tag = this;
                addQuoteForm.Show(this);
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to instantiate the new add quote form.");
            }
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes();
            viewAllQuotes.Tag = this;
            viewAllQuotes.Show(this);
            Hide();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
