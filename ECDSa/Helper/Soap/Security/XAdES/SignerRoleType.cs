using System;
using System.Xml.Serialization;

namespace ECDSa.Helper.Soap.Security.XAdES
{
    [Serializable]
    [XmlType(Namespace = XmlNamespaces.EtsiNs)]
    [XmlRoot("SignerRole", Namespace = XmlNamespaces.EtsiNs, IsNullable = false)]
    public partial class SignerRoleType
    {
        private AnyType[] claimedRolesField;

        private EncapsulatedPKIDataType[] certifiedRolesField;


        [XmlArrayItem("ClaimedRole", IsNullable = false)]
        public AnyType[] ClaimedRoles
        {
            get { return claimedRolesField; }
            set { claimedRolesField = value; }
        }


        [XmlArrayItem("CertifiedRole", IsNullable = false)]
        public EncapsulatedPKIDataType[] CertifiedRoles
        {
            get { return certifiedRolesField; }
            set { certifiedRolesField = value; }
        }
    }
}