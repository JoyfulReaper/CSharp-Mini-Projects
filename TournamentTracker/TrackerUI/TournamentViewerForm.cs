using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TrackerLibrary;
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

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            lblTournament.Text = tournament.TournamentName;
        }

        private void WireUpLists()
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
                            if (m.Winner == null || !checkUnplayedOnly.Checked)
                            {
                                selectedMatchups.Add(m);
                            }
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First()); 
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            lblTeamOneName.Visible = isVisible;
            lblTeamOneScore.Visible = isVisible;
            textBoxTeamOneScoreValue.Visible = isVisible;

            lblTeamTwoName.Visible = isVisible;
            lblTeamTwoScore.Visible = isVisible;
            textBoxTeamTwoScoreValue.Visible = isVisible;

            lblVersus.Visible = isVisible;
            btnScore.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            if (m != null)
            {
                for (int i = 0; i < m.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (m.Entries[0].TeamCompeting != null)
                        {
                            lblTeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                            textBoxTeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                            lblTeamTwoName.Text = "<bye>";
                            textBoxTeamTwoScoreValue.Text = "0";
                        }
                        else
                        {
                            lblTeamOneName.Text = "Not Yet Set";
                            textBoxTeamOneScoreValue.Text = "";
                        }
                    }

                    if (i == 1)
                    {
                        if (m.Entries[1].TeamCompeting != null)
                        {
                            lblTeamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                            textBoxTeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                        }
                        else
                        {
                            lblTeamTwoName.Text = "Not Yet Set";
                            textBoxTeamTwoScoreValue.Text = "";
                        }
                    }
                }
            }
        }

        private void listBoxMatchup_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadMatchup((MatchupModel)listBoxMatchup.SelectedItem);
        }

        private void checkUnplayedOnly_CheckedChanged(object sender, System.EventArgs e)
        {
            LoadMatchups((int)cbRoundDropDown.SelectedItem);
        }

        private void btnScore_Click(object sender, System.EventArgs e)
        {
            MatchupModel m = (MatchupModel)listBoxMatchup.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(textBoxTeamOneScoreValue.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore; 
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }
                if (i == 1)
                {
                    bool scoreValid = double.TryParse(textBoxTeamTwoScoreValue.Text, out teamTwoScore);

                    if (scoreValid)
                    {
                        m.Entries[1].Score = teamTwoScore;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid score for team 2.");
                        return;
                    }
                }
            }

            TournamentLogic.UpdateTournamentResults(tournament);

            LoadMatchups((int)cbRoundDropDown.SelectedItem);
        }
    }
}
