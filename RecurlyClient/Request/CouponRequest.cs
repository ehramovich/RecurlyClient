using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("coupon")]
    public class CouponRequest
    {
        [YAXSerializeAs("coupon_code")]
        public string Code { get; set; }

        [YAXSerializeAs("name")]
        public string Name { get; set; }

        [YAXSerializeAs("discount_type")]
        public DiscountType DiscountType { get; set; }

        [YAXSerializeAs("discount_percent")]
        public int DiscountPercent { get; set; }

        [YAXSerializeAs("discount_in_cents")]
        public int DiscountInCents { get; set; }
    }

    public enum DiscountType
    {
        [YAXEnum("percent")]
        Percent,
        [YAXEnum("dollars")]
        Dollars
    }
}
