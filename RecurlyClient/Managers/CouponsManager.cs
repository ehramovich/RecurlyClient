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
    public class CouponsManager : AbstractManager
    {
        internal CouponsManager(RestClient restClient, YAXRestSerializer serializer, string sResource)
            : base(restClient, serializer, sResource)
        {

        }

        public CouponResponse Create(CouponRequest coupon)
        {
            IRestRequest request = this.CreateRequest(this.Resource, Method.POST);
            request.AddBody(coupon);
            return this.ExecuteRequest<CouponResponse>(request).Data;
        }

        public CouponResponse Get(string sCouponCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{CouponCode}", Method.GET);
            request.AddUrlSegment("CouponCode", sCouponCode);

            return this.ExecuteRequest<CouponResponse>(request).Data;
        }

        public CouponResponse Get(Uri absoluteURI)
        {
            IRestRequest request = this.CreateRequest(absoluteURI.AbsoluteUri, Method.GET);

            return this.ExecuteRequest<CouponResponse>(request).Data;
        }

        public RedemptionResponse Redeem(string sCouponCode, RedemptionRequest redemption)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{CouponCode}/redeem", Method.POST);
            request.AddUrlSegment("CouponCode", sCouponCode);
            request.AddBody(redemption);

            return this.ExecuteRequest<RedemptionResponse>(request).Data;
        }

    }
}
