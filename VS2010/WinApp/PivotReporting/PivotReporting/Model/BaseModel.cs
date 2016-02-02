using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QIS.Data.Core.Dal;

namespace PivotReporting.Model
{
    public class Registration
    {
        private String _DepartmentCode;
        private String _DepartmentName;
        private String _ServiceUnitCode;
        private String _ServiceUnitName;
        private String _ChargeClassCode;
        private String _ChargeClassName;
        private String _ParamedicCode;
        private String _ParamedicName;
        private String _RegistrationNo;
        private DateTime _RegistrationDate;
        private DateTime _DischargeDate;
        private String _MedicalNo;
        private String _FirstName;
        private String _LastName;
        private String _PayerType;
        private String _PayerCode;
        private String _PayerName;

        [Column(Name = "DepartmentCode", DataType = "String")]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }
        [Column(Name = "DepartmentName", DataType = "String")]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        [Column(Name = "ServiceUnitCode", DataType = "String")]
        public String ServiceUnitCode
        {
            get { return _ServiceUnitCode; }
            set { _ServiceUnitCode = value; }
        }
        [Column(Name = "ServiceUnitName", DataType = "String")]
        public String ServiceUnitName
        {
            get { return _ServiceUnitName; }
            set { _ServiceUnitName = value; }
        }
        [Column(Name = "ChargeClassCode", DataType = "String")]
        public String ChargeClassCode
        {
            get { return _ChargeClassCode; }
            set { _ChargeClassCode = value; }
        }
        [Column(Name = "ChargeClassName", DataType = "String")]
        public String ChargeClassName
        {
            get { return _ChargeClassName; }
            set { _ChargeClassName = value; }
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
        [Column(Name = "RegistrationNo", DataType = "String")]
        public String RegistrationNo
        {
            get { return _RegistrationNo; }
            set { _RegistrationNo = value; }
        }
        [Column(Name = "RegistrationDate", DataType = "DateTime")]
        public DateTime RegistrationDate
        {
            get { return _RegistrationDate; }
            set { _RegistrationDate = value; }
        }
        [Column(Name = "DischargeDate", DataType = "DateTime")]
        public DateTime DischargeDate
        {
            get { return _DischargeDate; }
            set { _DischargeDate = value; }
        }
        [Column(Name = "MedicalNo", DataType = "String")]
        public String MedicalNo
        {
            get { return _MedicalNo; }
            set { _MedicalNo = value; }
        }
        [Column(Name = "FirstName", DataType = "String")]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        [Column(Name = "LastName", DataType = "String")]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        [Column(Name = "PayerType", DataType = "String")]
        public String PayerType
        {
            get { return _PayerType; }
            set { _PayerType = value; }
        }
        [Column(Name = "PayerCode", DataType = "String")]
        public String PayerCode
        {
            get { return _PayerCode; }
            set { _PayerCode = value; }
        }
        [Column(Name = "PayerName", DataType = "String")]
        public String PayerName
        {
            get { return _PayerName; }
            set { _PayerName = value; }
        }


        public String MRN
        {
            get { return string.Format("{0} - {1}", _MedicalNo.TrimEnd(), PatientName.TrimEnd()); }
        }

        public string PatientName
        {
            get { return string.Format("{0} {1}", _FirstName.TrimEnd(), _LastName.TrimEnd()); }
        }

        public string DischargeDateInString
        {
            get { return DischargeDate.ToString("dd-MMM-yyyy"); }
        }
    }

    public class Revenue
    {
        private String _DepartmentCode;
        private String _DepartmentName;
        private String _ServiceUnitCode;
        private String _ServiceUnitName;
        private String _ChargeClassCode;
        private String _ChargeClassName;
        private String _ParamedicCode;
        private String _ParamedicName;
        private String _RegistrationNo;
        private String _NoSEP;
        private DateTime _RegistrationDate;
        private DateTime _DischargeDate;
        private String _MedicalNo;
        private String _FirstName;
        private String _LastName;
        private String _PayerType;
        private String _PayerCode;
        private String _PayerName;
        private String _TransactionNo;
        private DateTime _TransactionDate;
        private String _ItemType;
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
        private Decimal _ASKEP_5;

        [Column(Name = "DepartmentCode", DataType = "String")]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }
        [Column(Name = "DepartmentName", DataType = "String")]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        [Column(Name = "ServiceUnitCode", DataType = "String")]
        public String ServiceUnitCode
        {
            get { return _ServiceUnitCode; }
            set { _ServiceUnitCode = value; }
        }
        [Column(Name = "ServiceUnitName", DataType = "String")]
        public String ServiceUnitName
        {
            get { return _ServiceUnitName; }
            set { _ServiceUnitName = value; }
        }
        [Column(Name = "ChargeClassCode", DataType = "String")]
        public String ChargeClassCode
        {
            get { return _ChargeClassCode; }
            set { _ChargeClassCode = value; }
        }
        [Column(Name = "ChargeClassName", DataType = "String")]
        public String ChargeClassName
        {
            get { return _ChargeClassName; }
            set { _ChargeClassName = value; }
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
        [Column(Name = "RegistrationNo", DataType = "String")]
        public String RegistrationNo
        {
            get { return _RegistrationNo; }
            set { _RegistrationNo = value; }
        }
        [Column(Name = "NoSEP", DataType = "String")]
        public String NoSEP
        {
            get { return _NoSEP; }
            set { _NoSEP = value; }
        }
        [Column(Name = "RegistrationDate", DataType = "DateTime")]
        public DateTime RegistrationDate
        {
            get { return _RegistrationDate; }
            set { _RegistrationDate = value; }
        }
        [Column(Name = "DischargeDate", DataType = "DateTime")]
        public DateTime DischargeDate
        {
            get { return _DischargeDate; }
            set { _DischargeDate = value; }
        }
        [Column(Name = "MedicalNo", DataType = "String")]
        public String MedicalNo
        {
            get { return _MedicalNo; }
            set { _MedicalNo = value; }
        }
        [Column(Name = "FirstName", DataType = "String")]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        [Column(Name = "LastName", DataType = "String")]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        [Column(Name = "PayerType", DataType = "String")]
        public String PayerType
        {
            get { return _PayerType; }
            set { _PayerType = value; }
        }
        [Column(Name = "PayerCode", DataType = "String")]
        public String PayerCode
        {
            get { return _PayerCode; }
            set { _PayerCode = value; }
        }
        [Column(Name = "PayerName", DataType = "String")]
        public String PayerName
        {
            get { return _PayerName; }
            set { _PayerName = value; }
        }
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
        [Column(Name = "ItemType", DataType = "String")]
        public String ItemType
        {
            get { return _ItemType; }
            set { _ItemType = value; }
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
        [Column(Name = "ASKEP_5", DataType = "Decimal")]
        public Decimal ASKEP_5
        {
            get { return _ASKEP_5; }
            set { _ASKEP_5 = value; }
        }


        public String MRN
        {
            get { return string.Format("{0} - {1}", _MedicalNo.TrimEnd(), PatientName.TrimEnd()); }
        }

        public string PatientName
        {
            get { return string.Format("{0} {1}", _FirstName.TrimEnd(), _LastName.TrimEnd()); }
        }

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

        public string RegistrationDateInString
        {
            get { return RegistrationDate.ToString("dd-MMM-yyyy"); }
        }
        public string DischargeDateInString
        {
            get { return DischargeDate.ToString("dd-MMM-yyyy"); }
        }
    }

    public class MDRevenue : Revenue
    {
        private String _FromServiceUnitCode;
        private String _FromServiceUnitName;

        [Column(Name = "FromServiceUnitCode", DataType = "String")]
        public String FromServiceUnitCode
        {
            get { return _FromServiceUnitCode; }
            set { _FromServiceUnitCode = value; }
        }

        [Column(Name = "FromServiceUnitName", DataType = "String")]
        public String FromServiceUnitName
        {
            get { return _FromServiceUnitName; }
            set { _FromServiceUnitName = value; }
        }
    }

    public class Prescription
    {
        private String _DepartmentCode;
        private String _DepartmentName;
        private String _ServiceUnitCode;
        private String _ServiceUnitName;
        private String _FromServiceUnitCode;
        private String _FromServiceUnitName;
        private String _ChargeClassCode;
        private String _ChargeClassName;
        private String _ParamedicCode;
        private String _ParamedicName;
        private String _RegistrationNo;
        private DateTime _RegistrationDate;
        private DateTime _DischargeDate;
        private String _MedicalNo;
        private String _FirstName;
        private String _LastName;
        private String _PayerType;
        private String _PayerCode;
        private String _PayerName;
        private String _PrescriptionNo;
        private DateTime _TransactionDate;
        private String _ItemCode;
        private String _ItemName;
        private Double _Quantity;
        private Double _Price;
        private Double _LineAmount;

        [Column(Name = "DepartmentCode", DataType = "String")]
        public String DepartmentCode
        {
            get { return _DepartmentCode; }
            set { _DepartmentCode = value; }
        }
        [Column(Name = "DepartmentName", DataType = "String")]
        public String DepartmentName
        {
            get { return _DepartmentName; }
            set { _DepartmentName = value; }
        }
        [Column(Name = "ServiceUnitCode", DataType = "String")]
        public String ServiceUnitCode
        {
            get { return _ServiceUnitCode; }
            set { _ServiceUnitCode = value; }
        }
        [Column(Name = "ServiceUnitName", DataType = "String")]
        public String ServiceUnitName
        {
            get { return _ServiceUnitName; }
            set { _ServiceUnitName = value; }
        }
        [Column(Name = "FromServiceUnitCode", DataType = "String")]
        public String FromServiceUnitCode
        {
            get { return _FromServiceUnitCode; }
            set { _FromServiceUnitCode = value; }
        }

        [Column(Name = "FromServiceUnitName", DataType = "String")]
        public String FromServiceUnitName
        {
            get { return _FromServiceUnitName; }
            set { _FromServiceUnitName = value; }
        }
        [Column(Name = "ChargeClassCode", DataType = "String")]
        public String ChargeClassCode
        {
            get { return _ChargeClassCode; }
            set { _ChargeClassCode = value; }
        }
        [Column(Name = "ChargeClassName", DataType = "String")]
        public String ChargeClassName
        {
            get { return _ChargeClassName; }
            set { _ChargeClassName = value; }
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
        [Column(Name = "RegistrationNo", DataType = "String")]
        public String RegistrationNo
        {
            get { return _RegistrationNo; }
            set { _RegistrationNo = value; }
        }
        [Column(Name = "RegistrationDate", DataType = "DateTime")]
        public DateTime RegistrationDate
        {
            get { return _RegistrationDate; }
            set { _RegistrationDate = value; }
        }
        [Column(Name = "DischargeDate", DataType = "DateTime")]
        public DateTime DischargeDate
        {
            get { return _DischargeDate; }
            set { _DischargeDate = value; }
        }
        [Column(Name = "MedicalNo", DataType = "String")]
        public String MedicalNo
        {
            get { return _MedicalNo; }
            set { _MedicalNo = value; }
        }
        [Column(Name = "FirstName", DataType = "String")]
        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        [Column(Name = "LastName", DataType = "String")]
        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        [Column(Name = "PayerType", DataType = "String")]
        public String PayerType
        {
            get { return _PayerType; }
            set { _PayerType = value; }
        }
        [Column(Name = "PayerCode", DataType = "String")]
        public String PayerCode
        {
            get { return _PayerCode; }
            set { _PayerCode = value; }
        }
        [Column(Name = "PayerName", DataType = "String")]
        public String PayerName
        {
            get { return _PayerName; }
            set { _PayerName = value; }
        }
        [Column(Name = "PrescriptionNo", DataType = "String")]
        public String PrescriptionNo
        {
            get { return _PrescriptionNo; }
            set { _PrescriptionNo = value; }
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
        [Column(Name = "Quantity", DataType = "Double")]
        public Double Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        [Column(Name = "Price", DataType = "Double")]
        public Double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        [Column(Name = "LineAmount", DataType = "Double")]
        public Double LineAmount
        {
            get { return _LineAmount; }
            set { _LineAmount = value; }
        }
        public String MRN
        {
            get { return string.Format("{0} - {1}", _MedicalNo.TrimEnd(), PatientName.TrimEnd()); }
        }

        public string PatientName
        {
            get { return string.Format("{0} {1}", _FirstName.TrimEnd(), _LastName.TrimEnd()); }
        }
        public string TransactionDateInString
        {
            get { return TransactionDate.ToString("dd-MMM-yyyy"); }
        }

        public string RegistrationDateInString
        {
            get { return RegistrationDate.ToString("dd-MMM-yyyy"); }
        }
        public string DischargeDateInString
        {
            get { return DischargeDate.ToString("dd-MMM-yyyy"); }
        }
    }
}
