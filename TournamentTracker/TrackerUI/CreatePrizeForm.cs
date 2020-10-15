using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
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

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                textBoxPlaceName.Text = "";
                textBoxPlaceNumber.Text = "";
                textBoxPrizeAmount.Text = "0";
                textBoxPrizePercentage.Text = "0";
            } 
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            if(!int.TryParse(textBoxPlaceNumber.Text, out placeNumber))
            {
                output = false;
            }

            if(placeNumber < 1)
            {
                output = false;
            }

            if(textBoxPlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(textBoxPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(textBoxPrizePercentage.Text, out prizePercentage);

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
