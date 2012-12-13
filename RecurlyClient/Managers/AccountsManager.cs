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
    public class AccountsManager : AbstractManager
    {
        internal AccountsManager(RestClient restClient, YAXRestSerializer serializer, string sResource)
            : base(restClient, serializer, sResource)
        {

        }

        public AccountResponseCollection List()
        {
            IRestRequest request = this.CreateRequest(this.Resource, Method.GET);
            return this.ExecuteRequest<AccountResponseCollection>(request).Data;
        }

        public AccountResponse Get(string sAccountCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}", Method.GET);
            request.AddUrlSegment("AccountCode", sAccountCode);
            return this.ExecuteRequest<AccountResponse>(request).Data;
        }

        public AccountResponse Get(Uri absoluteURI)
        {
            IRestRequest request = this.CreateRequest(absoluteURI.AbsoluteUri, Method.GET);
            return this.ExecuteRequest<AccountResponse>(request).Data;
        }

        public AccountResponse Create(AccountRequest account)
        {
            IRestRequest request = this.CreateRequest(this.Resource, Method.POST);
            request.AddBody(account);
            return this.ExecuteRequest<AccountResponse>(request).Data;
        }

        public SubscriptionResponseCollection GetSubscriptions(string sAccountCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}/subscriptions", Method.GET);
            request.AddUrlSegment("AccountCode", sAccountCode);
            return this.ExecuteRequest<SubscriptionResponseCollection>(request).Data;
        }

        public RedemptionResponse GetActiveCoupon(string sAccountCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}/redemption", Method.GET);
            request.AddUrlSegment("AccountCode", sAccountCode);
            return this.ExecuteRequest<RedemptionResponse>(request).Data;
        }

        public RedemptionResponse RemoveActiveCoupon(string sAccountCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}/redemption", Method.DELETE);
            request.AddUrlSegment("AccountCode", sAccountCode);
            return this.ExecuteRequest<RedemptionResponse>(request).Data;
        }

        public BillingInfoResponse GetBillingInfo(string sAccountCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}/billing_info", Method.GET);
            request.AddUrlSegment("AccountCode", sAccountCode);
            return this.ExecuteRequest<BillingInfoResponse>(request).Data;
        }

        public BillingInfoResponse UpdateBillingInfo(string sAccountCode, BillingInfoRequest billingInfo)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}/billing_info", Method.PUT);
            request.AddUrlSegment("AccountCode", sAccountCode);
            request.AddBody(billingInfo);
            return this.ExecuteRequest<BillingInfoResponse>(request).Data;
        }

        public void ClearBillingInfo(string sAccountCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{AccountCode}/billing_info", Method.DELETE);
            request.AddUrlSegment("AccountCode", sAccountCode);
            this.ExecuteRequest<BillingInfoResponse>(request);
        }
    }
}
