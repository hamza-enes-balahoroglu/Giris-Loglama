using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisLog
{
    internal class DeficientDataException : Exception
    {
        public DeficientDataException()
        {

        }
        public DeficientDataException(string message) : base(message)
        {

        }

    }
}
