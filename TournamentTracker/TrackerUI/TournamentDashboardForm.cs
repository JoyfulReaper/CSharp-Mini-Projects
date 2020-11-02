using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        System.Collections.Generic.List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

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
            TournamentModel tm = (TournamentModel)cbSelectTournament.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
