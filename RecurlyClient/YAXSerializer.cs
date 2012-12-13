using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly
{
    internal class YAXRestSerializer : IDeserializer, ISerializer
    {
        public string DateFormat
        {
            get;
            set;
        }

        public T Deserialize<T>(IRestResponse response)
        {
            YAXSerializer serializer = new YAXSerializer(typeof(T));
            return (T)serializer.Deserialize(response.Content);
        }

        public string Namespace
        {
            get;
            set;
        }

        public string RootElement
        {
            get;
            set;
        }

        public string ContentType
        {
            get
            {
                return "*";
            }
            set
            {
            }
        }

        public string Serialize(object obj)
        {
            YAXSerializer serializer = new YAXSerializer(obj.GetType(), YAXExceptionHandlingPolicies.ThrowErrorsOnly, YAXExceptionTypes.Error, YAXSerializationOptions.DontSerializeNullObjects);
            return serializer.Serialize(obj);
        }
    }
}
