using Art_Auction_GUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Art_Auction
{
    public partial class ArtAuctionForm : Form
    {
        public int NumPaintings { get; set; } = 2;

        private readonly List<Painting> paintings;
        private static readonly Random random = new Random();
        private int profit = 0;
        private int spent = 0;
        private bool selling = false;
        private int currentPainting = 0;
        private int paintingsOwned = 0;
        private int currentOffer = 0;
        private List<int> paintingOffers;

        public ArtAuctionForm()
        {
            InitializeComponent();
            paintings = new List<Painting>(NumPaintings);
            for(int i = 0; i < NumPaintings; i++)
            {
                paintings.Add(new Painting());
            }
        }

        private void ChangeToSellMode()
        {
            btnAction.Text = "Accept";
            btnReject.Visible = true;
            textBox1.Visible = false;
        }

        private void ArtAuctionForm_Load(object sender, EventArgs e)
        {
            btnAction.Text = "Bid";
            updateLabel();
        }

        private void updateLabel()
        {
            if (!selling)
            {
                StringBuilder sb = new StringBuilder();
                lblTitle.Text = $"Bidding on painting # { currentPainting + 1}\n";
                sb.Append($"Price Range:\n");
                sb.Append($"Low: ${paintings[currentPainting].PriceRange.Low}\nMean: ${paintings[currentPainting].PriceRange.Mean}\nHigh: ${paintings[currentPainting].PriceRange.High}");
                lblInfo.Text = sb.ToString();
            } else {
                paintingOffers = GetOffers(paintings[currentPainting]);
                if (paintingOffers.Count != 0 && currentOffer < paintingOffers.Count)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"Selling Painting #");
                    sb.Append(currentPainting + 1);
                    sb.Append($"\nYou bought it for: ${paintings[currentPainting].PricePaid}");
                    lblTitle.Text = sb.ToString();
                    sb.Clear();
                    sb.Append($"\nThe average offer is: ${paintings[currentPainting].Price + 50}");
                    sb.Append($"\nOffer #{currentOffer + 1}: ${paintingOffers[currentOffer]}");
                    lblInfo.Text = sb.ToString();
                    currentOffer++;
                }
                else
                {
                    currentPainting++;
                    updateLabel();
                }
            }
            lblOwned.Text = $"Paintings Owned: {paintingsOwned}";
            lblSpent.Text = $"Money Spent: ${spent}";
        }

        private List<int> GetOffers(Painting painting)
        {
            List<int> offers = new List<int>();
            if(!painting.Owned)
            {
                return offers;
            }

            int numOffers = random.Next(1, 6);

            for(int i = 0; i < numOffers; i++)
            {
                offers.Add(Auction.GetOfferOnPainting(painting));
            }
            return offers;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!selling)
            {
                if(!Int32.TryParse(textBox1.Text, out int bid))
                {
                    MessageBox.Show("Please enter a valid bid.", "Bidding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool purchased = Auction.BidOnPainting(bid, paintings[currentPainting], out int opponentBid);

                if(purchased)
                {
                    spent += bid;
                    paintingsOwned++;
                    MessageBox.Show($"Your opponent bid ${opponentBid}\nYou won the auction!", "Auction Won", MessageBoxButtons.OK, MessageBoxIcon.None);
                } 
                else
                {
                    MessageBox.Show($"Your opponent bid ${opponentBid}\nYou were out bid.", "Out Bid", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                currentPainting++;

                if (currentPainting == NumPaintings)
                {
                    selling = true;
                    ChangeToSellMode();
                    currentPainting = 0;
                }
            }
            else 
            {
                paintings[currentPainting].Owned = false;
                profit += paintingOffers[currentOffer - 1] - paintings[currentPainting].PricePaid;
                currentPainting++;
            }
            textBox1.Text = "";
            updateLabel();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if(currentOffer < paintingOffers.Count)
            {
                currentOffer++;
                updateLabel();
                return;
            }
            updateLabel();
            profit += -1 * paintings[currentPainting].PricePaid;
            MessageBox.Show("Oh no! You didn't sell that one!", "Painting not sold", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            currentPainting++;
        }

        public void StartNewGame()
        {
            currentPainting = 0;
            profit = 0;
            spent = 0;
            btnAction.Text = "Bid";
            btnReject.Visible = false;
            textBox1.Visible = true;
            updateLabel();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAbout about = new frmAbout();
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings(this);
            settings.Show();
        }
    }
}
