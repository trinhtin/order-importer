using System;
using System.Collections.Generic;
using System.Text;

namespace OrderImporter
{
    public class WooCommerceKey
    {
        public WooCommerceKey(string domainName, string ck, string cs)
        {
            this.DomainName = domainName;
            this.ConsumerKey = ck;
            this.ConsumerSecret = cs;
        }

        public string DomainName { get; set; }

        public string ConsumerKey { get; set; }

        public string ConsumerSecret { get; set; }
    }
}
