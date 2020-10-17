using System;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = textBoxFirstName.Text;
                p.LastName = textBoxLastName.Text;
                p.EmailAddress = textBoxEmail.Text;
                p.CellphoneNumber = textBoxCellphone.Text;

                GlobalConfig.Connection.CreatePerson(p);

                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                textBoxCellphone.Text = "";
            } 
            else
            {
                MessageBox.Show("All fields must contain data.");
            }
        }

        private bool ValidateForm()
        {
            if (textBoxFirstName.Text.Length == 0)
            {
                return false;
            }
            if (textBoxLastName.Text.Length == 0)
            {
                return false;
            }
            if (textBoxEmail.Text.Length == 0)
            {
                return false;
            }
            if (textBoxCellphone.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
