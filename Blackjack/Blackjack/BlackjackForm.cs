using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class BlackjackForm : Form
    {
        public FrenchDeck Deck { get; set; }
        private const int NUMBER_OF_DECK = 2;
        Image[,] ImgDeck { get; set; }
        int DealerScore { get; set; }
        int PlayerScore { get; set; }
        bool Gamer { get; set; } //false Player - true Dealer

        public BlackjackForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            ScoreButton.Enabled = false;
            DoubleDownButton.Enabled = true;
            SplitButton.Enabled = true;
            InsuranceButton.Enabled = true;
            StandButton.Enabled = true;
            HitButton.Enabled = true;
            Deck.Shuffle();
            
            for(int n=0; n < 3; n++)
            {
                if(n == 1) //dealer carta coperta
                {
                    Gamer = true;
                    PictureBox card = new PictureBox()
                    {
                        Image = Image.FromFile(@"C:\Users\Simone\Source\Repos\.NET\Blackjack\Blackjack\Resources\RETROCARTA.jpg"),
                        Width = 74,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    DealerCardsFlowLayoutPanel.Controls.Add(card);
                    UpgradePoints(Gamer, n);
                    Gamer = false;
                }
                else //player
                {
                    PlayerCardsFlowLayoutpanel.Controls.Add(ShowCard(n));
                    UpgradePoints(Gamer, n);
                    PlayerPointLabel.Text = PlayerScore.ToString();
                }
            }
            
        }

        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            Deck = new FrenchDeck(NUMBER_OF_DECK);
            ImgDeck = new Image[Enum.GetValues(typeof(Seed)).Length, Enum.GetValues(typeof(Value)).Length];
            Deck.Initialize();
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            
        }

        private PictureBox ShowCard(int n)
        {
            Seed CardSeed;
            Value CardValue;
            string path = @"C:\Users\Simone\Source\Repos\.NET\Blackjack\Blackjack\Resources\";

            CardSeed = Deck.Deck[n].Seed;
            CardValue = Deck.Deck[n].Value;

            PictureBox card = new PictureBox()
            {
                Width = 74,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            switch((int)CardValue)
            {
                case 0:
                    path += @"ASSO";
                    break;
                case 1:
                    path += @"DUE";
                    break;
                case 2:
                    path += @"TRE";
                    break;
                case 3:
                    path += @"QUATTRO";
                    break;
                case 4:
                    path += @"CINQUE";
                    break;
                case 5:
                    path += @"SEI";
                    break;
                case 6:
                    path += @"SETTE";
                    break;
                case 7:
                    path += @"OTTO";
                    break;
                case 8:
                    path += @"NOVE";
                    break;
                case 9:
                    path += @"DIECI";
                    break;
                case 10:
                    path += @"JACK";
                    break;
                case 11:
                    path += @"QUEEN";
                    break;
                case 12:
                    path += @"KING";
                    break;
            }

            switch ((int)CardSeed)
            {
                case 0:
                    path += @"FIORI";
                    break;
                case 1:
                    path += @"PICCHE";
                    break;
                case 2:
                    path += @"CUORI";
                    break;
                case 3:
                    path += @"QUADRI";
                    break;
            }

            path += @".bmp";
            card.Image = Image.FromFile(path);

            return card;
        }

        private void UpgradePoints(bool gamer, int n)
        {
            
            if(gamer)
            {
                if ((int)Deck.Deck[n].Value == 0)
                {
                    if (DealerScore >= 21)
                    {
                        DealerScore += 1;
                    }
                    else
                    {
                        DealerScore += 11;
                    }
                }
                else if ((int)Deck.Deck[n].Value == 10 || (int)Deck.Deck[n].Value == 11 || (int)Deck.Deck[n].Value == 12)
                {
                    DealerScore += 10;
                }
                else
                {
                    DealerScore += (int)Deck.Deck[]
                }
            }
            else
            {
                if ((int)Deck.Deck[n].Value == 0)
                {
                    if (PlayerScore >= 21)
                    {
                        PlayerScore += 1;
                    }
                    else
                    {
                        PlayerScore += 11;
                    }
                }
                else if ((int)Deck.Deck[n].Value == 10 || (int)Deck.Deck[n].Value == 11 || (int)Deck.Deck[n].Value == 12)
                {
                    PlayerScore += 10;
                }
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {

        }

        private void HitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
