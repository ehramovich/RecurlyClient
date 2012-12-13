using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("transaction_error")]
    public class TransactionErrorResponse
    {
        [YAXSerializeAs("error_code")]
        public string ErrorCode { get; set; }
        [YAXSerializeAs("error_category")]
        public string ErrorCategory { get; set; }
        [YAXSerializeAs("merchant_message")]
        public string MerchantMessage { get; set; }
        [YAXSerializeAs("customer_message")]
        public string CustomerMessage { get; set; }
    }
}
