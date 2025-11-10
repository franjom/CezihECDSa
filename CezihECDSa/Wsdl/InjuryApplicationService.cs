namespace CezihECDSa.Wsdl.InjuryApplicationService
{
    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Web.Services.WebServiceBindingAttribute(Name = "InjuryApplicationServiceSoap11", Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    //public partial class InjuryApplicationService : System.Web.Services.Protocols.SoapHttpClientProtocol
    //{

    //    private System.Threading.SendOrPostCallback prijavaOperationCompleted;

    //    private System.Threading.SendOrPostCallback listaPrijavaOperationCompleted;

    //    private System.Threading.SendOrPostCallback izvjesceLijecnikaOperationCompleted;

    //    private System.Threading.SendOrPostCallback echoOperationCompleted;

    //    /// <remarks/>
    //    public InjuryApplicationService()
    //    {
    //        this.Url = "https://localhost:8443/eozljede-webservices/ws";
    //    }

    //    /// <remarks/>
    //    public event prijavaCompletedEventHandler prijavaCompleted;

    //    /// <remarks/>
    //    public event listaPrijavaCompletedEventHandler listaPrijavaCompleted;

    //    /// <remarks/>
    //    public event izvjesceLijecnikaCompletedEventHandler izvjesceLijecnikaCompleted;

    //    /// <remarks/>
    //    public event echoCompletedEventHandler echoCompleted;

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    //    [return: System.Xml.Serialization.XmlElementAttribute("prijavaResponse", Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    //    public prijavaResponse prijava([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")] prijavaRequest prijavaRequest)
    //    {
    //        object[] results = this.Invoke("prijava", new object[] {
    //                prijavaRequest});
    //        return ((prijavaResponse)(results[0]));
    //    }

    //    /// <remarks/>
    //    public System.IAsyncResult Beginprijava(prijavaRequest prijavaRequest, System.AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("prijava", new object[] {
    //                prijavaRequest}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public prijavaResponse Endprijava(System.IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((prijavaResponse)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void prijavaAsync(prijavaRequest prijavaRequest)
    //    {
    //        this.prijavaAsync(prijavaRequest, null);
    //    }

    //    /// <remarks/>
    //    public void prijavaAsync(prijavaRequest prijavaRequest, object userState)
    //    {
    //        if ((this.prijavaOperationCompleted == null))
    //        {
    //            this.prijavaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprijavaOperationCompleted);
    //        }
    //        this.InvokeAsync("prijava", new object[] {
    //                prijavaRequest}, this.prijavaOperationCompleted, userState);
    //    }

    //    private void OnprijavaOperationCompleted(object arg)
    //    {
    //        if ((this.prijavaCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            this.prijavaCompleted(this, new prijavaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    //    [return: System.Xml.Serialization.XmlElementAttribute("listaPrijavaResponse", Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    //    public listaPrijavaResponse listaPrijava([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")] listaPrijavaRequest listaPrijavaRequest)
    //    {
    //        object[] results = this.Invoke("listaPrijava", new object[] {
    //                listaPrijavaRequest});
    //        return ((listaPrijavaResponse)(results[0]));
    //    }

    //    /// <remarks/>
    //    public System.IAsyncResult BeginlistaPrijava(listaPrijavaRequest listaPrijavaRequest, System.AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("listaPrijava", new object[] {
    //                listaPrijavaRequest}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public listaPrijavaResponse EndlistaPrijava(System.IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((listaPrijavaResponse)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void listaPrijavaAsync(listaPrijavaRequest listaPrijavaRequest)
    //    {
    //        this.listaPrijavaAsync(listaPrijavaRequest, null);
    //    }

    //    /// <remarks/>
    //    public void listaPrijavaAsync(listaPrijavaRequest listaPrijavaRequest, object userState)
    //    {
    //        if ((this.listaPrijavaOperationCompleted == null))
    //        {
    //            this.listaPrijavaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistaPrijavaOperationCompleted);
    //        }
    //        this.InvokeAsync("listaPrijava", new object[] {
    //                listaPrijavaRequest}, this.listaPrijavaOperationCompleted, userState);
    //    }

    //    private void OnlistaPrijavaOperationCompleted(object arg)
    //    {
    //        if ((this.listaPrijavaCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            this.listaPrijavaCompleted(this, new listaPrijavaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    //    [return: System.Xml.Serialization.XmlElementAttribute("izvjesceLijecnikaResponse", Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    //    public izvjesceLijecnikaResponse izvjesceLijecnika([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")] izvjesceLijecnikaRequest izvjesceLijecnikaRequest)
    //    {
    //        object[] results = this.Invoke("izvjesceLijecnika", new object[] {
    //                izvjesceLijecnikaRequest});
    //        return ((izvjesceLijecnikaResponse)(results[0]));
    //    }

    //    /// <remarks/>
    //    public System.IAsyncResult BeginizvjesceLijecnika(izvjesceLijecnikaRequest izvjesceLijecnikaRequest, System.AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("izvjesceLijecnika", new object[] {
    //                izvjesceLijecnikaRequest}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public izvjesceLijecnikaResponse EndizvjesceLijecnika(System.IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((izvjesceLijecnikaResponse)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void izvjesceLijecnikaAsync(izvjesceLijecnikaRequest izvjesceLijecnikaRequest)
    //    {
    //        this.izvjesceLijecnikaAsync(izvjesceLijecnikaRequest, null);
    //    }

    //    /// <remarks/>
    //    public void izvjesceLijecnikaAsync(izvjesceLijecnikaRequest izvjesceLijecnikaRequest, object userState)
    //    {
    //        if ((this.izvjesceLijecnikaOperationCompleted == null))
    //        {
    //            this.izvjesceLijecnikaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnizvjesceLijecnikaOperationCompleted);
    //        }
    //        this.InvokeAsync("izvjesceLijecnika", new object[] {
    //                izvjesceLijecnikaRequest}, this.izvjesceLijecnikaOperationCompleted, userState);
    //    }

    //    private void OnizvjesceLijecnikaOperationCompleted(object arg)
    //    {
    //        if ((this.izvjesceLijecnikaCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            this.izvjesceLijecnikaCompleted(this, new izvjesceLijecnikaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
    //    [return: System.Xml.Serialization.XmlElementAttribute("echoResponse", Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    //    public string echo([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")] string echoRequest)
    //    {
    //        object[] results = this.Invoke("echo", new object[] {
    //                echoRequest});
    //        return ((string)(results[0]));
    //    }

    //    /// <remarks/>
    //    public System.IAsyncResult Beginecho(string echoRequest, System.AsyncCallback callback, object asyncState)
    //    {
    //        return this.BeginInvoke("echo", new object[] {
    //                echoRequest}, callback, asyncState);
    //    }

    //    /// <remarks/>
    //    public string Endecho(System.IAsyncResult asyncResult)
    //    {
    //        object[] results = this.EndInvoke(asyncResult);
    //        return ((string)(results[0]));
    //    }

    //    /// <remarks/>
    //    public void echoAsync(string echoRequest)
    //    {
    //        this.echoAsync(echoRequest, null);
    //    }

    //    /// <remarks/>
    //    public void echoAsync(string echoRequest, object userState)
    //    {
    //        if ((this.echoOperationCompleted == null))
    //        {
    //            this.echoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnechoOperationCompleted);
    //        }
    //        this.InvokeAsync("echo", new object[] {
    //                echoRequest}, this.echoOperationCompleted, userState);
    //    }

    //    private void OnechoOperationCompleted(object arg)
    //    {
    //        if ((this.echoCompleted != null))
    //        {
    //            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
    //            this.echoCompleted(this, new echoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
    //        }
    //    }

    //    /// <remarks/>
    //    public new void CancelAsync(object userState)
    //    {
    //        base.CancelAsync(userState);
    //    }
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    public partial class prijavaRequest
    {

        private int idPrijaveField;

        /// <remarks/>
        public int idPrijave
        {
            get
            {
                return this.idPrijaveField;
            }
            set
            {
                this.idPrijaveField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class prijavaOsnovni
    {

        private int idField;

        private string nazivPoslodavcaField;

        private string oibPoslodavcaField;

        private string imePrezimeOsiguranikaField;

        private string oibOsiguranikaField;

        private string mboOsiguranikaField;

        private System.DateTime datumPodnosenjaField;

        private System.DateTime datumNastankaOzljedeField;

        private bool nadopunaField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string nazivPoslodavca
        {
            get
            {
                return this.nazivPoslodavcaField;
            }
            set
            {
                this.nazivPoslodavcaField = value;
            }
        }

        /// <remarks/>
        public string oibPoslodavca
        {
            get
            {
                return this.oibPoslodavcaField;
            }
            set
            {
                this.oibPoslodavcaField = value;
            }
        }

        /// <remarks/>
        public string imePrezimeOsiguranika
        {
            get
            {
                return this.imePrezimeOsiguranikaField;
            }
            set
            {
                this.imePrezimeOsiguranikaField = value;
            }
        }

        /// <remarks/>
        public string oibOsiguranika
        {
            get
            {
                return this.oibOsiguranikaField;
            }
            set
            {
                this.oibOsiguranikaField = value;
            }
        }

        /// <remarks/>
        public string mboOsiguranika
        {
            get
            {
                return this.mboOsiguranikaField;
            }
            set
            {
                this.mboOsiguranikaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumPodnosenja
        {
            get
            {
                return this.datumPodnosenjaField;
            }
            set
            {
                this.datumPodnosenjaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumNastankaOzljede
        {
            get
            {
                return this.datumNastankaOzljedeField;
            }
            set
            {
                this.datumNastankaOzljedeField = value;
            }
        }

        /// <remarks/>
        public bool nadopuna
        {
            get
            {
                return this.nadopunaField;
            }
            set
            {
                this.nadopunaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class zahtjevZaNadopunu
    {

        private string lpImePrezimeField;

        private string lpMboField;

        private System.DateTime datumKreiranjaZahtjevaField;

        private string opisZahtjevaField;

        /// <remarks/>
        public string lpImePrezime
        {
            get
            {
                return this.lpImePrezimeField;
            }
            set
            {
                this.lpImePrezimeField = value;
            }
        }

        /// <remarks/>
        public string lpMbo
        {
            get
            {
                return this.lpMboField;
            }
            set
            {
                this.lpMboField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumKreiranjaZahtjeva
        {
            get
            {
                return this.datumKreiranjaZahtjevaField;
            }
            set
            {
                this.datumKreiranjaZahtjevaField = value;
            }
        }

        /// <remarks/>
        public string opisZahtjeva
        {
            get
            {
                return this.opisZahtjevaField;
            }
            set
            {
                this.opisZahtjevaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class pdf
    {

        private string imeDatotekeField;

        private byte[] datotekaField;

        /// <remarks/>
        public string imeDatoteke
        {
            get
            {
                return this.imeDatotekeField;
            }
            set
            {
                this.imeDatotekeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] datoteka
        {
            get
            {
                return this.datotekaField;
            }
            set
            {
                this.datotekaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class izvjesceLijecnika
    {

        private izvjesceLijecnikaIzvjesceSacinjeno izvjesceSacinjenoField;

        private string prviPregledDoktorMboField;

        private adresa prviPregledDoktorAdresaField;

        private string prviPregledDoktorOpisField;

        private string prviPregledUstanovaField;

        private izvjesceLijecnikaDijagnoze dijagnozeField;

        private string vanjskiUzrokOzljedeField;

        private int drugeBolestiField;

        private string drugeBolestiOpisField;

        private int fizickePsihickePoteskoceField;

        private string fizickePsihickePoteskoceOpisField;

        private int testiranjeAlkoholDrogeField;

        private string testiranjeAlkoholDrogeOpisField;

        private string napomenaField;

        private pdf pdfField;

        /// <remarks/>
        public izvjesceLijecnikaIzvjesceSacinjeno izvjesceSacinjeno
        {
            get
            {
                return this.izvjesceSacinjenoField;
            }
            set
            {
                this.izvjesceSacinjenoField = value;
            }
        }

        /// <remarks/>
        public string prviPregledDoktorMbo
        {
            get
            {
                return this.prviPregledDoktorMboField;
            }
            set
            {
                this.prviPregledDoktorMboField = value;
            }
        }

        /// <remarks/>
        public adresa prviPregledDoktorAdresa
        {
            get
            {
                return this.prviPregledDoktorAdresaField;
            }
            set
            {
                this.prviPregledDoktorAdresaField = value;
            }
        }

        /// <remarks/>
        public string prviPregledDoktorOpis
        {
            get
            {
                return this.prviPregledDoktorOpisField;
            }
            set
            {
                this.prviPregledDoktorOpisField = value;
            }
        }

        /// <remarks/>
        public string prviPregledUstanova
        {
            get
            {
                return this.prviPregledUstanovaField;
            }
            set
            {
                this.prviPregledUstanovaField = value;
            }
        }

        /// <remarks/>
        public izvjesceLijecnikaDijagnoze dijagnoze
        {
            get
            {
                return this.dijagnozeField;
            }
            set
            {
                this.dijagnozeField = value;
            }
        }

        /// <remarks/>
        public string vanjskiUzrokOzljede
        {
            get
            {
                return this.vanjskiUzrokOzljedeField;
            }
            set
            {
                this.vanjskiUzrokOzljedeField = value;
            }
        }

        /// <remarks/>
        public int drugeBolesti
        {
            get
            {
                return this.drugeBolestiField;
            }
            set
            {
                this.drugeBolestiField = value;
            }
        }

        /// <remarks/>
        public string drugeBolestiOpis
        {
            get
            {
                return this.drugeBolestiOpisField;
            }
            set
            {
                this.drugeBolestiOpisField = value;
            }
        }

        /// <remarks/>
        public int fizickePsihickePoteskoce
        {
            get
            {
                return this.fizickePsihickePoteskoceField;
            }
            set
            {
                this.fizickePsihickePoteskoceField = value;
            }
        }

        /// <remarks/>
        public string fizickePsihickePoteskoceOpis
        {
            get
            {
                return this.fizickePsihickePoteskoceOpisField;
            }
            set
            {
                this.fizickePsihickePoteskoceOpisField = value;
            }
        }

        /// <remarks/>
        public int testiranjeAlkoholDroge
        {
            get
            {
                return this.testiranjeAlkoholDrogeField;
            }
            set
            {
                this.testiranjeAlkoholDrogeField = value;
            }
        }

        /// <remarks/>
        public string testiranjeAlkoholDrogeOpis
        {
            get
            {
                return this.testiranjeAlkoholDrogeOpisField;
            }
            set
            {
                this.testiranjeAlkoholDrogeOpisField = value;
            }
        }

        /// <remarks/>
        public string napomena
        {
            get
            {
                return this.napomenaField;
            }
            set
            {
                this.napomenaField = value;
            }
        }

        /// <remarks/>
        public pdf pdf
        {
            get
            {
                return this.pdfField;
            }
            set
            {
                this.pdfField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public enum izvjesceLijecnikaIzvjesceSacinjeno
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class adresa
    {

        private string ulicaField;

        private string kucniBrojField;

        private string postanskiBrojField;

        private string mjestoField;

        /// <remarks/>
        public string ulica
        {
            get
            {
                return this.ulicaField;
            }
            set
            {
                this.ulicaField = value;
            }
        }

        /// <remarks/>
        public string kucniBroj
        {
            get
            {
                return this.kucniBrojField;
            }
            set
            {
                this.kucniBrojField = value;
            }
        }

        /// <remarks/>
        public string postanskiBroj
        {
            get
            {
                return this.postanskiBrojField;
            }
            set
            {
                this.postanskiBrojField = value;
            }
        }

        /// <remarks/>
        public string mjesto
        {
            get
            {
                return this.mjestoField;
            }
            set
            {
                this.mjestoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class izvjesceLijecnikaDijagnoze
    {

        private string dijagnoza1Field;

        private string dijagnoza2Field;

        private string dijagnoza3Field;

        private string dijagnoza4Field;

        /// <remarks/>
        public string dijagnoza1
        {
            get
            {
                return this.dijagnoza1Field;
            }
            set
            {
                this.dijagnoza1Field = value;
            }
        }

        /// <remarks/>
        public string dijagnoza2
        {
            get
            {
                return this.dijagnoza2Field;
            }
            set
            {
                this.dijagnoza2Field = value;
            }
        }

        /// <remarks/>
        public string dijagnoza3
        {
            get
            {
                return this.dijagnoza3Field;
            }
            set
            {
                this.dijagnoza3Field = value;
            }
        }

        /// <remarks/>
        public string dijagnoza4
        {
            get
            {
                return this.dijagnoza4Field;
            }
            set
            {
                this.dijagnoza4Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class prijaviteljOzljede
    {

        private string imePrezimeField;

        private string telefonField;

        private string radnoMjestoField;

        private string emailField;

        /// <remarks/>
        public string imePrezime
        {
            get
            {
                return this.imePrezimeField;
            }
            set
            {
                this.imePrezimeField = value;
            }
        }

        /// <remarks/>
        public string telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }

        /// <remarks/>
        public string radnoMjesto
        {
            get
            {
                return this.radnoMjestoField;
            }
            set
            {
                this.radnoMjestoField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class ocevidac
    {

        private string imePrezimeField;

        private string telefonField;

        private adresa adresaField;

        private string emailField;

        /// <remarks/>
        public string imePrezime
        {
            get
            {
                return this.imePrezimeField;
            }
            set
            {
                this.imePrezimeField = value;
            }
        }

        /// <remarks/>
        public string telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }

        /// <remarks/>
        public adresa adresa
        {
            get
            {
                return this.adresaField;
            }
            set
            {
                this.adresaField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class rukovoditelj
    {

        private string imePrezimeField;

        private string funkcijaField;

        private string telefonField;

        private adresa adresaField;

        private string emailField;

        /// <remarks/>
        public string imePrezime
        {
            get
            {
                return this.imePrezimeField;
            }
            set
            {
                this.imePrezimeField = value;
            }
        }

        /// <remarks/>
        public string funkcija
        {
            get
            {
                return this.funkcijaField;
            }
            set
            {
                this.funkcijaField = value;
            }
        }

        /// <remarks/>
        public string telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }

        /// <remarks/>
        public adresa adresa
        {
            get
            {
                return this.adresaField;
            }
            set
            {
                this.adresaField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class ozljeda
    {

        private System.DateTime datumField;

        private string vrijemeField;

        private adresa lokacijaField;

        private string zupanijaField;

        private int tezinaOzljedeField;

        private string vrstaOzljedeField;

        private string ozlijedjeniDioTijelaField;

        private int mjestoRadaField;

        private int ozljedaZaVrijemeRadaField;

        private int mjestaUVeziSRadomField;

        private string radniOkolisField;

        private string radniProcesField;

        private string specificnaAktivnostField;

        private string poremecajURadnomProcesuField;

        private string kontaktNacinOzljedivanjaField;

        private string uzrokOzljedeField;

        private int koristenjeZastitnihSredstavaField;

        private int osobnaZastitnaSredstvaField;

        private int osposobljenZaRadNaSiguranNacinField;

        private int osnovnaPravilaZastiteNaRaduField;

        private int posebnaPravilaZastiteNaRaduField;

        private int pruzenaPrvaPomocField;

        private int provedenaInternaIstragaField;

        private string provedenaInternaIstragaOpisField;

        private int obavljenOcevidField;

        private int nadzorInspektoraField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }

        /// <remarks/>
        public string vrijeme
        {
            get
            {
                return this.vrijemeField;
            }
            set
            {
                this.vrijemeField = value;
            }
        }

        /// <remarks/>
        public adresa lokacija
        {
            get
            {
                return this.lokacijaField;
            }
            set
            {
                this.lokacijaField = value;
            }
        }

        /// <remarks/>
        public string zupanija
        {
            get
            {
                return this.zupanijaField;
            }
            set
            {
                this.zupanijaField = value;
            }
        }

        /// <remarks/>
        public int tezinaOzljede
        {
            get
            {
                return this.tezinaOzljedeField;
            }
            set
            {
                this.tezinaOzljedeField = value;
            }
        }

        /// <remarks/>
        public string vrstaOzljede
        {
            get
            {
                return this.vrstaOzljedeField;
            }
            set
            {
                this.vrstaOzljedeField = value;
            }
        }

        /// <remarks/>
        public string ozlijedjeniDioTijela
        {
            get
            {
                return this.ozlijedjeniDioTijelaField;
            }
            set
            {
                this.ozlijedjeniDioTijelaField = value;
            }
        }

        /// <remarks/>
        public int mjestoRada
        {
            get
            {
                return this.mjestoRadaField;
            }
            set
            {
                this.mjestoRadaField = value;
            }
        }

        /// <remarks/>
        public int ozljedaZaVrijemeRada
        {
            get
            {
                return this.ozljedaZaVrijemeRadaField;
            }
            set
            {
                this.ozljedaZaVrijemeRadaField = value;
            }
        }

        /// <remarks/>
        public int mjestaUVeziSRadom
        {
            get
            {
                return this.mjestaUVeziSRadomField;
            }
            set
            {
                this.mjestaUVeziSRadomField = value;
            }
        }

        /// <remarks/>
        public string radniOkolis
        {
            get
            {
                return this.radniOkolisField;
            }
            set
            {
                this.radniOkolisField = value;
            }
        }

        /// <remarks/>
        public string radniProces
        {
            get
            {
                return this.radniProcesField;
            }
            set
            {
                this.radniProcesField = value;
            }
        }

        /// <remarks/>
        public string specificnaAktivnost
        {
            get
            {
                return this.specificnaAktivnostField;
            }
            set
            {
                this.specificnaAktivnostField = value;
            }
        }

        /// <remarks/>
        public string poremecajURadnomProcesu
        {
            get
            {
                return this.poremecajURadnomProcesuField;
            }
            set
            {
                this.poremecajURadnomProcesuField = value;
            }
        }

        /// <remarks/>
        public string kontaktNacinOzljedivanja
        {
            get
            {
                return this.kontaktNacinOzljedivanjaField;
            }
            set
            {
                this.kontaktNacinOzljedivanjaField = value;
            }
        }

        /// <remarks/>
        public string uzrokOzljede
        {
            get
            {
                return this.uzrokOzljedeField;
            }
            set
            {
                this.uzrokOzljedeField = value;
            }
        }

        /// <remarks/>
        public int koristenjeZastitnihSredstava
        {
            get
            {
                return this.koristenjeZastitnihSredstavaField;
            }
            set
            {
                this.koristenjeZastitnihSredstavaField = value;
            }
        }

        /// <remarks/>
        public int osobnaZastitnaSredstva
        {
            get
            {
                return this.osobnaZastitnaSredstvaField;
            }
            set
            {
                this.osobnaZastitnaSredstvaField = value;
            }
        }

        /// <remarks/>
        public int osposobljenZaRadNaSiguranNacin
        {
            get
            {
                return this.osposobljenZaRadNaSiguranNacinField;
            }
            set
            {
                this.osposobljenZaRadNaSiguranNacinField = value;
            }
        }

        /// <remarks/>
        public int osnovnaPravilaZastiteNaRadu
        {
            get
            {
                return this.osnovnaPravilaZastiteNaRaduField;
            }
            set
            {
                this.osnovnaPravilaZastiteNaRaduField = value;
            }
        }

        /// <remarks/>
        public int posebnaPravilaZastiteNaRadu
        {
            get
            {
                return this.posebnaPravilaZastiteNaRaduField;
            }
            set
            {
                this.posebnaPravilaZastiteNaRaduField = value;
            }
        }

        /// <remarks/>
        public int pruzenaPrvaPomoc
        {
            get
            {
                return this.pruzenaPrvaPomocField;
            }
            set
            {
                this.pruzenaPrvaPomocField = value;
            }
        }

        /// <remarks/>
        public int provedenaInternaIstraga
        {
            get
            {
                return this.provedenaInternaIstragaField;
            }
            set
            {
                this.provedenaInternaIstragaField = value;
            }
        }

        /// <remarks/>
        public string provedenaInternaIstragaOpis
        {
            get
            {
                return this.provedenaInternaIstragaOpisField;
            }
            set
            {
                this.provedenaInternaIstragaOpisField = value;
            }
        }

        /// <remarks/>
        public int obavljenOcevid
        {
            get
            {
                return this.obavljenOcevidField;
            }
            set
            {
                this.obavljenOcevidField = value;
            }
        }

        /// <remarks/>
        public int nadzorInspektora
        {
            get
            {
                return this.nadzorInspektoraField;
            }
            set
            {
                this.nadzorInspektoraField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class ozlijedjenaOsoba
    {

        private string imePrezimeField;

        private string imeRoditeljaField;

        private System.DateTime datumRodjenjaField;

        private adresa adresaField;

        private string telefonField;

        private string emailField;

        private string oibField;

        private string mboField;

        private int spolField;

        private int drzavljanstvoField;

        private string drzavljanstvoIzEuField;

        private string drzavljanstvoIzvanEuField;

        private string osnovaOsiguranjaField;

        private int vrstaUgovoraField;

        private int radnoVrijemeZaposlenikaField;

        private System.DateTime radnoVrijemeNaDanOdField;

        private System.DateTime radnoVrijemeNaDanDoField;

        private string zanimanjeField;

        private System.DateTime satRadaPrijeOzljedeField;

        private string ukupnoObavljanjePoslaField;

        /// <remarks/>
        public string imePrezime
        {
            get
            {
                return this.imePrezimeField;
            }
            set
            {
                this.imePrezimeField = value;
            }
        }

        /// <remarks/>
        public string imeRoditelja
        {
            get
            {
                return this.imeRoditeljaField;
            }
            set
            {
                this.imeRoditeljaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumRodjenja
        {
            get
            {
                return this.datumRodjenjaField;
            }
            set
            {
                this.datumRodjenjaField = value;
            }
        }

        /// <remarks/>
        public adresa adresa
        {
            get
            {
                return this.adresaField;
            }
            set
            {
                this.adresaField = value;
            }
        }

        /// <remarks/>
        public string telefon
        {
            get
            {
                return this.telefonField;
            }
            set
            {
                this.telefonField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string oib
        {
            get
            {
                return this.oibField;
            }
            set
            {
                this.oibField = value;
            }
        }

        /// <remarks/>
        public string mbo
        {
            get
            {
                return this.mboField;
            }
            set
            {
                this.mboField = value;
            }
        }

        /// <remarks/>
        public int spol
        {
            get
            {
                return this.spolField;
            }
            set
            {
                this.spolField = value;
            }
        }

        /// <remarks/>
        public int drzavljanstvo
        {
            get
            {
                return this.drzavljanstvoField;
            }
            set
            {
                this.drzavljanstvoField = value;
            }
        }

        /// <remarks/>
        public string drzavljanstvoIzEu
        {
            get
            {
                return this.drzavljanstvoIzEuField;
            }
            set
            {
                this.drzavljanstvoIzEuField = value;
            }
        }

        /// <remarks/>
        public string drzavljanstvoIzvanEu
        {
            get
            {
                return this.drzavljanstvoIzvanEuField;
            }
            set
            {
                this.drzavljanstvoIzvanEuField = value;
            }
        }

        /// <remarks/>
        public string osnovaOsiguranja
        {
            get
            {
                return this.osnovaOsiguranjaField;
            }
            set
            {
                this.osnovaOsiguranjaField = value;
            }
        }

        /// <remarks/>
        public int vrstaUgovora
        {
            get
            {
                return this.vrstaUgovoraField;
            }
            set
            {
                this.vrstaUgovoraField = value;
            }
        }

        /// <remarks/>
        public int radnoVrijemeZaposlenika
        {
            get
            {
                return this.radnoVrijemeZaposlenikaField;
            }
            set
            {
                this.radnoVrijemeZaposlenikaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime radnoVrijemeNaDanOd
        {
            get
            {
                return this.radnoVrijemeNaDanOdField;
            }
            set
            {
                this.radnoVrijemeNaDanOdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime radnoVrijemeNaDanDo
        {
            get
            {
                return this.radnoVrijemeNaDanDoField;
            }
            set
            {
                this.radnoVrijemeNaDanDoField = value;
            }
        }

        /// <remarks/>
        public string zanimanje
        {
            get
            {
                return this.zanimanjeField;
            }
            set
            {
                this.zanimanjeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime satRadaPrijeOzljede
        {
            get
            {
                return this.satRadaPrijeOzljedeField;
            }
            set
            {
                this.satRadaPrijeOzljedeField = value;
            }
        }

        /// <remarks/>
        public string ukupnoObavljanjePosla
        {
            get
            {
                return this.ukupnoObavljanjePoslaField;
            }
            set
            {
                this.ukupnoObavljanjePoslaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class poslodavac
    {

        private string nazivField;

        private adresa adresaField;

        private string emailField;

        private string oibField;

        private string brojObvezeField;

        private string glavnaGospodarskaDjelatnostField;

        private int brojZaposlenihField;

        private string smrDoktorIdField;

        /// <remarks/>
        public string naziv
        {
            get
            {
                return this.nazivField;
            }
            set
            {
                this.nazivField = value;
            }
        }

        /// <remarks/>
        public adresa adresa
        {
            get
            {
                return this.adresaField;
            }
            set
            {
                this.adresaField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public string oib
        {
            get
            {
                return this.oibField;
            }
            set
            {
                this.oibField = value;
            }
        }

        /// <remarks/>
        public string brojObveze
        {
            get
            {
                return this.brojObvezeField;
            }
            set
            {
                this.brojObvezeField = value;
            }
        }

        /// <remarks/>
        public string glavnaGospodarskaDjelatnost
        {
            get
            {
                return this.glavnaGospodarskaDjelatnostField;
            }
            set
            {
                this.glavnaGospodarskaDjelatnostField = value;
            }
        }

        /// <remarks/>
        public int brojZaposlenih
        {
            get
            {
                return this.brojZaposlenihField;
            }
            set
            {
                this.brojZaposlenihField = value;
            }
        }

        /// <remarks/>
        public string smrDoktorId
        {
            get
            {
                return this.smrDoktorIdField;
            }
            set
            {
                this.smrDoktorIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.hzzo.hr/eozljede/webservice/types")]
    public partial class prijava
    {

        private int idField;

        private poslodavac poslodavacField;

        private ozlijedjenaOsoba ozlijedenaOsobaField;

        private ozljeda ozljedaField;

        private rukovoditelj rukovoditeljField;

        private ocevidac ocevidacField;

        private prijaviteljOzljede prijaviteljOzljedeField;

        private izvjesceLijecnika izvjesceLijecnikaField;

        private System.DateTime datumPodnosenjaField;

        private pdf pdfField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public poslodavac poslodavac
        {
            get
            {
                return this.poslodavacField;
            }
            set
            {
                this.poslodavacField = value;
            }
        }

        /// <remarks/>
        public ozlijedjenaOsoba ozlijedenaOsoba
        {
            get
            {
                return this.ozlijedenaOsobaField;
            }
            set
            {
                this.ozlijedenaOsobaField = value;
            }
        }

        /// <remarks/>
        public ozljeda ozljeda
        {
            get
            {
                return this.ozljedaField;
            }
            set
            {
                this.ozljedaField = value;
            }
        }

        /// <remarks/>
        public rukovoditelj rukovoditelj
        {
            get
            {
                return this.rukovoditeljField;
            }
            set
            {
                this.rukovoditeljField = value;
            }
        }

        /// <remarks/>
        public ocevidac ocevidac
        {
            get
            {
                return this.ocevidacField;
            }
            set
            {
                this.ocevidacField = value;
            }
        }

        /// <remarks/>
        public prijaviteljOzljede prijaviteljOzljede
        {
            get
            {
                return this.prijaviteljOzljedeField;
            }
            set
            {
                this.prijaviteljOzljedeField = value;
            }
        }

        /// <remarks/>
        public izvjesceLijecnika izvjesceLijecnika
        {
            get
            {
                return this.izvjesceLijecnikaField;
            }
            set
            {
                this.izvjesceLijecnikaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime datumPodnosenja
        {
            get
            {
                return this.datumPodnosenjaField;
            }
            set
            {
                this.datumPodnosenjaField = value;
            }
        }

        /// <remarks/>
        public pdf pdf
        {
            get
            {
                return this.pdfField;
            }
            set
            {
                this.pdfField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    public partial class prijavaResponse
    {

        private prijava prijavaField;

        private zahtjevZaNadopunu zahtjevZaNadopunuField;

        /// <remarks/>
        public prijava prijava
        {
            get
            {
                return this.prijavaField;
            }
            set
            {
                this.prijavaField = value;
            }
        }

        /// <remarks/>
        public zahtjevZaNadopunu zahtjevZaNadopunu
        {
            get
            {
                return this.zahtjevZaNadopunuField;
            }
            set
            {
                this.zahtjevZaNadopunuField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    public partial class listaPrijavaRequest
    {

        private string mboPacijentaField;

        /// <remarks/>
        public string mboPacijenta
        {
            get
            {
                return this.mboPacijentaField;
            }
            set
            {
                this.mboPacijentaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    public partial class listaPrijavaResponse
    {

        private prijavaOsnovni[] prijavaOsnovniField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prijavaOsnovni")]
        public prijavaOsnovni[] prijavaOsnovni
        {
            get
            {
                return this.prijavaOsnovniField;
            }
            set
            {
                this.prijavaOsnovniField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    public partial class izvjesceLijecnikaRequest
    {

        private int idPrijaveField;

        private izvjesceLijecnika izvjesceLijecnikaField;

        private bool nadopunaField;

        /// <remarks/>
        public int idPrijave
        {
            get
            {
                return this.idPrijaveField;
            }
            set
            {
                this.idPrijaveField = value;
            }
        }

        /// <remarks/>
        public izvjesceLijecnika izvjesceLijecnika
        {
            get
            {
                return this.izvjesceLijecnikaField;
            }
            set
            {
                this.izvjesceLijecnikaField = value;
            }
        }

        /// <remarks/>
        public bool nadopuna
        {
            get
            {
                return this.nadopunaField;
            }
            set
            {
                this.nadopunaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.hzzo.hr/eozljede/webservice/operations")]
    public enum izvjesceLijecnikaResponse
    {

        /// <remarks/>
        SUCCESS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void prijavaCompletedEventHandler(object sender, prijavaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class prijavaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal prijavaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public prijavaResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((prijavaResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void listaPrijavaCompletedEventHandler(object sender, listaPrijavaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listaPrijavaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal listaPrijavaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public listaPrijavaResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((listaPrijavaResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void izvjesceLijecnikaCompletedEventHandler(object sender, izvjesceLijecnikaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class izvjesceLijecnikaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal izvjesceLijecnikaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public izvjesceLijecnikaResponse Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((izvjesceLijecnikaResponse)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void echoCompletedEventHandler(object sender, echoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class echoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal echoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}