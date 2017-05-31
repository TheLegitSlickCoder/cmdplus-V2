using System;
using System.Net;

namespace cmd_V2
{
    class Client
    {
        WebClient wc = new WebClient();

        //Get HTML Source:
        public string getHTMLSource(string URL)
        {
            string HTMLSource = wc.DownloadString(URL);
            return HTMLSource;
        }

        //Get IP:
        public string getIP(string URL)
        {
            string IP = Dns.GetHostAddresses(URL)[0].ToString();
            return IP;
        } 
    }
}