using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace CezihECDSa.Wsdl.OsigInfo
{
    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    //[DebuggerStepThroughAttribute()]
    //[DesignerCategoryAttribute("code")]
    //[System.Web.Services.WebServiceBindingAttribute(Name = "osiginfo", Namespace = "http://www.hzzo-net.hr/")]
    //public partial class OsigInfo : System.Web.Services.Protocols.SoapHttpClientProtocol
    //{

    //    private System.Threading.SendOrPostCallback chosenDoctorOperationCompleted;

    //    private System.Threading.SendOrPostCallback infoGlavarinaOperationCompleted;

    //    private System.Threading.SendOrPostCallback orthopedicAidCheckOperationCompleted;

    //    private System.Threading.SendOrPostCallback osigInfoForBISOperationCompleted;

    //    private System.Threading.SendOrPostCallback osigInfoForDoctorOperationCompleted;

    //    private System.Threading.SendOrPostCallback osigInfoForPharmacyOperationCompleted;

    //    private System.Threading.SendOrPostCallback osigInfoForSKZZOperationCompleted;

    //    /// <remarks/>
    //    public OsigInfo()
    //    {
    //        this.Url = "https://servis.hzzo-net.hr:8445/osiginfo-3";
    //    }

    //    /// <remarks/>
    //    public event chosenDoctorCompletedEventHandler chosenDoctorCompleted;

    //    /// <remarks/>
    //    public event infoGlavarinaCompletedEventHandler infoGlavarinaCompleted;

    //    /// <remarks/>
    //    public event orthopedicAidCheckCompletedEventHandler orthopedicAidCheckCompleted;

    //    /// <remarks/>
    //    public event osigInfoForBISCompletedEventHandler osigInfoForBISCompleted;

    //    /// <remarks/>
    //    public event osigInfoForDoctorCompletedEventHandler osigInfoForDoctorCompleted;

    //    /// <remarks/>
    //    public event osigInfoForPharmacyCompletedEventHandler osigInfoForPharmacyCompleted;

    //    /// <remarks/>
    //    public event osigInfoForSKZZCompletedEventHandler osigInfoForSKZZCompleted;

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("chosenDoctor", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlElementAttribute("chosenDoctorOutput")]
    //    public chosenDoctorResponseChosenDoctorOutput chosenDoctor(string OIBOsobe)
    //    {
    //        object[] results = this.Invoke("chosenDoctor", new object[] {
    //                OIBOsobe});
    //        return ((chosenDoctorResponseChosenDoctorOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BeginchosenDoctor(string OIBOsobe, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("chosenDoctor", new object[] {
    //                OIBOsobe}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public chosenDoctorResponseChosenDoctorOutput EndchosenDoctor(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((chosenDoctorResponseChosenDoctorOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void chosenDoctorAsync(string OIBOsobe)
    //    {
    //        chosenDoctorAsync(OIBOsobe, null);
    //    }

    //    /// <remarks/>
    //    public void chosenDoctorAsync(string OIBOsobe, object userState)
    //    {
    //        if ((chosenDoctorOperationCompleted == null))
    //        {
    //            chosenDoctorOperationCompleted = new System.Threading.SendOrPostCallback(OnchosenDoctorOperationCompleted);
    //        }
    //        this.InvokeAsync("chosenDoctor", new object[] {
    //                OIBOsobe}, chosenDoctorOperationCompleted, userState);
    //    }

    //    private void OnchosenDoctorOperationCompleted(object arg)
    //    {
    //        if ((chosenDoctorCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            chosenDoctorCompleted(this, new chosenDoctorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("infoGlavarina", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlArrayAttribute("infoGlavarinaOutput")]
    //    [return: XmlArrayItemAttribute("Glavarina", IsNullable = false)]
    //    public infoGlavarinaResponseGlavarina[] infoGlavarina(string MBODoktor, [XmlElementAttribute(DataType = "date")] DateTime Datum, [XmlElementAttribute(DataType = "date")] [XmlIgnoreAttribute()] bool DatumSpecified)
    //    {
    //        object[] results = this.Invoke("infoGlavarina", new object[] {
    //                MBODoktor,
    //                Datum,
    //                DatumSpecified});
    //        return ((infoGlavarinaResponseGlavarina[])(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BegininfoGlavarina(string MBODoktor, DateTime Datum, bool DatumSpecified, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("infoGlavarina", new object[] {
    //                MBODoktor,
    //                Datum,
    //                DatumSpecified}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public infoGlavarinaResponseGlavarina[] EndinfoGlavarina(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((infoGlavarinaResponseGlavarina[])(results[0]));
    //    }

    //    /// <remarks/>
    //    public void infoGlavarinaAsync(string MBODoktor, DateTime Datum, bool DatumSpecified)
    //    {
    //        infoGlavarinaAsync(MBODoktor, Datum, DatumSpecified, null);
    //    }

    //    /// <remarks/>
    //    public void infoGlavarinaAsync(string MBODoktor, DateTime Datum, bool DatumSpecified, object userState)
    //    {
    //        if ((infoGlavarinaOperationCompleted == null))
    //        {
    //            infoGlavarinaOperationCompleted = new System.Threading.SendOrPostCallback(OninfoGlavarinaOperationCompleted);
    //        }
    //        this.InvokeAsync("infoGlavarina", new object[] {
    //                MBODoktor,
    //                Datum,
    //                DatumSpecified}, infoGlavarinaOperationCompleted, userState);
    //    }

    //    private void OninfoGlavarinaOperationCompleted(object arg)
    //    {
    //        if ((infoGlavarinaCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            infoGlavarinaCompleted(this, new infoGlavarinaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("orthopedicAidCheck", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlElementAttribute("OrthopedicAidCheckOutput")]
    //    public orthopedicAidCheckResponseOrthopedicAidCheckOutput orthopedicAidCheck(string MBOsiguraneOsobe, string SifraPomagala)
    //    {
    //        object[] results = this.Invoke("orthopedicAidCheck", new object[] {
    //                MBOsiguraneOsobe,
    //                SifraPomagala});
    //        return ((orthopedicAidCheckResponseOrthopedicAidCheckOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BeginorthopedicAidCheck(string MBOsiguraneOsobe, string SifraPomagala, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("orthopedicAidCheck", new object[] {
    //                MBOsiguraneOsobe,
    //                SifraPomagala}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public orthopedicAidCheckResponseOrthopedicAidCheckOutput EndorthopedicAidCheck(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((orthopedicAidCheckResponseOrthopedicAidCheckOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void orthopedicAidCheckAsync(string MBOsiguraneOsobe, string SifraPomagala)
    //    {
    //        orthopedicAidCheckAsync(MBOsiguraneOsobe, SifraPomagala, null);
    //    }

    //    /// <remarks/>
    //    public void orthopedicAidCheckAsync(string MBOsiguraneOsobe, string SifraPomagala, object userState)
    //    {
    //        if ((orthopedicAidCheckOperationCompleted == null))
    //        {
    //            orthopedicAidCheckOperationCompleted = new System.Threading.SendOrPostCallback(OnorthopedicAidCheckOperationCompleted);
    //        }
    //        this.InvokeAsync("orthopedicAidCheck", new object[] {
    //                MBOsiguraneOsobe,
    //                SifraPomagala}, orthopedicAidCheckOperationCompleted, userState);
    //    }

    //    private void OnorthopedicAidCheckOperationCompleted(object arg)
    //    {
    //        if ((orthopedicAidCheckCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            orthopedicAidCheckCompleted(this, new orthopedicAidCheckCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("osigInfoForBIS", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlElementAttribute("OsigInfoForBISOutput")]
    //    public osigInfoForBISResponseOsigInfoForBISOutput[] osigInfoForBIS([XmlElementAttribute("BrojOsiguraneOsobe", typeof(osigInfoForBISBrojOsiguraneOsobe))] [XmlElementAttribute("MBOsiguraneOsobe", typeof(string))] [XmlElementAttribute("OpceInformacijeOPacijentu", typeof(osigInfoForBISOpceInformacijeOPacijentu))] object Item)
    //    {
    //        object[] results = this.Invoke("osigInfoForBIS", new object[] {
    //                Item});
    //        return ((osigInfoForBISResponseOsigInfoForBISOutput[])(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BeginosigInfoForBIS(object Item, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("osigInfoForBIS", new object[] {
    //                Item}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public osigInfoForBISResponseOsigInfoForBISOutput[] EndosigInfoForBIS(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((osigInfoForBISResponseOsigInfoForBISOutput[])(results[0]));
    //    }

    //    /// <remarks/>
    //    public void osigInfoForBISAsync(object Item)
    //    {
    //        osigInfoForBISAsync(Item, null);
    //    }

    //    /// <remarks/>
    //    public void osigInfoForBISAsync(object Item, object userState)
    //    {
    //        if ((osigInfoForBISOperationCompleted == null))
    //        {
    //            osigInfoForBISOperationCompleted = new System.Threading.SendOrPostCallback(OnosigInfoForBISOperationCompleted);
    //        }
    //        this.InvokeAsync("osigInfoForBIS", new object[] {
    //                Item}, osigInfoForBISOperationCompleted, userState);
    //    }

    //    private void OnosigInfoForBISOperationCompleted(object arg)
    //    {
    //        if ((osigInfoForBISCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            osigInfoForBISCompleted(this, new osigInfoForBISCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("osigInfoForDoctor", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlElementAttribute("OsigInfoForDoctorOutput")]
    //    public osigInfoForDoctorResponseOsigInfoForDoctorOutput[] osigInfoForDoctor([XmlElementAttribute("BrojOsiguraneOsobe", typeof(osigInfoForDoctorBrojOsiguraneOsobe))] [XmlElementAttribute("MBOsiguraneOsobe", typeof(string))] [XmlElementAttribute("OpceInformacijeOPacijentu", typeof(osigInfoForDoctorOpceInformacijeOPacijentu))] object Item)
    //    {
    //        object[] results = this.Invoke("osigInfoForDoctor", new object[] {
    //                Item});
    //        return ((osigInfoForDoctorResponseOsigInfoForDoctorOutput[])(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BeginosigInfoForDoctor(object Item, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("osigInfoForDoctor", new object[] {
    //                Item}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public osigInfoForDoctorResponseOsigInfoForDoctorOutput[] EndosigInfoForDoctor(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((osigInfoForDoctorResponseOsigInfoForDoctorOutput[])(results[0]));
    //    }

    //    /// <remarks/>
    //    public void osigInfoForDoctorAsync(object Item)
    //    {
    //        osigInfoForDoctorAsync(Item, null);
    //    }

    //    /// <remarks/>
    //    public void osigInfoForDoctorAsync(object Item, object userState)
    //    {
    //        if ((osigInfoForDoctorOperationCompleted == null))
    //        {
    //            osigInfoForDoctorOperationCompleted = new System.Threading.SendOrPostCallback(OnosigInfoForDoctorOperationCompleted);
    //        }
    //        this.InvokeAsync("osigInfoForDoctor", new object[] {
    //                Item}, osigInfoForDoctorOperationCompleted, userState);
    //    }

    //    private void OnosigInfoForDoctorOperationCompleted(object arg)
    //    {
    //        if ((osigInfoForDoctorCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            osigInfoForDoctorCompleted(this, new osigInfoForDoctorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("osigInfoForPharmacy", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlElementAttribute("OsigInfoForPharmacyOutput")]
    //    public osigInfoForPharmacyResponseOsigInfoForPharmacyOutput osigInfoForPharmacy([XmlElementAttribute("BrojOsiguraneOsobe", typeof(osigInfoForPharmacyBrojOsiguraneOsobe))] [XmlElementAttribute("MBOsiguraneOsobe", typeof(string))] object Item)
    //    {
    //        object[] results = this.Invoke("osigInfoForPharmacy", new object[] {
    //                Item});
    //        return ((osigInfoForPharmacyResponseOsigInfoForPharmacyOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BeginosigInfoForPharmacy(object Item, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("osigInfoForPharmacy", new object[] {
    //                Item}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public osigInfoForPharmacyResponseOsigInfoForPharmacyOutput EndosigInfoForPharmacy(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((osigInfoForPharmacyResponseOsigInfoForPharmacyOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void osigInfoForPharmacyAsync(object Item)
    //    {
    //        osigInfoForPharmacyAsync(Item, null);
    //    }

    //    /// <remarks/>
    //    public void osigInfoForPharmacyAsync(object Item, object userState)
    //    {
    //        if ((osigInfoForPharmacyOperationCompleted == null))
    //        {
    //            osigInfoForPharmacyOperationCompleted = new System.Threading.SendOrPostCallback(OnosigInfoForPharmacyOperationCompleted);
    //        }
    //        this.InvokeAsync("osigInfoForPharmacy", new object[] {
    //                Item}, osigInfoForPharmacyOperationCompleted, userState);
    //    }

    //    private void OnosigInfoForPharmacyOperationCompleted(object arg)
    //    {
    //        if ((osigInfoForPharmacyCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            osigInfoForPharmacyCompleted(this, new osigInfoForPharmacyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("osigInfoForSKZZ", RequestNamespace = "http://www.hzzo-net.hr/", ResponseNamespace = "http://www.hzzo-net.hr/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    //    [return: XmlElementAttribute("OsigInfoForSKZZOutput")]
    //    public osigInfoForSKZZResponseOsigInfoForSKZZOutput osigInfoForSKZZ([XmlElementAttribute("BrojOsiguraneOsobe", typeof(osigInfoForSKZZBrojOsiguraneOsobe))] [XmlElementAttribute("MBOsiguraneOsobe", typeof(string))] object Item)
    //    {
    //        object[] results = this.Invoke("osigInfoForSKZZ", new object[] {
    //                Item});
    //        return ((osigInfoForSKZZResponseOsigInfoForSKZZOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public IAsyncResult BeginosigInfoForSKZZ(object Item, AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("osigInfoForSKZZ", new object[] {
    //                Item}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public osigInfoForSKZZResponseOsigInfoForSKZZOutput EndosigInfoForSKZZ(IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((osigInfoForSKZZResponseOsigInfoForSKZZOutput)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void osigInfoForSKZZAsync(object Item)
    //    {
    //        osigInfoForSKZZAsync(Item, null);
    //    }

    //    /// <remarks/>
    //    public void osigInfoForSKZZAsync(object Item, object userState)
    //    {
    //        if ((osigInfoForSKZZOperationCompleted == null))
    //        {
    //            osigInfoForSKZZOperationCompleted = new System.Threading.SendOrPostCallback(OnosigInfoForSKZZOperationCompleted);
    //        }
    //        this.InvokeAsync("osigInfoForSKZZ", new object[] {
    //                Item}, osigInfoForSKZZOperationCompleted, userState);
    //    }

    //    private void OnosigInfoForSKZZOperationCompleted(object arg)
    //    {
    //        if ((osigInfoForSKZZCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            osigInfoForSKZZCompleted(this, new osigInfoForSKZZCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    public new void CancelAsync(object userState)
    //    {
    //        base.CancelAsync(userState);
    //    }
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class chosenDoctorResponseChosenDoctorOutput
    {

        private string imeField;

        private string prezimeField;

        private string mBOsiguraneOsobeField;

        private chosenDoctorResponseChosenDoctorOutputOdabraniLijecnik[] odabraniLijecnikField;

        /// <remarks/>
        public string Ime
        {
            get
            {
                return imeField;
            }
            set
            {
                imeField = value;
            }
        }

        /// <remarks/>
        public string Prezime
        {
            get
            {
                return prezimeField;
            }
            set
            {
                prezimeField = value;
            }
        }

        /// <remarks/>
        public string MBOsiguraneOsobe
        {
            get
            {
                return mBOsiguraneOsobeField;
            }
            set
            {
                mBOsiguraneOsobeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("OdabraniLijecnik")]
        public chosenDoctorResponseChosenDoctorOutputOdabraniLijecnik[] OdabraniLijecnik
        {
            get
            {
                return odabraniLijecnikField;
            }
            set
            {
                odabraniLijecnikField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class chosenDoctorResponseChosenDoctorOutputOdabraniLijecnik
    {

        private VrstaOdabranogLijecnika vrstaField;

        private string sifraField;

        private string imeLijecnikaField;

        private string prezimeLijecnikaField;

        /// <remarks/>
        public VrstaOdabranogLijecnika Vrsta
        {
            get
            {
                return vrstaField;
            }
            set
            {
                vrstaField = value;
            }
        }

        /// <remarks/>
        public string Sifra
        {
            get
            {
                return sifraField;
            }
            set
            {
                sifraField = value;
            }
        }

        /// <remarks/>
        public string ImeLijecnika
        {
            get
            {
                return imeLijecnikaField;
            }
            set
            {
                imeLijecnikaField = value;
            }
        }

        /// <remarks/>
        public string PrezimeLijecnika
        {
            get
            {
                return prezimeLijecnikaField;
            }
            set
            {
                prezimeLijecnikaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.hzzo-net.hr/")]
    public enum VrstaOdabranogLijecnika
    {

        /// <remarks/>
        DEN,

        /// <remarks/>
        GP,

        /// <remarks/>
        GYN,

        /// <remarks/>
        PED,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class infoGlavarinaResponseGlavarina
    {

        private string matBrField;

        private string ustanovaField;

        private string mjGodField;

        private DateTime datumOdField;

        private DateTime datumDoField;

        private string brojOsiguranikaField;

        private string brojAktivnihOsiguranikaField;

        private string iznosGlavarineField;

        private string moguciMjesecniDTPField;

        private string ladicaField;

        private string protetikaField;

        /// <remarks/>
        public string MatBr
        {
            get
            {
                return matBrField;
            }
            set
            {
                matBrField = value;
            }
        }

        /// <remarks/>
        public string Ustanova
        {
            get
            {
                return ustanovaField;
            }
            set
            {
                ustanovaField = value;
            }
        }

        /// <remarks/>
        public string MjGod
        {
            get
            {
                return mjGodField;
            }
            set
            {
                mjGodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumOd
        {
            get
            {
                return datumOdField;
            }
            set
            {
                datumOdField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumDo
        {
            get
            {
                return datumDoField;
            }
            set
            {
                datumDoField = value;
            }
        }

        /// <remarks/>
        public string BrojOsiguranika
        {
            get
            {
                return brojOsiguranikaField;
            }
            set
            {
                brojOsiguranikaField = value;
            }
        }

        /// <remarks/>
        public string BrojAktivnihOsiguranika
        {
            get
            {
                return brojAktivnihOsiguranikaField;
            }
            set
            {
                brojAktivnihOsiguranikaField = value;
            }
        }

        /// <remarks/>
        public string IznosGlavarine
        {
            get
            {
                return iznosGlavarineField;
            }
            set
            {
                iznosGlavarineField = value;
            }
        }

        /// <remarks/>
        public string MoguciMjesecniDTP
        {
            get
            {
                return moguciMjesecniDTPField;
            }
            set
            {
                moguciMjesecniDTPField = value;
            }
        }

        /// <remarks/>
        public string Ladica
        {
            get
            {
                return ladicaField;
            }
            set
            {
                ladicaField = value;
            }
        }

        /// <remarks/>
        public string Protetika
        {
            get
            {
                return protetikaField;
            }
            set
            {
                protetikaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class orthopedicAidCheckResponseOrthopedicAidCheckOutput
    {

        private bool odobrenoField;

        private string[] komentarField;

        /// <remarks/>
        public bool Odobreno
        {
            get
            {
                return odobrenoField;
            }
            set
            {
                odobrenoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Komentar")]
        public string[] Komentar
        {
            get
            {
                return komentarField;
            }
            set
            {
                komentarField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISBrojOsiguraneOsobe
    {

        private string fLIDField;

        private string idField;

        /// <remarks/>
        public string FLID
        {
            get
            {
                return fLIDField;
            }
            set
            {
                fLIDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISOpceInformacijeOPacijentu
    {

        private string imeField;

        private string prezimeField;

        private DateTime datumRodjenjaField;

        /// <remarks/>
        public string Ime
        {
            get
            {
                return imeField;
            }
            set
            {
                imeField = value;
            }
        }

        /// <remarks/>
        public string Prezime
        {
            get
            {
                return prezimeField;
            }
            set
            {
                prezimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenjaField;
            }
            set
            {
                datumRodjenjaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISResponseOsigInfoForBISOutput
    {

        private string imeField;

        private string prezimeField;

        private DateTime datumRodjenjaField;

        private Spol spolField;

        private string mBOsiguraneOsobeField;

        private string oIBField;

        private osigInfoForBISResponseOsigInfoForBISOutputAktivnaPolicaOsnovno[] aktivnaPolicaOsnovnoField;

        private osigInfoForBISResponseOsigInfoForBISOutputAktivnaPolicaDopunsko aktivnaPolicaDopunskoField;

        private osigInfoForBISResponseOsigInfoForBISOutputOdabraniLijecnik[] odabraniLijecnikField;

        private osigInfoForBISResponseOsigInfoForBISOutputAdresa adresaField;

        private bool hrvatskiBraniteljField;

        private string[] vrstaUlogeField;

        /// <remarks/>
        public string Ime
        {
            get
            {
                return imeField;
            }
            set
            {
                imeField = value;
            }
        }

        /// <remarks/>
        public string Prezime
        {
            get
            {
                return prezimeField;
            }
            set
            {
                prezimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenjaField;
            }
            set
            {
                datumRodjenjaField = value;
            }
        }

        /// <remarks/>
        public Spol Spol
        {
            get
            {
                return spolField;
            }
            set
            {
                spolField = value;
            }
        }

        /// <remarks/>
        public string MBOsiguraneOsobe
        {
            get
            {
                return mBOsiguraneOsobeField;
            }
            set
            {
                mBOsiguraneOsobeField = value;
            }
        }

        /// <remarks/>
        public string OIB
        {
            get
            {
                return oIBField;
            }
            set
            {
                oIBField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AktivnaPolicaOsnovno")]
        public osigInfoForBISResponseOsigInfoForBISOutputAktivnaPolicaOsnovno[] AktivnaPolicaOsnovno
        {
            get
            {
                return aktivnaPolicaOsnovnoField;
            }
            set
            {
                aktivnaPolicaOsnovnoField = value;
            }
        }

        /// <remarks/>
        public osigInfoForBISResponseOsigInfoForBISOutputAktivnaPolicaDopunsko AktivnaPolicaDopunsko
        {
            get
            {
                return aktivnaPolicaDopunskoField;
            }
            set
            {
                aktivnaPolicaDopunskoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("OdabraniLijecnik")]
        public osigInfoForBISResponseOsigInfoForBISOutputOdabraniLijecnik[] OdabraniLijecnik
        {
            get
            {
                return odabraniLijecnikField;
            }
            set
            {
                odabraniLijecnikField = value;
            }
        }

        /// <remarks/>
        public osigInfoForBISResponseOsigInfoForBISOutputAdresa Adresa
        {
            get
            {
                return adresaField;
            }
            set
            {
                adresaField = value;
            }
        }

        /// <remarks/>
        public bool HrvatskiBranitelj
        {
            get
            {
                return hrvatskiBraniteljField;
            }
            set
            {
                hrvatskiBraniteljField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Sifra", IsNullable = false)]
        public string[] VrstaUloge
        {
            get
            {
                return vrstaUlogeField;
            }
            set
            {
                vrstaUlogeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.hzzo-net.hr/")]
    public enum Spol
    {

        /// <remarks/>
        Musko,

        /// <remarks/>
        Zensko,

        /// <remarks/>
        Nepoznato,

        /// <remarks/>
        Nerazlucivo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISResponseOsigInfoForBISOutputAktivnaPolicaOsnovno
    {

        private string sifraPodrucnogUredaField;

        private KategorijaOsiguranja kategorijaOsiguranjaField;

        private string osnovaOsiguranjaField;

        private string drzavaField;

        private string brojField;

        private DateTime periodTrajanjaOdField;

        private bool periodTrajanjaOdFieldSpecified;

        private DateTime periodTrajanjaDoField;

        private bool periodTrajanjaDoFieldSpecified;

        /// <remarks/>
        public string SifraPodrucnogUreda
        {
            get
            {
                return sifraPodrucnogUredaField;
            }
            set
            {
                sifraPodrucnogUredaField = value;
            }
        }

        /// <remarks/>
        public KategorijaOsiguranja KategorijaOsiguranja
        {
            get
            {
                return kategorijaOsiguranjaField;
            }
            set
            {
                kategorijaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public string OsnovaOsiguranja
        {
            get
            {
                return osnovaOsiguranjaField;
            }
            set
            {
                osnovaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public string Drzava
        {
            get
            {
                return drzavaField;
            }
            set
            {
                drzavaField = value;
            }
        }

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaOd
        {
            get
            {
                return periodTrajanjaOdField;
            }
            set
            {
                periodTrajanjaOdField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaOdSpecified
        {
            get
            {
                return periodTrajanjaOdFieldSpecified;
            }
            set
            {
                periodTrajanjaOdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaDo
        {
            get
            {
                return periodTrajanjaDoField;
            }
            set
            {
                periodTrajanjaDoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaDoSpecified
        {
            get
            {
                return periodTrajanjaDoFieldSpecified;
            }
            set
            {
                periodTrajanjaDoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.hzzo-net.hr/")]
    public enum KategorijaOsiguranja
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        H,

        /// <remarks/>
        I,

        /// <remarks/>
        IS,

        /// <remarks/>
        IS1,

        /// <remarks/>
        IS2,

        /// <remarks/>
        IS3,

        /// <remarks/>
        IS4,

        /// <remarks/>
        J,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        M,
        
        /// <remarks/>
        T,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISResponseOsigInfoForBISOutputAktivnaPolicaDopunsko
    {

        private string brojField;

        private DateTime periodTrajanjaOdField;

        private bool periodTrajanjaOdFieldSpecified;

        private DateTime periodTrajanjaDoField;

        private bool periodTrajanjaDoFieldSpecified;

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaOd
        {
            get
            {
                return periodTrajanjaOdField;
            }
            set
            {
                periodTrajanjaOdField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaOdSpecified
        {
            get
            {
                return periodTrajanjaOdFieldSpecified;
            }
            set
            {
                periodTrajanjaOdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaDo
        {
            get
            {
                return periodTrajanjaDoField;
            }
            set
            {
                periodTrajanjaDoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaDoSpecified
        {
            get
            {
                return periodTrajanjaDoFieldSpecified;
            }
            set
            {
                periodTrajanjaDoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISResponseOsigInfoForBISOutputOdabraniLijecnik
    {

        private VrstaOdabranogLijecnika vrstaField;

        private string sifraField;

        /// <remarks/>
        public VrstaOdabranogLijecnika Vrsta
        {
            get
            {
                return vrstaField;
            }
            set
            {
                vrstaField = value;
            }
        }

        /// <remarks/>
        public string Sifra
        {
            get
            {
                return sifraField;
            }
            set
            {
                sifraField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForBISResponseOsigInfoForBISOutputAdresa
    {

        private string ulicaField;

        private string kucniBrojField;

        private string brojPosteField;

        private string sifraNaseljaField;

        /// <remarks/>
        public string Ulica
        {
            get
            {
                return ulicaField;
            }
            set
            {
                ulicaField = value;
            }
        }

        /// <remarks/>
        public string KucniBroj
        {
            get
            {
                return kucniBrojField;
            }
            set
            {
                kucniBrojField = value;
            }
        }

        /// <remarks/>
        public string BrojPoste
        {
            get
            {
                return brojPosteField;
            }
            set
            {
                brojPosteField = value;
            }
        }

        /// <remarks/>
        public string SifraNaselja
        {
            get
            {
                return sifraNaseljaField;
            }
            set
            {
                sifraNaseljaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorBrojOsiguraneOsobe
    {

        private string fLIDField;

        private string idField;

        /// <remarks/>
        public string FLID
        {
            get
            {
                return fLIDField;
            }
            set
            {
                fLIDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorOpceInformacijeOPacijentu
    {

        private string imeField;

        private string prezimeField;

        private DateTime datumRodjenjaField;

        /// <remarks/>
        public string Ime
        {
            get
            {
                return imeField;
            }
            set
            {
                imeField = value;
            }
        }

        /// <remarks/>
        public string Prezime
        {
            get
            {
                return prezimeField;
            }
            set
            {
                prezimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenjaField;
            }
            set
            {
                datumRodjenjaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorResponseOsigInfoForDoctorOutput
    {

        private string imeField;

        private string prezimeField;

        private DateTime datumRodjenjaField;

        private Spol spolField;

        private string mBOsiguraneOsobeField;

        private string oIBField;

        private osigInfoForDoctorResponseOsigInfoForDoctorOutputAktivnaPolicaOsnovno[] aktivnaPolicaOsnovnoField;

        private osigInfoForDoctorResponseOsigInfoForDoctorOutputAktivnaPolicaDopunsko aktivnaPolicaDopunskoField;

        private osigInfoForDoctorResponseOsigInfoForDoctorOutputOdabraniLijecnik[] odabraniLijecnikField;

        private string sifraLaboratorijaField;

        private osigInfoForDoctorResponseOsigInfoForDoctorOutputAdresa adresaField;

        private bool hrvatskiBraniteljField;

        private osigInfoForDoctorResponseOsigInfoForDoctorOutputBolnickoLijecenje bolnickoLijecenjeField;

        private string[] vrstaUlogeField;

        /// <remarks/>
        public string Ime
        {
            get
            {
                return imeField;
            }
            set
            {
                imeField = value;
            }
        }

        /// <remarks/>
        public string Prezime
        {
            get
            {
                return prezimeField;
            }
            set
            {
                prezimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenjaField;
            }
            set
            {
                datumRodjenjaField = value;
            }
        }

        /// <remarks/>
        public Spol Spol
        {
            get
            {
                return spolField;
            }
            set
            {
                spolField = value;
            }
        }

        /// <remarks/>
        public string MBOsiguraneOsobe
        {
            get
            {
                return mBOsiguraneOsobeField;
            }
            set
            {
                mBOsiguraneOsobeField = value;
            }
        }

        /// <remarks/>
        public string OIB
        {
            get
            {
                return oIBField;
            }
            set
            {
                oIBField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AktivnaPolicaOsnovno")]
        public osigInfoForDoctorResponseOsigInfoForDoctorOutputAktivnaPolicaOsnovno[] AktivnaPolicaOsnovno
        {
            get
            {
                return aktivnaPolicaOsnovnoField;
            }
            set
            {
                aktivnaPolicaOsnovnoField = value;
            }
        }

        /// <remarks/>
        public osigInfoForDoctorResponseOsigInfoForDoctorOutputAktivnaPolicaDopunsko AktivnaPolicaDopunsko
        {
            get
            {
                return aktivnaPolicaDopunskoField;
            }
            set
            {
                aktivnaPolicaDopunskoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("OdabraniLijecnik")]
        public osigInfoForDoctorResponseOsigInfoForDoctorOutputOdabraniLijecnik[] OdabraniLijecnik
        {
            get
            {
                return odabraniLijecnikField;
            }
            set
            {
                odabraniLijecnikField = value;
            }
        }

        /// <remarks/>
        public string SifraLaboratorija
        {
            get
            {
                return sifraLaboratorijaField;
            }
            set
            {
                sifraLaboratorijaField = value;
            }
        }

        /// <remarks/>
        public osigInfoForDoctorResponseOsigInfoForDoctorOutputAdresa Adresa
        {
            get
            {
                return adresaField;
            }
            set
            {
                adresaField = value;
            }
        }

        /// <remarks/>
        public bool HrvatskiBranitelj
        {
            get
            {
                return hrvatskiBraniteljField;
            }
            set
            {
                hrvatskiBraniteljField = value;
            }
        }

        /// <remarks/>
        public osigInfoForDoctorResponseOsigInfoForDoctorOutputBolnickoLijecenje BolnickoLijecenje
        {
            get
            {
                return bolnickoLijecenjeField;
            }
            set
            {
                bolnickoLijecenjeField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Sifra", IsNullable = false)]
        public string[] VrstaUloge
        {
            get
            {
                return vrstaUlogeField;
            }
            set
            {
                vrstaUlogeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorResponseOsigInfoForDoctorOutputAktivnaPolicaOsnovno
    {

        private NositeljPolice nositeljField;

        private string sifraPodrucnogUredaField;

        private KategorijaOsiguranja kategorijaOsiguranjaField;

        private string osnovaOsiguranjaField;

        private string brojField;

        private DateTime periodTrajanjaOdField;

        private bool periodTrajanjaOdFieldSpecified;

        private DateTime periodTrajanjaDoField;

        private bool periodTrajanjaDoFieldSpecified;

        /// <remarks/>
        public NositeljPolice Nositelj
        {
            get
            {
                return nositeljField;
            }
            set
            {
                nositeljField = value;
            }
        }

        /// <remarks/>
        public string SifraPodrucnogUreda
        {
            get
            {
                return sifraPodrucnogUredaField;
            }
            set
            {
                sifraPodrucnogUredaField = value;
            }
        }

        /// <remarks/>
        public KategorijaOsiguranja KategorijaOsiguranja
        {
            get
            {
                return kategorijaOsiguranjaField;
            }
            set
            {
                kategorijaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public string OsnovaOsiguranja
        {
            get
            {
                return osnovaOsiguranjaField;
            }
            set
            {
                osnovaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaOd
        {
            get
            {
                return periodTrajanjaOdField;
            }
            set
            {
                periodTrajanjaOdField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaOdSpecified
        {
            get
            {
                return periodTrajanjaOdFieldSpecified;
            }
            set
            {
                periodTrajanjaOdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaDo
        {
            get
            {
                return periodTrajanjaDoField;
            }
            set
            {
                periodTrajanjaDoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaDoSpecified
        {
            get
            {
                return periodTrajanjaDoFieldSpecified;
            }
            set
            {
                periodTrajanjaDoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.hzzo-net.hr/")]
    public enum NositeljPolice
    {

        /// <remarks/>
        Nositelj,

        /// <remarks/>
        Clan,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorResponseOsigInfoForDoctorOutputAktivnaPolicaDopunsko
    {

        private string brojField;

        private DateTime periodTrajanjaOdField;

        private bool periodTrajanjaOdFieldSpecified;

        private DateTime periodTrajanjaDoField;

        private bool periodTrajanjaDoFieldSpecified;

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaOd
        {
            get
            {
                return periodTrajanjaOdField;
            }
            set
            {
                periodTrajanjaOdField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaOdSpecified
        {
            get
            {
                return periodTrajanjaOdFieldSpecified;
            }
            set
            {
                periodTrajanjaOdFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaDo
        {
            get
            {
                return periodTrajanjaDoField;
            }
            set
            {
                periodTrajanjaDoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaDoSpecified
        {
            get
            {
                return periodTrajanjaDoFieldSpecified;
            }
            set
            {
                periodTrajanjaDoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorResponseOsigInfoForDoctorOutputOdabraniLijecnik
    {

        private VrstaOdabranogLijecnika vrstaField;

        private string sifraField;

        private string regionalniUredField;

        /// <remarks/>
        public VrstaOdabranogLijecnika Vrsta
        {
            get
            {
                return vrstaField;
            }
            set
            {
                vrstaField = value;
            }
        }

        /// <remarks/>
        public string Sifra
        {
            get
            {
                return sifraField;
            }
            set
            {
                sifraField = value;
            }
        }

        /// <remarks/>
        public string RegionalniUred
        {
            get
            {
                return regionalniUredField;
            }
            set
            {
                regionalniUredField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorResponseOsigInfoForDoctorOutputAdresa
    {

        private string ulicaField;

        private string kucniBrojField;

        private string brojPosteField;

        private string sifraNaseljaField;

        /// <remarks/>
        public string Ulica
        {
            get
            {
                return ulicaField;
            }
            set
            {
                ulicaField = value;
            }
        }

        /// <remarks/>
        public string KucniBroj
        {
            get
            {
                return kucniBrojField;
            }
            set
            {
                kucniBrojField = value;
            }
        }

        /// <remarks/>
        public string BrojPoste
        {
            get
            {
                return brojPosteField;
            }
            set
            {
                brojPosteField = value;
            }
        }

        /// <remarks/>
        public string SifraNaselja
        {
            get
            {
                return sifraNaseljaField;
            }
            set
            {
                sifraNaseljaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForDoctorResponseOsigInfoForDoctorOutputBolnickoLijecenje
    {

        private string sifraField;

        private DateTime pocetakLijecenjaField;

        /// <remarks/>
        public string Sifra
        {
            get
            {
                return sifraField;
            }
            set
            {
                sifraField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PocetakLijecenja
        {
            get
            {
                return pocetakLijecenjaField;
            }
            set
            {
                pocetakLijecenjaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForPharmacyBrojOsiguraneOsobe
    {

        private string fLIDField;

        private string idField;

        /// <remarks/>
        public string FLID
        {
            get
            {
                return fLIDField;
            }
            set
            {
                fLIDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForPharmacyResponseOsigInfoForPharmacyOutput
    {

        private string mBOsiguraneOsobeField;

        private osigInfoForPharmacyResponseOsigInfoForPharmacyOutputAktivnaPolicaOsnovno[] aktivnaPolicaOsnovnoField;

        private osigInfoForPharmacyResponseOsigInfoForPharmacyOutputAktivnaPolicaDopunsko aktivnaPolicaDopunskoField;

        private bool hrvatskiBraniteljField;

        private string[] vrstaUlogeField;

        /// <remarks/>
        public string MBOsiguraneOsobe
        {
            get
            {
                return mBOsiguraneOsobeField;
            }
            set
            {
                mBOsiguraneOsobeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AktivnaPolicaOsnovno")]
        public osigInfoForPharmacyResponseOsigInfoForPharmacyOutputAktivnaPolicaOsnovno[] AktivnaPolicaOsnovno
        {
            get
            {
                return aktivnaPolicaOsnovnoField;
            }
            set
            {
                aktivnaPolicaOsnovnoField = value;
            }
        }

        /// <remarks/>
        public osigInfoForPharmacyResponseOsigInfoForPharmacyOutputAktivnaPolicaDopunsko AktivnaPolicaDopunsko
        {
            get
            {
                return aktivnaPolicaDopunskoField;
            }
            set
            {
                aktivnaPolicaDopunskoField = value;
            }
        }

        /// <remarks/>
        public bool HrvatskiBranitelj
        {
            get
            {
                return hrvatskiBraniteljField;
            }
            set
            {
                hrvatskiBraniteljField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Sifra", IsNullable = false)]
        public string[] VrstaUloge
        {
            get
            {
                return vrstaUlogeField;
            }
            set
            {
                vrstaUlogeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForPharmacyResponseOsigInfoForPharmacyOutputAktivnaPolicaOsnovno
    {

        private string brojField;

        private string osnovaOsiguranjaField;

        private KategorijaOsiguranja kategorijaOsiguranjaField;

        private string drzavaField;

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }

        /// <remarks/>
        public string OsnovaOsiguranja
        {
            get
            {
                return osnovaOsiguranjaField;
            }
            set
            {
                osnovaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public KategorijaOsiguranja KategorijaOsiguranja
        {
            get
            {
                return kategorijaOsiguranjaField;
            }
            set
            {
                kategorijaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public string Drzava
        {
            get
            {
                return drzavaField;
            }
            set
            {
                drzavaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForPharmacyResponseOsigInfoForPharmacyOutputAktivnaPolicaDopunsko
    {

        private string brojField;

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForSKZZBrojOsiguraneOsobe
    {

        private string fLIDField;

        private string idField;

        /// <remarks/>
        public string FLID
        {
            get
            {
                return fLIDField;
            }
            set
            {
                fLIDField = value;
            }
        }

        /// <remarks/>
        public string ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForSKZZResponseOsigInfoForSKZZOutput
    {

        private string imeField;

        private string prezimeField;

        private DateTime datumRodjenjaField;

        private Spol spolField;

        private string mBOsiguraneOsobeField;

        private string oIBField;

        private osigInfoForSKZZResponseOsigInfoForSKZZOutputAktivnaPolicaOsnovno[] aktivnaPolicaOsnovnoField;

        private osigInfoForSKZZResponseOsigInfoForSKZZOutputAktivnaPolicaDopunsko aktivnaPolicaDopunskoField;

        private bool hrvatskiBraniteljField;

        private string[] vrstaUlogeField;

        /// <remarks/>
        public string Ime
        {
            get
            {
                return imeField;
            }
            set
            {
                imeField = value;
            }
        }

        /// <remarks/>
        public string Prezime
        {
            get
            {
                return prezimeField;
            }
            set
            {
                prezimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenjaField;
            }
            set
            {
                datumRodjenjaField = value;
            }
        }

        /// <remarks/>
        public Spol Spol
        {
            get
            {
                return spolField;
            }
            set
            {
                spolField = value;
            }
        }

        /// <remarks/>
        public string MBOsiguraneOsobe
        {
            get
            {
                return mBOsiguraneOsobeField;
            }
            set
            {
                mBOsiguraneOsobeField = value;
            }
        }

        /// <remarks/>
        public string OIB
        {
            get
            {
                return oIBField;
            }
            set
            {
                oIBField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("AktivnaPolicaOsnovno")]
        public osigInfoForSKZZResponseOsigInfoForSKZZOutputAktivnaPolicaOsnovno[] AktivnaPolicaOsnovno
        {
            get
            {
                return aktivnaPolicaOsnovnoField;
            }
            set
            {
                aktivnaPolicaOsnovnoField = value;
            }
        }

        /// <remarks/>
        public osigInfoForSKZZResponseOsigInfoForSKZZOutputAktivnaPolicaDopunsko AktivnaPolicaDopunsko
        {
            get
            {
                return aktivnaPolicaDopunskoField;
            }
            set
            {
                aktivnaPolicaDopunskoField = value;
            }
        }

        /// <remarks/>
        public bool HrvatskiBranitelj
        {
            get
            {
                return hrvatskiBraniteljField;
            }
            set
            {
                hrvatskiBraniteljField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("Sifra", IsNullable = false)]
        public string[] VrstaUloge
        {
            get
            {
                return vrstaUlogeField;
            }
            set
            {
                vrstaUlogeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForSKZZResponseOsigInfoForSKZZOutputAktivnaPolicaOsnovno
    {

        private KategorijaOsiguranja kategorijaOsiguranjaField;

        private DateTime periodTrajanjaDoField;

        private bool periodTrajanjaDoFieldSpecified;

        /// <remarks/>
        public KategorijaOsiguranja KategorijaOsiguranja
        {
            get
            {
                return kategorijaOsiguranjaField;
            }
            set
            {
                kategorijaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaDo
        {
            get
            {
                return periodTrajanjaDoField;
            }
            set
            {
                periodTrajanjaDoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaDoSpecified
        {
            get
            {
                return periodTrajanjaDoFieldSpecified;
            }
            set
            {
                periodTrajanjaDoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo-net.hr/")]
    public partial class osigInfoForSKZZResponseOsigInfoForSKZZOutputAktivnaPolicaDopunsko
    {

        private string brojField;

        private DateTime periodTrajanjaDoField;

        private bool periodTrajanjaDoFieldSpecified;

        /// <remarks/>
        public string Broj
        {
            get
            {
                return brojField;
            }
            set
            {
                brojField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime PeriodTrajanjaDo
        {
            get
            {
                return periodTrajanjaDoField;
            }
            set
            {
                periodTrajanjaDoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool PeriodTrajanjaDoSpecified
        {
            get
            {
                return periodTrajanjaDoFieldSpecified;
            }
            set
            {
                periodTrajanjaDoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void chosenDoctorCompletedEventHandler(object sender, chosenDoctorCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class chosenDoctorCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal chosenDoctorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public chosenDoctorResponseChosenDoctorOutput Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((chosenDoctorResponseChosenDoctorOutput)(results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void infoGlavarinaCompletedEventHandler(object sender, infoGlavarinaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class infoGlavarinaCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal infoGlavarinaCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public infoGlavarinaResponseGlavarina[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((infoGlavarinaResponseGlavarina[])(results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void orthopedicAidCheckCompletedEventHandler(object sender, orthopedicAidCheckCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class orthopedicAidCheckCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal orthopedicAidCheckCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public orthopedicAidCheckResponseOrthopedicAidCheckOutput Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((orthopedicAidCheckResponseOrthopedicAidCheckOutput)(results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void osigInfoForBISCompletedEventHandler(object sender, osigInfoForBISCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class osigInfoForBISCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal osigInfoForBISCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public osigInfoForBISResponseOsigInfoForBISOutput[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((osigInfoForBISResponseOsigInfoForBISOutput[])(results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void osigInfoForDoctorCompletedEventHandler(object sender, osigInfoForDoctorCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class osigInfoForDoctorCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal osigInfoForDoctorCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public osigInfoForDoctorResponseOsigInfoForDoctorOutput[] Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((osigInfoForDoctorResponseOsigInfoForDoctorOutput[])(results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void osigInfoForPharmacyCompletedEventHandler(object sender, osigInfoForPharmacyCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class osigInfoForPharmacyCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal osigInfoForPharmacyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public osigInfoForPharmacyResponseOsigInfoForPharmacyOutput Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((osigInfoForPharmacyResponseOsigInfoForPharmacyOutput)(results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    public delegate void osigInfoForSKZZCompletedEventHandler(object sender, osigInfoForSKZZCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    public partial class osigInfoForSKZZCompletedEventArgs : AsyncCompletedEventArgs
    {

        private object[] results;

        internal osigInfoForSKZZCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public osigInfoForSKZZResponseOsigInfoForSKZZOutput Result
        {
            get
            {
                RaiseExceptionIfNecessary();
                return ((osigInfoForSKZZResponseOsigInfoForSKZZOutput)(results[0]));
            }
        }
    }
}