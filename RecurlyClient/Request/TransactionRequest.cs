using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("transaction")]
    public class TransactionRequest
    {
        [YAXSerializeAs("amount_in_cents")]
        public int AmountInCents { get; set; }

        [YAXSerializeAs("currency")]
        public string Currency { get; set; }

        [YAXSerializeAs("account")]
        public AccountRequest Account { get; set; }
    }
}
