using Art_Auction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art_Auction_GUI
{
    public partial class frmSettings : Form
    {
        ArtAuctionForm form;
        public frmSettings(ArtAuctionForm form)
        {
            InitializeComponent();
            this.form = form;
            txtBoxNumPainting.Text = form.NumPaintings.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!Int32.TryParse(txtBoxNumPainting.Text, out int input))
            {
                MessageBox.Show("Invaild number of paintings.", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("End the current game?", "End game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            form.NumPaintings = input;
            form.StartNewGame();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtBoxNumPainting.Text, out int input))
            {
                MessageBox.Show("Invaild number of paintings.", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            form.NumPaintings = input;
            this.Close();
        }
    }
}
