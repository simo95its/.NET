using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Blackjack
{
    [Serializable]
    [XmlRoot("games")]
    public class Games
    {
        [XmlElement("game")]
        public Game[] GameList { get; set; }
    }
}
