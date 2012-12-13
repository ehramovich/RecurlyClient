using Recurly.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly
{
    public class RecurlyException : Exception
    {
        public RecurlyException() : base() { }

        public RecurlyException(string sMessage) : base(sMessage) { }
    }

    public class RecurlyValidationException : RecurlyException
    {
        public RecurlyValidationErrorCollection Errors
        {
            get;
            private set;
        }

        public RecurlyValidationException(RecurlyValidationErrorCollection errors)
            : base()
        {
            this.Errors = errors;
        }
    }

    public class RecurlyErrorException : RecurlyException
    {
        public RecurlyError Error
        {
            get;
            private set;
        }

        public RecurlyErrorException(RecurlyError error)
            : base()
        {
            this.Error = error;
        }
    }

    public class RecurlyNotFoundException : RecurlyException
    {
        public RecurlyNotFoundException()
            : base()
        {

        }
    }

    public class RecurlyTransactionException : RecurlyException
    {
        public RecurlyTransactionErrors Errors
        {
            get;
            private set;
        }

        public RecurlyTransactionException(RecurlyTransactionErrors errors)
        {
            this.Errors = errors;
        }
    }

    [YAXSerializeAs("errors")]
    public class RecurlyValidationErrorCollection : List<RecurlyValidationError>
    {
    }

    [YAXSerializeAs("error")]
    public class RecurlyValidationError
    {

        [YAXAttributeForClass]
        [YAXSerializeAs("field")]
        public string Field { get; set; }

        [YAXAttributeForClass]
        [YAXSerializeAs("symbol")]
        public string Symbol { get; set; }

        [YAXValueForClass]
        public string Message { get; set; }
    }


    [YAXSerializeAs("error")]
    public class RecurlyError
    {
        [YAXSerializeAs("symbol")]
        public string Symbol { get; set; }

        [YAXSerializeAs("description")]
        public string Description { get; set; }
    }

    [YAXSerializeAs("errors")]
    public class RecurlyTransactionErrors
    {
        [YAXSerializeAs("transaction_error")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public TransactionErrorResponse TransactionError { get; set; }

        [YAXSerializeAs("error")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public RecurlyValidationError ValidationError { get; set; }

        [YAXSerializeAs("transaction")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public TransactionResponse Transaction { get; set; }
    }
}
