using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
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
    }
}
