using System.Xml.Serialization;

namespace izzitech.Carestream.Models
{
    [XmlRoot("WORKLIST")]
    public class Orm
    {
        [XmlElement(ElementName = "STATUS")]
        public string Status { get; set; }

        [XmlElement(ElementName = "ACCESSIONNUMBER")]
        public string AccessionNumber { get; set; }

        [XmlElement(ElementName = "PATIENTFIRSTNAME")]
        public string PatientFirstName { get; set; }

        [XmlElement(ElementName = "PATIENTLASTNAME")]
        public string PatientLastName { get; set; }

        [XmlElement(ElementName = "PATIENTID")]
        public string PatientId { get; set; }

        [XmlElement(ElementName = "PAT_DOB")]
        public string PatientDOB { get; set; }

        [XmlElement(ElementName = "PAT_SEX")]
        public string PatientSex { get; set; }

        [XmlElement(ElementName = "PAT_EMAIL")]
        public string PatientEmail { get; set; }

        [XmlElement(ElementName = "MYVUE_CONSENT")]
        public string MyVueConsent { get; set; }

        [XmlElement(ElementName = "MODALITY")]
        public string Modality { get; set; }

        [XmlElement(ElementName = "STATION_NAME")]
        public string StationName { get; set; }

        [XmlElement(ElementName = "START_DATE")]
        public string StartDate { get; set; }

        [XmlElement(ElementName = "START_TIME")]
        public string StartTime { get; set; }

        [XmlElement(ElementName = "REQUESTING_SERVICE")]
        public string RequestingService { get; set; }

        [XmlElement(ElementName = "REFPHY_ID")]
        public string ReferrentPhysicianId { get; set; }

        [XmlElement(ElementName = "REFPHY_FIRST")]
        public string ReferrentPhysicianFirstName { get; set; }

        [XmlElement(ElementName = "REFPHY_LAST")]
        public string ReferrentPhysicianLastName { get; set; }

        [XmlElement(ElementName = "PROD_CODE")]
        public string ProcedureCode { get; set; }

        [XmlElement(ElementName = "PROD_DESC")]
        public string ProcedureDesc { get; set; }

        [XmlElement(ElementName = "PATIENT_CLASS")]
        public string PatientClass { get; set; }

        [XmlElement(ElementName = "PATIENT_LOCATION")]
        public string PatientLocation { get; set; }

        [XmlElement(ElementName = "APTO_ENTREGA")]
        public string AptoEntrega { get; set; }

        [XmlElement(ElementName = "MEDICO_INFORMANTE")]
        public string MedicoInformante { get; set; }

        [XmlElement(ElementName = "INSURANCE_PROV_ID")]
        public string InsuranceProviderId { get; set; }

        [XmlElement(ElementName = "INSURANCE_PROV_NAME")]
        public string InsuranceProviderName { get; set; }

        [XmlElement(ElementName = "INSURANCE_PROV_PLAN")]
        public string InsuranceProviderPlan { get; set; }

        [XmlElement(ElementName = "INSURANCE_PROV_CRED")]
        public string InsuranceProviderCredit { get; set; }
    }
}
