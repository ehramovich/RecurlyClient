using Recurly.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("coupon")]
    public class CouponResponse
    {
        [YAXSerializeAs("coupon_code")]
        public string Code { get; set; }

        [YAXSerializeAs("name")]
        public string Name { get; set; }

        [YAXSerializeAs("state")]
        public CouponState State { get; set; }

        [YAXSerializeAs("discount_type")]
        public DiscountType DiscountType { get; set; }

        [YAXSerializeAs("discount_percent")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public int DiscountPercent { get; set; }

        [YAXSerializeAs("discount_in_cents")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public int DiscountInCents { get; set; }

        [YAXSerializeAs("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public enum CouponState
    {
        [YAXEnum("all")]
        All,
        [YAXEnum("redeemable")]
        Redeemable,
        [YAXEnum("expired")]
        Expired,
        [YAXEnum("maxed_out")]
        MaxedOut,
        [YAXEnum("inactive")]
        Inactive
    }
}
