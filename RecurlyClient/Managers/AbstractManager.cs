using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAXLib;

namespace Recurly.Managers
{
    public abstract class AbstractManager
    {
        private const int HTTP_UNPROCESSABLE_ENTITY = 422;

        protected string Resource
        {
            get { return mResource; }
        }
        private string mResource;

        private RestClient mRestClient;

        private YAXRestSerializer mSerializer;

        internal AbstractManager(RestClient restClient, YAXRestSerializer serializer, string sResource)
        {
            this.mRestClient = restClient;
            this.mSerializer = serializer;
            this.mResource = sResource;
        }

        protected IRestRequest CreateRequest(string sResource, Method eMethod)
        {
            RestRequest request = new RestRequest(sResource, eMethod);
            request.XmlSerializer = mSerializer;
            return request;
        }

        protected IRestResponse<T> ExecuteRequest<T>(IRestRequest request) where T : new()
        {
            AmendResource(request);
            request.OnBeforeDeserialization = CheckErrors;
            return mRestClient.Execute<T>(request);
        }

        private void AmendResource(IRestRequest request)
        {
            string sBaseURL = mRestClient.BaseUrl;
            if (request.Resource.StartsWith(sBaseURL))
            {
                request.Resource = request.Resource.Remove(0, sBaseURL.Length);
            }
        }

        private void CheckErrors(IRestResponse response)
        {
            int iStatusCode = (int)response.StatusCode;

            if (!HttpIsOK(iStatusCode))
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new RecurlyNotFoundException();
                }
                else
                {
                }
                if ((int)response.StatusCode == HTTP_UNPROCESSABLE_ENTITY)
                {
                    RecurlyValidationErrorCollection errors = null;
                    try
                    {
                        errors = mSerializer.Deserialize<RecurlyValidationErrorCollection>(response);
                    }
                    catch (YAXException)
                    {
                        RecurlyError error = null;
                        try
                        {
                            error = mSerializer.Deserialize<RecurlyError>(response);
                        }
                        catch (YAXException)
                        {
                            RecurlyTransactionErrors transactionErrors = null;
                            try
                            {
                                transactionErrors = mSerializer.Deserialize<RecurlyTransactionErrors>(response);
                            }
                            catch (YAXException)
                            {
                                throw new RecurlyException(response.Content);
                            }
                            throw new RecurlyTransactionException(transactionErrors);
                        }
                        throw new RecurlyErrorException(error);
                    }
                    throw new RecurlyValidationException(errors);
                }
            }
        }

        private static bool HttpIsOK(int iStatusCode)
        {
            return iStatusCode >= 200 && iStatusCode <= 299;
        }
    }
}
