using System.Net;

namespace AppStudio.DataProviders.InternetClient
{
    internal class InternetRequestResult
    {
        public InternetRequestResult()
        {
            this.StatusCode = HttpStatusCode.OK;
            this.Result = string.Empty;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Result { get; set; }

        public bool Success { get { return (this.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(this.Result)); } }
    }
}
