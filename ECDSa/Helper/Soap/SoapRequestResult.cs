namespace ECDSa.Helper.Soap
{
    public class SoapRequestResult
    {
        public bool IsSuccessStatusCode { get; set; }
        public bool IsFault { get; set; }

        public bool IsXml
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Content) &&
                       (Content.Contains(XmlNamespaces.SoapNs11)
                        || Content.Contains(XmlNamespaces.SoapNs12));
            }
        }

        public bool IsSoap11
        {
            get { return IsXml && Content.Contains(XmlNamespaces.SoapNs11); }
        }

        public bool IsSoap12
        {
            get { return IsXml && Content.Contains(XmlNamespaces.SoapNs12); }
        }

        public string Content { get; set; }
    }
}