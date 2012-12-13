using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("redemption")]
    public class RedemptionRequest
    {
        [YAXSerializeAs("account_code")]
        public string AccountCode { get; set; }

        [YAXSerializeAs("currency")]
        public RecurlyCurrency Currency { get; set; }
    }
}
