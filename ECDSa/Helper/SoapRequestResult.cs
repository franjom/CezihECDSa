namespace ECDSa.Helper
{
    public class SoapRequestResult
    {
        public bool IsSuccessStatusCode { get; set; }

        public bool IsXml
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Content) && Content.Contains("http://www.w3.org/2003/05/soap-envelope");
            }
        }

        public string Content { get; set; }
    }
}