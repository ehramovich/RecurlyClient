using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("billing_info")]
    public class BillingInfoRequest
    {
        [YAXSerializeAs("first_name")]
        public string FirstName { get; set; }

        [YAXSerializeAs("last_name")]
        public string LastName { get; set; }

        [YAXSerializeAs("address1")]
        public string Address1 { get; set; }

        [YAXSerializeAs("address2")]
        public string Address2 { get; set; }

        [YAXSerializeAs("city")]
        public string City { get; set; }

        [YAXSerializeAs("state")]
        public string State { get; set; }

        [YAXSerializeAs("country")]
        public string Country { get; set; }

        [YAXSerializeAs("zip")]
        public string Zip { get; set; }

        [YAXSerializeAs("phone")]
        public string Phone { get; set; }

        [YAXSerializeAs("vat_number")]
        public string VAT { get; set; }

        [YAXSerializeAs("ip_address")]
        public string IPAddress { get; set; }

        [YAXSerializeAs("number")]
        public string Number { get; set; }

        [YAXSerializeAs("month")]
        public int ExpirationMonth { get; set; }

        [YAXSerializeAs("year")]
        public int ExpirationYear { get; set; }

        [YAXSerializeAs("verification_value")]
        public string CVV { get; set; }
    }
}
