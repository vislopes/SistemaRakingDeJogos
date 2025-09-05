using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakingDeJogos.ranking.Exceptions
{
    [Serializable]
    internal class RankingJogosException : Exception
    {
        public RankingJogosException() { }

        public RankingJogosException(string message) : base("Aconteceu uma exceção -> "+ message){ }

        public RankingJogosException(string message, Exception inner) : base(message, inner) { }

        protected RankingJogosException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    }
}
