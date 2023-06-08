using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class CheckScoreException : Exception
    {
        public CheckScoreException(string msg)
            : base(msg)
        {
        }
    }
}
