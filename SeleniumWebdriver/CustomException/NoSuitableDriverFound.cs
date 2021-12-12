using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is how you create a custom exception
namespace SeleniumWebdriver.CustomException
{
    class NoSuitableDriverFound : Exception //inherit the exception class
    {
        public NoSuitableDriverFound(string msg) : base(msg) //msg is the argument
        {

        }
    }
}
