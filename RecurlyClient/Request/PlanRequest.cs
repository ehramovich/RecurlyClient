using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YAXLib;

namespace Recurly.Request
{
    [YAXSerializeAs("plan")]
    public class PlanRequest
    {
        [YAXSerializeAs("plan_code")]
        public string Code { get; set; }

        [YAXSerializeAs("name")]
        public string Name { get; set; }

        [YAXSerializeAs("unit_amount_in_cents")]
        [YAXErrorIfMissed(YAXExceptionTypes.Ignore)]
        public CurrencyObject[] UnitAmountInCents { get; set; }
    }

    [YAXCustomSerializer(typeof(CurrencyObjectSerializer))]
    public class CurrencyObject
    {
        public int AmountInCents { get; set; }

        public RecurlyCurrency Currency { get; set; }
    }

    public class CurrencyObjectSerializer : ICustomSerializer<CurrencyObject>
    {
        public CurrencyObject DeserializeFromAttribute(XAttribute attrib)
        {
            throw new NotImplementedException();
        }

        public CurrencyObject DeserializeFromElement(XElement element)
        {
            RecurlyCurrency eCurrency = (RecurlyCurrency)Enum.Parse(typeof(RecurlyCurrency), element.Name.LocalName);
            int iAmountInCents = int.Parse(element.Value);
            return new CurrencyObject { Currency = eCurrency, AmountInCents = iAmountInCents };
        }

        public CurrencyObject DeserializeFromValue(string value)
        {
            throw new NotImplementedException();
        }

        public void SerializeToAttribute(CurrencyObject objectToSerialize, XAttribute attrToFill)
        {
            throw new NotImplementedException();
        }

        public void SerializeToElement(CurrencyObject objectToSerialize, XElement elemToFill)
        {
            elemToFill.ReplaceWith(new XElement(XName.Get(objectToSerialize.Currency.ToString()))
            {
                Value = objectToSerialize.AmountInCents.ToString()
            });
        }

        public string SerializeToValue(CurrencyObject objectToSerialize)
        {
            throw new NotImplementedException();
        }
    }
}
