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
        int a = 0;
        int b = 0;

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
                if(n == 1) //dealer
                {
                    for(int i=0; i < Enum.GetValues(typeof(Seed)).Length; i++)
                    {
                        for(int j=0; j < Enum.GetValues(typeof(Value)).Length; j++)
                        {
                            if((int)Deck.Deck[n].Seed == i && (int)Deck.Deck[n].Value == j )
                            {
                                PictureBox card = new PictureBox()
                                {
                                    Image = ImgDeck[i,j],
                                    Width = 74,
                                    Height = 100,
                                    SizeMode = PictureBoxSizeMode.Zoom
                                };
                                DealerCardsFlowLayoutPanel.Controls.Add(card);
                            }
                        }
                    }
                }
                else //player
                {
                    for (int i = 0; i < Enum.GetValues(typeof(Seed)).Length; i++)
                    {
                        for (int j = 0; j < Enum.GetValues(typeof(Value)).Length; j++)
                        {
                            if ((int)Deck.Deck[n].Seed == i && (int)Deck.Deck[n].Value == j)
                            {
                                PictureBox card = new PictureBox()
                                {
                                    Image = ImgDeck[i,j],
                                    Width = 74,
                                    Height = 100,
                                    SizeMode = PictureBoxSizeMode.Zoom
                                };
                                PlayerCardsFlowLayoutpanel.Controls.Add(card);
                            }
                        }
                    }
                }
            }
            
        }

        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            Deck = new FrenchDeck(NUMBER_OF_DECK);
            ImgDeck = new Image[Enum.GetValues(typeof(Seed)).Length, Enum.GetValues(typeof(Value)).Length];
            Deck.Initialize();

            Image img = Image.FromFile(@"C:\Users\Simone\Downloads\deck.jpg");
            for (int i = 0; i < Enum.GetValues(typeof(Seed)).Length; i++) 
            {
                for (int j = 0; j < Enum.GetValues(typeof(Value)).Length; j++)
                {
                    ImgDeck[i,j] = new Bitmap(950 / 13, 392 / 4);
                    Graphics graphics = Graphics.FromImage(ImgDeck[i,j]);
                    graphics.DrawImage(img, new Rectangle(950/13*i, 392/4*j, 950/13, 392/4), 
                        new Rectangle(0, 0, 950/13, 392/4), 
                        GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
        }

        private void ScoreButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
