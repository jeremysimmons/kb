using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.WebServiceClient;
using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;

namespace S2S_Auth_Blog.Controllers
{
    public class CrmController : Controller
    {
        // Get App settings from Config file
        private string clientId = ConfigurationManager.AppSettings["ida:ClientId"];
        private string authority = ConfigurationManager.AppSettings["ida:AADInstance"] + "common";
        private string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private string OrganizationHostName = ConfigurationManager.AppSettings["ida:OrganizationHostName"];
        private string appKey = ConfigurationManager.AppSettings["ida:ClientSecret"];

        // GET: Crm
        [Authorize]
        public ActionResult Index()
        {
            string tenantID = ClaimsPrincipal.Current.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid").Value;

            // Clean organization name from user logged
            string organizationName = User.Identity.Name.Substring(
             User.Identity.Name.IndexOf('@') + 1,
             User.Identity.Name.IndexOf('.') - (User.Identity.Name.IndexOf('@') + 1));

            //string crmResourceId = "https://[orgname].crm.microsoftonline.com";
            var resource = string.Format(OrganizationHostName, organizationName);

            // Request a token using application credentials
            ClientCredential clientcred = new ClientCredential(clientId, appKey);
            AuthenticationContext authenticationContext = new AuthenticationContext(aadInstance + tenantID);


            AuthenticationResult authenticationResult = authenticationContext.AcquireToken(resource, clientcred);
            var requestedToken = authenticationResult.AccessToken;

            // Invoke SDK using using the requested token
            using (var sdkService = new OrganizationWebProxyClient(GetServiceUrl(organizationName), false))
            {
                // Query CRM
                sdkService.HeaderToken = requestedToken;
                OrganizationRequest request = new OrganizationRequest()
                {
                    RequestName = "WhoAmI"
                };


                OrganizationResponse response = sdkService.Execute(request);

                return View((object)string.Join(",", response.Results.ToList()));
            }
        }

        private Uri GetServiceUrl(string organizationName)
        {
            var organizationUrl = new Uri(
             string.Format(OrganizationHostName, organizationName)
             );
            return new Uri(
             organizationUrl +
             @"/xrmservices/2011/organization.svc/web?SdkClientVersion=8.2"
         );
        }
    }
}