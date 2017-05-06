using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    [Serializable]
    public class PlayerPointsOutOfRangeException : ApplicationException
    {
        public PlayerPointsOutOfRangeException() : this("Player Out") {}

        public PlayerPointsOutOfRangeException(string message) : base(message) {}

        public PlayerPointsOutOfRangeException(string message, Exception innerException)
            : base(message, innerException) {}

        public PlayerPointsOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context) {}
    }
}
