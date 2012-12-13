using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("redemption")]
    public class RedemptionResponse
    {
        [YAXSerializeAs("href")]
        [YAXAttributeFor("coupon")]
        public string CouponHRef { get; set; }

        [YAXSerializeAs("href")]
        [YAXAttributeFor("account")]
        public string AccountHRef { get; set; }

        [YAXSerializeAs("currency")]
        public RecurlyCurrency Currency { get; set; }

        [YAXSerializeAs("single_use")]
        public bool SingleUse { get; set; }
    }
}
