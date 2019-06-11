using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebsiteSOLID
{
    class WebRequester : IRequest
    {
        public string Request(string input)
        {
            WebRequest request = WebRequest.Create(input);
            WebResponse response = request.GetResponse();
            return ((HttpWebResponse)response).StatusDescription;
        }
    }
}
