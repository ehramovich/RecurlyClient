using Recurly.Request;
using Recurly.Response;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurly.Managers
{
    public class SubscriptionsManager : AbstractManager
    {
        internal SubscriptionsManager(RestClient restClient, YAXRestSerializer serializer, string sResource)
            : base(restClient, serializer, sResource)
        {

        }

        public SubscriptionResponse Create(SubscriptionRequest subscription)
        {
            IRestRequest request = this.CreateRequest(this.Resource, Method.POST);
            request.AddBody(subscription);
            return this.ExecuteRequest<SubscriptionResponse>(request).Data;
        }

        public SubscriptionResponse Get(string sUUID)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{UUID}", Method.GET);
            request.AddUrlSegment("UUID", sUUID);
            return this.ExecuteRequest<SubscriptionResponse>(request).Data;
        }

        public SubscriptionResponse Get(Uri absoluteURI)
        {
            IRestRequest request = this.CreateRequest(absoluteURI.AbsoluteUri, Method.GET);
            return this.ExecuteRequest<SubscriptionResponse>(request).Data;
        }

        public SubscriptionResponse Cancel(string sUUID)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{UUID}/cancel", Method.PUT);
            request.AddUrlSegment("UUID", sUUID);
            return this.ExecuteRequest<SubscriptionResponse>(request).Data;
        }

        public SubscriptionResponse Reactivate(string sUUID)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{UUID}/reactivate", Method.PUT);
            request.AddUrlSegment("UUID", sUUID);
            return this.ExecuteRequest<SubscriptionResponse>(request).Data;
        }

        public SubscriptionResponse Terminate(string sUUID, RefundType eRefundType)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{UUID}/terminate?refund={refund}", Method.PUT);
            request.AddUrlSegment("UUID", sUUID);
            request.AddUrlSegment("refund", eRefundType.ToString().ToLowerInvariant());
            return this.ExecuteRequest<SubscriptionResponse>(request).Data;
        }

        public enum RefundType
        {
            None,
            Partial,
            Full

        }
    }
}
