using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private readonly List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private readonly List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            this.callingForm = caller;

            //CreateSampleData();

            WireUpLists();
        }

        private void WireUpLists()
        {
            cbSelectMemberDropDown.DataSource = null;

            cbSelectMemberDropDown.DataSource = availableTeamMembers;
            cbSelectMemberDropDown.DisplayMember = nameof(PersonModel.FullName);

            listBoxTeamMembers.DataSource = null;

            listBoxTeamMembers.DataSource = selectedTeamMembers;
            listBoxTeamMembers.DisplayMember = nameof(PersonModel.FullName);
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
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

                selectedTeamMembers.Add(p);

                WireUpLists();

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

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)cbSelectMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void cbSelectMemberDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnAddMember_Click(this, EventArgs.Empty);
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)listBoxTeamMembers.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Add(p);
                selectedTeamMembers.Remove(p);

                WireUpLists(); 
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            if(textBoxTeamName.Text == "")
            {
                MessageBox.Show("Team name cannot be empty.");
                return;
            }

            TeamModel t = new TeamModel();

            t.TeamName = textBoxTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
