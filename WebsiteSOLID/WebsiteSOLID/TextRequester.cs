using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WebsiteSOLID
{
    class TextRequester : IRequest
    {
        public string Request(string input)
        {
            string text = File.ReadAllText(input);
            return text;
        }
    }
}
