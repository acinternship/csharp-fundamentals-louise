using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string Scrapeweboage(string url)
        {
            WebCliente client = new WebCliente();
            return client.DownloadString(url);

        }

        public string Scrapewebpage(string url, string filepage);
    }
}
