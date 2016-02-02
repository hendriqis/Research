using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QIS.Data.Core.Dal;

namespace PivotReporting.Model
{
    #region vPivotRegistration
    [Serializable]
    [Table(Name = "vPivotRegistration")]
    public partial class vPivotRegistration : Registration
    {
        //private String _ClassCode;
        //private String _ClassName;
        private String _RoomCode;
        //private String _RoomName;
        private String _BedNo;
        //private String _SpecialtyCode;
        //private String _SpecialtyName;
        private Boolean _IsNewPatient;
        private Boolean _IsOldPatient;
        //private Boolean _IsVoid;

        //private String _VisitTypeCode;
        //private String _VisitTypeName;
        //private String _GCVisitReason;
        //private String _VisitReason;
        //private DateTime _DischargeDate;
        //private String _DischargeTime;
        //private String _GCVisitStatus;
        //private String _GCRegistrationStatus;
        //private String _RegistrationStatus;
        //private Boolean _IsMainVisit;
        //private String _GCAdmissionCondition;
        //private String _AdmissionCondition;
        //private Boolean _IsNewBorn;
        //private Boolean _IsParturition;
        //private String _ReferrerName;
        //private String _GCDischargeCondition;
        //private String _DischargeCondition;
        //private String _GCDischargeMethod;
        //private String _DischargeMethod;
        //private Decimal _LOSInDay;
        //private Decimal _LOSInHour;
        //private Decimal _LOSInMinute;
        //private String _GCCustomerType;
        //private String _CustomerType;
        //private String _GCPatientCategory;
        //private String _PatientCategory;
        //private String _GCTriage;
        //private String _Triage;
        //private String _MedicalNo;
        //private String _Education;
        //private String _Occupation;
        //private DateTime _DateOfBirth;
        //private String _GCSex;
        //private String _Sex;
        //private String _GCGender;
        //private String _Gender;
        //private String _ZipCode;

        //[Column(Name = "ClassCode", DataType = "String")]
        //public String ClassCode
        //{
        //    get { return _ClassCode; }
        //    set { _ClassCode = value; }
        //}
        //[Column(Name = "ClassName", DataType = "String")]
        //public String ClassName
        //{
        //    get { return _ClassName; }
        //    set { _ClassName = value; }
        //}

        [Column(Name = "RoomCode", DataType = "String")]
        public String RoomCode
        {
            get { return _RoomCode; }
            set { _RoomCode = value; }
        }
        //[Column(Name = "RoomName", DataType = "String")]
        //public String RoomName
        //{
        //    get { return _RoomName; }
        //    set { _RoomName = value; }
        //}
        [Column(Name = "BedNo", DataType = "String")]
        public String BedNo
        {
            get { return _BedNo; }
            set { _BedNo = value; }
        }
        //[Column(Name = "SpecialtyCode", DataType = "String")]
        //public String SpecialtyCode
        //{
        //    get { return _SpecialtyCode; }
        //    set { _SpecialtyCode = value; }
        //}
        //[Column(Name = "SpecialtyName", DataType = "String")]
        //public String SpecialtyName
        //{
        //    get { return _SpecialtyName; }
        //    set { _SpecialtyName = value; }
        //}
        //[Column(Name = "IsVoid", DataType = "Boolean")]
        //public Boolean IsVoid
        //{
        //    get { return _IsVoid; }
        //    set { _IsVoid = value; }
        //}
        [Column(Name = "IsNewPatient", DataType = "Boolean")]
        public Boolean IsNewPatient
        {
            get { return _IsNewPatient; }
            set { _IsNewPatient = value; }
        }
        [Column(Name = "IsOldPatient", DataType = "Boolean")]
        public Boolean IsOldPatient
        {
            get { return _IsOldPatient; }
            set { _IsOldPatient = value; }
        }
        //[Column(Name = "VisitTime", DataType = "String")]
        //public String VisitTime
        //{
        //    get { return _VisitTime; }
        //    set { _VisitTime = value; }
        //}

        //[Column(Name = "VisitTypeCode", DataType = "String")]
        //public String VisitTypeCode
        //{
        //    get { return _VisitTypeCode; }
        //    set { _VisitTypeCode = value; }
        //}
        //[Column(Name = "VisitTypeName", DataType = "String")]
        //public String VisitTypeName
        //{
        //    get { return _VisitTypeName; }
        //    set { _VisitTypeName = value; }
        //}
        //[Column(Name = "GCVisitReason", DataType = "String")]
        //public String GCVisitReason
        //{
        //    get { return _GCVisitReason; }
        //    set { _GCVisitReason = value; }
        //}
        //[Column(Name = "VisitReason", DataType = "String")]
        //public String VisitReason
        //{
        //    get { return _VisitReason; }
        //    set { _VisitReason = value; }
        //}
        //[Column(Name = "DischargeDate", DataType = "DateTime")]
        //public DateTime DischargeDate
        //{
        //    get { return _DischargeDate; }
        //    set { _DischargeDate = value; }
        //}
        //[Column(Name = "DischargeTime", DataType = "String")]
        //public String DischargeTime
        //{
        //    get { return _DischargeTime; }
        //    set { _DischargeTime = value; }
        //}
        //[Column(Name = "GCVisitStatus", DataType = "String")]
        //public String GCVisitStatus
        //{
        //    get { return _GCVisitStatus; }
        //    set { _GCVisitStatus = value; }
        //}
        //[Column(Name = "GCRegistrationStatus", DataType = "String")]
        //public String GCRegistrationStatus
        //{
        //    get { return _GCRegistrationStatus; }
        //    set { _GCRegistrationStatus = value; }
        //}
        //[Column(Name = "RegistrationStatus", DataType = "String")]
        //public String RegistrationStatus
        //{
        //    get { return _RegistrationStatus; }
        //    set { _RegistrationStatus = value; }
        //}
        //[Column(Name = "IsMainVisit", DataType = "Boolean")]
        //public Boolean IsMainVisit
        //{
        //    get { return _IsMainVisit; }
        //    set { _IsMainVisit = value; }
        //}
        //[Column(Name = "GCAdmissionCondition", DataType = "String")]
        //public String GCAdmissionCondition
        //{
        //    get { return _GCAdmissionCondition; }
        //    set { _GCAdmissionCondition = value; }
        //}
        //[Column(Name = "AdmissionCondition", DataType = "String")]
        //public String AdmissionCondition
        //{
        //    get { return _AdmissionCondition; }
        //    set { _AdmissionCondition = value; }
        //}
        //[Column(Name = "IsNewBorn", DataType = "Boolean")]
        //public Boolean IsNewBorn
        //{
        //    get { return _IsNewBorn; }
        //    set { _IsNewBorn = value; }
        //}
        //[Column(Name = "IsParturition", DataType = "Boolean")]
        //public Boolean IsParturition
        //{
        //    get { return _IsParturition; }
        //    set { _IsParturition = value; }
        //}
        //[Column(Name = "ReferrerName", DataType = "String")]
        //public String ReferrerName
        //{
        //    get { return _ReferrerName; }
        //    set { _ReferrerName = value; }
        //}
        //[Column(Name = "GCDischargeCondition", DataType = "String")]
        //public String GCDischargeCondition
        //{
        //    get { return _GCDischargeCondition; }
        //    set { _GCDischargeCondition = value; }
        //}
        //[Column(Name = "DischargeCondition", DataType = "String")]
        //public String DischargeCondition
        //{
        //    get { return _DischargeCondition; }
        //    set { _DischargeCondition = value; }
        //}
        //[Column(Name = "GCDischargeMethod", DataType = "String")]
        //public String GCDischargeMethod
        //{
        //    get { return _GCDischargeMethod; }
        //    set { _GCDischargeMethod = value; }
        //}
        //[Column(Name = "DischargeMethod", DataType = "String")]
        //public String DischargeMethod
        //{
        //    get { return _DischargeMethod; }
        //    set { _DischargeMethod = value; }
        //}
        //[Column(Name = "LOSInDay", DataType = "Decimal")]
        //public Decimal LOSInDay
        //{
        //    get { return _LOSInDay; }
        //    set { _LOSInDay = value; }
        //}
        //[Column(Name = "LOSInHour", DataType = "Decimal")]
        //public Decimal LOSInHour
        //{
        //    get { return _LOSInHour; }
        //    set { _LOSInHour = value; }
        //}
        //[Column(Name = "LOSInMinute", DataType = "Decimal")]
        //public Decimal LOSInMinute
        //{
        //    get { return _LOSInMinute; }
        //    set { _LOSInMinute = value; }
        //}
        //[Column(Name = "GCCustomerType", DataType = "String")]
        //public String GCCustomerType
        //{
        //    get { return _GCCustomerType; }
        //    set { _GCCustomerType = value; }
        //}
        //[Column(Name = "CustomerType", DataType = "String")]
        //public String CustomerType
        //{
        //    get { return _CustomerType; }
        //    set { _CustomerType = value; }
        //}
        //[Column(Name = "BusinessPartnerID", DataType = "Int32")]
        //public Int32 BusinessPartnerID
        //{
        //    get { return _BusinessPartnerID; }
        //    set { _BusinessPartnerID = value; }
        //}
        //[Column(Name = "BusinessPartnerCode", DataType = "String")]
        //public String BusinessPartnerCode
        //{
        //    get { return _BusinessPartnerCode; }
        //    set { _BusinessPartnerCode = value; }
        //}
        //[Column(Name = "BusinessPartnerName", DataType = "String")]
        //public String BusinessPartnerName
        //{
        //    get { return _BusinessPartnerName; }
        //    set { _BusinessPartnerName = value; }
        //}
        //[Column(Name = "GCPatientCategory", DataType = "String")]
        //public String GCPatientCategory
        //{
        //    get { return _GCPatientCategory; }
        //    set { _GCPatientCategory = value; }
        //}
        //[Column(Name = "PatientCategory", DataType = "String")]
        //public String PatientCategory
        //{
        //    get { return _PatientCategory; }
        //    set { _PatientCategory = value; }
        //}
        //[Column(Name = "GCTriage", DataType = "String")]
        //public String GCTriage
        //{
        //    get { return _GCTriage; }
        //    set { _GCTriage = value; }
        //}
        //[Column(Name = "Triage", DataType = "String")]
        //public String Triage
        //{
        //    get { return _Triage; }
        //    set { _Triage = value; }
        //}
        //[Column(Name = "MedicalNo", DataType = "String")]
        //public String MedicalNo
        //{
        //    get { return _MedicalNo; }
        //    set { _MedicalNo = value; }
        //}
        //[Column(Name = "Education", DataType = "String")]
        //public String Education
        //{
        //    get { return _Education; }
        //    set { _Education = value; }
        //}
        //[Column(Name = "Occupation", DataType = "String")]
        //public String Occupation
        //{
        //    get { return _Occupation; }
        //    set { _Occupation = value; }
        //}
        //[Column(Name = "DateOfBirth", DataType = "DateTime")]
        //public DateTime DateOfBirth
        //{
        //    get { return _DateOfBirth; }
        //    set { _DateOfBirth = value; }
        //}
        //[Column(Name = "GCSex", DataType = "String")]
        //public String GCSex
        //{
        //    get { return _GCSex; }
        //    set { _GCSex = value; }
        //}
        //[Column(Name = "Sex", DataType = "String")]
        //public String Sex
        //{
        //    get { return _Sex; }
        //    set { _Sex = value; }
        //}
        //[Column(Name = "GCGender", DataType = "String")]
        //public String GCGender
        //{
        //    get { return _GCGender; }
        //    set { _GCGender = value; }
        //}
        //[Column(Name = "Gender", DataType = "String")]
        //public String Gender
        //{
        //    get { return _Gender; }
        //    set { _Gender = value; }
        //}
        //[Column(Name = "ZipCode", DataType = "String")]
        //public String ZipCode
        //{
        //    get { return _ZipCode; }
        //    set { _ZipCode = value; }
        //}
    }
    #endregion

    #region vPivotOutpatientPayment
    [Serializable]
    [Table(Name = "vPivotOutpatientPayment")]
    public partial class vPivotOutpatientPayment : Registration
    {
        private String _ParamedicCode;
        private String _ParamedicName;
        private String _NoSEP;
        private Decimal _ServiceAmount;
        private Decimal _DrugSuppliesAmount;
        private Decimal _PharmacyAmount;
        private Decimal _LaboratoryAmount;
        private Decimal _OtherDiagnosticAmount;
        private Decimal _CashAmount;
        private Decimal _DebitCardAmount;
        private Decimal _FinalDiscount;
        private Decimal _CreditCardAmount;
        private Decimal _PersonalARAmount;
        private Decimal _PayerARAmount;
        private Decimal _BillingTransferAmount;
        private Decimal _RoundingAmount;
        private Decimal _TransactionAmount;
        private Decimal _PaymentAmount;
        private Decimal _OutstandingAmount;

        [Column(Name = "ParamedicCode", DataType = "String")]
        public String ParamedicCode
        {
            get { return _ParamedicCode; }
            set { _ParamedicCode = value; }
        }
        [Column(Name = "ParamedicName", DataType = "String")]
        public String ParamedicName
        {
            get { return _ParamedicName; }
            set { _ParamedicName = value; }
        }

        [Column(Name = "ServiceAmount", DataType = "Decimal")]
        public Decimal ServiceAmount
        {
            get { return _ServiceAmount; }
            set { _ServiceAmount = value; }
        }

        [Column(Name = "DrugSuppliesAmount", DataType = "Decimal")]
        public Decimal DrugSuppliesAmount
        {
            get { return _DrugSuppliesAmount; }
            set { _DrugSuppliesAmount = value; }
        }

        [Column(Name = "PharmacyAmount", DataType = "Decimal")]
        public Decimal PharmacyAmount
        {
            get { return _PharmacyAmount; }
            set { _PharmacyAmount = value; }
        }

        [Column(Name = "LaboratoryAmount", DataType = "Decimal")]
        public Decimal LaboratoryAmount
        {
            get { return _LaboratoryAmount; }
            set { _LaboratoryAmount = value; }
        }

        [Column(Name = "OtherDiagnosticAmount", DataType = "Decimal")]
        public Decimal OtherDiagnosticAmount
        {
            get { return _OtherDiagnosticAmount; }
            set { _OtherDiagnosticAmount = value; }
        }

        [Column(Name = "CashAmount", DataType = "Decimal")]
        public Decimal CashAmount
        {
            get { return _CashAmount; }
            set { _CashAmount = value; }
        }

        [Column(Name = "DebitCardAmount", DataType = "Decimal")]
        public Decimal DebitCardAmount
        {
            get { return _DebitCardAmount; }
            set { _DebitCardAmount = value; }
        }

        [Column(Name = "CreditCardAmount", DataType = "Decimal")]
        public Decimal CreditCardAmount
        {
            get { return _CreditCardAmount; }
            set { _CreditCardAmount = value; }
        }

        [Column(Name = "FinalDiscount", DataType = "Decimal")]
        public Decimal FinalDiscount
        {
            get { return _FinalDiscount; }
            set { _FinalDiscount = value; }
        }

        [Column(Name = "PersonalARAmount", DataType = "Decimal")]
        public Decimal PersonalARAmount
        {
            get { return _PersonalARAmount; }
            set { _PersonalARAmount = value; }
        }
        [Column(Name = "RoundingAmount", DataType = "Decimal")]
        public Decimal RoundingAmount
        {
            get { return _RoundingAmount; }
            set { _RoundingAmount = value; }
        }
        [Column(Name = "PayerARAmount", DataType = "Decimal")]
        public Decimal PayerARAmount
        {
            get { return _PayerARAmount; }
            set { _PayerARAmount = value; }
        }

        [Column(Name = "BillingTransferAmount", DataType = "Decimal")]
        public Decimal BillingTransferAmount
        {
            get { return _BillingTransferAmount; }
            set { _BillingTransferAmount = value; }
        }

        [Column(Name = "TransactionAmount", DataType = "Decimal")]
        public Decimal TransactionAmount
        {
            get { return _TransactionAmount; }
            set { _TransactionAmount = value; }
        }

        [Column(Name = "PaymentAmount", DataType = "Decimal")]
        public Decimal PaymentAmount
        {
            get { return _PaymentAmount; }
            set { _PaymentAmount = value; }
        }

        [Column(Name = "OutstandingAmount", DataType = "Decimal")]
        public Decimal OutstandingAmount
        {
            get { return _OutstandingAmount; }
            set { _OutstandingAmount = value; }
        }
        [Column(Name = "NoSEP", DataType = "String")]
        public String NoSEP
        {
            get { return _NoSEP; }
            set { _NoSEP = value; }
        }
        public string RegistrationDateInString
        {
            get { return RegistrationDate.ToString("dd-MMM-yyyy"); }
        }
    }
    #endregion
    #region vPivotInpatientPayment
    [Serializable]
    [Table(Name = "vPivotInpatientPayment")]
    public partial class vPivotInpatientPayment : Registration
    {
        private DateTime _DischargeDate;
        private String _ParamedicCode;
        private String _ParamedicName;
        private Decimal _ServiceAmount;
        private Decimal _DrugSuppliesAmount;
        private Decimal _PharmacyAmount;
        private Decimal _LogisticAmount;
        private Decimal _LaboratoryAmount;
        private Decimal _OtherDiagnosticAmount;
        private Decimal _DownPaymentAmount;
        private Decimal _CashAmount;
        private Decimal _DebitCardAmount;
        private Decimal _CreditCardAmount;
        private Decimal _BankTransferAmount;
        private Decimal _PersonalARAmount;
        private Decimal _PayerARAmount;
        private Decimal _RoundingAmount;
        private String _NoSEP;
        private Decimal _TransactionAmount;
        private Decimal _PaymentAmount;
        private Decimal _OutstandingAmount;

        [Column(Name = "DischargeDate", DataType = "DateTime")]
        public DateTime DischargeDate
        {
            get { return _DischargeDate; }
            set { _DischargeDate = value; }
        }
        [Column(Name = "ParamedicCode", DataType = "String")]
        public String ParamedicCode
        {
            get { return _ParamedicCode; }
            set { _ParamedicCode = value; }
        }
        [Column(Name = "ParamedicName", DataType = "String")]
        public String ParamedicName
        {
            get { return _ParamedicName; }
            set { _ParamedicName = value; }
        }

        [Column(Name = "ServiceAmount", DataType = "Decimal")]
        public Decimal ServiceAmount
        {
            get { return _ServiceAmount; }
            set { _ServiceAmount = value; }
        }

        [Column(Name = "DrugSuppliesAmount", DataType = "Decimal")]
        public Decimal DrugSuppliesAmount
        {
            get { return _DrugSuppliesAmount; }
            set { _DrugSuppliesAmount = value; }
        }

        [Column(Name = "PharmacyAmount", DataType = "Decimal")]
        public Decimal PharmacyAmount
        {
            get { return _PharmacyAmount; }
            set { _PharmacyAmount = value; }
        }

        [Column(Name = "LogisticAmount", DataType = "Decimal")]
        public Decimal LogisticAmount
        {
            get { return _LogisticAmount; }
            set { _LogisticAmount = value; }
        }

        [Column(Name = "LaboratoryAmount", DataType = "Decimal")]
        public Decimal LaboratoryAmount
        {
            get { return _LaboratoryAmount; }
            set { _LaboratoryAmount = value; }
        }

        [Column(Name = "OtherDiagnosticAmount", DataType = "Decimal")]
        public Decimal OtherDiagnosticAmount
        {
            get { return _OtherDiagnosticAmount; }
            set { _OtherDiagnosticAmount = value; }
        }

        [Column(Name = "DownPaymentAmount", DataType = "Decimal")]
        public Decimal DownPaymentAmount
        {
            get { return _DownPaymentAmount; }
            set { _DownPaymentAmount = value; }
        }

        [Column(Name = "CashAmount", DataType = "Decimal")]
        public Decimal CashAmount
        {
            get { return _CashAmount; }
            set { _CashAmount = value; }
        }

        [Column(Name = "DebitCardAmount", DataType = "Decimal")]
        public Decimal DebitCardAmount
        {
            get { return _DebitCardAmount; }
            set { _DebitCardAmount = value; }
        }

        [Column(Name = "CreditCardAmount", DataType = "Decimal")]
        public Decimal CreditCardAmount
        {
            get { return _CreditCardAmount; }
            set { _CreditCardAmount = value; }
        }

        [Column(Name = "BankTransferAmount", DataType = "Decimal")]
        public Decimal BankTransferAmount
        {
            get { return _BankTransferAmount; }
            set { _BankTransferAmount = value; }
        }

        [Column(Name = "PersonalARAmount", DataType = "Decimal")]
        public Decimal PersonalARAmount
        {
            get { return _PersonalARAmount; }
            set { _PersonalARAmount = value; }
        }
        [Column(Name = "RoundingAmount", DataType = "Decimal")]
        public Decimal RoundingAmount
        {
            get { return _RoundingAmount; }
            set { _RoundingAmount = value; }
        }
        [Column(Name = "PayerARAmount", DataType = "Decimal")]
        public Decimal PayerARAmount
        {
            get { return _PayerARAmount; }
            set { _PayerARAmount = value; }
        }

        [Column(Name = "NoSEP", DataType = "String")]
        public String NoSEP
        {
            get { return _NoSEP; }
            set { _NoSEP = value; }
        }

        [Column(Name = "TransactionAmount", DataType = "Decimal")]
        public Decimal TransactionAmount
        {
            get { return _TransactionAmount; }
            set { _TransactionAmount = value; }
        }

        [Column(Name = "PaymentAmount", DataType = "Decimal")]
        public Decimal PaymentAmount
        {
            get { return _PaymentAmount; }
            set { _PaymentAmount = value; }
        }

        [Column(Name = "OutstandingAmount", DataType = "Decimal")]
        public Decimal OutstandingAmount
        {
            get { return _OutstandingAmount; }
            set { _OutstandingAmount = value; }
        }
        //[Column(Name = "LastUpdatedBy", DataType = "String")]
        //public String LastUpdatedBy
        //{
        //    get { return _LastUpdatedBy; }
        //    set { _LastUpdatedBy = value; }
        //}

        public string RegistrationDateInString
        {
            get { return RegistrationDate.ToString("dd-MMM-yyyy"); }
        }
        public string DischargeDateInString
        {
            get { return DischargeDate.ToString("dd-MMM-yyyy"); }
        }
    }
    #endregion
    #region vPivotOutpatientTrx
    [Serializable]
    [Table(Name = "vPivotOutpatientTrx")]
    public partial class vPivotOutpatientTrx : Registration
    {
        private String _Shift;
        private String _TransactionNo;
        private String _ItemCode;
        private String _ItemName;
        private String _ItemGroupCode;
        private String _ItemGroupName;
        private String _TransactionType;
        private Decimal _TariffComp1;
        private Decimal _TariffComp2;
        private Decimal _TariffComp3;
        private Decimal _TariffComp4;
        private Decimal _Discount1;
        private Decimal _Discount2;
        private Decimal _Discount3;
        private Decimal _Discount4;
        private Decimal _CitoAmount;
        private Decimal _CompAmount;
        private String _LastUpdatedBy;

        [Column(Name = "Shift", DataType = "String")]
        public String Shift
        {
            get { return _Shift; }
            set { _Shift = value; }
        }

        [Column(Name = "TransactionNo", DataType = "String")]
        public String TransactionNo
        {
            get { return _TransactionNo; }
            set { _TransactionNo = value; }
        }

        [Column(Name = "ItemCode", DataType = "String")]
        public String ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }

        [Column(Name = "ItemName", DataType = "String")]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [Column(Name = "ItemGroupCode", DataType = "String")]
        public String ItemGroupCode
        {
            get { return _ItemGroupCode; }
            set { _ItemGroupCode = value; }
        }

        [Column(Name = "ItemGroupName", DataType = "String")]
        public String ItemGroupName
        {
            get { return _ItemGroupName; }
            set { _ItemGroupName = value; }
        }

        [Column(Name = "TransactionType", DataType = "String")]
        public String TransactionType
        {
            get { return _TransactionType; }
            set { _TransactionType = value; }
        }

        [Column(Name = "TariffComp1", DataType = "Decimal")]
        public Decimal TariffComp1
        {
            get { return _TariffComp1; }
            set { _TariffComp1 = value; }
        }

        [Column(Name = "TariffComp2", DataType = "Decimal")]
        public Decimal TariffComp2
        {
            get { return _TariffComp2; }
            set { _TariffComp2 = value; }
        }

        [Column(Name = "TariffComp3", DataType = "Decimal")]
        public Decimal TariffComp3
        {
            get { return _TariffComp3; }
            set { _TariffComp3 = value; }
        }

        [Column(Name = "TariffComp4", DataType = "Decimal")]
        public Decimal TariffComp4
        {
            get { return _TariffComp4; }
            set { _TariffComp4 = value; }
        }

        [Column(Name = "Discount1", DataType = "Decimal")]
        public Decimal Discount1
        {
            get { return _Discount1; }
            set { _Discount1 = value; }
        }

        [Column(Name = "Discount2", DataType = "Decimal")]
        public Decimal Discount2
        {
            get { return _Discount2; }
            set { _Discount2 = value; }
        }

        [Column(Name = "Discount3", DataType = "Decimal")]
        public Decimal Discount3
        {
            get { return _Discount3; }
            set { _Discount3 = value; }
        }

        [Column(Name = "Discount4", DataType = "Decimal")]
        public Decimal Discount4
        {
            get { return _Discount4; }
            set { _Discount4 = value; }
        }

        [Column(Name = "CitoAmount", DataType = "Decimal")]
        public Decimal CitoAmount
        {
            get { return _CitoAmount; }
            set { _CitoAmount = value; }
        }

        [Column(Name = "CompAmount", DataType = "Decimal")]
        public Decimal CompAmount
        {
            get { return _CompAmount; }
            set { _CompAmount = value; }
        }

        [Column(Name = "LastUpdatedBy", DataType = "String")]
        public String LastUpdatedBy
        {
            get { return _LastUpdatedBy; }
            set { _LastUpdatedBy = value; }
        }


        public Decimal TransactionAmount
        {
            get { return _TariffComp1+_TariffComp2+_TariffComp3+_TariffComp4; }
        }
        public Decimal DiscountAmount
        {
            get { return _Discount1 + _Discount2 + _Discount3 + _Discount4; }
        }
        public Decimal NettAmount
        {
            get { return TransactionAmount - DiscountAmount;  }
        }

        //[Column(Name = "VisitTypeName", DataType = "String")]
        //public String VisitTypeName
        //{
        //    get { return _VisitTypeName; }
        //    set { _VisitTypeName = value; }
        //}
        //[Column(Name = "GCVisitReason", DataType = "String")]
        //public String GCVisitReason
        //{
        //    get { return _GCVisitReason; }
        //    set { _GCVisitReason = value; }
        //}
        //[Column(Name = "VisitReason", DataType = "String")]
        //public String VisitReason
        //{
        //    get { return _VisitReason; }
        //    set { _VisitReason = value; }
        //}
        //[Column(Name = "DischargeDate", DataType = "DateTime")]
        //public DateTime DischargeDate
        //{
        //    get { return _DischargeDate; }
        //    set { _DischargeDate = value; }
        //}
        //[Column(Name = "DischargeTime", DataType = "String")]
        //public String DischargeTime
        //{
        //    get { return _DischargeTime; }
        //    set { _DischargeTime = value; }
        //}
        //[Column(Name = "GCVisitStatus", DataType = "String")]
        //public String GCVisitStatus
        //{
        //    get { return _GCVisitStatus; }
        //    set { _GCVisitStatus = value; }
        //}
        //[Column(Name = "GCRegistrationStatus", DataType = "String")]
        //public String GCRegistrationStatus
        //{
        //    get { return _GCRegistrationStatus; }
        //    set { _GCRegistrationStatus = value; }
        //}
        //[Column(Name = "RegistrationStatus", DataType = "String")]
        //public String RegistrationStatus
        //{
        //    get { return _RegistrationStatus; }
        //    set { _RegistrationStatus = value; }
        //}
        //[Column(Name = "IsMainVisit", DataType = "Boolean")]
        //public Boolean IsMainVisit
        //{
        //    get { return _IsMainVisit; }
        //    set { _IsMainVisit = value; }
        //}
        //[Column(Name = "GCAdmissionCondition", DataType = "String")]
        //public String GCAdmissionCondition
        //{
        //    get { return _GCAdmissionCondition; }
        //    set { _GCAdmissionCondition = value; }
        //}
        //[Column(Name = "AdmissionCondition", DataType = "String")]
        //public String AdmissionCondition
        //{
        //    get { return _AdmissionCondition; }
        //    set { _AdmissionCondition = value; }
        //}
        //[Column(Name = "IsNewBorn", DataType = "Boolean")]
        //public Boolean IsNewBorn
        //{
        //    get { return _IsNewBorn; }
        //    set { _IsNewBorn = value; }
        //}
        //[Column(Name = "IsParturition", DataType = "Boolean")]
        //public Boolean IsParturition
        //{
        //    get { return _IsParturition; }
        //    set { _IsParturition = value; }
        //}
        //[Column(Name = "ReferrerName", DataType = "String")]
        //public String ReferrerName
        //{
        //    get { return _ReferrerName; }
        //    set { _ReferrerName = value; }
        //}
        //[Column(Name = "GCDischargeCondition", DataType = "String")]
        //public String GCDischargeCondition
        //{
        //    get { return _GCDischargeCondition; }
        //    set { _GCDischargeCondition = value; }
        //}
        //[Column(Name = "DischargeCondition", DataType = "String")]
        //public String DischargeCondition
        //{
        //    get { return _DischargeCondition; }
        //    set { _DischargeCondition = value; }
        //}
        //[Column(Name = "GCDischargeMethod", DataType = "String")]
        //public String GCDischargeMethod
        //{
        //    get { return _GCDischargeMethod; }
        //    set { _GCDischargeMethod = value; }
        //}
        //[Column(Name = "DischargeMethod", DataType = "String")]
        //public String DischargeMethod
        //{
        //    get { return _DischargeMethod; }
        //    set { _DischargeMethod = value; }
        //}
        //[Column(Name = "LOSInDay", DataType = "Decimal")]
        //public Decimal LOSInDay
        //{
        //    get { return _LOSInDay; }
        //    set { _LOSInDay = value; }
        //}
        //[Column(Name = "LOSInHour", DataType = "Decimal")]
        //public Decimal LOSInHour
        //{
        //    get { return _LOSInHour; }
        //    set { _LOSInHour = value; }
        //}
        //[Column(Name = "LOSInMinute", DataType = "Decimal")]
        //public Decimal LOSInMinute
        //{
        //    get { return _LOSInMinute; }
        //    set { _LOSInMinute = value; }
        //}
        //[Column(Name = "GCCustomerType", DataType = "String")]
        //public String GCCustomerType
        //{
        //    get { return _GCCustomerType; }
        //    set { _GCCustomerType = value; }
        //}
        //[Column(Name = "CustomerType", DataType = "String")]
        //public String CustomerType
        //{
        //    get { return _CustomerType; }
        //    set { _CustomerType = value; }
        //}
        //[Column(Name = "BusinessPartnerID", DataType = "Int32")]
        //public Int32 BusinessPartnerID
        //{
        //    get { return _BusinessPartnerID; }
        //    set { _BusinessPartnerID = value; }
        //}
        //[Column(Name = "BusinessPartnerCode", DataType = "String")]
        //public String BusinessPartnerCode
        //{
        //    get { return _BusinessPartnerCode; }
        //    set { _BusinessPartnerCode = value; }
        //}
        //[Column(Name = "BusinessPartnerName", DataType = "String")]
        //public String BusinessPartnerName
        //{
        //    get { return _BusinessPartnerName; }
        //    set { _BusinessPartnerName = value; }
        //}
        //[Column(Name = "GCPatientCategory", DataType = "String")]
        //public String GCPatientCategory
        //{
        //    get { return _GCPatientCategory; }
        //    set { _GCPatientCategory = value; }
        //}
        //[Column(Name = "PatientCategory", DataType = "String")]
        //public String PatientCategory
        //{
        //    get { return _PatientCategory; }
        //    set { _PatientCategory = value; }
        //}
        //[Column(Name = "GCTriage", DataType = "String")]
        //public String GCTriage
        //{
        //    get { return _GCTriage; }
        //    set { _GCTriage = value; }
        //}
        //[Column(Name = "Triage", DataType = "String")]
        //public String Triage
        //{
        //    get { return _Triage; }
        //    set { _Triage = value; }
        //}
        //[Column(Name = "MedicalNo", DataType = "String")]
        //public String MedicalNo
        //{
        //    get { return _MedicalNo; }
        //    set { _MedicalNo = value; }
        //}
        //[Column(Name = "Education", DataType = "String")]
        //public String Education
        //{
        //    get { return _Education; }
        //    set { _Education = value; }
        //}
        //[Column(Name = "Occupation", DataType = "String")]
        //public String Occupation
        //{
        //    get { return _Occupation; }
        //    set { _Occupation = value; }
        //}
        //[Column(Name = "DateOfBirth", DataType = "DateTime")]
        //public DateTime DateOfBirth
        //{
        //    get { return _DateOfBirth; }
        //    set { _DateOfBirth = value; }
        //}
        //[Column(Name = "GCSex", DataType = "String")]
        //public String GCSex
        //{
        //    get { return _GCSex; }
        //    set { _GCSex = value; }
        //}
        //[Column(Name = "Sex", DataType = "String")]
        //public String Sex
        //{
        //    get { return _Sex; }
        //    set { _Sex = value; }
        //}
        //[Column(Name = "GCGender", DataType = "String")]
        //public String GCGender
        //{
        //    get { return _GCGender; }
        //    set { _GCGender = value; }
        //}
        //[Column(Name = "Gender", DataType = "String")]
        //public String Gender
        //{
        //    get { return _Gender; }
        //    set { _Gender = value; }
        //}
        //[Column(Name = "ZipCode", DataType = "String")]
        //public String ZipCode
        //{
        //    get { return _ZipCode; }
        //    set { _ZipCode = value; }
        //}
    }
    #endregion

    #region Revenue Pivot
    /// <summary>
    /// Pendapatan Rawat Inap
    /// </summary>
    #region vPivotInpatientRevenue
    [Serializable]
    [Table(Name = "vPivotInpatientRevenue")]
    public partial class vPivotInpatientRevenue : Revenue
    {
        private String _LinkRegistrationNo;
        [Column(Name = "LinkRegistrationNo", DataType = "String")]
        public String LinkRegistrationNo
        {
            get { return _LinkRegistrationNo; }
            set { _LinkRegistrationNo = value; }
        }
    }
    #endregion

    /// <summary>
    /// Pendapatan Rawat Inap
    /// </summary>
    #region vPivotOutpatientRevenue
    [Serializable]
    [Table(Name = "vPivotOutpatientRevenue")]
    public partial class vPivotOutpatientRevenue : Revenue
    {
        private String _LinkRegistrationNo;
        [Column(Name = "LinkRegistrationNo", DataType = "String")]
        public String LinkRegistrationNo
        {
            get { return _LinkRegistrationNo; }
            set { _LinkRegistrationNo = value; }
        }
    }
    #endregion

    /// <summary>
    /// Pendapatan Rawat Darurat
    /// </summary>
    #region vPivotEmergencyRevenue
    [Serializable]
    [Table(Name = "vPivotEmergencyRevenue")]
    public partial class vPivotEmergencyRevenue : Revenue
    {
        private String _LinkRegistrationNo;
        [Column(Name = "LinkRegistrationNo", DataType = "String")]
        public String LinkRegistrationNo
        {
            get { return _LinkRegistrationNo; }
            set { _LinkRegistrationNo = value; }
        }
    }
    #endregion

    /// <summary>
    /// Pendapatan per Departemen
    /// </summary>
    #region vPivotRevenue
    [Serializable]
    [Table(Name = "vPivotRevenue")]
    public partial class vPivotRevenue : Registration
    {
        private String _TransactionNo;
        private DateTime _TransactionDate;
        private String _ItemCode;
        private String _ItemName;
        private String _ItemGroupCode;
        private String _ItemGroupName;
        private Decimal _TariffComp1;
        private Decimal _TariffComp2;
        private Decimal _TariffComp3;
        private Decimal _TariffComp4;
        private Decimal _Discount1;
        private Decimal _Discount2;
        private Decimal _Discount3;
        private Decimal _Discount4;
        private Decimal _CitoAmount;
        private Decimal _CompAmount;
        private Decimal _PatientAmount;
        private Decimal _PayerAmount;
        private Decimal _Physician_100_0;
        private Decimal _Physician_83_17;
        private Decimal _Physician_80_20;
        private Decimal _Physician_75_25;
        private Decimal _Physician_70_30;
        private Decimal _Physician_60_40;
        private Decimal _Physician_50_50;
        private Decimal _Physician_40_60;
        private Decimal _Physician_30_70;
        private Decimal _Physician_25_75;
        private Decimal _Hospital_100_0;
        private Decimal _Hospital_83_17;
        private Decimal _Hospital_80_20;
        private Decimal _Hospital_75_25;
        private Decimal _Hospital_70_30;
        private Decimal _Hospital_60_40;
        private Decimal _Hospital_50_50;
        private Decimal _Hospital_40_60;
        private Decimal _Hospital_30_70;
        private Decimal _Hospital_25_75;

        [Column(Name = "TransactionNo", DataType = "String")]
        public String TransactionNo
        {
            get { return _TransactionNo; }
            set { _TransactionNo = value; }
        }
        [Column(Name = "TransactionDate", DataType = "DateTime")]
        public DateTime TransactionDate
        {
            get { return _TransactionDate; }
            set { _TransactionDate = value; }
        }
        [Column(Name = "ItemCode", DataType = "String")]
        public String ItemCode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }

        [Column(Name = "ItemName", DataType = "String")]
        public String ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        [Column(Name = "ItemGroupCode", DataType = "String")]
        public String ItemGroupCode
        {
            get { return _ItemGroupCode; }
            set { _ItemGroupCode = value; }
        }

        [Column(Name = "ItemGroupName", DataType = "String")]
        public String ItemGroupName
        {
            get { return _ItemGroupName; }
            set { _ItemGroupName = value; }
        }

        [Column(Name = "TariffComp1", DataType = "Decimal")]
        public Decimal TariffComp1
        {
            get { return _TariffComp1; }
            set { _TariffComp1 = value; }
        }

        [Column(Name = "TariffComp2", DataType = "Decimal")]
        public Decimal TariffComp2
        {
            get { return _TariffComp2; }
            set { _TariffComp2 = value; }
        }

        [Column(Name = "TariffComp3", DataType = "Decimal")]
        public Decimal TariffComp3
        {
            get { return _TariffComp3; }
            set { _TariffComp3 = value; }
        }

        [Column(Name = "TariffComp4", DataType = "Decimal")]
        public Decimal TariffComp4
        {
            get { return _TariffComp4; }
            set { _TariffComp4 = value; }
        }

        [Column(Name = "Discount1", DataType = "Decimal")]
        public Decimal Discount1
        {
            get { return _Discount1; }
            set { _Discount1 = value; }
        }

        [Column(Name = "Discount2", DataType = "Decimal")]
        public Decimal Discount2
        {
            get { return _Discount2; }
            set { _Discount2 = value; }
        }

        [Column(Name = "Discount3", DataType = "Decimal")]
        public Decimal Discount3
        {
            get { return _Discount3; }
            set { _Discount3 = value; }
        }

        [Column(Name = "Discount4", DataType = "Decimal")]
        public Decimal Discount4
        {
            get { return _Discount4; }
            set { _Discount4 = value; }
        }

        [Column(Name = "CitoAmount", DataType = "Decimal")]
        public Decimal CitoAmount
        {
            get { return _CitoAmount; }
            set { _CitoAmount = value; }
        }

        [Column(Name = "CompAmount", DataType = "Decimal")]
        public Decimal CompAmount
        {
            get { return _CompAmount; }
            set { _CompAmount = value; }
        }

        [Column(Name = "PatientAmount", DataType = "Decimal")]
        public Decimal PatientAmount
        {
            get { return _PatientAmount; }
            set { _PatientAmount = value; }
        }

        [Column(Name = "PayerAmount", DataType = "Decimal")]
        public Decimal PayerAmount
        {
            get { return _PayerAmount; }
            set { _PayerAmount = value; }
        }

        [Column(Name = "Physician_100_0", DataType = "Decimal")]
        public Decimal Physician_100_0
        {
            get { return _Physician_100_0; }
            set { _Physician_100_0 = value; }
        }

        [Column(Name = "Physician_83_17", DataType = "Decimal")]
        public Decimal Physician_83_17
        {
            get { return _Physician_83_17; }
            set { _Physician_83_17 = value; }
        }

        [Column(Name = "Physician_80_20", DataType = "Decimal")]
        public Decimal Physician_80_20
        {
            get { return _Physician_80_20; }
            set { _Physician_80_20 = value; }
        }

        [Column(Name = "Physician_75_25", DataType = "Decimal")]
        public Decimal Physician_75_25
        {
            get { return _Physician_75_25; }
            set { _Physician_75_25 = value; }
        }
        [Column(Name = "Physician_70_30", DataType = "Decimal")]
        public Decimal Physician_70_30
        {
            get { return _Physician_70_30; }
            set { _Physician_70_30 = value; }
        }
        [Column(Name = "Physician_60_40", DataType = "Decimal")]
        public Decimal Physician_60_40
        {
            get { return _Physician_60_40; }
            set { _Physician_60_40 = value; }
        }
        [Column(Name = "Physician_50_50", DataType = "Decimal")]
        public Decimal Physician_50_50
        {
            get { return _Physician_50_50; }
            set { _Physician_50_50 = value; }
        }
        [Column(Name = "Physician_40_60", DataType = "Decimal")]
        public Decimal Physician_40_60
        {
            get { return _Physician_40_60; }
            set { _Physician_40_60 = value; }
        }
        [Column(Name = "Physician_30_70", DataType = "Decimal")]
        public Decimal Physician_30_70
        {
            get { return _Physician_30_70; }
            set { _Physician_30_70 = value; }
        }
        [Column(Name = "Physician_25_75", DataType = "Decimal")]
        public Decimal Physician_25_75
        {
            get { return _Physician_25_75; }
            set { _Physician_25_75 = value; }
        }
        [Column(Name = "Hospital_100_0", DataType = "Decimal")]
        public Decimal Hospital_100_0
        {
            get { return _Hospital_100_0; }
            set { _Hospital_100_0 = value; }
        }
        [Column(Name = "Hospital_83_17", DataType = "Decimal")]
        public Decimal Hospital_83_17
        {
            get { return _Hospital_83_17; }
            set { _Hospital_83_17 = value; }
        }
        [Column(Name = "Hospital_80_20", DataType = "Decimal")]
        public Decimal Hospital_80_20
        {
            get { return _Hospital_80_20; }
            set { _Hospital_80_20 = value; }
        }
        [Column(Name = "Hospital_75_25", DataType = "Decimal")]
        public Decimal Hospital_75_25
        {
            get { return _Hospital_75_25; }
            set { _Hospital_75_25 = value; }
        }
        [Column(Name = "Hospital_70_30", DataType = "Decimal")]
        public Decimal Hospital_70_30
        {
            get { return _Hospital_70_30; }
            set { _Hospital_70_30 = value; }
        }
        [Column(Name = "Hospital_60_40", DataType = "Decimal")]
        public Decimal Hospital_60_40
        {
            get { return _Hospital_60_40; }
            set { _Hospital_60_40 = value; }
        }
        [Column(Name = "Hospital_50_50", DataType = "Decimal")]
        public Decimal Hospital_50_50
        {
            get { return _Hospital_50_50; }
            set { _Hospital_50_50 = value; }
        }
        [Column(Name = "Hospital_40_60", DataType = "Decimal")]
        public Decimal Hospital_40_60
        {
            get { return _Hospital_40_60; }
            set { _Hospital_40_60 = value; }
        }
        [Column(Name = "Hospital_30_70", DataType = "Decimal")]
        public Decimal Hospital_30_70
        {
            get { return _Hospital_30_70; }
            set { _Hospital_30_70 = value; }
        }
        [Column(Name = "Hospital_25_75", DataType = "Decimal")]
        public Decimal Hospital_25_75
        {
            get { return _Hospital_25_75; }
            set { _Hospital_25_75 = value; }
        }
        //[Column(Name = "LastUpdatedBy", DataType = "String")]
        //public String LastUpdatedBy
        //{
        //    get { return _LastUpdatedBy; }
        //    set { _LastUpdatedBy = value; }
        //}


        public Decimal TransactionAmount
        {
            get { return _TariffComp1 + _TariffComp2 + _TariffComp3 + _TariffComp4; }
        }
        public Decimal DiscountAmount
        {
            get { return _Discount1 + _Discount2 + _Discount3 + _Discount4; }
        }
        public Decimal NettAmount
        {
            get { return TransactionAmount - DiscountAmount; }
        }

        public string TransactionDateInString
        {
            get { return TransactionDate.ToString("dd-MMM-yyyy"); }
        }


        //[Column(Name = "VisitTypeName", DataType = "String")]
        //public String VisitTypeName
        //{
        //    get { return _VisitTypeName; }
        //    set { _VisitTypeName = value; }
        //}
        //[Column(Name = "GCVisitReason", DataType = "String")]
        //public String GCVisitReason
        //{
        //    get { return _GCVisitReason; }
        //    set { _GCVisitReason = value; }
        //}
        //[Column(Name = "VisitReason", DataType = "String")]
        //public String VisitReason
        //{
        //    get { return _VisitReason; }
        //    set { _VisitReason = value; }
        //}
        //[Column(Name = "DischargeDate", DataType = "DateTime")]
        //public DateTime DischargeDate
        //{
        //    get { return _DischargeDate; }
        //    set { _DischargeDate = value; }
        //}
        //[Column(Name = "DischargeTime", DataType = "String")]
        //public String DischargeTime
        //{
        //    get { return _DischargeTime; }
        //    set { _DischargeTime = value; }
        //}
        //[Column(Name = "GCVisitStatus", DataType = "String")]
        //public String GCVisitStatus
        //{
        //    get { return _GCVisitStatus; }
        //    set { _GCVisitStatus = value; }
        //}
        //[Column(Name = "GCRegistrationStatus", DataType = "String")]
        //public String GCRegistrationStatus
        //{
        //    get { return _GCRegistrationStatus; }
        //    set { _GCRegistrationStatus = value; }
        //}
        //[Column(Name = "RegistrationStatus", DataType = "String")]
        //public String RegistrationStatus
        //{
        //    get { return _RegistrationStatus; }
        //    set { _RegistrationStatus = value; }
        //}
        //[Column(Name = "IsMainVisit", DataType = "Boolean")]
        //public Boolean IsMainVisit
        //{
        //    get { return _IsMainVisit; }
        //    set { _IsMainVisit = value; }
        //}
        //[Column(Name = "GCAdmissionCondition", DataType = "String")]
        //public String GCAdmissionCondition
        //{
        //    get { return _GCAdmissionCondition; }
        //    set { _GCAdmissionCondition = value; }
        //}
        //[Column(Name = "AdmissionCondition", DataType = "String")]
        //public String AdmissionCondition
        //{
        //    get { return _AdmissionCondition; }
        //    set { _AdmissionCondition = value; }
        //}
        //[Column(Name = "IsNewBorn", DataType = "Boolean")]
        //public Boolean IsNewBorn
        //{
        //    get { return _IsNewBorn; }
        //    set { _IsNewBorn = value; }
        //}
        //[Column(Name = "IsParturition", DataType = "Boolean")]
        //public Boolean IsParturition
        //{
        //    get { return _IsParturition; }
        //    set { _IsParturition = value; }
        //}
        //[Column(Name = "ReferrerName", DataType = "String")]
        //public String ReferrerName
        //{
        //    get { return _ReferrerName; }
        //    set { _ReferrerName = value; }
        //}
        //[Column(Name = "GCDischargeCondition", DataType = "String")]
        //public String GCDischargeCondition
        //{
        //    get { return _GCDischargeCondition; }
        //    set { _GCDischargeCondition = value; }
        //}
        //[Column(Name = "DischargeCondition", DataType = "String")]
        //public String DischargeCondition
        //{
        //    get { return _DischargeCondition; }
        //    set { _DischargeCondition = value; }
        //}
        //[Column(Name = "GCDischargeMethod", DataType = "String")]
        //public String GCDischargeMethod
        //{
        //    get { return _GCDischargeMethod; }
        //    set { _GCDischargeMethod = value; }
        //}
        //[Column(Name = "DischargeMethod", DataType = "String")]
        //public String DischargeMethod
        //{
        //    get { return _DischargeMethod; }
        //    set { _DischargeMethod = value; }
        //}
        //[Column(Name = "LOSInDay", DataType = "Decimal")]
        //public Decimal LOSInDay
        //{
        //    get { return _LOSInDay; }
        //    set { _LOSInDay = value; }
        //}
        //[Column(Name = "LOSInHour", DataType = "Decimal")]
        //public Decimal LOSInHour
        //{
        //    get { return _LOSInHour; }
        //    set { _LOSInHour = value; }
        //}
        //[Column(Name = "LOSInMinute", DataType = "Decimal")]
        //public Decimal LOSInMinute
        //{
        //    get { return _LOSInMinute; }
        //    set { _LOSInMinute = value; }
        //}
        //[Column(Name = "GCCustomerType", DataType = "String")]
        //public String GCCustomerType
        //{
        //    get { return _GCCustomerType; }
        //    set { _GCCustomerType = value; }
        //}
        //[Column(Name = "CustomerType", DataType = "String")]
        //public String CustomerType
        //{
        //    get { return _CustomerType; }
        //    set { _CustomerType = value; }
        //}
        //[Column(Name = "BusinessPartnerID", DataType = "Int32")]
        //public Int32 BusinessPartnerID
        //{
        //    get { return _BusinessPartnerID; }
        //    set { _BusinessPartnerID = value; }
        //}
        //[Column(Name = "BusinessPartnerCode", DataType = "String")]
        //public String BusinessPartnerCode
        //{
        //    get { return _BusinessPartnerCode; }
        //    set { _BusinessPartnerCode = value; }
        //}
        //[Column(Name = "BusinessPartnerName", DataType = "String")]
        //public String BusinessPartnerName
        //{
        //    get { return _BusinessPartnerName; }
        //    set { _BusinessPartnerName = value; }
        //}
        //[Column(Name = "GCPatientCategory", DataType = "String")]
        //public String GCPatientCategory
        //{
        //    get { return _GCPatientCategory; }
        //    set { _GCPatientCategory = value; }
        //}
        //[Column(Name = "PatientCategory", DataType = "String")]
        //public String PatientCategory
        //{
        //    get { return _PatientCategory; }
        //    set { _PatientCategory = value; }
        //}
        //[Column(Name = "GCTriage", DataType = "String")]
        //public String GCTriage
        //{
        //    get { return _GCTriage; }
        //    set { _GCTriage = value; }
        //}
        //[Column(Name = "Triage", DataType = "String")]
        //public String Triage
        //{
        //    get { return _Triage; }
        //    set { _Triage = value; }
        //}
        //[Column(Name = "MedicalNo", DataType = "String")]
        //public String MedicalNo
        //{
        //    get { return _MedicalNo; }
        //    set { _MedicalNo = value; }
        //}
        //[Column(Name = "Education", DataType = "String")]
        //public String Education
        //{
        //    get { return _Education; }
        //    set { _Education = value; }
        //}
        //[Column(Name = "Occupation", DataType = "String")]
        //public String Occupation
        //{
        //    get { return _Occupation; }
        //    set { _Occupation = value; }
        //}
        //[Column(Name = "DateOfBirth", DataType = "DateTime")]
        //public DateTime DateOfBirth
        //{
        //    get { return _DateOfBirth; }
        //    set { _DateOfBirth = value; }
        //}
        //[Column(Name = "GCSex", DataType = "String")]
        //public String GCSex
        //{
        //    get { return _GCSex; }
        //    set { _GCSex = value; }
        //}
        //[Column(Name = "Sex", DataType = "String")]
        //public String Sex
        //{
        //    get { return _Sex; }
        //    set { _Sex = value; }
        //}
        //[Column(Name = "GCGender", DataType = "String")]
        //public String GCGender
        //{
        //    get { return _GCGender; }
        //    set { _GCGender = value; }
        //}
        //[Column(Name = "Gender", DataType = "String")]
        //public String Gender
        //{
        //    get { return _Gender; }
        //    set { _Gender = value; }
        //}
        //[Column(Name = "ZipCode", DataType = "String")]
        //public String ZipCode
        //{
        //    get { return _ZipCode; }
        //    set { _ZipCode = value; }
        //}
    }
    #endregion

    /// <summary>
    /// Pendapatan Penunjang Medis
    /// </summary>
    #region vPivotMDRevenue
    [Serializable]
    [Table(Name = "vPivotMDRevenue")]
    public partial class vPivotMDRevenue : MDRevenue
    {
    }
    #endregion

    /// <summary>
    /// Pendapatan Laboratorium
    /// </summary>
    #region vPivotLBRevenue
    [Serializable]
    [Table(Name = "vPivotLBRevenue")]
    public partial class vPivotLBRevenue : MDRevenue
    {
    }
    #endregion
    #endregion
    #region Prescription
    #region vPivotPrescription
    [Serializable]
    [Table(Name = "vPivotPrescription")]
    public partial class vPivotPrescription : Prescription
    {
    }
    #endregion 
    #region vBPJSInpatientPrescription
    [Serializable]
    [Table(Name = "vPivotBPJSInpatientPrescription")]
    public partial class vPivotBPJSInpatientPrescription : Prescription
    {
    }
    #endregion 
    #region vPivotBPJSOutpatientPrescription
    [Serializable]
    [Table(Name = "vPivotBPJSOutpatientPrescription")]
    public partial class vPivotBPJSOutpatientPrescription : Prescription
    {
    }
    #endregion 
    #endregion
}
    