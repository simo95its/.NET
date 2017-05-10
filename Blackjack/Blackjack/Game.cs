using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Blackjack
{
    [Serializable]
    public class Game
    {
        [XmlIgnore]
        public int DealerAcesNumber { get; set; }
        [XmlIgnore]
        public int PlayerAcesNumber { get; set; }
        [XmlIgnore]
        public bool IsDealerAceChanged { get; set; } //false 11 - true 1
        [XmlIgnore]
        public bool IsPlayerAceChanged { get; set; } //false 11 - true 1
        
        public int  Cash { get; set; }
        
        public int Bet { get; set; }

        [XmlAttribute("Started")]
        public DateTime DateStarted { get; set; }

        [XmlAttribute("End")]
        public DateTime DateEnd { get; set; }

        private int _playerPoints;
        [XmlElement("PlayerPoints")]
        public int PlayerPoints
        {
            get
            {
                return _playerPoints;
            }
            set
            {
                _playerPoints = value;
                if(_playerPoints > 21 && PlayerAcesNumber != 0)
                {
                    _playerPoints -= 10 * PlayerAcesNumber;
                    IsPlayerAceChanged = true;
                    PlayerAcesNumber = 0;
                }
                else if(_playerPoints > 21)
                {
                    throw new PlayerPointsOutOfRangeException();
                }
            }
        }

        private int _dealerPoints;
        [XmlElement("DealerPoints")]
        public int DealerPoints
        {
            get
            {
                return _dealerPoints;
            }
            set
            {
                _dealerPoints = value;
                if(_dealerPoints > 21 && DealerAcesNumber != 0)
                {
                    _dealerPoints -= 10 * DealerAcesNumber;
                    IsDealerAceChanged = true;
                    DealerAcesNumber = 0;
                }
                else if(_dealerPoints > 21)
                {
                    throw new DealerPointsOutOfRangeException();
                }
            }
        }

        [XmlElement("Winner")]
        public string Winner { get; set; }

        public void UpgradePoints(FrenchDeck deck, string gamer)
        {
            switch(gamer)
            {
                case "dealer":
                    if (deck.Deck[deck.ExtractCard].Value == Value.Ace)
                    {
                        if(IsDealerAceChanged)
                        {
                            DealerPoints += 1;
                        }
                        else
                        {
                            DealerPoints += 11;
                            DealerAcesNumber++;
                        }
                        
                    }
                    else if (deck.Deck[deck.ExtractCard].Value == Value.Jack || deck.Deck[deck.ExtractCard].Value == Value.Queen || deck.Deck[deck.ExtractCard].Value == Value.King)
                    {
                        DealerPoints += 10;
                    }
                    else
                    {
                        DealerPoints += ((int)deck.Deck[deck.ExtractCard].Value + 1);
                    }
                    break;
                case "player":
                    if (deck.Deck[deck.ExtractCard].Value == Value.Ace)
                    {
                        if (IsPlayerAceChanged)
                        {
                            PlayerPoints += 1;
                        }
                        else
                        {
                            PlayerPoints += 11;
                            PlayerAcesNumber++;
                        }
                    }
                    else if (deck.Deck[deck.ExtractCard].Value == Value.Jack || deck.Deck[deck.ExtractCard].Value == Value.Queen || deck.Deck[deck.ExtractCard].Value == Value.King)
                    {
                        PlayerPoints += 10;
                    }
                    else
                    {
                        PlayerPoints += ((int)deck.Deck[deck.ExtractCard].Value + 1);
                    }
                    break;
            }
        }
    }
}
