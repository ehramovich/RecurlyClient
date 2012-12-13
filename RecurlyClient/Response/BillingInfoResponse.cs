using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("billing_info")]
    public class BillingInfoResponse
    {
        [YAXSerializeAs("first_name")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string FirstName { get; set; }

        [YAXSerializeAs("last_name")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string LastName { get; set; }

        [YAXSerializeAs("address1")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string Address1 { get; set; }

        [YAXSerializeAs("address2")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string Address2 { get; set; }

        [YAXSerializeAs("city")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string City { get; set; }

        [YAXSerializeAs("state")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string State { get; set; }

        [YAXSerializeAs("country")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string Country { get; set; }

        [YAXSerializeAs("zip")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string Zip { get; set; }

        [YAXSerializeAs("phone")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string Phone { get; set; }

        [YAXSerializeAs("vat_number")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string VAT { get; set; }

        [YAXSerializeAs("ip_address")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string IPAddress { get; set; }

        [YAXSerializeAs("ip_address_country")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string IPAddressCountry { get; set; }

        [YAXSerializeAs("first_six")]
        public string FirstSixDigits { get; set; }

        [YAXSerializeAs("last_four")]
        public string LastFourDigits { get; set; }

        [YAXSerializeAs("card_type")]
        public string CardType { get; set; }

        [YAXSerializeAs("month")]
        public int ExpirationMonth { get; set; }

        [YAXSerializeAs("year")]
        public int ExpirationYear { get; set; }

        [YAXSerializeAs("billing_agreement_id")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string BillingAgreementID { get; set; }
    }
}
