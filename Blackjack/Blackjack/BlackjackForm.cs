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
        Image[] imgDeck = new Image[52];

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

            PictureBox imgPlayerCard1 = new PictureBox();
            for(int n=0; n < 3; n++)
            {
                if(n % 2 != 0) //dealer
                {
                    for(int i=0; i < Enum.GetValues(typeof(Seed)).Length; i++)
                    {
                        for(int j=0; j < Enum.GetValues(typeof(Value)).Length; j++)
                        {
                            if((int)Deck.Deck[n].Seed == i && (int)Deck.Deck[n].Value == j )
                        }
                    }
                }
                else //player
                {

                }
            }
            imgPlayerCard1.Image = imgDeck[0];
            imgPlayerCard1.Width = 74;
            imgPlayerCard1.Height = 100;
            imgPlayerCard1.SizeMode = PictureBoxSizeMode.Zoom;
            this.DealerCardsFlowLayoutPanel.Controls.Add(imgPlayerCard1);

            PictureBox imgDealerCard1 = new PictureBox();
            imgDealerCard1.Image = imgDeck[1];
            imgDealerCard1.Width = 74;
            imgDealerCard1.Height = 100;
            imgDealerCard1.SizeMode = PictureBoxSizeMode.Zoom;
            this.DealerCardsFlowLayoutPanel.Controls.Add(imgDealerCard1);

            PictureBox imgDealerCard1 = new PictureBox();
            imgDealerCard1.Image = imgDeck[2];
            imgDealerCard1.Width = 74;
            imgDealerCard1.Height = 100;
            imgDealerCard1.SizeMode = PictureBoxSizeMode.Zoom;
            this.DealerCardsFlowLayoutPanel.Controls.Add(imgDealerCard1);
        }

        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            Deck = new FrenchDeck(NUMBER_OF_DECK);
            Deck.Initialize();

            Image img = Image.FromFile(@"C:\Users\Simone\Downloads\deck.jpg");
            for (int i = 0; i < Enum.GetValues(typeof(Seed)).Length; i++)
            {
                for (int j = 0; j < Enum.GetValues(typeof(Value)).Length; j++)
                {
                    int index = i * 4 + j;
                    imgDeck[index] = new Bitmap(950 / 13, 392 / 4);
                    Graphics graphics = Graphics.FromImage(imgDeck[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 950/13, 392/4), 
                        new Rectangle(i * 950/13, j * 392/4, 950/13, 392/4), 
                        GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
        }
    }
}
