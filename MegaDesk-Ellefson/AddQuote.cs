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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            todayDateLabel.Text = DateTime.Now.ToString("MM/dd/yyyy");
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

        private void deskWidthInput_Validating(object sender, CancelEventArgs e)
        {
            int width;

            // Check if input is an integer, number will be 0 if it was not an integer
            int.TryParse(deskWidthTextBox.Text, out width);

            // Check if the width is an unacceptable value or if the input was an integer
            if ((width < Desk.WIDTH_MIN) || (width > Desk.WIDTH_MAX))
                deskWidthTextBox.BackColor = Color.Red;
            else 
                deskWidthTextBox.BackColor = Color.White;
        }

        private void submitQuoteButton_Click(object sender, EventArgs e)
        {
            int width;
            int.TryParse(deskWidthTextBox.Text, out width);
            int depth;
            int.TryParse(deskDepthTextBox.Text, out depth);

            // If input is valid, make a DeskQuote object to pass
            // to and be displayed by a DisplayQuote form
            if (width <= Desk.WIDTH_MAX && width >= Desk.WIDTH_MIN &&
                depth <= Desk.DEPTH_MAX && depth >= Desk.DEPTH_MIN)
            {
                // Create a Desk and with it set the currentDeskQuote object
                Desk desk = new Desk(width, depth, (int)deskNumOfDrawersUpDown.Value,
                                     whatMaterialSelected());
                DeskQuote deskQuote = new DeskQuote(desk, customerNameTextBox.Text, DateTime.Now,
                                                    whatRushOptionSelected());

                // Go to the display quote Form
                DisplayQuote displayQuoteForm = new DisplayQuote();
                displayQuoteForm.display(deskQuote);
                displayQuoteForm.Show();
                Close();
            }
        }

        private ProductionTime whatRushOptionSelected()
        {
            ProductionTime rushOption;

            // Determine which rush option was selected
            if (time14DaysRadioButton.Checked == true)
            {
                rushOption = ProductionTime.FourteenDays;
            }
            else if (time7DaysRadioButton.Checked == true)
            {
                rushOption = ProductionTime.SevenDays;
            }
            else if (time5DaysRadioButton.Checked == true)
            {
                rushOption = ProductionTime.FiveDays;
            }
            else 
            {
                rushOption = ProductionTime.ThreeDays;
            }

            return rushOption;
        }


        private DesktopMaterial whatMaterialSelected()
        {
            DesktopMaterial material;
            string selectedMaterial = desktopMaterialComboBox.Text;

            // Determine which material option was selected
            if (selectedMaterial == "Pine")
            {
                material = DesktopMaterial.Pine;
            }
            else if (selectedMaterial == "Laminate")
            {
                material = DesktopMaterial.Laminate;
            }
            else if (selectedMaterial == "Veneer")
            {
                material = DesktopMaterial.Veneer;
            }
            else if (selectedMaterial == "Oak")
            {
                material = DesktopMaterial.Oak;
            }
            else
            {
                material = DesktopMaterial.Rosewood;
            }

            return material;
        }



        private void deskDepthInputKeyPress(object sender, KeyEventArgs e)
        {
            string depthInput = deskDepthTextBox.Text;
            int depth = 0;
            bool isValid = false;

            // Check if input is valid using Char IsControl and IsDigit as requested
            if (depthInput.Length >= 2)
            {
                if (!Char.IsControl(depthInput[0]) && !Char.IsControl(depthInput[1])
                    && Char.IsDigit(depthInput[0]) && Char.IsDigit(depthInput[1]))
                {
                    int.TryParse(depthInput, out depth);

                    // Ensure that the depth is within bounds
                    if (depth >= Desk.DEPTH_MIN && depth <= Desk.DEPTH_MAX)
                    {
                        deskDepthTextBox.BackColor = Color.White;
                        isValid = true;
                    }
                }
            }
            if (!isValid)
                deskDepthTextBox.BackColor = Color.Red;
        }
    }
}
