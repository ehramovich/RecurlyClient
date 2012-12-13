using Recurly.Managers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurly
{
    public class RecurlyClient
    {
        private const string RECURLY_BASE_URL = "https://api.recurly.com/v2/";

        private RestClient mRESTClient;

        private YAXRestSerializer mSerializer;

        private AccountsManager mAccountsManager = null;

        private CouponsManager mCouponsManager = null;

        private PlansManager mPlansManager = null;

        private SubscriptionsManager mSubscriptionsManager = null;

        public RecurlyClient(string sAPIKey)
        {
            mRESTClient = new RestClient();
            mRESTClient.BaseUrl = RECURLY_BASE_URL;
            mRESTClient.AddDefaultHeader("Accept", "application/xml");
            mRESTClient.AddDefaultHeader("Content-Type", "application/xml; charset=utf-8");
            mRESTClient.Authenticator = new HttpBasicAuthenticator(sAPIKey, string.Empty);

            mSerializer = new YAXRestSerializer();

            mRESTClient.AddHandler("application/xml", mSerializer);
            mRESTClient.AddHandler("text/xml", mSerializer);
        }

        public AccountsManager GetAccountsManager()
        {
            if (mAccountsManager == null)
            {
                mAccountsManager = new AccountsManager(mRESTClient, mSerializer, "accounts");
            }
            return mAccountsManager;
        }

        public CouponsManager GetCouponsManager()
        {
            if (mCouponsManager == null)
            {
                mCouponsManager = new CouponsManager(mRESTClient, mSerializer, "coupons");
            }
            return mCouponsManager;
        }

        public PlansManager GetPlansManager()
        {
            if (mPlansManager == null)
            {
                mPlansManager = new PlansManager(mRESTClient, mSerializer, "plans");
            }
            return mPlansManager;
        }

        public SubscriptionsManager GetSubscriptionsManager()
        {
            if (mSubscriptionsManager == null)
            {
                mSubscriptionsManager = new SubscriptionsManager(mRESTClient, mSerializer, "subscriptions");
            }
            return mSubscriptionsManager;
        }
    }
}
