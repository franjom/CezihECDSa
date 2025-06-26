using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.Wsdl.PrijavaZarazneUpdate
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "urn:ihe:iti:xds-b:2007",
        ConfigurationName = "XDSbRegistry_ITI57.DocumentRegistryUpdate_PortType")]
    public interface DocumentRegistryUpdate_PortType
    {
        // CODEGEN: Generating message contract since the operation DocumentRegistry_UpdateDocumentSet is neither RPC nor document wrapped.
        [OperationContractAttribute(Action = "urn:ihe:iti:2010:UpdateDocumentSet",
            ReplyAction = "urn:ihe:iti:2010:UpdateDocumentSetResponse")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(RegistryRequestType))]
        DocumentRegistry_UpdateDocumentSetResponse DocumentRegistry_UpdateDocumentSet(
            DocumentRegistry_UpdateDocumentSetRequest request);

        [OperationContractAttribute(Action = "urn:ihe:iti:2010:UpdateDocumentSet",
            ReplyAction = "urn:ihe:iti:2010:UpdateDocumentSetResponse")]
        Task<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistry_UpdateDocumentSetAsync(
            DocumentRegistry_UpdateDocumentSetRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0")]
    [XmlRoot(ElementName = "SubmitObjectsRequest", Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0")]
    public partial class SubmitObjectsRequest : RegistryRequestType
    {
        private IdentifiableType[] registryObjectListField;

        /// <remarks/>
        [XmlArrayAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", Order = 0)]
        [XmlArrayItemAttribute("Notification", typeof(NotificationType), IsNullable = false)]
        [XmlArrayItemAttribute("AdhocQuery", typeof(AdhocQueryType), IsNullable = false)]
        [XmlArrayItemAttribute("Subscription", typeof(SubscriptionType), IsNullable = false)]
        [XmlArrayItemAttribute("Federation", typeof(FederationType), IsNullable = false)]
        [XmlArrayItemAttribute("Registry", typeof(RegistryType), IsNullable = false)]
        [XmlArrayItemAttribute("Person", typeof(PersonType), IsNullable = false)]
        [XmlArrayItemAttribute("User", typeof(UserType), IsNullable = false)]
        [XmlArrayItemAttribute("SpecificationLink", typeof(SpecificationLinkType), IsNullable = false)]
        [XmlArrayItemAttribute("ServiceBinding", typeof(ServiceBindingType), IsNullable = false)]
        [XmlArrayItemAttribute("Service", typeof(ServiceType), IsNullable = false)]
        [XmlArrayItemAttribute("RegistryPackage", typeof(RegistryPackageType), IsNullable = false)]
        [XmlArrayItemAttribute("Organization", typeof(OrganizationType), IsNullable = false)]
        [XmlArrayItemAttribute("ExtrinsicObject", typeof(ExtrinsicObjectType), IsNullable = false)]
        [XmlArrayItemAttribute("ExternalLink", typeof(ExternalLinkType), IsNullable = false)]
        [XmlArrayItemAttribute("ClassificationScheme", typeof(ClassificationSchemeType), IsNullable = false)]
        [XmlArrayItemAttribute("ClassificationNode", typeof(ClassificationNodeType), IsNullable = false)]
        [XmlArrayItemAttribute("AuditableEvent", typeof(AuditableEventType), IsNullable = false)]
        [XmlArrayItemAttribute("Association", typeof(AssociationType1), IsNullable = false)]
        [XmlArrayItemAttribute("ExternalIdentifier", typeof(ExternalIdentifierType), IsNullable = false)]
        [XmlArrayItemAttribute("Classification", typeof(ClassificationType), IsNullable = false)]
        [XmlArrayItemAttribute("Identifiable", IsNullable = false)]

        public IdentifiableType[] RegistryObjectList
        {
            get { return this.registryObjectListField; }
            set
            {
                this.registryObjectListField = value;
                this.RaisePropertyChanged("RegistryObjectList");
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(RegistryObjectType))]
    [XmlIncludeAttribute(typeof(NotificationType))]
    [XmlIncludeAttribute(typeof(AdhocQueryType))]
    [XmlIncludeAttribute(typeof(SubscriptionType))]
    [XmlIncludeAttribute(typeof(FederationType))]
    [XmlIncludeAttribute(typeof(RegistryType))]
    [XmlIncludeAttribute(typeof(PersonType))]
    [XmlIncludeAttribute(typeof(UserType))]
    [XmlIncludeAttribute(typeof(SpecificationLinkType))]
    [XmlIncludeAttribute(typeof(ServiceBindingType))]
    [XmlIncludeAttribute(typeof(ServiceType))]
    [XmlIncludeAttribute(typeof(RegistryPackageType))]
    [XmlIncludeAttribute(typeof(OrganizationType))]
    [XmlIncludeAttribute(typeof(ExtrinsicObjectType))]
    [XmlIncludeAttribute(typeof(ExternalLinkType))]
    [XmlIncludeAttribute(typeof(ClassificationSchemeType))]
    [XmlIncludeAttribute(typeof(ClassificationNodeType))]
    [XmlIncludeAttribute(typeof(AuditableEventType))]
    [XmlIncludeAttribute(typeof(AssociationType1))]
    [XmlIncludeAttribute(typeof(ExternalIdentifierType))]
    [XmlIncludeAttribute(typeof(ClassificationType))]
    [XmlIncludeAttribute(typeof(ObjectRefType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class IdentifiableType : object, INotifyPropertyChanged
    {
        private SlotType1[] slotField;

        private string idField;

        private string homeField;

        /// <remarks/>
        [XmlElementAttribute("Slot", Order = 0)]
        public SlotType1[] Slot
        {
            get { return this.slotField; }
            set
            {
                this.slotField = value;
                this.RaisePropertyChanged("Slot");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get { return this.idField; }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string home
        {
            get { return this.homeField; }
            set
            {
                this.homeField = value;
                this.RaisePropertyChanged("home");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class SlotType1 : object, INotifyPropertyChanged
    {
        private ValueListType valueListField;

        private string nameField;

        private string slotTypeField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ValueListType ValueList
        {
            get { return this.valueListField; }
            set
            {
                this.valueListField = value;
                this.RaisePropertyChanged("ValueList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string slotType
        {
            get { return this.slotTypeField; }
            set
            {
                this.slotTypeField = value;
                this.RaisePropertyChanged("slotType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ValueListType : object, INotifyPropertyChanged
    {
        private string[] valueField;

        /// <remarks/>
        [XmlElementAttribute("Value", Order = 0)]
        public string[] Value
        {
            get { return this.valueField; }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0")]
    public partial class RegistryResponseType : object, INotifyPropertyChanged
    {
        private SlotType1[] responseSlotListField;

        private RegistryErrorList registryErrorListField;

        private string statusField;

        private string requestIdField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Slot", Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", IsNullable = false)]
        public SlotType1[] ResponseSlotList
        {
            get { return this.responseSlotListField; }
            set
            {
                this.responseSlotListField = value;
                this.RaisePropertyChanged("ResponseSlotList");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public RegistryErrorList RegistryErrorList
        {
            get { return this.registryErrorListField; }
            set
            {
                this.registryErrorListField = value;
                this.RaisePropertyChanged("RegistryErrorList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string status
        {
            get { return this.statusField; }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string requestId
        {
            get { return this.requestIdField; }
            set
            {
                this.requestIdField = value;
                this.RaisePropertyChanged("requestId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0")]
    public partial class RegistryErrorList : object, INotifyPropertyChanged
    {
        private RegistryError[] registryErrorField;

        private string highestSeverityField;

        /// <remarks/>
        [XmlElementAttribute("RegistryError", Order = 0)]
        public RegistryError[] RegistryError
        {
            get { return this.registryErrorField; }
            set
            {
                this.registryErrorField = value;
                this.RaisePropertyChanged("RegistryError");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string highestSeverity
        {
            get { return this.highestSeverityField; }
            set
            {
                this.highestSeverityField = value;
                this.RaisePropertyChanged("highestSeverity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0")]
    public partial class RegistryError : object, INotifyPropertyChanged
    {
        private string codeContextField;

        private string errorCodeField;

        private string severityField;

        private string locationField;

        private string valueField;

        public RegistryError()
        {
            this.severityField = "urn:oasis:names:tc:ebxml-regrep:ErrorSeverityType:Error";
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string codeContext
        {
            get { return this.codeContextField; }
            set
            {
                this.codeContextField = value;
                this.RaisePropertyChanged("codeContext");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string errorCode
        {
            get { return this.errorCodeField; }
            set
            {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        [DefaultValueAttribute("urn:oasis:names:tc:ebxml-regrep:ErrorSeverityType:Error")]
        public string severity
        {
            get { return this.severityField; }
            set
            {
                this.severityField = value;
                this.RaisePropertyChanged("severity");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string location
        {
            get { return this.locationField; }
            set
            {
                this.locationField = value;
                this.RaisePropertyChanged("location");
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value
        {
            get { return this.valueField; }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class QueryExpressionType : object, INotifyPropertyChanged
    {
        private XmlNode[] anyField;

        private string queryLanguageField;

        /// <remarks/>
        [XmlTextAttribute()]
        [XmlAnyElementAttribute(Order = 0)]
        public XmlNode[] Any
        {
            get { return this.anyField; }
            set
            {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string queryLanguage
        {
            get { return this.queryLanguageField; }
            set
            {
                this.queryLanguageField = value;
                this.RaisePropertyChanged("queryLanguage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(NotifyActionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public abstract partial class ActionType : object, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class NotifyActionType : ActionType
    {
        private string notificationOptionField;

        private string endPointField;

        public NotifyActionType()
        {
            this.notificationOptionField = "urn:oasis:names:tc:ebxml-regrep:NotificationOptionType:ObjectRefs";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        [DefaultValueAttribute("urn:oasis:names:tc:ebxml-regrep:NotificationOptionType:ObjectRefs")]
        public string notificationOption
        {
            get { return this.notificationOptionField; }
            set
            {
                this.notificationOptionField = value;
                this.RaisePropertyChanged("notificationOption");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string endPoint
        {
            get { return this.endPointField; }
            set
            {
                this.endPointField = value;
                this.RaisePropertyChanged("endPoint");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class PersonNameType : object, INotifyPropertyChanged
    {
        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string firstName
        {
            get { return this.firstNameField; }
            set
            {
                this.firstNameField = value;
                this.RaisePropertyChanged("firstName");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string middleName
        {
            get { return this.middleNameField; }
            set
            {
                this.middleNameField = value;
                this.RaisePropertyChanged("middleName");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string lastName
        {
            get { return this.lastNameField; }
            set
            {
                this.lastNameField = value;
                this.RaisePropertyChanged("lastName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class EmailAddressType : object, INotifyPropertyChanged
    {
        private string addressField;

        private string typeField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string address
        {
            get { return this.addressField; }
            set
            {
                this.addressField = value;
                this.RaisePropertyChanged("address");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string type
        {
            get { return this.typeField; }
            set
            {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class TelephoneNumberType : object, INotifyPropertyChanged
    {
        private string areaCodeField;

        private string countryCodeField;

        private string extensionField;

        private string numberField;

        private string phoneTypeField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string areaCode
        {
            get { return this.areaCodeField; }
            set
            {
                this.areaCodeField = value;
                this.RaisePropertyChanged("areaCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string countryCode
        {
            get { return this.countryCodeField; }
            set
            {
                this.countryCodeField = value;
                this.RaisePropertyChanged("countryCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string extension
        {
            get { return this.extensionField; }
            set
            {
                this.extensionField = value;
                this.RaisePropertyChanged("extension");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string number
        {
            get { return this.numberField; }
            set
            {
                this.numberField = value;
                this.RaisePropertyChanged("number");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string phoneType
        {
            get { return this.phoneTypeField; }
            set
            {
                this.phoneTypeField = value;
                this.RaisePropertyChanged("phoneType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class PostalAddressType : object, INotifyPropertyChanged
    {
        private string cityField;

        private string countryField;

        private string postalCodeField;

        private string stateOrProvinceField;

        private string streetField;

        private string streetNumberField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string city
        {
            get { return this.cityField; }
            set
            {
                this.cityField = value;
                this.RaisePropertyChanged("city");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string country
        {
            get { return this.countryField; }
            set
            {
                this.countryField = value;
                this.RaisePropertyChanged("country");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string postalCode
        {
            get { return this.postalCodeField; }
            set
            {
                this.postalCodeField = value;
                this.RaisePropertyChanged("postalCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string stateOrProvince
        {
            get { return this.stateOrProvinceField; }
            set
            {
                this.stateOrProvinceField = value;
                this.RaisePropertyChanged("stateOrProvince");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string street
        {
            get { return this.streetField; }
            set
            {
                this.streetField = value;
                this.RaisePropertyChanged("street");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string streetNumber
        {
            get { return this.streetNumberField; }
            set
            {
                this.streetNumberField = value;
                this.RaisePropertyChanged("streetNumber");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ObjectRefListType : object, INotifyPropertyChanged
    {
        private ObjectRefType[] objectRefField;

        /// <remarks/>
        [XmlElementAttribute("ObjectRef", Order = 0)]
        public ObjectRefType[] ObjectRef
        {
            get { return this.objectRefField; }
            set
            {
                this.objectRefField = value;
                this.RaisePropertyChanged("ObjectRef");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ObjectRefType : IdentifiableType
    {
        private bool createReplicaField;

        public ObjectRefType()
        {
            this.createReplicaField = false;
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(false)]
        public bool createReplica
        {
            get { return this.createReplicaField; }
            set
            {
                this.createReplicaField = value;
                this.RaisePropertyChanged("createReplica");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class VersionInfoType : object, INotifyPropertyChanged
    {
        private string versionNameField;

        private string commentField;

        public VersionInfoType()
        {
            this.versionNameField = "1.1";
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute("1.1")]
        public string versionName
        {
            get { return this.versionNameField; }
            set
            {
                this.versionNameField = value;
                this.RaisePropertyChanged("versionName");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string comment
        {
            get { return this.commentField; }
            set
            {
                this.commentField = value;
                this.RaisePropertyChanged("comment");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class LocalizedStringType : object, INotifyPropertyChanged
    {
        private string langField;

        private string charsetField;

        private string valueField;

        public LocalizedStringType()
        {
            this.charsetField = "UTF-8";
        }

        /// <remarks/>
        [XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
            Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get { return this.langField; }
            set
            {
                this.langField = value;
                this.RaisePropertyChanged("lang");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute("UTF-8")]
        public string charset
        {
            get { return this.charsetField; }
            set
            {
                this.charsetField = value;
                this.RaisePropertyChanged("charset");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class InternationalStringType : object, INotifyPropertyChanged
    {
        private LocalizedStringType[] localizedStringField;

        /// <remarks/>
        [XmlElementAttribute("LocalizedString", Order = 0)]
        public LocalizedStringType[] LocalizedString
        {
            get { return this.localizedStringField; }
            set
            {
                this.localizedStringField = value;
                this.RaisePropertyChanged("LocalizedString");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0")]
    public partial class RegistryRequestType : object, INotifyPropertyChanged
    {
        private SlotType1[] requestSlotListField;

        private string idField;

        private string commentField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Slot", Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0", IsNullable = false)]
        public SlotType1[] RequestSlotList
        {
            get { return this.requestSlotListField; }
            set
            {
                this.requestSlotListField = value;
                this.RaisePropertyChanged("RequestSlotList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get { return this.idField; }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string comment
        {
            get { return this.commentField; }
            set
            {
                this.commentField = value;
                this.RaisePropertyChanged("comment");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(NotificationType))]
    [XmlIncludeAttribute(typeof(AdhocQueryType))]
    [XmlIncludeAttribute(typeof(SubscriptionType))]
    [XmlIncludeAttribute(typeof(FederationType))]
    [XmlIncludeAttribute(typeof(RegistryType))]
    [XmlIncludeAttribute(typeof(PersonType))]
    [XmlIncludeAttribute(typeof(UserType))]
    [XmlIncludeAttribute(typeof(SpecificationLinkType))]
    [XmlIncludeAttribute(typeof(ServiceBindingType))]
    [XmlIncludeAttribute(typeof(ServiceType))]
    [XmlIncludeAttribute(typeof(RegistryPackageType))]
    [XmlIncludeAttribute(typeof(OrganizationType))]
    [XmlIncludeAttribute(typeof(ExtrinsicObjectType))]
    [XmlIncludeAttribute(typeof(ExternalLinkType))]
    [XmlIncludeAttribute(typeof(ClassificationSchemeType))]
    [XmlIncludeAttribute(typeof(ClassificationNodeType))]
    [XmlIncludeAttribute(typeof(AuditableEventType))]
    [XmlIncludeAttribute(typeof(AssociationType1))]
    [XmlIncludeAttribute(typeof(ExternalIdentifierType))]
    [XmlIncludeAttribute(typeof(ClassificationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class RegistryObjectType : IdentifiableType
    {
        private InternationalStringType nameField;

        private InternationalStringType descriptionField;

        private VersionInfoType versionInfoField;

        private ClassificationType[] classificationField;

        private ExternalIdentifierType[] externalIdentifierField;

        private string lidField;

        private string objectTypeField;

        private string statusField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public InternationalStringType Name
        {
            get { return this.nameField; }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public InternationalStringType Description
        {
            get { return this.descriptionField; }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public VersionInfoType VersionInfo
        {
            get { return this.versionInfoField; }
            set
            {
                this.versionInfoField = value;
                this.RaisePropertyChanged("VersionInfo");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Classification", Order = 3)]
        public ClassificationType[] Classification
        {
            get { return this.classificationField; }
            set
            {
                this.classificationField = value;
                this.RaisePropertyChanged("Classification");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ExternalIdentifier", Order = 4)]
        public ExternalIdentifierType[] ExternalIdentifier
        {
            get { return this.externalIdentifierField; }
            set
            {
                this.externalIdentifierField = value;
                this.RaisePropertyChanged("ExternalIdentifier");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string lid
        {
            get { return this.lidField; }
            set
            {
                this.lidField = value;
                this.RaisePropertyChanged("lid");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string objectType
        {
            get { return this.objectTypeField; }
            set
            {
                this.objectTypeField = value;
                this.RaisePropertyChanged("objectType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string status
        {
            get { return this.statusField; }
            set
            {
                this.statusField = value;
                this.RaisePropertyChanged("status");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ClassificationType : RegistryObjectType
    {
        private string classificationSchemeField;

        private string classifiedObjectField;

        private string classificationNodeField;

        private string nodeRepresentationField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string classificationScheme
        {
            get { return this.classificationSchemeField; }
            set
            {
                this.classificationSchemeField = value;
                this.RaisePropertyChanged("classificationScheme");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string classifiedObject
        {
            get { return this.classifiedObjectField; }
            set
            {
                this.classifiedObjectField = value;
                this.RaisePropertyChanged("classifiedObject");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string classificationNode
        {
            get { return this.classificationNodeField; }
            set
            {
                this.classificationNodeField = value;
                this.RaisePropertyChanged("classificationNode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string nodeRepresentation
        {
            get { return this.nodeRepresentationField; }
            set
            {
                this.nodeRepresentationField = value;
                this.RaisePropertyChanged("nodeRepresentation");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ExternalIdentifierType : RegistryObjectType
    {
        private string registryObjectField;

        private string identificationSchemeField;

        private string valueField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string registryObject
        {
            get { return this.registryObjectField; }
            set
            {
                this.registryObjectField = value;
                this.RaisePropertyChanged("registryObject");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string identificationScheme
        {
            get { return this.identificationSchemeField; }
            set
            {
                this.identificationSchemeField = value;
                this.RaisePropertyChanged("identificationScheme");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class NotificationType : RegistryObjectType
    {
        private IdentifiableType[] registryObjectListField;

        private string subscriptionField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Identifiable", IsNullable = false)]
        public IdentifiableType[] RegistryObjectList
        {
            get { return this.registryObjectListField; }
            set
            {
                this.registryObjectListField = value;
                this.RaisePropertyChanged("RegistryObjectList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string subscription
        {
            get { return this.subscriptionField; }
            set
            {
                this.subscriptionField = value;
                this.RaisePropertyChanged("subscription");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class AdhocQueryType : RegistryObjectType
    {
        private QueryExpressionType queryExpressionField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public QueryExpressionType QueryExpression
        {
            get { return this.queryExpressionField; }
            set
            {
                this.queryExpressionField = value;
                this.RaisePropertyChanged("QueryExpression");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class SubscriptionType : RegistryObjectType
    {
        private ActionType[] itemsField;

        private string selectorField;

        private DateTime startTimeField;

        private bool startTimeFieldSpecified;

        private DateTime endTimeField;

        private bool endTimeFieldSpecified;

        private string notificationIntervalField;

        public SubscriptionType()
        {
            this.notificationIntervalField = "P1D";
        }

        /// <remarks/>
        [XmlElementAttribute("Action", typeof(ActionType), Order = 0)]
        [XmlElementAttribute("NotifyAction", typeof(NotifyActionType), Order = 0)]
        public ActionType[] Items
        {
            get { return this.itemsField; }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string selector
        {
            get { return this.selectorField; }
            set
            {
                this.selectorField = value;
                this.RaisePropertyChanged("selector");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime startTime
        {
            get { return this.startTimeField; }
            set
            {
                this.startTimeField = value;
                this.RaisePropertyChanged("startTime");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool startTimeSpecified
        {
            get { return this.startTimeFieldSpecified; }
            set
            {
                this.startTimeFieldSpecified = value;
                this.RaisePropertyChanged("startTimeSpecified");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime endTime
        {
            get { return this.endTimeField; }
            set
            {
                this.endTimeField = value;
                this.RaisePropertyChanged("endTime");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool endTimeSpecified
        {
            get { return this.endTimeFieldSpecified; }
            set
            {
                this.endTimeFieldSpecified = value;
                this.RaisePropertyChanged("endTimeSpecified");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string notificationInterval
        {
            get { return this.notificationIntervalField; }
            set
            {
                this.notificationIntervalField = value;
                this.RaisePropertyChanged("notificationInterval");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class FederationType : RegistryObjectType
    {
        private string replicationSyncLatencyField;

        public FederationType()
        {
            this.replicationSyncLatencyField = "P1D";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string replicationSyncLatency
        {
            get { return this.replicationSyncLatencyField; }
            set
            {
                this.replicationSyncLatencyField = value;
                this.RaisePropertyChanged("replicationSyncLatency");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class RegistryType : RegistryObjectType
    {
        private string operatorField;

        private string specificationVersionField;

        private string replicationSyncLatencyField;

        private string catalogingLatencyField;

        private RegistryTypeConformanceProfile conformanceProfileField;

        public RegistryType()
        {
            this.replicationSyncLatencyField = "P1D";
            this.catalogingLatencyField = "P1D";
            this.conformanceProfileField = RegistryTypeConformanceProfile.registryLite;
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string @operator
        {
            get { return this.operatorField; }
            set
            {
                this.operatorField = value;
                this.RaisePropertyChanged("operator");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string specificationVersion
        {
            get { return this.specificationVersionField; }
            set
            {
                this.specificationVersionField = value;
                this.RaisePropertyChanged("specificationVersion");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string replicationSyncLatency
        {
            get { return this.replicationSyncLatencyField; }
            set
            {
                this.replicationSyncLatencyField = value;
                this.RaisePropertyChanged("replicationSyncLatency");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string catalogingLatency
        {
            get { return this.catalogingLatencyField; }
            set
            {
                this.catalogingLatencyField = value;
                this.RaisePropertyChanged("catalogingLatency");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(RegistryTypeConformanceProfile.registryLite)]
        public RegistryTypeConformanceProfile conformanceProfile
        {
            get { return this.conformanceProfileField; }
            set
            {
                this.conformanceProfileField = value;
                this.RaisePropertyChanged("conformanceProfile");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public enum RegistryTypeConformanceProfile
    {
        /// <remarks/>
        registryFull,

        /// <remarks/>
        registryLite,
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(UserType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class PersonType : RegistryObjectType
    {
        private PostalAddressType[] addressField;

        private PersonNameType personNameField;

        private TelephoneNumberType[] telephoneNumberField;

        private EmailAddressType[] emailAddressField;

        /// <remarks/>
        [XmlElementAttribute("Address", Order = 0)]
        public PostalAddressType[] Address
        {
            get { return this.addressField; }
            set
            {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public PersonNameType PersonName
        {
            get { return this.personNameField; }
            set
            {
                this.personNameField = value;
                this.RaisePropertyChanged("PersonName");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("TelephoneNumber", Order = 2)]
        public TelephoneNumberType[] TelephoneNumber
        {
            get { return this.telephoneNumberField; }
            set
            {
                this.telephoneNumberField = value;
                this.RaisePropertyChanged("TelephoneNumber");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("EmailAddress", Order = 3)]
        public EmailAddressType[] EmailAddress
        {
            get { return this.emailAddressField; }
            set
            {
                this.emailAddressField = value;
                this.RaisePropertyChanged("EmailAddress");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class UserType : PersonType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class SpecificationLinkType : RegistryObjectType
    {
        private InternationalStringType usageDescriptionField;

        private string[] usageParameterField;

        private string serviceBindingField;

        private string specificationObjectField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public InternationalStringType UsageDescription
        {
            get { return this.usageDescriptionField; }
            set
            {
                this.usageDescriptionField = value;
                this.RaisePropertyChanged("UsageDescription");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("UsageParameter", Order = 1)]
        public string[] UsageParameter
        {
            get { return this.usageParameterField; }
            set
            {
                this.usageParameterField = value;
                this.RaisePropertyChanged("UsageParameter");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string serviceBinding
        {
            get { return this.serviceBindingField; }
            set
            {
                this.serviceBindingField = value;
                this.RaisePropertyChanged("serviceBinding");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string specificationObject
        {
            get { return this.specificationObjectField; }
            set
            {
                this.specificationObjectField = value;
                this.RaisePropertyChanged("specificationObject");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ServiceBindingType : RegistryObjectType
    {
        private SpecificationLinkType[] specificationLinkField;

        private string serviceField;

        private string accessURIField;

        private string targetBindingField;

        /// <remarks/>
        [XmlElementAttribute("SpecificationLink", Order = 0)]
        public SpecificationLinkType[] SpecificationLink
        {
            get { return this.specificationLinkField; }
            set
            {
                this.specificationLinkField = value;
                this.RaisePropertyChanged("SpecificationLink");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string service
        {
            get { return this.serviceField; }
            set
            {
                this.serviceField = value;
                this.RaisePropertyChanged("service");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string accessURI
        {
            get { return this.accessURIField; }
            set
            {
                this.accessURIField = value;
                this.RaisePropertyChanged("accessURI");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string targetBinding
        {
            get { return this.targetBindingField; }
            set
            {
                this.targetBindingField = value;
                this.RaisePropertyChanged("targetBinding");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ServiceType : RegistryObjectType
    {
        private ServiceBindingType[] serviceBindingField;

        /// <remarks/>
        [XmlElementAttribute("ServiceBinding", Order = 0)]
        public ServiceBindingType[] ServiceBinding
        {
            get { return this.serviceBindingField; }
            set
            {
                this.serviceBindingField = value;
                this.RaisePropertyChanged("ServiceBinding");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class RegistryPackageType : RegistryObjectType
    {
        private IdentifiableType[] registryObjectListField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Identifiable", IsNullable = false)]
        public IdentifiableType[] RegistryObjectList
        {
            get { return this.registryObjectListField; }
            set
            {
                this.registryObjectListField = value;
                this.RaisePropertyChanged("RegistryObjectList");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class OrganizationType : RegistryObjectType
    {
        private PostalAddressType[] addressField;

        private TelephoneNumberType[] telephoneNumberField;

        private EmailAddressType[] emailAddressField;

        private string parentField;

        private string primaryContactField;

        /// <remarks/>
        [XmlElementAttribute("Address", Order = 0)]
        public PostalAddressType[] Address
        {
            get { return this.addressField; }
            set
            {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("TelephoneNumber", Order = 1)]
        public TelephoneNumberType[] TelephoneNumber
        {
            get { return this.telephoneNumberField; }
            set
            {
                this.telephoneNumberField = value;
                this.RaisePropertyChanged("TelephoneNumber");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("EmailAddress", Order = 2)]
        public EmailAddressType[] EmailAddress
        {
            get { return this.emailAddressField; }
            set
            {
                this.emailAddressField = value;
                this.RaisePropertyChanged("EmailAddress");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string parent
        {
            get { return this.parentField; }
            set
            {
                this.parentField = value;
                this.RaisePropertyChanged("parent");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string primaryContact
        {
            get { return this.primaryContactField; }
            set
            {
                this.primaryContactField = value;
                this.RaisePropertyChanged("primaryContact");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ExtrinsicObjectType : RegistryObjectType
    {
        private VersionInfoType contentVersionInfoField;

        private string mimeTypeField;

        private bool isOpaqueField;

        public ExtrinsicObjectType()
        {
            this.mimeTypeField = "application/octet-stream";
            this.isOpaqueField = false;
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public VersionInfoType ContentVersionInfo
        {
            get { return this.contentVersionInfoField; }
            set
            {
                this.contentVersionInfoField = value;
                this.RaisePropertyChanged("ContentVersionInfo");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute("application/octet-stream")]
        public string mimeType
        {
            get { return this.mimeTypeField; }
            set
            {
                this.mimeTypeField = value;
                this.RaisePropertyChanged("mimeType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(false)]
        public bool isOpaque
        {
            get { return this.isOpaqueField; }
            set
            {
                this.isOpaqueField = value;
                this.RaisePropertyChanged("isOpaque");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ExternalLinkType : RegistryObjectType
    {
        private string externalURIField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string externalURI
        {
            get { return this.externalURIField; }
            set
            {
                this.externalURIField = value;
                this.RaisePropertyChanged("externalURI");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ClassificationSchemeType : RegistryObjectType
    {
        private ClassificationNodeType[] classificationNodeField;

        private bool isInternalField;

        private string nodeTypeField;

        /// <remarks/>
        [XmlElementAttribute("ClassificationNode", Order = 0)]
        public ClassificationNodeType[] ClassificationNode
        {
            get { return this.classificationNodeField; }
            set
            {
                this.classificationNodeField = value;
                this.RaisePropertyChanged("ClassificationNode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool isInternal
        {
            get { return this.isInternalField; }
            set
            {
                this.isInternalField = value;
                this.RaisePropertyChanged("isInternal");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string nodeType
        {
            get { return this.nodeTypeField; }
            set
            {
                this.nodeTypeField = value;
                this.RaisePropertyChanged("nodeType");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class ClassificationNodeType : RegistryObjectType
    {
        private ClassificationNodeType[] classificationNodeField;

        private string parentField;

        private string codeField;

        private string pathField;

        /// <remarks/>
        [XmlElementAttribute("ClassificationNode", Order = 0)]
        public ClassificationNodeType[] ClassificationNode
        {
            get { return this.classificationNodeField; }
            set
            {
                this.classificationNodeField = value;
                this.RaisePropertyChanged("ClassificationNode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string parent
        {
            get { return this.parentField; }
            set
            {
                this.parentField = value;
                this.RaisePropertyChanged("parent");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string code
        {
            get { return this.codeField; }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string path
        {
            get { return this.pathField; }
            set
            {
                this.pathField = value;
                this.RaisePropertyChanged("path");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class AuditableEventType : RegistryObjectType
    {
        private ObjectRefListType affectedObjectsField;

        private string eventTypeField;

        private DateTime timestampField;

        private string userField;

        private string requestIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ObjectRefListType affectedObjects
        {
            get { return this.affectedObjectsField; }
            set
            {
                this.affectedObjectsField = value;
                this.RaisePropertyChanged("affectedObjects");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string eventType
        {
            get { return this.eventTypeField; }
            set
            {
                this.eventTypeField = value;
                this.RaisePropertyChanged("eventType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime timestamp
        {
            get { return this.timestampField; }
            set
            {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string user
        {
            get { return this.userField; }
            set
            {
                this.userField = value;
                this.RaisePropertyChanged("user");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string requestId
        {
            get { return this.requestIdField; }
            set
            {
                this.requestIdField = value;
                this.RaisePropertyChanged("requestId");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rim:3.0")]
    public partial class AssociationType1 : RegistryObjectType
    {
        private string associationTypeField;

        private string sourceObjectField;

        private string targetObjectField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string associationType
        {
            get { return this.associationTypeField; }
            set
            {
                this.associationTypeField = value;
                this.RaisePropertyChanged("associationType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string sourceObject
        {
            get { return this.sourceObjectField; }
            set
            {
                this.sourceObjectField = value;
                this.RaisePropertyChanged("sourceObject");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string targetObject
        {
            get { return this.targetObjectField; }
            set
            {
                this.targetObjectField = value;
                this.RaisePropertyChanged("targetObject");
            }
        }
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class DocumentRegistry_UpdateDocumentSetRequest
    {
        [MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0", Order = 0)]
        public SubmitObjectsRequest SubmitObjectsRequest;

        public DocumentRegistry_UpdateDocumentSetRequest()
        {
        }

        public DocumentRegistry_UpdateDocumentSetRequest(SubmitObjectsRequest SubmitObjectsRequest)
        {
            this.SubmitObjectsRequest = SubmitObjectsRequest;
        }
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class DocumentRegistry_UpdateDocumentSetResponse
    {
        [MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0", Order = 0)]
        public RegistryResponseType RegistryResponse;

        public DocumentRegistry_UpdateDocumentSetResponse()
        {
        }

        public DocumentRegistry_UpdateDocumentSetResponse(RegistryResponseType RegistryResponse)
        {
            this.RegistryResponse = RegistryResponse;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DocumentRegistryUpdate_PortTypeChannel : DocumentRegistryUpdate_PortType, IClientChannel
    {
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentRegistryUpdate_PortTypeClient : ClientBase<DocumentRegistryUpdate_PortType>,
        DocumentRegistryUpdate_PortType
    {
        public DocumentRegistryUpdate_PortTypeClient()
        {
        }

        public DocumentRegistryUpdate_PortTypeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public DocumentRegistryUpdate_PortTypeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public DocumentRegistryUpdate_PortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public DocumentRegistryUpdate_PortTypeClient(System.ServiceModel.Channels.Binding binding,
            EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        DocumentRegistry_UpdateDocumentSetResponse DocumentRegistryUpdate_PortType.DocumentRegistry_UpdateDocumentSet(
            DocumentRegistry_UpdateDocumentSetRequest request)
        {
            return Channel.DocumentRegistry_UpdateDocumentSet(request);
        }

        public RegistryResponseType DocumentRegistry_UpdateDocumentSet(SubmitObjectsRequest SubmitObjectsRequest)
        {
            DocumentRegistry_UpdateDocumentSetRequest inValue = new DocumentRegistry_UpdateDocumentSetRequest();
            inValue.SubmitObjectsRequest = SubmitObjectsRequest;
            DocumentRegistry_UpdateDocumentSetResponse retVal =
                ((DocumentRegistryUpdate_PortType)(this)).DocumentRegistry_UpdateDocumentSet(inValue);
            return retVal.RegistryResponse;
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        Task<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistryUpdate_PortType.
            DocumentRegistry_UpdateDocumentSetAsync(DocumentRegistry_UpdateDocumentSetRequest request)
        {
            return Channel.DocumentRegistry_UpdateDocumentSetAsync(request);
        }

        public Task<DocumentRegistry_UpdateDocumentSetResponse> DocumentRegistry_UpdateDocumentSetAsync(
            SubmitObjectsRequest SubmitObjectsRequest)
        {
            DocumentRegistry_UpdateDocumentSetRequest inValue = new DocumentRegistry_UpdateDocumentSetRequest();
            inValue.SubmitObjectsRequest = SubmitObjectsRequest;
            return ((DocumentRegistryUpdate_PortType)(this)).DocumentRegistry_UpdateDocumentSetAsync(inValue);
        }
    }
}