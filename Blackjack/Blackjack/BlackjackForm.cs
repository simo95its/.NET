using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Blackjack
{
    public partial class BlackjackForm : Form
    {
        public FrenchDeck Deck { get; set; }
        private const int NUMBER_OF_DECK = 2;
        Image[,] ImgDeck { get; set; }
        Game CurrentGame { get; set; }

        public BlackjackForm()
        {
            InitializeComponent();
        }

        #region StartButtonMethod
        private void StartButtonClickSettings()
        {
            StartButton.Visible = false;
            ScoreButton.Visible = false;
            CashTextBox.Visible = false;
            BetLabel.Visible = true;
            BetTextBox.Visible = true;

            Deck.Shuffle();
            CurrentGame = new Game();
            CurrentGame.DateStarted = DateTime.Now;
            CurrentGame.PlayerPoints = 0;
            CurrentGame.DealerPoints = 0;
            CurrentGame.DealerAcesNumber = 0;
            CurrentGame.PlayerAcesNumber = 0;
            CurrentGame.IsDealerAceChanged = false;
            CurrentGame.IsPlayerAceChanged = false;
            CurrentGame.Cash = int.Parse(CashLabel.Text.Substring(6));
            CurrentGame.Bet = 0;

            BetTextBox.MaxLength = CurrentGame.Cash.ToString().Length;
        }
        private void ZeroToThreeHands()
        {
            for (Deck.ExtractCard = 0; Deck.ExtractCard < 4; Deck.ExtractCard++)
            {
                if (Deck.ExtractCard % 2 != 0) //dealer
                {
                    DealerCardsFlowLayoutPanel.Controls.Add(ShowCard(Deck.ExtractCard));
                    try
                    {
                        CurrentGame.UpgradePoints(Deck, "dealer");
                    }
                    catch (DealerPointsOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.TargetSite);
                    }
                    DealerPointLabel.Text = CurrentGame.DealerPoints.ToString();
                }
                else //player
                {
                    PlayerCardsFlowLayoutpanel.Controls.Add(ShowCard(Deck.ExtractCard));
                    try
                    {
                        CurrentGame.UpgradePoints(Deck, "player");
                    }
                    catch (PlayerPointsOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.TargetSite);
                    }

                    PlayerPointLabel.Text = CurrentGame.PlayerPoints.ToString();
                }
            }
        }
        #endregion

        #region StandButtonMethod
        private void StandButtonClickSettings()
        {
            HitButton.Visible = false;
            StandButton.Visible = false;
            BetTextBox.Visible = false;
        }
        #endregion

        #region ButtonEvents
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButtonClickSettings();
            ZeroToThreeHands();
        }
        private void ScoreButton_Click(object sender, EventArgs e)
        {
            ScoreForm sf = new ScoreForm(this);
            sf.Show();
            this.Hide();
        }
        private void StandButton_Click(object sender, EventArgs e)
        {
            CurrentGame.Cash -= CurrentGame.Bet;
            while (!(CurrentGame.DealerPoints >= 16))
            {
                
                DealerCardsFlowLayoutPanel.Controls.Add(ShowCard(Deck.ExtractCard));
                try
                {
                    CurrentGame.UpgradePoints(Deck, "dealer");
                    DealerPointLabel.Text = CurrentGame.DealerPoints.ToString();
                    Deck.ExtractCard++;
                }
                catch (DealerPointsOutOfRangeException)
                {
                    DealerPointLabel.Text = CurrentGame.DealerPoints.ToString();
                    EndingGameSettings("You Win!", "Player");
                }
            }
            if (CurrentGame.DealerPoints >= CurrentGame.PlayerPoints && CurrentGame.DealerPoints <= 21)
            {
                EndingGameSettings("You Lose!", "Dealer");
            }
            else if (CurrentGame.DealerPoints < CurrentGame.PlayerPoints && CurrentGame.DealerPoints <= 21)
            {
                EndingGameSettings("You Win!", "Player");
            }
        }
        private void HitButton_Click(object sender, EventArgs e)
        {
            PlayerCardsFlowLayoutpanel.Controls.Add(ShowCard(Deck.ExtractCard));
            try
            {
                CurrentGame.UpgradePoints(Deck, "player");
                PlayerPointLabel.Text = CurrentGame.PlayerPoints.ToString();
                Deck.ExtractCard++;
            }
            catch (PlayerPointsOutOfRangeException)
            {
                PlayerPointLabel.Text = CurrentGame.PlayerPoints.ToString();
                EndingGameSettings("You Lose!", "Dealer");
            }
        }
        #endregion

        #region UtilMethod
        public void Reset()
        {
            StandButton.Visible = false;
            HitButton.Visible = false;
            InsuranceButton.Visible = false;
            DoubleDownButton.Visible = false;
            SplitButton.Visible = false;
            ScoreButton.Visible = true;
            StartButton.Visible = true;

            DealerPointLabel.Text = "0";
            PlayerPointLabel.Text = "0";
            PlayerSplitPointLabel.Text = "0";

            DealerCardsFlowLayoutPanel.Controls.Clear();
            PlayerCardsFlowLayoutpanel.Controls.Clear();
            PlayerSplitFlowLayoutPanel.Controls.Clear();

            CashTextBox.Text = "Insert your cash...";
            BetTextBox.Text = "Insert your bet...";

            BetLabel.Visible = false;
            BetTextBox.Visible = false;
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

            switch ((int)CardValue)
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
        private void EndingGameSettings(string result, string winner)
        {
            switch(winner)
            {
                case "Player":
                    CurrentGame.Cash += CurrentGame.Bet * 2;
                    break;
                case "Dealer":
                    CurrentGame.Cash -= CurrentGame.Bet;
                    break;
            }
            BetLabel.Text = "Bet: ";
            CashLabel.Text = "Cash: " + CurrentGame.Cash;
            CurrentGame.Bet = 0;
            MessageBox.Show(result);
            CurrentGame.DateEnd = DateTime.Now;
            CurrentGame.Winner = winner;
            UpgradeXml(CurrentGame);
            Reset();
        }
        #endregion

        #region TextBoxEvents
        private void CashTextBox_Click(object sender, EventArgs e)
        {
            CashTextBox.Text = string.Empty;
        }
        private void BetTextBox_Click(object sender, EventArgs e)
        {
            BetTextBox.Text = string.Empty;
        }
        private void CashTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(CashTextBox.Text, out result))
            {
                StartButton.Visible = true;
                CashLabel.Text = "Cash: " + result; 
            }
            if (string.IsNullOrWhiteSpace(CashTextBox.Text)) 
            {
                CashLabel.Text = "Cash: "; 
                StartButton.Visible = false;
            }
            if (CashLabel.Text.Length >= 7) 
            {
                if (int.Parse(CashLabel.Text.Substring(6)) <= 0)
                {
                    CashTextBox.Visible = true; 
                    StartButton.Visible = false; 
                }
            }
        }
        private void BetTextBox_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(BetTextBox.Text, out result) && !string.IsNullOrWhiteSpace(BetTextBox.Text) && int.Parse(BetTextBox.Text) <= CurrentGame.Cash)
            {
                BetLabel.Text = "Bet: " + result;
                CurrentGame.Bet = result;
                HitButton.Visible = true;
                StandButton.Visible = true;
            }
            else
            {
                HitButton.Visible = false;
                StandButton.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(BetTextBox.Text))
            {
                BetLabel.Text = "Bet: ";
            }
            if (CashLabel.Text.Length >= 7)
            {
                CashLabel.Text = "Cash: " + (CurrentGame.Cash - ((BetLabel.Text.Length >= 6) ? int.Parse(BetLabel.Text.Substring(5)) : 0));

            }
        }
        #endregion

        #region FormEvents
        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            //init vectors
            Deck = new FrenchDeck(NUMBER_OF_DECK);
            ImgDeck = new Image[Enum.GetValues(typeof(Seed)).Length, Enum.GetValues(typeof(Value)).Length];
            Deck.Initialize();
        }
        #endregion

        #region xml 
        private void UpgradeXml(Game element)
        {
            Games xmlList = new Games();
            xmlList = ReadXml<Games>(@"C:\Users\Simone\Source\Repos\.NET\Blackjack\Blackjack\XML\games.xml");
            xmlList.GameList.Add(element);
            WriteXml<Games>(xmlList, @"C:\Users\Simone\Source\Repos\.NET\Blackjack\Blackjack\XML\games.xml");
        }
        public T ReadXml<T>(string path)
        {
            T typeObject;
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            using (TextReader textReader = new StreamReader(path))
            {
                typeObject = (T)deserializer.Deserialize(textReader);
            }
            return typeObject;
        }
        public void WriteXml<T>(T typeObject, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter textWriter = new StreamWriter(path))
            {
                serializer.Serialize(textWriter, typeObject);
            }
        }
        #endregion
    }
}
