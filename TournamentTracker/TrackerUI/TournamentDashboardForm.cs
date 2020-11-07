using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            cbSelectTournament.DataSource = tournaments;
            cbSelectTournament.DisplayMember = nameof(TournamentModel.TournamentName);
        }

        private void btnCreateTournament_Click(object sender, System.EventArgs e)
        {
            CreateTournamentForm frm = new CreateTournamentForm();
            frm.Show();
        }

        private void btnLoadTournament_Click(object sender, System.EventArgs e)
        {
            bool valid = false;
            foreach (var t in tournaments)
            {
                if (t.TournamentName == cbSelectTournament.Text)
                {
                    valid = true;
                }
            }

            if(!valid)
            {
                MessageBox.Show("Please choose a valid tournament.");
                return;
            }

            TournamentModel tm = (TournamentModel)cbSelectTournament.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
