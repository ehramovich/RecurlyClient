using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("subscription")]
    public class SubscriptionRequest
    {
        [YAXSerializeAs("plan_code")]
        public string PlanCode { get; set; }

        [YAXSerializeAs("account")]
        public AccountRequest Account { get; set; }

        [YAXSerializeAs("coupon_code")]
        public string CouponCode { get; set; }

        [YAXSerializeAs("currency")]
        public RecurlyCurrency Currency { get; set; }
    }
}
