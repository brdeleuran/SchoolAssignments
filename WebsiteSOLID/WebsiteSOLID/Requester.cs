using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebsiteSOLID
{
    class Requester
    {
        public string DataRequester(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            return ((HttpWebResponse)response).StatusDescription;
        }
    }
}
