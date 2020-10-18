using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    textBoxPlaceName.Text,
                    textBoxPlaceNumber.Text,
                    textBoxPrizeAmount.Text,
                    textBoxPrizePercentage.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //textBoxPlaceName.Text = "";
                //textBoxPlaceNumber.Text = "";
                //textBoxPrizeAmount.Text = "0";
                //textBoxPrizePercentage.Text = "0";
            } 
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        /// <summary>
        /// Validate that form information is valid
        /// </summary>
        /// <returns>True if valid, otherwise false</returns>
        private bool ValidateForm()
        {
            bool output = true;

            if (!int.TryParse(textBoxPlaceNumber.Text, out int placeNumber))
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if(textBoxPlaceName.Text.Length == 0)
            {
                output = false;
            }


            bool prizeAmountValid = decimal.TryParse(textBoxPrizeAmount.Text, out decimal prizeAmount);
            bool prizePercentageValid = double.TryParse(textBoxPrizePercentage.Text, out double prizePercentage);

            if(!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
