using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("subscription")]
    public class SubscriptionResponse
    {
        [YAXSerializeAs("plan")]
        public PlanResponse Plan { get; set; }

        [YAXSerializeAs("uuid")]
        public string UUID { get; set; }

        [YAXSerializeAs("state")]
        public SubscriptionState State { get; set; }

        [YAXSerializeAs("unit_amount_in_cents")]
        public int UnitAmountInCents { get; set; }

        [YAXSerializeAs("currency")]
        public RecurlyCurrency Currency { get; set; }
    }

    public enum SubscriptionState
    {
        [YAXEnum("active")]
        Active,
        [YAXEnum("canceled")]
        Canceled,
        [YAXEnum("future")]
        Future,
        [YAXEnum("expired")]
        Expired,
        [YAXEnum("modified")]
        Modified
    }

    [YAXSerializeAs("subscriptions")]
    public class SubscriptionResponseCollection : List<SubscriptionResponse>
    {
    }
}
