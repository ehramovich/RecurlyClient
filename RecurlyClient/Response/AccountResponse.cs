using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAXLib;

namespace Recurly.Response
{
    [YAXSerializeAs("account")]
    public class AccountResponse
    {
        [YAXSerializeAs("account_code")]
        public string Code { get; set; }

        [YAXSerializeAs("email")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string EMail { get; set; }

        [YAXSerializeAs("state")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore, DefaultValue = AccountState.Unknown)]
        public AccountState State { get; set; }

        [YAXSerializeAs("first_name")]
        public string FirstName { get; set; }

        [YAXSerializeAs("last_name")]
        public string LastName { get; set; }

        [YAXSerializeAs("created_at")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public DateTime CreatedAt { get; set; }

        [YAXSerializeAs("username")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public string Username { get; set; }
    }

    [YAXSerializeAs("accounts")]
    public class AccountResponseCollection : List<AccountResponse>
    {
    }

    public enum AccountState
    {
        Unknown,
        [YAXEnum("active")]
        Active,
        [YAXEnum("closed")]
        Closed,
        [YAXEnum("past_due")]
        PastDue
    }
}
