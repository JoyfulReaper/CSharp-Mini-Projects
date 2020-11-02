using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        private BindingList<int> rounds = new BindingList<int>();
        private BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpList();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            lblTournament.Text = tournament.TournamentName;
        }

        private void WireUpList()
        {
            cbRoundDropDown.DataSource = rounds;
            listBoxMatchup.DataSource = selectedMatchups;
            listBoxMatchup.DisplayMember = nameof(MatchupModel.DisplayName);
        }

        private void  LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (var matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            LoadMatchups(1);
        }

        private void cbRoundDropDown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadMatchups((int)cbRoundDropDown.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            if (cbRoundDropDown.SelectedItem != null)
            {
                foreach (var matchups in tournament.Rounds)
                {
                    if (matchups.First().MatchupRound == round)
                    {
                        selectedMatchups.Clear();
                        foreach (var m in matchups)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }
            LoadMatchup(selectedMatchups.First());
        }

        private void LoadMatchup(MatchupModel m)
        {
            if(m == null)
            {
                return;
            }

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if(i == 0)
                {
                    lblTeamOneName.Text = m.Entries[0]?.TeamCompeting?.TeamName ?? "Not Yet Set";
                    lblTeamTwoName.Text = "{Bye}";
                    textBoxTeamTwoScoreValue.Text = "0";

                    if (m.Entries[0].Score == 0)
                    {
                        textBoxTeamOneScoreValue.Text = "";
                    }
                    else
                    {
                        textBoxTeamOneScoreValue.Text = m.Entries[0].Score.ToString();
                    }
                }
                if (i == 1)
                {
                    lblTeamTwoName.Text = m.Entries[1]?.TeamCompeting?.TeamName ?? "Not Yet Set";

                    if (m.Entries[1].Score == 0)
                    {
                        textBoxTeamTwoScoreValue.Text = "";
                    }
                    else
                    {
                        textBoxTeamOneScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                }
            }
        }

        private void listBoxMatchup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadMatchup((MatchupModel)listBoxMatchup.SelectedItem);
        }
    }
}
