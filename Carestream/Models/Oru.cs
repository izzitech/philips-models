using System.Xml.Serialization;

namespace izzitech.Carestream.Models
{
    [XmlRoot("REPORT")]
    public class Oru
    {
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

        // - Nuevos

        [XmlElement(ElementName = "SIGN_DATE")]
        public string SignDate { get; set; }

        [XmlElement(ElementName = "SIGN_TIME")]
        public string SignTime { get; set; }

        [XmlElement(ElementName = "SIGN_ID")]
        public string SignId { get; set; }

        [XmlElement(ElementName = "SIGN_FIRST")]
        public string SignFirstname { get; set; }

        [XmlElement(ElementName = "SIGN_LAST")]
        public string SignLastname { get; set; }

        [XmlElement(ElementName = "REPORT_TEXT")]
        public string ReportText { get; set; }
    }
}
