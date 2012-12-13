using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("account")]
    public class AccountRequest
    {
        [YAXSerializeAs("account_code")]
        public string Code { get; set; }

        [YAXSerializeAs("email")]
        public string EMail { get; set; }

        [YAXSerializeAs("username")]
        public string Username { get; set; }

        [YAXSerializeAs("first_name")]
        public string FirstName { get; set; }

        [YAXSerializeAs("last_name")]
        public string LastName { get; set; }

        [YAXSerializeAs("company_name")]
        public string CompanyName { get; set; }

        [YAXSerializeAs("accept_language")]
        public string AcceptLanguage { get; set; }

        [YAXSerializeAs("billing_info")]
        public BillingInfoRequest BillingInfo { get; set; }
    }
}
