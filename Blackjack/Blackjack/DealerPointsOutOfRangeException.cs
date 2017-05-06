using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    [Serializable]
    public class DealerPointsOutOfRangeException : ApplicationException
    {
        public DealerPointsOutOfRangeException() : this("Player Out") { }

        public DealerPointsOutOfRangeException(string message) : base(message) { }

        public DealerPointsOutOfRangeException(string message, Exception innerException)
            : base(message, innerException) { }

        public DealerPointsOutOfRangeException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
