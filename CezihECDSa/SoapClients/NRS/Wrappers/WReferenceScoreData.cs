using CezihECDSa.Wsdl;
using System;
using System.Xml.Serialization;

namespace CezihECDSa.SoapClients.NRS.Wrappers
{
    [XmlRoot("ReferenceScoreData", Namespace = "http://tempuri.org/")]
    public sealed class WReferenceScoreData
    {
        public WReferenceScoreData() { }
        public WReferenceScoreData(MedicalOperater medicalOperater, PatientReferenceData patientReferenceData)
        {
            MedicalOperater = medicalOperater;
            PatientReferenceData = patientReferenceData;
        }

        [XmlElement("MedicalOperater", Namespace = "http://tempuri.org/", Order = 0)]
        public MedicalOperater MedicalOperater { get; set; }

        [XmlElement("PatientReferenceData", Namespace = "http://tempuri.org/", Order = 1)]
        public PatientReferenceData PatientReferenceData { get; set; }
    }
}
