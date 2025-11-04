using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SignatureProductionPlace", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SignatureProductionPlaceType
    {
        private string cityField;

        private string stateOrProvinceField;

        private string postalCodeField;

        private string countryNameField;


        public string City
        {
            get { return cityField; }
            set { cityField = value; }
        }


        public string StateOrProvince
        {
            get { return stateOrProvinceField; }
            set { stateOrProvinceField = value; }
        }


        public string PostalCode
        {
            get { return postalCodeField; }
            set { postalCodeField = value; }
        }


        public string CountryName
        {
            get { return countryNameField; }
            set { countryNameField = value; }
        }
    }
}