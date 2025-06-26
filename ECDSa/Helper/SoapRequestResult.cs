namespace ECDSa.Helper
{
    public class SoapRequestResult
    {
        public bool IsSuccessStatusCode { get; set; }

        public bool IsXml
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Content) &&
                       (Content.Contains(SoapEnvelopeHelper.SoapNs11)
                        || Content.Contains(SoapEnvelopeHelper.SoapNs12));
            }
        }

        public string Content { get; set; }
    }
}