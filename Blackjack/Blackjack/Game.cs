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
        [XmlAttribute("started")]
        public DateTime DateStarted { get; set; }
        [XmlAttribute("end")]
        public DateTime DateEnd { get; set; }
        [XmlElement("playerPoints")]
        public int PlayerPoints { get; set; }
        [XmlElement("dealerPoints")]
        public int DealerPoints { get; set; }
        [XmlElement("winner")]
        public bool Winner { get; set; }
    }
}
