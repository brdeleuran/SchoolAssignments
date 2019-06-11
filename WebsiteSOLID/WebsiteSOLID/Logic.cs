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
        Requester Requester = new Requester();
        public void GetData(string url, int destination)
        {
            try
            {
                switch (destination)
                {
                    case 1:
                        url = "https://" + url;
                        Console.WriteLine(Requester.DataRequester(url));
                        break;
                    default:
                        Console.WriteLine("Denied");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
