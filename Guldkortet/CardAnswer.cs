using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guldkortet
{
    class CardAnswer
    {
        protected User user;
        protected string answer;

        public CardAnswer()
        {

        }
        public CardAnswer(User user, string answer)
        {
            this.user = user;
            this.answer = answer;
        }
    }
}
