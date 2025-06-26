using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CezihECDSa.Wsdl.PrijavaZarazne
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "urn:ihe:iti:xds-b:2007",
        ConfigurationName = "XDSbRepository.DocumentRepository_PortType")]
    public interface DocumentRepository_PortType
    {
        // CODEGEN: Generating message contract since the operation DocumentRepository_RetrieveDocumentSet is neither RPC nor document wrapped.
        [OperationContractAttribute(Action = "urn:ihe:iti:2007:RetrieveDocumentSet",
            ReplyAction = "urn:ihe:iti:2007:RetrieveDocumentSetResponse")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(RegistryRequestType))]
        DocumentRepository_RetrieveDocumentSetResponse DocumentRepository_RetrieveDocumentSet(
            DocumentRepository_RetrieveDocumentSetRequest request);

        [OperationContractAttribute(Action = "urn:ihe:iti:2007:RetrieveDocumentSet",
            ReplyAction = "urn:ihe:iti:2007:RetrieveDocumentSetResponse")]
        Task<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSetAsync(
            DocumentRepository_RetrieveDocumentSetRequest request);

        // CODEGEN: Generating message contract since the operation DocumentRepository_ProvideAndRegisterDocumentSet-b is neither RPC nor document wrapped.
        [OperationContractAttribute(Action = "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b",
            ReplyAction = "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-bResponse")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        [ServiceKnownTypeAttribute(typeof(RegistryRequestType))]
        DocumentRepository_ProvideAndRegisterDocumentSetbResponse DocumentRepository_ProvideAndRegisterDocumentSetb(
            DocumentRepository_ProvideAndRegisterDocumentSetbRequest request);

        [OperationContractAttribute(Action = "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-b",
            ReplyAction = "urn:ihe:iti:2007:ProvideAndRegisterDocumentSet-bResponse")]
        Task<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>
            DocumentRepository_ProvideAndRegisterDocumentSetbAsync(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ihe:iti:xds-b:2007")]
    [XmlRoot(ElementName = "DocumentRequest", Namespace = "urn:ihe:iti:xds-b:2007")]
    public partial class RetrieveDocumentSetRequestTypeDocumentRequest : object, INotifyPropertyChanged
    {
        private string homeCommunityIdField;

        private string repositoryUniqueIdField;

        private string documentUniqueIdField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string HomeCommunityId
        {
            get { return homeCommunityIdField; }
            set
            {
                homeCommunityIdField = value;
                RaisePropertyChanged("HomeCommunityId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string RepositoryUniqueId
        {
            get { return repositoryUniqueIdField; }
            set
            {
                repositoryUniqueIdField = value;
                RaisePropertyChanged("RepositoryUniqueId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string DocumentUniqueId
        {
            get { return documentUniqueIdField; }
            set
            {
                documentUniqueIdField = value;
                RaisePropertyChanged("DocumentUniqueId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return anyField; }
            set
            {
                anyField = value;
                RaisePropertyChanged("Any");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string queryLanguage
        {
            get { return queryLanguageField; }
            set
            {
                queryLanguageField = value;
                RaisePropertyChanged("queryLanguage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            notificationOptionField = "urn:oasis:names:tc:ebxml-regrep:NotificationOptionType:ObjectRefs";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        [DefaultValueAttribute("urn:oasis:names:tc:ebxml-regrep:NotificationOptionType:ObjectRefs")]
        public string notificationOption
        {
            get { return notificationOptionField; }
            set
            {
                notificationOptionField = value;
                RaisePropertyChanged("notificationOption");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string endPoint
        {
            get { return endPointField; }
            set
            {
                endPointField = value;
                RaisePropertyChanged("endPoint");
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
            get { return firstNameField; }
            set
            {
                firstNameField = value;
                RaisePropertyChanged("firstName");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string middleName
        {
            get { return middleNameField; }
            set
            {
                middleNameField = value;
                RaisePropertyChanged("middleName");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string lastName
        {
            get { return lastNameField; }
            set
            {
                lastNameField = value;
                RaisePropertyChanged("lastName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return addressField; }
            set
            {
                addressField = value;
                RaisePropertyChanged("address");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string type
        {
            get { return typeField; }
            set
            {
                typeField = value;
                RaisePropertyChanged("type");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return areaCodeField; }
            set
            {
                areaCodeField = value;
                RaisePropertyChanged("areaCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string countryCode
        {
            get { return countryCodeField; }
            set
            {
                countryCodeField = value;
                RaisePropertyChanged("countryCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string extension
        {
            get { return extensionField; }
            set
            {
                extensionField = value;
                RaisePropertyChanged("extension");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string number
        {
            get { return numberField; }
            set
            {
                numberField = value;
                RaisePropertyChanged("number");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string phoneType
        {
            get { return phoneTypeField; }
            set
            {
                phoneTypeField = value;
                RaisePropertyChanged("phoneType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return cityField; }
            set
            {
                cityField = value;
                RaisePropertyChanged("city");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string country
        {
            get { return countryField; }
            set
            {
                countryField = value;
                RaisePropertyChanged("country");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string postalCode
        {
            get { return postalCodeField; }
            set
            {
                postalCodeField = value;
                RaisePropertyChanged("postalCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string stateOrProvince
        {
            get { return stateOrProvinceField; }
            set
            {
                stateOrProvinceField = value;
                RaisePropertyChanged("stateOrProvince");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string street
        {
            get { return streetField; }
            set
            {
                streetField = value;
                RaisePropertyChanged("street");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string streetNumber
        {
            get { return streetNumberField; }
            set
            {
                streetNumberField = value;
                RaisePropertyChanged("streetNumber");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return objectRefField; }
            set
            {
                objectRefField = value;
                RaisePropertyChanged("ObjectRef");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            createReplicaField = false;
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(false)]
        public bool createReplica
        {
            get { return createReplicaField; }
            set
            {
                createReplicaField = value;
                RaisePropertyChanged("createReplica");
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
            get { return slotField; }
            set
            {
                slotField = value;
                RaisePropertyChanged("Slot");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get { return idField; }
            set
            {
                idField = value;
                RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string home
        {
            get { return homeField; }
            set
            {
                homeField = value;
                RaisePropertyChanged("home");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return valueListField; }
            set
            {
                valueListField = value;
                RaisePropertyChanged("ValueList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string name
        {
            get { return nameField; }
            set
            {
                nameField = value;
                RaisePropertyChanged("name");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string slotType
        {
            get { return slotTypeField; }
            set
            {
                slotTypeField = value;
                RaisePropertyChanged("slotType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return valueField; }
            set
            {
                valueField = value;
                RaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return nameField; }
            set
            {
                nameField = value;
                RaisePropertyChanged("Name");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public InternationalStringType Description
        {
            get { return descriptionField; }
            set
            {
                descriptionField = value;
                RaisePropertyChanged("Description");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public VersionInfoType VersionInfo
        {
            get { return versionInfoField; }
            set
            {
                versionInfoField = value;
                RaisePropertyChanged("VersionInfo");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Classification", Order = 3)]
        public ClassificationType[] Classification
        {
            get { return classificationField; }
            set
            {
                classificationField = value;
                RaisePropertyChanged("Classification");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ExternalIdentifier", Order = 4)]
        public ExternalIdentifierType[] ExternalIdentifier
        {
            get { return externalIdentifierField; }
            set
            {
                externalIdentifierField = value;
                RaisePropertyChanged("ExternalIdentifier");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string lid
        {
            get { return lidField; }
            set
            {
                lidField = value;
                RaisePropertyChanged("lid");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string objectType
        {
            get { return objectTypeField; }
            set
            {
                objectTypeField = value;
                RaisePropertyChanged("objectType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string status
        {
            get { return statusField; }
            set
            {
                statusField = value;
                RaisePropertyChanged("status");
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
            get { return localizedStringField; }
            set
            {
                localizedStringField = value;
                RaisePropertyChanged("LocalizedString");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            charsetField = "UTF-8";
        }

        /// <remarks/>
        [XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
            Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get { return langField; }
            set
            {
                langField = value;
                RaisePropertyChanged("lang");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute("UTF-8")]
        public string charset
        {
            get { return charsetField; }
            set
            {
                charsetField = value;
                RaisePropertyChanged("charset");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value
        {
            get { return valueField; }
            set
            {
                valueField = value;
                RaisePropertyChanged("value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
    public partial class VersionInfoType : object, INotifyPropertyChanged
    {
        private string versionNameField;

        private string commentField;

        public VersionInfoType()
        {
            versionNameField = "1.1";
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute("1.1")]
        public string versionName
        {
            get { return versionNameField; }
            set
            {
                versionNameField = value;
                RaisePropertyChanged("versionName");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string comment
        {
            get { return commentField; }
            set
            {
                commentField = value;
                RaisePropertyChanged("comment");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return classificationSchemeField; }
            set
            {
                classificationSchemeField = value;
                RaisePropertyChanged("classificationScheme");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string classifiedObject
        {
            get { return classifiedObjectField; }
            set
            {
                classifiedObjectField = value;
                RaisePropertyChanged("classifiedObject");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string classificationNode
        {
            get { return classificationNodeField; }
            set
            {
                classificationNodeField = value;
                RaisePropertyChanged("classificationNode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string nodeRepresentation
        {
            get { return nodeRepresentationField; }
            set
            {
                nodeRepresentationField = value;
                RaisePropertyChanged("nodeRepresentation");
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
            get { return registryObjectField; }
            set
            {
                registryObjectField = value;
                RaisePropertyChanged("registryObject");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string identificationScheme
        {
            get { return identificationSchemeField; }
            set
            {
                identificationSchemeField = value;
                RaisePropertyChanged("identificationScheme");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string value
        {
            get { return valueField; }
            set
            {
                valueField = value;
                RaisePropertyChanged("value");
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
            get { return registryObjectListField; }
            set
            {
                registryObjectListField = value;
                RaisePropertyChanged("RegistryObjectList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string subscription
        {
            get { return subscriptionField; }
            set
            {
                subscriptionField = value;
                RaisePropertyChanged("subscription");
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
            get { return queryExpressionField; }
            set
            {
                queryExpressionField = value;
                RaisePropertyChanged("QueryExpression");
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
            notificationIntervalField = "P1D";
        }

        /// <remarks/>
        [XmlElementAttribute("Action", typeof(ActionType), Order = 0)]
        [XmlElementAttribute("NotifyAction", typeof(NotifyActionType), Order = 0)]
        public ActionType[] Items
        {
            get { return itemsField; }
            set
            {
                itemsField = value;
                RaisePropertyChanged("Items");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string selector
        {
            get { return selectorField; }
            set
            {
                selectorField = value;
                RaisePropertyChanged("selector");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime startTime
        {
            get { return startTimeField; }
            set
            {
                startTimeField = value;
                RaisePropertyChanged("startTime");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool startTimeSpecified
        {
            get { return startTimeFieldSpecified; }
            set
            {
                startTimeFieldSpecified = value;
                RaisePropertyChanged("startTimeSpecified");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime endTime
        {
            get { return endTimeField; }
            set
            {
                endTimeField = value;
                RaisePropertyChanged("endTime");
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool endTimeSpecified
        {
            get { return endTimeFieldSpecified; }
            set
            {
                endTimeFieldSpecified = value;
                RaisePropertyChanged("endTimeSpecified");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string notificationInterval
        {
            get { return notificationIntervalField; }
            set
            {
                notificationIntervalField = value;
                RaisePropertyChanged("notificationInterval");
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
            replicationSyncLatencyField = "P1D";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string replicationSyncLatency
        {
            get { return replicationSyncLatencyField; }
            set
            {
                replicationSyncLatencyField = value;
                RaisePropertyChanged("replicationSyncLatency");
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
            replicationSyncLatencyField = "P1D";
            catalogingLatencyField = "P1D";
            conformanceProfileField = RegistryTypeConformanceProfile.registryLite;
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string @operator
        {
            get { return operatorField; }
            set
            {
                operatorField = value;
                RaisePropertyChanged("operator");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string specificationVersion
        {
            get { return specificationVersionField; }
            set
            {
                specificationVersionField = value;
                RaisePropertyChanged("specificationVersion");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string replicationSyncLatency
        {
            get { return replicationSyncLatencyField; }
            set
            {
                replicationSyncLatencyField = value;
                RaisePropertyChanged("replicationSyncLatency");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "duration")]
        [DefaultValueAttribute("P1D")]
        public string catalogingLatency
        {
            get { return catalogingLatencyField; }
            set
            {
                catalogingLatencyField = value;
                RaisePropertyChanged("catalogingLatency");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(RegistryTypeConformanceProfile.registryLite)]
        public RegistryTypeConformanceProfile conformanceProfile
        {
            get { return conformanceProfileField; }
            set
            {
                conformanceProfileField = value;
                RaisePropertyChanged("conformanceProfile");
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
            get { return addressField; }
            set
            {
                addressField = value;
                RaisePropertyChanged("Address");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public PersonNameType PersonName
        {
            get { return personNameField; }
            set
            {
                personNameField = value;
                RaisePropertyChanged("PersonName");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("TelephoneNumber", Order = 2)]
        public TelephoneNumberType[] TelephoneNumber
        {
            get { return telephoneNumberField; }
            set
            {
                telephoneNumberField = value;
                RaisePropertyChanged("TelephoneNumber");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("EmailAddress", Order = 3)]
        public EmailAddressType[] EmailAddress
        {
            get { return emailAddressField; }
            set
            {
                emailAddressField = value;
                RaisePropertyChanged("EmailAddress");
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
            get { return usageDescriptionField; }
            set
            {
                usageDescriptionField = value;
                RaisePropertyChanged("UsageDescription");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("UsageParameter", Order = 1)]
        public string[] UsageParameter
        {
            get { return usageParameterField; }
            set
            {
                usageParameterField = value;
                RaisePropertyChanged("UsageParameter");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string serviceBinding
        {
            get { return serviceBindingField; }
            set
            {
                serviceBindingField = value;
                RaisePropertyChanged("serviceBinding");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string specificationObject
        {
            get { return specificationObjectField; }
            set
            {
                specificationObjectField = value;
                RaisePropertyChanged("specificationObject");
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
            get { return specificationLinkField; }
            set
            {
                specificationLinkField = value;
                RaisePropertyChanged("SpecificationLink");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string service
        {
            get { return serviceField; }
            set
            {
                serviceField = value;
                RaisePropertyChanged("service");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string accessURI
        {
            get { return accessURIField; }
            set
            {
                accessURIField = value;
                RaisePropertyChanged("accessURI");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string targetBinding
        {
            get { return targetBindingField; }
            set
            {
                targetBindingField = value;
                RaisePropertyChanged("targetBinding");
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
            get { return serviceBindingField; }
            set
            {
                serviceBindingField = value;
                RaisePropertyChanged("ServiceBinding");
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
            get { return registryObjectListField; }
            set
            {
                registryObjectListField = value;
                RaisePropertyChanged("RegistryObjectList");
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
            get { return addressField; }
            set
            {
                addressField = value;
                RaisePropertyChanged("Address");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("TelephoneNumber", Order = 1)]
        public TelephoneNumberType[] TelephoneNumber
        {
            get { return telephoneNumberField; }
            set
            {
                telephoneNumberField = value;
                RaisePropertyChanged("TelephoneNumber");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("EmailAddress", Order = 2)]
        public EmailAddressType[] EmailAddress
        {
            get { return emailAddressField; }
            set
            {
                emailAddressField = value;
                RaisePropertyChanged("EmailAddress");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string parent
        {
            get { return parentField; }
            set
            {
                parentField = value;
                RaisePropertyChanged("parent");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string primaryContact
        {
            get { return primaryContactField; }
            set
            {
                primaryContactField = value;
                RaisePropertyChanged("primaryContact");
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
            mimeTypeField = "application/octet-stream";
            isOpaqueField = false;
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public VersionInfoType ContentVersionInfo
        {
            get { return contentVersionInfoField; }
            set
            {
                contentVersionInfoField = value;
                RaisePropertyChanged("ContentVersionInfo");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute("application/octet-stream")]
        public string mimeType
        {
            get { return mimeTypeField; }
            set
            {
                mimeTypeField = value;
                RaisePropertyChanged("mimeType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        [DefaultValueAttribute(false)]
        public bool isOpaque
        {
            get { return isOpaqueField; }
            set
            {
                isOpaqueField = value;
                RaisePropertyChanged("isOpaque");
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
            get { return externalURIField; }
            set
            {
                externalURIField = value;
                RaisePropertyChanged("externalURI");
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
            get { return classificationNodeField; }
            set
            {
                classificationNodeField = value;
                RaisePropertyChanged("ClassificationNode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public bool isInternal
        {
            get { return isInternalField; }
            set
            {
                isInternalField = value;
                RaisePropertyChanged("isInternal");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string nodeType
        {
            get { return nodeTypeField; }
            set
            {
                nodeTypeField = value;
                RaisePropertyChanged("nodeType");
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
            get { return classificationNodeField; }
            set
            {
                classificationNodeField = value;
                RaisePropertyChanged("ClassificationNode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string parent
        {
            get { return parentField; }
            set
            {
                parentField = value;
                RaisePropertyChanged("parent");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string code
        {
            get { return codeField; }
            set
            {
                codeField = value;
                RaisePropertyChanged("code");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string path
        {
            get { return pathField; }
            set
            {
                pathField = value;
                RaisePropertyChanged("path");
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
            get { return affectedObjectsField; }
            set
            {
                affectedObjectsField = value;
                RaisePropertyChanged("affectedObjects");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string eventType
        {
            get { return eventTypeField; }
            set
            {
                eventTypeField = value;
                RaisePropertyChanged("eventType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public DateTime timestamp
        {
            get { return timestampField; }
            set
            {
                timestampField = value;
                RaisePropertyChanged("timestamp");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string user
        {
            get { return userField; }
            set
            {
                userField = value;
                RaisePropertyChanged("user");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string requestId
        {
            get { return requestIdField; }
            set
            {
                requestIdField = value;
                RaisePropertyChanged("requestId");
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
            get { return associationTypeField; }
            set
            {
                associationTypeField = value;
                RaisePropertyChanged("associationType");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string sourceObject
        {
            get { return sourceObjectField; }
            set
            {
                sourceObjectField = value;
                RaisePropertyChanged("sourceObject");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string targetObject
        {
            get { return targetObjectField; }
            set
            {
                targetObjectField = value;
                RaisePropertyChanged("targetObject");
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
            get { return requestSlotListField; }
            set
            {
                requestSlotListField = value;
                RaisePropertyChanged("RequestSlotList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get { return idField; }
            set
            {
                idField = value;
                RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string comment
        {
            get { return commentField; }
            set
            {
                commentField = value;
                RaisePropertyChanged("comment");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
    [XmlTypeAttribute(Namespace = "urn:ihe:iti:xds-b:2007")]
    [XmlRoot(ElementName = "ProvideAndRegisterDocumentSetRequest", Namespace = "urn:ihe:iti:xds-b:2007")]
    public partial class ProvideAndRegisterDocumentSetRequestType : object, INotifyPropertyChanged
    {
        private SubmitObjectsRequest submitObjectsRequestField;

        private ProvideAndRegisterDocumentSetRequestTypeDocument[] documentField;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0", Order = 0)]
        public SubmitObjectsRequest SubmitObjectsRequest
        {
            get { return submitObjectsRequestField; }
            set
            {
                submitObjectsRequestField = value;
                RaisePropertyChanged("SubmitObjectsRequest");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Document", Order = 1)]
        public ProvideAndRegisterDocumentSetRequestTypeDocument[] Document
        {
            get { return documentField; }
            set
            {
                documentField = value;
                RaisePropertyChanged("Document");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:lcm:3.0")]
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
            get { return registryObjectListField; }
            set
            {
                registryObjectListField = value;
                RaisePropertyChanged("RegistryObjectList");
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ihe:iti:xds-b:2007")]
    public partial class ProvideAndRegisterDocumentSetRequestTypeDocument : object, INotifyPropertyChanged
    {
        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string id
        {
            get { return idField; }
            set
            {
                idField = value;
                RaisePropertyChanged("id");
            }
        }

        /// <remarks/>
        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get { return valueField; }
            set
            {
                valueField = value;
                RaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return responseSlotListField; }
            set
            {
                responseSlotListField = value;
                RaisePropertyChanged("ResponseSlotList");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public RegistryErrorList RegistryErrorList
        {
            get { return registryErrorListField; }
            set
            {
                registryErrorListField = value;
                RaisePropertyChanged("RegistryErrorList");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string status
        {
            get { return statusField; }
            set
            {
                statusField = value;
                RaisePropertyChanged("status");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string requestId
        {
            get { return requestIdField; }
            set
            {
                requestIdField = value;
                RaisePropertyChanged("requestId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            get { return registryErrorField; }
            set
            {
                registryErrorField = value;
                RaisePropertyChanged("RegistryError");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string highestSeverity
        {
            get { return highestSeverityField; }
            set
            {
                highestSeverityField = value;
                RaisePropertyChanged("highestSeverity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
            severityField = "urn:oasis:names:tc:ebxml-regrep:ErrorSeverityType:Error";
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string codeContext
        {
            get { return codeContextField; }
            set
            {
                codeContextField = value;
                RaisePropertyChanged("codeContext");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string errorCode
        {
            get { return errorCodeField; }
            set
            {
                errorCodeField = value;
                RaisePropertyChanged("errorCode");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        [DefaultValueAttribute("urn:oasis:names:tc:ebxml-regrep:ErrorSeverityType:Error")]
        public string severity
        {
            get { return severityField; }
            set
            {
                severityField = value;
                RaisePropertyChanged("severity");
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string location
        {
            get { return locationField; }
            set
            {
                locationField = value;
                RaisePropertyChanged("location");
            }
        }

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value
        {
            get { return valueField; }
            set
            {
                valueField = value;
                RaisePropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
    [XmlTypeAttribute(Namespace = "urn:ihe:iti:xds-b:2007")]
    public partial class RetrieveDocumentSetResponseType : object, INotifyPropertyChanged
    {
        private RegistryResponseType registryResponseField;

        private RetrieveDocumentSetResponseTypeDocumentResponse[] documentResponseField;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0", Order = 0)]
        public RegistryResponseType RegistryResponse
        {
            get { return registryResponseField; }
            set
            {
                registryResponseField = value;
                RaisePropertyChanged("RegistryResponse");
            }
        }

        /// <remarks/>
        [XmlElementAttribute("DocumentResponse", Order = 1)]
        public RetrieveDocumentSetResponseTypeDocumentResponse[] DocumentResponse
        {
            get { return documentResponseField; }
            set
            {
                documentResponseField = value;
                RaisePropertyChanged("DocumentResponse");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:ihe:iti:xds-b:2007")]
    public partial class RetrieveDocumentSetResponseTypeDocumentResponse : object, INotifyPropertyChanged
    {
        private string homeCommunityIdField;

        private string repositoryUniqueIdField;

        private string documentUniqueIdField;

        private string newRepositoryUniqueIdField;

        private string newDocumentUniqueIdField;

        private string mimeTypeField;

        private byte[] documentField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string HomeCommunityId
        {
            get { return homeCommunityIdField; }
            set
            {
                homeCommunityIdField = value;
                RaisePropertyChanged("HomeCommunityId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string RepositoryUniqueId
        {
            get { return repositoryUniqueIdField; }
            set
            {
                repositoryUniqueIdField = value;
                RaisePropertyChanged("RepositoryUniqueId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public string DocumentUniqueId
        {
            get { return documentUniqueIdField; }
            set
            {
                documentUniqueIdField = value;
                RaisePropertyChanged("DocumentUniqueId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public string NewRepositoryUniqueId
        {
            get { return newRepositoryUniqueIdField; }
            set
            {
                newRepositoryUniqueIdField = value;
                RaisePropertyChanged("NewRepositoryUniqueId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public string NewDocumentUniqueId
        {
            get { return newDocumentUniqueIdField; }
            set
            {
                newDocumentUniqueIdField = value;
                RaisePropertyChanged("NewDocumentUniqueId");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 5)]
        public string mimeType
        {
            get { return mimeTypeField; }
            set
            {
                mimeTypeField = value;
                RaisePropertyChanged("mimeType");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary", Order = 6)]
        public byte[] Document
        {
            get { return documentField; }
            set
            {
                documentField = value;
                RaisePropertyChanged("Document");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class DocumentRepository_RetrieveDocumentSetRequest
    {
        [MessageBodyMemberAttribute(Namespace = "urn:ihe:iti:xds-b:2007", Order = 0)]
        [XmlArrayItemAttribute("DocumentRequest", IsNullable = false)]
        public RetrieveDocumentSetRequestTypeDocumentRequest[] RetrieveDocumentSetRequest;

        public DocumentRepository_RetrieveDocumentSetRequest()
        {
        }

        public DocumentRepository_RetrieveDocumentSetRequest(
            RetrieveDocumentSetRequestTypeDocumentRequest[] RetrieveDocumentSetRequest)
        {
            this.RetrieveDocumentSetRequest = RetrieveDocumentSetRequest;
        }
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class DocumentRepository_RetrieveDocumentSetResponse
    {
        [MessageBodyMemberAttribute(Namespace = "urn:ihe:iti:xds-b:2007", Order = 0)]
        public RetrieveDocumentSetResponseType RetrieveDocumentSetResponse;

        public DocumentRepository_RetrieveDocumentSetResponse()
        {
        }

        public DocumentRepository_RetrieveDocumentSetResponse(
            RetrieveDocumentSetResponseType RetrieveDocumentSetResponse)
        {
            this.RetrieveDocumentSetResponse = RetrieveDocumentSetResponse;
        }
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class DocumentRepository_ProvideAndRegisterDocumentSetbRequest
    {
        [MessageBodyMemberAttribute(Namespace = "urn:ihe:iti:xds-b:2007", Order = 0)]
        public ProvideAndRegisterDocumentSetRequestType ProvideAndRegisterDocumentSetRequest;

        public DocumentRepository_ProvideAndRegisterDocumentSetbRequest()
        {
        }

        public DocumentRepository_ProvideAndRegisterDocumentSetbRequest(
            ProvideAndRegisterDocumentSetRequestType ProvideAndRegisterDocumentSetRequest)
        {
            this.ProvideAndRegisterDocumentSetRequest = ProvideAndRegisterDocumentSetRequest;
        }
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class DocumentRepository_ProvideAndRegisterDocumentSetbResponse
    {
        [MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:ebxml-regrep:xsd:rs:3.0", Order = 0)]
        public RegistryResponseType RegistryResponse;

        public DocumentRepository_ProvideAndRegisterDocumentSetbResponse()
        {
        }

        public DocumentRepository_ProvideAndRegisterDocumentSetbResponse(RegistryResponseType RegistryResponse)
        {
            this.RegistryResponse = RegistryResponse;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DocumentRepository_PortTypeChannel : DocumentRepository_PortType, IClientChannel
    {
    }

    [DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DocumentRepository_PortTypeClient : ClientBase<DocumentRepository_PortType>,
        DocumentRepository_PortType
    {
        public DocumentRepository_PortTypeClient()
        {
        }

        public DocumentRepository_PortTypeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public DocumentRepository_PortTypeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public DocumentRepository_PortTypeClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public DocumentRepository_PortTypeClient(System.ServiceModel.Channels.Binding binding,
            EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        DocumentRepository_RetrieveDocumentSetResponse DocumentRepository_PortType.
            DocumentRepository_RetrieveDocumentSet(DocumentRepository_RetrieveDocumentSetRequest request)
        {
            return Channel.DocumentRepository_RetrieveDocumentSet(request);
        }

        public RetrieveDocumentSetResponseType DocumentRepository_RetrieveDocumentSet(
            RetrieveDocumentSetRequestTypeDocumentRequest[] RetrieveDocumentSetRequest)
        {
            DocumentRepository_RetrieveDocumentSetRequest inValue = new DocumentRepository_RetrieveDocumentSetRequest();
            inValue.RetrieveDocumentSetRequest = RetrieveDocumentSetRequest;
            DocumentRepository_RetrieveDocumentSetResponse retVal =
                ((DocumentRepository_PortType)(this)).DocumentRepository_RetrieveDocumentSet(inValue);
            return retVal.RetrieveDocumentSetResponse;
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        Task<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_PortType.
            DocumentRepository_RetrieveDocumentSetAsync(DocumentRepository_RetrieveDocumentSetRequest request)
        {
            return Channel.DocumentRepository_RetrieveDocumentSetAsync(request);
        }

        public Task<DocumentRepository_RetrieveDocumentSetResponse> DocumentRepository_RetrieveDocumentSetAsync(
            RetrieveDocumentSetRequestTypeDocumentRequest[] RetrieveDocumentSetRequest)
        {
            DocumentRepository_RetrieveDocumentSetRequest inValue = new DocumentRepository_RetrieveDocumentSetRequest();
            inValue.RetrieveDocumentSetRequest = RetrieveDocumentSetRequest;
            return ((DocumentRepository_PortType)(this)).DocumentRepository_RetrieveDocumentSetAsync(inValue);
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        DocumentRepository_ProvideAndRegisterDocumentSetbResponse DocumentRepository_PortType.
            DocumentRepository_ProvideAndRegisterDocumentSetb(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request)
        {
            return Channel.DocumentRepository_ProvideAndRegisterDocumentSetb(request);
        }

        public RegistryResponseType DocumentRepository_ProvideAndRegisterDocumentSetb(
            ProvideAndRegisterDocumentSetRequestType ProvideAndRegisterDocumentSetRequest)
        {
            DocumentRepository_ProvideAndRegisterDocumentSetbRequest inValue =
                new DocumentRepository_ProvideAndRegisterDocumentSetbRequest();
            inValue.ProvideAndRegisterDocumentSetRequest = ProvideAndRegisterDocumentSetRequest;
            DocumentRepository_ProvideAndRegisterDocumentSetbResponse retVal =
                ((DocumentRepository_PortType)(this)).DocumentRepository_ProvideAndRegisterDocumentSetb(inValue);
            return retVal.RegistryResponse;
        }

        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        Task<DocumentRepository_ProvideAndRegisterDocumentSetbResponse> DocumentRepository_PortType.
            DocumentRepository_ProvideAndRegisterDocumentSetbAsync(
                DocumentRepository_ProvideAndRegisterDocumentSetbRequest request)
        {
            return Channel.DocumentRepository_ProvideAndRegisterDocumentSetbAsync(request);
        }

        public Task<DocumentRepository_ProvideAndRegisterDocumentSetbResponse>
            DocumentRepository_ProvideAndRegisterDocumentSetbAsync(
                ProvideAndRegisterDocumentSetRequestType ProvideAndRegisterDocumentSetRequest)
        {
            DocumentRepository_ProvideAndRegisterDocumentSetbRequest inValue =
                new DocumentRepository_ProvideAndRegisterDocumentSetbRequest();
            inValue.ProvideAndRegisterDocumentSetRequest = ProvideAndRegisterDocumentSetRequest;
            return ((DocumentRepository_PortType)(this))
                .DocumentRepository_ProvideAndRegisterDocumentSetbAsync(inValue);
        }
    }
}