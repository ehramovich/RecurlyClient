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
    public class PlansManager : AbstractManager
    {
        internal PlansManager(RestClient restClient, YAXRestSerializer serializer, string sResource)
            : base(restClient, serializer, sResource)
        {

        }

        public PlanResponse Create(PlanRequest plan)
        {
            IRestRequest request = this.CreateRequest(this.Resource, Method.POST);
            request.AddBody(plan);
            return this.ExecuteRequest<PlanResponse>(request).Data;
        }

        public PlanResponse Get(string sPlanCode)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{PlanCode}", Method.GET);
            request.AddUrlSegment("PlanCode", sPlanCode);
            return this.ExecuteRequest<PlanResponse>(request).Data;
        }

        public PlanResponse Get(Uri absoluteURI)
        {
            IRestRequest request = this.CreateRequest(absoluteURI.AbsoluteUri, Method.GET);
            return this.ExecuteRequest<PlanResponse>(request).Data;
        }

        public PlanResponse Update(string sPlanCode, PlanRequest plan)
        {
            IRestRequest request = this.CreateRequest(this.Resource + "/{PlanCode}", Method.PUT);
            request.AddUrlSegment("PlanCode", sPlanCode);
            request.AddBody(plan);
            return this.ExecuteRequest<PlanResponse>(request).Data;
        }

    }
}
