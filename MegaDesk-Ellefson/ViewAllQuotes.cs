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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
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
