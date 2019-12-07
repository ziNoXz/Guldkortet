using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guldkortet
{
    class Reader
    {
        CardAnswer cardAnswer;

        public User getUserBySerialNum(string serialNum)
        {
            //Create method for reading from textfile and finding matching user
            return null;
        }
        public User getCardInfoBySerialNum(string serialNum)
        {
            //Create method for reading from textfile and finding cardinfo by serialnum
            return null;
        }

        public CardAnswer GetCardAnswer(string userSerialNum, string cardSerialNum)
        {
            //Split the string input and call on the other methods to retrieve all information and create a new cardAnswer obj and return it. 
            return null;
        }
    }
}
