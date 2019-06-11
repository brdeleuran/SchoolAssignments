using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace WebsiteSOLID
{
    class Logic
    {
        IRequest request;

        public void setRequest(IRequest r)
        {
            request = r;
        }
        public string GetData(string input)
        {
            string output = request.Request(input);
            return output;
        }
    }
}
