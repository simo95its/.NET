using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Blackjack
{
    [Serializable]
    [XmlRoot("Games")]
    public class Games
    {
        [XmlElement("Game")]
        public List<Game> GameList { get; set; }

        public Games()
        {
            GameList = new List<Game>();
        }
    }
}
