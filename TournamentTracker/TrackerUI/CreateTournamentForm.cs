using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        readonly List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        readonly List<TeamModel> selectedTeams = new List<TeamModel>();
        readonly List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cbSelectTeamDropDown.DataSource = null;
            cbSelectTeamDropDown.DataSource = availableTeams;
            cbSelectTeamDropDown.DisplayMember = nameof(TeamModel.TeamName);

            listBoxTournamentTeams.DataSource = null;
            listBoxTournamentTeams.DataSource = selectedTeams;
            listBoxTournamentTeams.DisplayMember = nameof(TeamModel.TeamName);

            listBoxPrizes.DataSource = null;
            listBoxPrizes.DataSource = selectedPrizes;
            listBoxPrizes.DisplayMember = nameof(PrizeModel.PlaceName);
        }

        private void btnAddTeam_Click(object sender, System.EventArgs e)
        {
            TeamModel t = (TeamModel)cbSelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void btnCreatePrize_Click(object sender, System.EventArgs e)
        {
            // Call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();


        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a prize model
            // Put prize model in to list of selected prizes
            selectedPrizes.Add(model);

            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);

            WireUpLists();
        }

        private void linkNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void btnRemoveTeam_Click(object sender, System.EventArgs e)
        {
            TeamModel t = (TeamModel)listBoxTournamentTeams.SelectedItem;

            if (t != null)
            {
                availableTeams.Add(t);
                selectedTeams.Remove(t);

                WireUpLists();
            }
        }

        private void btnRemovePrize_Click(object sender, System.EventArgs e)
        {
            PrizeModel p = (PrizeModel)listBoxPrizes.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void btnCreateTournament_Click(object sender, System.EventArgs e)
        {

        }
    }
}
