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
        }

        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            Deck = new FrenchDeck(NUMBER_OF_DECK);
            Deck.Initialize();
        }
    }
}
