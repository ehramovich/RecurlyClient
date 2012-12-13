using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("transaction")]
    public class TransactionResponse
    {
        [YAXSerializeAs("uuid")]
        public string UUID { get; set; }

        [YAXSerializeAs("action")]
        public string Action { get; set; }

        [YAXSerializeAs("amount_in_cents")]
        public int AmountInCents { get; set; }

        [YAXSerializeAs("tax_in_cents")]
        public int TaxInCents { get; set; }

        [YAXSerializeAs("currency")]
        public RecurlyCurrency Currency { get; set; }

        [YAXSerializeAs("status")]
        public string Status { get; set; }

        [YAXSerializeAs("reference")]
        public string Reference { get; set; }

        [YAXSerializeAs("source")]
        public string Source { get; set; }

        [YAXSerializeAs("test")]
        public bool IsTest { get; set; }

        [YAXSerializeAs("voidable")]
        public bool IsVoidable { get; set; }

        [YAXSerializeAs("refundable")]
        public bool IsRefundable { get; set; }

        [YAXSerializeAs("transaction_error")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public TransactionErrorResponse TransactionError { get; set; }

        [YAXSerializeAs("cvv_result")]
        public string CVVResult { get; set; }

        [YAXSerializeAs("avs_result")]
        public string AVSResult { get; set; }

        [YAXSerializeAs("avs_result_street")]
        public string AVSResultStreet { get; set; }

        [YAXSerializeAs("avs_result_postal")]
        public string AVSResultPostal { get; set; }

        [YAXSerializeAs("created_at")]
        public DateTime CreatedAt { get; set; }

        [YAXSerializeAs("details")]
        public TransactionDetails Details { get; set; }
    }

    [YAXSerializeAs("details")]
    public class TransactionDetails
    {
        [YAXSerializeAs("account")]
        public AccountResponse Account { get; set; }
    }
}
