using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using ebIModels.Mapping;
using ebIModels.Schema;
using ExtensionMethods;

namespace ebIModels.Models
{
    public partial class InvoiceType : Schema.InvoiceType, IInvoiceType
    {
        private string invoiceNumberField = "";
        private System.DateTime invoiceDateField;
        private CancelledOriginalDocumentType cancelledOriginalDocumentField;
        private List<RelatedDocumentType> relatedDocumentField;
        private DeliveryType deliveryField;
        private BillerType billerField;
        private InvoiceRecipientType invoiceRecipientField;
        private OrderingPartyType orderingPartyField;
        private DetailsType detailsField;
        private ReductionAndSurchargeDetailsType reductionAndSurchargeDetailsField;
        private TaxType taxField;
        private decimal? totalGrossAmountField;
        private decimal? payableAmountField;
        private PaymentMethodType paymentMethodField;
        private PaymentConditionsType paymentConditionsField;
        private PresentationDetailsType presentationDetailsField;
        private string commentField = "";
        private InvoiceRootExtensionType invoiceRootExtensionField;
        private string generatingSystemField = "";
        private DocumentTypeType documentTypeField;
        private CurrencyType invoiceCurrencyField;
        private bool manualProcessingField;
        private bool manualProcessingFieldSpecified;
        private string documentTitleField = "";
        private LanguageType languageField;
        private bool languageFieldSpecified;
        private bool isDuplicateField;
        private bool isDuplicateFieldSpecified;
        private List<AdditionalInformationType> additionalInformation;

        public InvoiceType()
        {
            this.invoiceRootExtensionField = new InvoiceRootExtensionType();
            this.presentationDetailsField = new PresentationDetailsType();
            this.paymentConditionsField = new PaymentConditionsType();
            this.paymentMethodField = new PaymentMethodType();
            this.taxField = new TaxType();
            this.reductionAndSurchargeDetailsField = new ReductionAndSurchargeDetailsType();
            this.reductionAndSurchargeDetailsField.ItemsElementName = new List<ItemsChoiceType1>();
            this.detailsField = new DetailsType();
            this.orderingPartyField = new OrderingPartyType();
            this.invoiceRecipientField = new InvoiceRecipientType();
            this.billerField = new BillerType();
            this.deliveryField = new DeliveryType();
            this.relatedDocumentField = new List<RelatedDocumentType>();


        }


        public new ebIVersion Version { get; set; }

        public string InvoiceNumber
        {
            get { return this.invoiceNumberField; }
            set { this.invoiceNumberField = value; }
        }
        public System.DateTime InvoiceDate
        {
            get { return this.invoiceDateField; }
            set {
                if ((invoiceDateField.Equals(value) != true))
                {
                    this.invoiceDateField = value;

                }
            }
        }
        public CancelledOriginalDocumentType CancelledOriginalDocument
        {
            get { return this.cancelledOriginalDocumentField; }
            set { this.cancelledOriginalDocumentField = value; }
        }
        public List<RelatedDocumentType> RelatedDocument
        {
            get { return this.relatedDocumentField; }
            set { this.relatedDocumentField = value; }
        }
        public DeliveryType Delivery
        {
            get { return this.deliveryField; }
            set { this.deliveryField = value; }
        }
        public BillerType Biller
        {
            get { return this.billerField; }
            set { this.billerField = value; }
        }
        public InvoiceRecipientType InvoiceRecipient
        {
            get { return this.invoiceRecipientField; }
            set { this.invoiceRecipientField = value; }
        }
        public OrderingPartyType OrderingParty
        {
            get { return this.orderingPartyField; }
            set { this.orderingPartyField = value; }
        }
        public DetailsType Details
        {
            get { return this.detailsField; }
            set { this.detailsField = value; }
        }
        public ReductionAndSurchargeDetailsType ReductionAndSurchargeDetails
        {
            get { return this.reductionAndSurchargeDetailsField; }
            set { this.reductionAndSurchargeDetailsField = value; }
        }
        public TaxType Tax
        {
            get { return this.taxField; }
            internal set { this.taxField = value; }
        }
        public decimal? TotalGrossAmount
        {
            get { return this.totalGrossAmountField.FixedFraction(2); }
            set { this.totalGrossAmountField = value; }
        }
        public decimal? PayableAmount
        {
            get { return this.payableAmountField.FixedFraction(2); }
            set { this.payableAmountField = value; }
        }

        public PaymentMethodType PaymentMethod
        {
            get { return this.paymentMethodField; }
            set { this.paymentMethodField = value; }
        }
        public PaymentConditionsType PaymentConditions
        {
            get { return this.paymentConditionsField; }
            set { this.paymentConditionsField = value; }
        }
        public PresentationDetailsType PresentationDetails
        {
            get { return this.presentationDetailsField; }
            set { this.presentationDetailsField = value; }
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }
        public InvoiceRootExtensionType InvoiceRootExtension
        {
            get { return this.invoiceRootExtensionField; }
            set { this.invoiceRootExtensionField = value; }
        }
        public string GeneratingSystem
        {
            get { return this.generatingSystemField; }
            set { this.generatingSystemField = value; }
        }
        public DocumentTypeType DocumentType
        {
            get { return this.documentTypeField; }
            set {
                if ((documentTypeField.Equals(value) != true))
                {
                    this.documentTypeField = value;

                }
            }
        }
        public CurrencyType InvoiceCurrency
        {
            get { return this.invoiceCurrencyField; }
            set {
                if ((invoiceCurrencyField.Equals(value) != true))
                {
                    this.invoiceCurrencyField = value;

                }
            }
        }
        public bool ManualProcessing
        {
            get { return this.manualProcessingField; }
            set {
                if ((manualProcessingField.Equals(value) != true))
                {
                    this.manualProcessingField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool ManualProcessingSpecified
        {
            get { return this.manualProcessingFieldSpecified; }
            set {
                if ((manualProcessingFieldSpecified.Equals(value) != true))
                {
                    this.manualProcessingFieldSpecified = value;

                }
            }
        }
        public string DocumentTitle
        {
            get { return this.documentTitleField; }
            set { this.documentTitleField = value; }
        }
        public LanguageType Language
        {
            get { return this.languageField; }
            set {
                if ((languageField.Equals(value) != true))
                {
                    this.languageField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool LanguageSpecified
        {
            get { return this.languageFieldSpecified; }
            set {
                if ((languageFieldSpecified.Equals(value) != true))
                {
                    this.languageFieldSpecified = value;

                }
            }
        }
        public bool IsDuplicate
        {
            get { return this.isDuplicateField; }
            set {
                if ((isDuplicateField.Equals(value) != true))
                {
                    this.isDuplicateField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool IsDuplicateSpecified
        {
            get { return this.isDuplicateFieldSpecified; }
            set {
                if ((isDuplicateFieldSpecified.Equals(value) != true))
                {
                    this.isDuplicateFieldSpecified = value;

                }
            }
        }

        public List<AdditionalInformationType> AdditionalInformation { get { return additionalInformation; } set { additionalInformation = value; } }

        public override ebInterfaceResult Save(string file)
        {

            return Save(file, ebIVersion.V4P2);
        }
        public ebInterfaceResult Save(string filename, ebIVersion versionToSave)
        {
            ebInterfaceResult result = new ebInterfaceResult() { ResultType = ResultType.XmlValidationIssue };
            result.ResultMessages.Add(new ResultMessage() { Field = "Version", Message = "Unbekannte ebInterface Version", Severity = MessageType.Error });
            switch (versionToSave)
            {
                //case ebIVersion.V4P0:
                //    break;
                case ebIVersion.V4P1:
                    Schema.ebInterface4p1.InvoiceType inv4p1 = MappingServiceVmTo4p1.MapModelToV4p1(this);
                    result = inv4p1.Save(filename);
                    break;
                case ebIVersion.V4P2:
                    Schema.ebInterface4p2.InvoiceType inv4p2 = MappingServiceVmTo4p2.MapModelToV4p2(this);
                    result = inv4p2.Save(filename);
                    break;
                case ebIVersion.V4P3:
                    Schema.ebInterface4p3.InvoiceType inv4p3 = MappingServiceVmTo4p3.MapModelToV4p3(this);
                    result = inv4p3.Save(filename);
                    break;
                case ebIVersion.V5P0:
                    Schema.ebInterface5p0.InvoiceType inv5p0 = MappingServiceVmTo5p0.MapModelToV5p0(this);
                    result = inv5p0.Save(filename);
                    break;
                default:
                    break;
            }
            return result;
        }
        public bool InitFromSettings { get; set; }

        public override void SaveTemplate(string filename)
        {
            // ToDo: V5p0
            Schema.ebInterface4p2.InvoiceType inv = MappingServiceVmTo4p2.MapModelToV4p2(this);
            inv.SaveTemplate(filename);
        }
    }
    public partial class CancelledOriginalDocumentType
    {
        private string invoiceNumberField = "";
        private System.DateTime invoiceDateField;
        private DocumentTypeType documentTypeField;
        private bool documentTypeFieldSpecified;
        private string commentField = "";
        public string InvoiceNumber
        {
            get { return this.invoiceNumberField; }
            set { this.invoiceNumberField = value; }
        }
        public System.DateTime InvoiceDate
        {
            get { return this.invoiceDateField; }
            set {
                if ((invoiceDateField.Equals(value) != true))
                {
                    this.invoiceDateField = value;

                }
            }
        }
        public DocumentTypeType DocumentType
        {
            get { return this.documentTypeField; }
            set {
                if ((documentTypeField.Equals(value) != true))
                {
                    this.documentTypeField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool DocumentTypeSpecified
        {
            get { return this.documentTypeFieldSpecified; }
            set {
                if ((documentTypeFieldSpecified.Equals(value) != true))
                {
                    this.documentTypeFieldSpecified = value;

                }
            }
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }
    }
    public enum DocumentTypeType
    {

        CreditMemo,

        FinalSettlement,

        Invoice,

        InvoiceForAdvancePayment,

        InvoiceForPartialDelivery,

        SelfBilling,

        SubsequentCredit,

        SubsequentDebit,
    }
    public partial class InvoiceRootExtensionType1
    {

    }
    public partial class InvoiceRootExtensionType
    {
        private InvoiceRootExtensionType1 invoiceRootExtensionField;
        private CustomType customField;
        public InvoiceRootExtensionType()
        {
            this.customField = new CustomType();
            this.invoiceRootExtensionField = new InvoiceRootExtensionType1();
        }
        public InvoiceRootExtensionType1 InvoiceRootExtension
        {
            get { return this.invoiceRootExtensionField; }
            set { this.invoiceRootExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class CustomType
    {
        private System.Xml.XmlElement anyField;
        [XmlAnyElement(Order = 0)]
        public System.Xml.XmlElement Any
        {
            get { return this.anyField; }
            set { this.anyField = value; }
        }

    }
    public partial class PresentationDetailsExtensionType1
    {

    }
    public partial class PresentationDetailsExtensionType
    {
        private PresentationDetailsExtensionType1 presentationDetailsExtensionField;
        private CustomType customField;
        public PresentationDetailsExtensionType()
        {
            this.customField = new CustomType();
            this.presentationDetailsExtensionField = new PresentationDetailsExtensionType1();
        }
        public PresentationDetailsExtensionType1 PresentationDetailsExtension
        {
            get { return this.presentationDetailsExtensionField; }
            set { this.presentationDetailsExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class PresentationDetailsType
    {
        private string uRLField = "";
        private string logoURLField = "";
        private string layoutIDField = "";
        private bool suppressZeroField;
        private bool suppressZeroFieldSpecified;
        private PresentationDetailsExtensionType presentationDetailsExtensionField;
        public PresentationDetailsType()
        {
            this.presentationDetailsExtensionField = new PresentationDetailsExtensionType();
        }
        public string URL
        {
            get { return this.uRLField; }
            set { this.uRLField = value; }
        }
        public string LogoURL
        {
            get { return this.logoURLField; }
            set { this.logoURLField = value; }
        }
        public string LayoutID
        {
            get { return this.layoutIDField; }
            set { this.layoutIDField = value; }
        }
        public bool SuppressZero
        {
            get { return this.suppressZeroField; }
            set {
                if ((suppressZeroField.Equals(value) != true))
                {
                    this.suppressZeroField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool SuppressZeroSpecified
        {
            get { return this.suppressZeroFieldSpecified; }
            set {
                if ((suppressZeroFieldSpecified.Equals(value) != true))
                {
                    this.suppressZeroFieldSpecified = value;

                }
            }
        }
        public PresentationDetailsExtensionType PresentationDetailsExtension
        {
            get { return this.presentationDetailsExtensionField; }
            set { this.presentationDetailsExtensionField = value; }
        }

    }
    public partial class PaymentConditionsExtensionType1
    {

    }
    public partial class PaymentConditionsExtensionType
    {
        private PaymentConditionsExtensionType1 paymentConditionsExtensionField;
        private CustomType customField;
        public PaymentConditionsExtensionType()
        {
            this.customField = new CustomType();
            this.paymentConditionsExtensionField = new PaymentConditionsExtensionType1();
        }
        public PaymentConditionsExtensionType1 PaymentConditionsExtension
        {
            get { return this.paymentConditionsExtensionField; }
            set { this.paymentConditionsExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class DiscountType
    {
        private System.DateTime paymentDateField;
        private decimal? baseAmountField;
        private bool baseAmountFieldSpecified;
        private decimal? percentageField;
        private bool percentageFieldSpecified;
        private decimal? amountField;
        private bool amountFieldSpecified;
        public System.DateTime PaymentDate
        {
            get { return this.paymentDateField; }
            set {
                if ((paymentDateField.Equals(value) != true))
                {
                    this.paymentDateField = value;

                }
            }
        }
        public decimal? BaseAmount
        {
            get { return this.baseAmountField.FixedFraction(2); }
            set { this.baseAmountField = value; }
        }
        [XmlIgnore()]
        public bool BaseAmountSpecified
        {
            get { return this.baseAmountFieldSpecified; }
            set {
                if ((baseAmountFieldSpecified.Equals(value) != true))
                {
                    this.baseAmountFieldSpecified = value;

                }
            }
        }
        public decimal? Percentage
        {
            get { return this.percentageField; }
            set { this.percentageField = value; }
        }
        [XmlIgnore()]
        public bool PercentageSpecified
        {
            get { return this.percentageFieldSpecified; }
            set {
                if ((percentageFieldSpecified.Equals(value) != true))
                {
                    this.percentageFieldSpecified = value;

                }
            }
        }
        public decimal? Amount
        {
            get { return this.amountField.FixedFraction(2); }
            set { this.amountField = value; }
        }
        [XmlIgnore()]
        public bool AmountSpecified
        {
            get { return this.amountFieldSpecified; }
            set {
                if ((amountFieldSpecified.Equals(value) != true))
                {
                    this.amountFieldSpecified = value;

                }
            }
        }

    }
    public partial class PaymentConditionsType
    {
        // ToDo: Allow nullable datetime
        private System.DateTime dueDateField;
        private List<DiscountType> discountField;
        private decimal? minimumPaymentField;
        private bool minimumPaymentFieldSpecified;
        private string commentField = "";
        private PaymentConditionsExtensionType paymentConditionsExtensionField;
        public PaymentConditionsType()
        {
            this.paymentConditionsExtensionField = new PaymentConditionsExtensionType();
            this.discountField = new List<DiscountType>();
        }
        public System.DateTime DueDate
        {
            get { return this.dueDateField; }
            set {
                if ((dueDateField.Equals(value) != true))
                {
                    this.dueDateField = value;

                }
            }
        }
        public List<DiscountType> Discount
        {
            get { return this.discountField; }
            set { this.discountField = value; }
        }
        public decimal? MinimumPayment
        {
            get { return this.minimumPaymentField; }
            set { this.minimumPaymentField = value; }
        }
        [XmlIgnore()]
        public bool MinimumPaymentSpecified
        {
            get { return this.minimumPaymentFieldSpecified; }
            set {
                if ((minimumPaymentFieldSpecified.Equals(value) != true))
                {
                    this.minimumPaymentFieldSpecified = value;

                }
            }
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }
        public PaymentConditionsExtensionType PaymentConditionsExtension
        {
            get { return this.paymentConditionsExtensionField; }
            set { this.paymentConditionsExtensionField = value; }
        }

    }
    public partial class PaymentMethodExtensionType1
    {

    }
    public partial class PaymentMethodExtensionType
    {
        private PaymentMethodExtensionType1 paymentMethodExtensionField;
        private CustomType customField;
        public PaymentMethodExtensionType()
        {
            this.customField = new CustomType();
            this.paymentMethodExtensionField = new PaymentMethodExtensionType1();
        }
        public PaymentMethodExtensionType1 PaymentMethodExtension
        {
            get { return this.paymentMethodExtensionField; }
            set { this.paymentMethodExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class PaymentReferenceType
    {
        private string checkSumField = "";
        private string valueField = "";
        public string CheckSum
        {
            get { return this.checkSumField; }
            set { this.checkSumField = value; }
        }
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public partial class BankCodeType
    {
        private CountryCodeType bankCodeType1Field;
        private string valueField = "";
        public CountryCodeType BankCodeType1
        {
            get { return this.bankCodeType1Field; }
            set {
                if ((bankCodeType1Field.Equals(value) != true))
                {
                    this.bankCodeType1Field = value;

                }
            }
        }
        [XmlText(DataType = "integer")]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public enum CountryCodeType
    {

        AF,

        AX,

        AL,

        DZ,

        AS,

        AD,

        AO,

        AI,

        AQ,

        AG,

        AR,

        AM,

        AW,

        AU,

        AT,

        AZ,

        BS,

        BH,

        BD,

        BB,

        BY,

        BE,

        BZ,

        BJ,

        BM,

        BT,

        BO,

        BQ,

        BA,

        BW,

        BV,

        BR,

        IO,

        BN,

        BG,

        BF,

        BI,

        KH,

        CM,

        CA,

        CV,

        KY,

        CF,

        TD,

        CL,

        CN,

        CX,

        CC,

        CO,

        KM,

        CG,

        CD,

        CK,

        CR,

        CI,

        HR,

        CU,

        CW,

        CY,

        CZ,

        DK,

        DJ,

        DM,

        DO,

        EC,

        EG,

        SV,

        GQ,

        ER,

        EE,

        ET,

        FK,

        FO,

        FJ,

        FI,

        FR,

        GF,

        PF,

        TF,

        GA,

        GM,

        GE,

        DE,

        GH,

        GI,

        GR,

        GL,

        GD,

        GP,

        GU,

        GT,

        GG,

        GN,

        GW,

        GY,

        HT,

        HM,

        VA,

        HN,

        HK,

        HU,

        IS,

        IN,

        ID,

        IR,

        IQ,

        IE,

        IM,

        IL,

        IT,

        JM,

        JP,

        JE,

        JO,

        KZ,

        KE,

        KI,

        KP,

        KR,

        KW,

        KG,

        LA,

        LV,

        LB,

        LS,

        LR,

        LY,

        LI,

        LT,

        LU,

        MO,

        MK,

        MG,

        MW,

        MY,

        MV,

        ML,

        MT,

        MH,

        MQ,

        MR,

        MU,

        YT,

        MX,

        FM,

        MD,

        MC,

        MN,

        ME,

        MS,

        MA,

        MZ,

        MM,

        NA,

        NR,

        NP,

        NL,

        NC,

        NZ,

        NI,

        NE,

        NG,

        NU,

        NF,

        MP,

        NO,

        OM,

        PK,

        PW,

        PS,

        PA,

        PG,

        PY,

        PE,

        PH,

        PN,

        PL,

        PT,

        PR,

        QA,

        RE,

        RO,

        RU,

        RW,

        BL,

        SH,

        KN,

        LC,

        MF,

        PM,

        VC,

        WS,

        SM,

        ST,

        SA,

        SN,

        RS,

        SC,

        SL,

        SG,

        SX,

        SK,

        SI,

        SB,

        SO,

        ZA,

        GS,

        SS,

        ES,

        LK,

        SD,

        SR,

        SJ,

        SZ,

        SE,

        CH,

        SY,

        TW,

        TJ,

        TZ,

        TH,

        TL,

        TG,

        TK,

        TO,

        TT,

        TN,

        TR,

        TM,

        TC,

        TV,

        UG,

        UA,

        AE,

        GB,

        US,

        UM,

        UY,

        UZ,

        VU,

        VE,

        VN,

        VG,

        VI,

        WF,

        EH,

        YE,

        ZM,

        ZW,
    }
    public partial class AccountType
    {
        private string bankNameField = "";
        private BankCodeType bankCodeField;
        private string bICField = "";
        private string bankAccountNrField = "";
        private string iBANField = "";
        private string bankAccountOwnerField = "";
        public AccountType()
        {
            this.bankCodeField = new BankCodeType();
        }
        public string BankName
        {
            get { return this.bankNameField; }
            set { this.bankNameField = value; }
        }
        public BankCodeType BankCode
        {
            get { return this.bankCodeField; }
            set { this.bankCodeField = value; }
        }
        public string BIC
        {
            get { return this.bICField; }
            set { this.bICField = value; }
        }
        public string BankAccountNr
        {
            get { return this.bankAccountNrField; }
            set { this.bankAccountNrField = value; }
        }
        public string IBAN
        {
            get { return this.iBANField; }
            set { this.iBANField = value; }
        }
        public string BankAccountOwner
        {
            get { return this.bankAccountOwnerField; }
            set { this.bankAccountOwnerField = value; }
        }

    }
    public partial class UniversalBankTransactionType
    {
        private List<AccountType> beneficiaryAccountField;
        private PaymentReferenceType paymentReferenceField;
        private bool consolidatorPayableField;
        private bool consolidatorPayableFieldSpecified;
        public UniversalBankTransactionType()
        {
            this.paymentReferenceField = new PaymentReferenceType();
            this.beneficiaryAccountField = new List<AccountType>()
            {
                new AccountType()
            };
        }
        public List<AccountType> BeneficiaryAccount
        {
            get { return this.beneficiaryAccountField; }
            set { this.beneficiaryAccountField = value; }
        }
        public PaymentReferenceType PaymentReference
        {
            get { return this.paymentReferenceField; }
            set { this.paymentReferenceField = value; }
        }
        public bool ConsolidatorPayable
        {
            get { return this.consolidatorPayableField; }
            set {
                if ((consolidatorPayableField.Equals(value) != true))
                {
                    this.consolidatorPayableField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool ConsolidatorPayableSpecified
        {
            get { return this.consolidatorPayableFieldSpecified; }
            set {
                if ((consolidatorPayableFieldSpecified.Equals(value) != true))
                {
                    this.consolidatorPayableFieldSpecified = value;

                }
            }
        }

    }
    public partial class SEPADirectDebitType
    {
        private SEPADirectDebitTypeType typeField;
        private string bICField = "";
        private string iBANField = "";
        private string bankAccountOwnerField = "";
        private string creditorIDField = "";
        private string mandateReferenceField = "";
        private System.DateTime debitCollectionDateField;
        public SEPADirectDebitTypeType Type
        {
            get { return this.typeField; }
            set {
                if ((typeField.Equals(value) != true))
                {
                    this.typeField = value;

                }
            }
        }
        public string BIC
        {
            get { return this.bICField; }
            set { this.bICField = value; }
        }
        public string IBAN
        {
            get { return this.iBANField; }
            set { this.iBANField = value; }
        }
        public string BankAccountOwner
        {
            get { return this.bankAccountOwnerField; }
            set { this.bankAccountOwnerField = value; }
        }
        public string CreditorID
        {
            get { return this.creditorIDField; }
            set { this.creditorIDField = value; }
        }
        public string MandateReference
        {
            get { return this.mandateReferenceField; }
            set { this.mandateReferenceField = value; }
        }
        public System.DateTime DebitCollectionDate
        {
            get { return this.debitCollectionDateField; }
            set {
                if ((debitCollectionDateField.Equals(value) != true))
                {
                    this.debitCollectionDateField = value;

                }
            }
        }

    }
    public enum SEPADirectDebitTypeType
    {

        B2C,

        B2B,
    }
    public partial class DirectDebitType
    {

    }
    public partial class NoPaymentType
    {

    }
    public partial class PaymentMethodType
    {
        private string commentField = "";
        private object itemField;
        private PaymentMethodExtensionType paymentMethodExtensionField;
        public PaymentMethodType()
        {
            this.paymentMethodExtensionField = new PaymentMethodExtensionType();
            this.Item = new UniversalBankTransactionType();
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
        public PaymentMethodExtensionType PaymentMethodExtension
        {
            get { return this.paymentMethodExtensionField; }
            set { this.paymentMethodExtensionField = value; }
        }

    }
    public partial class TaxExtensionType1
    {

    }
    public partial class TaxExtensionType
    {
        private TaxExtensionType1 taxExtensionField;
        private CustomType customField;
        public TaxExtensionType()
        {
            this.customField = new CustomType();
            this.taxExtensionField = new TaxExtensionType1();
        }
        public TaxExtensionType1 TaxExtension
        {
            get { return this.taxExtensionField; }
            set { this.taxExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class OtherTaxType
    {
        private string commentField = "";
        private decimal? amountField;
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }
        public decimal? Amount
        {
            get { return this.amountField.FixedFraction(2); }
            set { this.amountField = value; }
        }

    }
    public partial class VATItemType
    {
        private decimal? taxedAmountField;
        private object itemField;
        private decimal? amountField;
        public decimal? TaxedAmount
        {
            get { return this.taxedAmountField.FixedFraction(2); }
            set { this.taxedAmountField = value; }
        }
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
        public decimal? Amount
        {
            get { return this.amountField.FixedFraction(2); }
            set { this.amountField = value; }
        }
    }
    public partial class TaxExemptionType
    {
        private string taxExemptionCodeField = "";
        private string valueField = "";
        public string TaxExemptionCode
        {
            get { return this.taxExemptionCodeField; }
            set { this.taxExemptionCodeField = value; }
        }
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public partial class VATRateType
    {
        private string taxCodeField = "";
        private decimal? valueField;
        public string TaxCode
        {
            get { return this.taxCodeField; }
            set { this.taxCodeField = value; }
        }
        [XmlText()]
        public decimal? Value
        {
            get {
                return this.valueField;
            }
            set { this.valueField = value; }
        }

    }
    public partial class TaxType
    {
        private List<VATItemType> vATField;
        private List<OtherTaxType> otherTaxField;
        private TaxExtensionType taxExtensionField;
        public TaxType()
        {
            this.taxExtensionField = new TaxExtensionType();
            this.otherTaxField = new List<OtherTaxType>();
            this.vATField = new List<VATItemType>();
        }
        //[XmlArray(Order = 0)]
        //[XmlArrayItem("VATItem", IsNullable = false)]
        public List<VATItemType> VAT
        {
            get { return this.vATField; }
            set { this.vATField = value; }
        }
        public List<OtherTaxType> OtherTax
        {
            get { return this.otherTaxField; }
            set { this.otherTaxField = value; }
        }
        public TaxExtensionType TaxExtension
        {
            get { return this.taxExtensionField; }
            set { this.taxExtensionField = value; }
        }

    }
    public partial class AccountingCurrencyAmountType
    {

        private string currencyField;

        private decimal valueField;

        /// <remarks/>
        public string Currency
        {
            get { return this.currencyField; }
            set { this.currencyField = value; }
        }

        /// <remarks/>
        public decimal Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
    public partial class TaxItemType
    {

        private decimal taxableAmountField;

        private TaxPercentType taxPercentField;

        private decimal taxAmountField;

        private bool taxAmountFieldSpecified;

        private AccountingCurrencyAmountType accountingCurrencyAmountField;

        private string commentField;

        /// <remarks/>
        public decimal TaxableAmount
        {
            get { return this.taxableAmountField; }
            set { this.taxableAmountField = value; }
        }

        /// <remarks/>
        public TaxPercentType TaxPercent
        {
            get { return this.taxPercentField; }
            set { this.taxPercentField = value; }
        }

        /// <remarks/>
        public decimal TaxAmount
        {
            get { return this.taxAmountField; }
            set { this.taxAmountField = value; }
        }
    }
    public partial class TaxPercentType
    {

        private string taxCategoryCodeField;

        private decimal valueField;

        /// <summary>
        /// Gets or sets the tax category code.
        /// </summary>
        /// <value>
        /// The tax category code according to ebInterface 5p0: Empfohlene Codes f�r TaxCategoryCode        
        /// </value>
        public string TaxCategoryCode
        {
            get { return this.taxCategoryCodeField; }
            set { taxCategoryCodeField = value; }
        }
        public decimal Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }

    public partial class ReductionAndSurchargeDetailsExtensionType1
    {

    }
    public partial class ReductionAndSurchargeDetailsExtensionType
    {
        private ReductionAndSurchargeDetailsExtensionType1 reductionAndSurchargeDetailsExtensionField;
        private CustomType customField;
        public ReductionAndSurchargeDetailsExtensionType()
        {
            this.customField = new CustomType();
            this.reductionAndSurchargeDetailsExtensionField = new ReductionAndSurchargeDetailsExtensionType1();
        }
        public ReductionAndSurchargeDetailsExtensionType1 ReductionAndSurchargeDetailsExtension
        {
            get { return this.reductionAndSurchargeDetailsExtensionField; }
            set { this.reductionAndSurchargeDetailsExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class ReductionAndSurchargeDetailsType
    {
        private List<object> itemsField;
        private List<ItemsChoiceType1> itemsElementNameField;
        private ReductionAndSurchargeDetailsExtensionType reductionAndSurchargeDetailsExtensionField;
        public ReductionAndSurchargeDetailsType()
        {
            this.reductionAndSurchargeDetailsExtensionField = new ReductionAndSurchargeDetailsExtensionType();
            this.itemsElementNameField = new List<ItemsChoiceType1>();
            this.itemsField = new List<object>();
        }
        [XmlChoiceIdentifier("ItemsElementName")]
        public List<object> Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }
        [XmlIgnore()]
        public List<ItemsChoiceType1> ItemsElementName
        {
            get { return this.itemsElementNameField; }
            set { this.itemsElementNameField = value; }
        }
        public ReductionAndSurchargeDetailsExtensionType ReductionAndSurchargeDetailsExtension
        {
            get { return this.reductionAndSurchargeDetailsExtensionField; }
            set { this.reductionAndSurchargeDetailsExtensionField = value; }
        }

    }
    public partial class OtherVATableTaxType : OtherVATableTaxBaseType
    {
        private VATRateType vATRateField;
        public OtherVATableTaxType()
        {
            this.vATRateField = new VATRateType();
        }
        public VATRateType VATRate
        {
            get { return this.vATRateField; }
            set { this.vATRateField = value; }
        }

    }
    [XmlInclude(typeof(OtherVATableTaxType))]
    public partial class OtherVATableTaxBaseType
    {
        private decimal? baseAmountField;
        private decimal? percentageField;
        private bool percentageFieldSpecified;
        private decimal? amountField;
        private string taxIDField = "";
        private string commentField = "";
        public decimal? BaseAmount
        {
            get { return this.baseAmountField.FixedFraction(2); }
            set { this.baseAmountField = value; }
        }
        public decimal? Percentage
        {
            get { return this.percentageField; }
            set { this.percentageField = value; }
        }
        [XmlIgnore()]
        public bool PercentageSpecified
        {
            get { return this.percentageFieldSpecified; }
            set {
                if ((percentageFieldSpecified.Equals(value) != true))
                {
                    this.percentageFieldSpecified = value;

                }
            }
        }
        public decimal? Amount
        {
            get { return this.amountField.FixedFraction(2); }
            set { this.amountField = value; }
        }
        public string TaxID
        {
            get { return this.taxIDField; }
            set { this.taxIDField = value; }
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }

    }
    public partial class ReductionAndSurchargeType : ReductionAndSurchargeBaseType
    {
        private VATRateType vATRateField;
        public ReductionAndSurchargeType()
        {
            this.vATRateField = new VATRateType();
        }
        public VATRateType VATRate
        {
            get { return this.vATRateField; }
            set { this.vATRateField = value; }
        }

    }
    [XmlInclude(typeof(ReductionAndSurchargeType))]
    public partial class ReductionAndSurchargeBaseType
    {
        private decimal? baseAmountField;
        private decimal? percentageField;
        private bool percentageFieldSpecified;
        private decimal? amountField;
        private bool amountFieldSpecified;
        private string commentField = "";
        public decimal? BaseAmount
        {
            get { return this.baseAmountField.FixedFraction(2); }
            set { this.baseAmountField = value; }
        }
        public decimal? Percentage
        {
            get { return this.percentageField; }
            set { this.percentageField = value; }
        }
        [XmlIgnore()]
        public bool PercentageSpecified
        {
            get { return this.percentageFieldSpecified; }
            set {
                if ((percentageFieldSpecified.Equals(value) != true))
                {
                    this.percentageFieldSpecified = value;

                }
            }
        }
        public decimal? Amount
        {
            get { return this.amountField.FixedFraction(2); }
            set { this.amountField = value; }
        }
        [XmlIgnore()]
        public bool AmountSpecified
        {
            get { return this.amountFieldSpecified; }
            set {
                if ((amountFieldSpecified.Equals(value) != true))
                {
                    this.amountFieldSpecified = value;

                }
            }
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }

    }
    public enum ItemsChoiceType1
    {

        OtherVATableTax,

        Reduction,

        Surcharge,
    }
    public partial class ReasonType
    {
        private System.DateTime dateField;
        private bool dateFieldSpecified;
        private string valueField = "";
        public System.DateTime Date
        {
            get { return this.dateField; }
            set {
                if ((dateField.Equals(value) != true))
                {
                    this.dateField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool DateSpecified
        {
            get { return this.dateFieldSpecified; }
            set {
                if ((dateFieldSpecified.Equals(value) != true))
                {
                    this.dateFieldSpecified = value;

                }
            }
        }
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public partial class BelowTheLineItemType
    {
        private string descriptionField = "";
        private decimal? lineItemAmountField;
        private ReasonType reasonField;
        public BelowTheLineItemType()
        {
            this.reasonField = new ReasonType();
        }
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }
        public decimal? LineItemAmount
        {
            get { return this.lineItemAmountField.FixedFraction(2); }
            set { this.lineItemAmountField = value; }
        }
        public ReasonType Reason
        {
            get { return this.reasonField; }
            set { this.reasonField = value; }
        }

    }
    public partial class ListLineItemExtensionType1
    {
        private string beneficiarySocialInsuranceNumberField = "";
        public string BeneficiarySocialInsuranceNumber
        {
            get { return this.beneficiarySocialInsuranceNumberField; }
            set { this.beneficiarySocialInsuranceNumberField = value; }
        }

    }
    public partial class ListLineItemExtensionType
    {
        private ListLineItemExtensionType1 listLineItemExtensionField;
        private CustomType customField;
        public ListLineItemExtensionType()
        {
            this.customField = new CustomType();
            this.listLineItemExtensionField = new ListLineItemExtensionType1();
        }
        public ListLineItemExtensionType1 ListLineItemExtension
        {
            get { return this.listLineItemExtensionField; }
            set { this.listLineItemExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class ClassificationType
    {
        private string classificationSchemaField = "";
        private string valueField = "";
        public string ClassificationSchema
        {
            get { return this.classificationSchemaField; }
            set { this.classificationSchemaField = value; }
        }
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public partial class AdditionalInformationType
    {
        private List<string> serialNumberField;
        private List<string> chargeNumberField;
        private List<ClassificationType> classificationField;
        private UnitType alternativeQuantityField;
        private string sizeField = "";
        private UnitType weightField;
        private string boxesField = "";
        private string colorField = "";
        public AdditionalInformationType()
        {
            this.weightField = new UnitType();
            this.alternativeQuantityField = new UnitType();
            this.classificationField = new List<ClassificationType>();
            this.chargeNumberField = new List<string>();
            this.serialNumberField = new List<string>();
        }
        public List<string> SerialNumber
        {
            get { return this.serialNumberField; }
            set { this.serialNumberField = value; }
        }
        public List<string> ChargeNumber
        {
            get { return this.chargeNumberField; }
            set { this.chargeNumberField = value; }
        }
        public List<ClassificationType> Classification
        {
            get { return this.classificationField; }
            set { this.classificationField = value; }
        }
        public UnitType AlternativeQuantity
        {
            get { return this.alternativeQuantityField; }
            set { this.alternativeQuantityField = value; }
        }
        public string Size
        {
            get { return this.sizeField; }
            set { this.sizeField = value; }
        }
        public UnitType Weight
        {
            get { return this.weightField; }
            set { this.weightField = value; }
        }
        public string Boxes
        {
            get { return this.boxesField; }
            set { this.boxesField = value; }
        }
        public string Color
        {
            get { return this.colorField; }
            set { this.colorField = value; }
        }

    }
    public partial class UnitType
    {
        private string unitField = "";
        private decimal? valueField;
        public string Unit
        {
            get { return this.unitField; }
            set { this.unitField = value; }
        }
        [XmlText()]
        public decimal? Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public partial class ReductionAndSurchargeListLineItemDetailsType
    {
        private List<object> itemsField;
        private List<ItemsChoiceType> itemsElementNameField;
        public ReductionAndSurchargeListLineItemDetailsType()
        {
            this.itemsElementNameField = new List<ItemsChoiceType>();
            this.itemsField = new List<object>();
        }
        [XmlChoiceIdentifier("ItemsElementName")]
        public List<object> Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
        }
        [XmlIgnore()]
        public List<ItemsChoiceType> ItemsElementName
        {
            get { return this.itemsElementNameField; }
            set { this.itemsElementNameField = value; }
        }

    }
    public enum ItemsChoiceType
    {

        OtherVATableTaxListLineItem,

        ReductionListLineItem,

        SurchargeListLineItem,
    }
    public partial class UnitPriceType
    {
        private decimal? baseQuantityField;
        private bool baseQuantityFieldSpecified;
        private decimal? valueField;
        public decimal? BaseQuantity
        {
            get { return this.baseQuantityField; }
            set { this.baseQuantityField = value; }
        }
        [XmlIgnore()]
        public bool BaseQuantitySpecified
        {
            get { return this.baseQuantityFieldSpecified; }
            set {
                if ((baseQuantityFieldSpecified.Equals(value) != true))
                {
                    this.baseQuantityFieldSpecified = value;

                }
            }
        }
        [XmlText()]
        public decimal? Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public partial class ArticleNumberType
    {
        private ArticleNumberTypeType articleNumberType1Field;
        private bool articleNumberType1FieldSpecified;
        private List<string> textField;
        public ArticleNumberType()
        {
            this.textField = new List<string>();
        }
        public ArticleNumberTypeType ArticleNumberType1
        {
            get { return this.articleNumberType1Field; }
            set {
                if ((articleNumberType1Field.Equals(value) != true))
                {
                    this.articleNumberType1Field = value;

                }
            }
        }
        [XmlIgnore()]
        public bool ArticleNumberType1Specified
        {
            get { return this.articleNumberType1FieldSpecified; }
            set {
                if ((articleNumberType1FieldSpecified.Equals(value) != true))
                {
                    this.articleNumberType1FieldSpecified = value;

                }
            }
        }
        [XmlText()]
        public List<string> Text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }

    }
    public enum ArticleNumberTypeType
    {

        PZN,

        GTIN,

        InvoiceRecipientsArticleNumber,

        BillersArticleNumber,
    }
    public partial class ListLineItemType
    {
        private string positionNumberField = "";
        private List<string> descriptionField;
        private List<ArticleNumberType> articleNumberField;
        private UnitType quantityField;
        private UnitPriceType unitPriceField;
        private object itemField;
        private bool discountFlagField;
        private bool discountFlagFieldSpecified;
        private ReductionAndSurchargeListLineItemDetailsType reductionAndSurchargeListLineItemDetailsField;
        private DeliveryType deliveryField;
        private OrderReferenceDetailType billersOrderReferenceField;
        private OrderReferenceDetailType invoiceRecipientsOrderReferenceField;
        private AdditionalInformationType additionalInformationField;
        private decimal? lineItemAmountField;
        private ListLineItemExtensionType listLineItemExtensionField;
        public ListLineItemType()
        {
            this.listLineItemExtensionField = new ListLineItemExtensionType();
            this.invoiceRecipientsOrderReferenceField = new OrderReferenceDetailType();
            this.billersOrderReferenceField = new OrderReferenceDetailType();
            this.deliveryField = new DeliveryType();
            this.reductionAndSurchargeListLineItemDetailsField = new ReductionAndSurchargeListLineItemDetailsType();
            this.unitPriceField = new UnitPriceType();
            this.quantityField = new UnitType();
            this.articleNumberField = new List<ArticleNumberType>();
            this.descriptionField = new List<string>();
        }
        public string PositionNumber
        {
            get { return this.positionNumberField; }
            set { this.positionNumberField = value; }
        }
        public List<string> Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }
        public List<ArticleNumberType> ArticleNumber
        {
            get { return this.articleNumberField; }
            set { this.articleNumberField = value; }
        }
        public UnitType Quantity
        {
            get { return this.quantityField; }
            set { this.quantityField = value; }
        }
        public UnitPriceType UnitPrice
        {
            get { return this.unitPriceField; }
            set { this.unitPriceField = value; }
        }

        /// <summary>
        /// Gets or sets the  TAX item.
        /// </summary>
        /// <value>
        /// The item.
        /// </value>
        public object Item
        {
            get { return this.itemField; }
          internal  set { this.itemField = value; }
        }
        public bool DiscountFlag
        {
            get { return this.discountFlagField; }
            set {
                if ((discountFlagField.Equals(value) != true))
                {
                    this.discountFlagField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool DiscountFlagSpecified
        {
            get { return this.discountFlagFieldSpecified; }
            set {
                if ((discountFlagFieldSpecified.Equals(value) != true))
                {
                    this.discountFlagFieldSpecified = value;

                }
            }
        }
        public ReductionAndSurchargeListLineItemDetailsType ReductionAndSurchargeListLineItemDetails
        {
            get { return this.reductionAndSurchargeListLineItemDetailsField; }
            set { this.reductionAndSurchargeListLineItemDetailsField = value; }
        }
        public DeliveryType Delivery
        {
            get { return this.deliveryField; }
            set { this.deliveryField = value; }
        }
        public OrderReferenceDetailType BillersOrderReference
        {
            get { return this.billersOrderReferenceField; }
            set { this.billersOrderReferenceField = value; }
        }
        public OrderReferenceDetailType InvoiceRecipientsOrderReference
        {
            get { return this.invoiceRecipientsOrderReferenceField; }
            set { this.invoiceRecipientsOrderReferenceField = value; }
        }
        public AdditionalInformationType AdditionalInformation
        {
            get { return this.additionalInformationField; }
            set { this.additionalInformationField = value; }
        }
        public decimal? LineItemAmount
        {
            get { return this.lineItemAmountField.FixedFraction(2); }
            set { this.lineItemAmountField = value; }
        }
        public ListLineItemExtensionType ListLineItemExtension
        {
            get { return this.listLineItemExtensionField; }
            set { this.listLineItemExtensionField = value; }
        }
        public void RecalcLineItem()
        {
            if (UnitPrice.Value == null)
            {
                return;
            }
            if (Quantity.Value == null)
            {
                return;
            }
            LineItemAmount = UnitPrice.Value * Quantity.Value;
        }
    }
    public partial class DeliveryType
    {
        private string deliveryIDField = "";
        private object itemField;
        private AddressType addressField;
        private string descriptionField = "";
        private DeliveryExtensionType deliveryExtensionField;
        public DeliveryType()
        {
            this.deliveryExtensionField = new DeliveryExtensionType();
            this.addressField = new AddressType();
        }
        public string DeliveryID
        {
            get { return this.deliveryIDField; }
            set { this.deliveryIDField = value; }
        }
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
        public AddressType Address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }
        public DeliveryExtensionType DeliveryExtension
        {
            get { return this.deliveryExtensionField; }
            set { this.deliveryExtensionField = value; }
        }

    }
    public partial class PeriodType
    {
        private System.DateTime? fromDateField;
        private System.DateTime? toDateField;
        public System.DateTime? FromDate
        {
            get { return this.fromDateField; }
            set {
                if ((fromDateField.Equals(value) != true))
                {
                    this.fromDateField = value;

                }
            }
        }
        public System.DateTime? ToDate
        {
            get { return this.toDateField; }
            set {
                if ((toDateField.Equals(value) != true))
                {
                    this.toDateField = value;

                }
            }
        }

    }
    public partial class AddressType
    {
        private List<AddressIdentifierType> addressIdentifierField;
        private string salutationField = "";
        private string nameField = "";
        private string streetField = "";
        private string pOBoxField = "";
        private string townField = "";
        private string zIPField = "";
        private CountryType countryField;
        private string phoneField = "";
        private string emailField = "";
        private string contactField = "";
        private List<string> addressExtensionField;
        public AddressType()
        {
            this.addressExtensionField = new List<string>();
            this.countryField = new CountryType();
            this.addressIdentifierField = new List<AddressIdentifierType>();
            salutationField = "";
            nameField = "";
            streetField = "";
            pOBoxField = "";
            townField = "";
            zIPField = "";
            phoneField = "";
            emailField = "";
            contactField = "";
        }
        public List<AddressIdentifierType> AddressIdentifier
        {
            get { return this.addressIdentifierField; }
            set { this.addressIdentifierField = value; }
        }
        public string Salutation
        {
            get { return this.salutationField; }
            set { this.salutationField = value; }
        }
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
        public string Street
        {
            get { return this.streetField; }
            set { this.streetField = value; }
        }
        public string POBox
        {
            get { return this.pOBoxField; }
            set { this.pOBoxField = value; }
        }
        public string Town
        {
            get { return this.townField; }
            set { this.townField = value; }
        }
        public string ZIP
        {
            get { return this.zIPField; }
            set { this.zIPField = value; }
        }
        public CountryType Country
        {
            get { return this.countryField; }
            set { this.countryField = value; }
        }
        public string Phone
        {
            get { return this.phoneField; }
            set { this.phoneField = value; }
        }
        public string Email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }
        public string Contact
        {
            get { return this.contactField; }
            set { this.contactField = value; }
        }
        public List<string> AddressExtension
        {
            get { return this.addressExtensionField; }
            set { this.addressExtensionField = value; }
        }

    }
    public partial class AddressIdentifierType
    {
        private AddressIdentifierTypeType addressIdentifierType1Field;
        private bool addressIdentifierType1FieldSpecified;
        private string valueField = "";
        public AddressIdentifierTypeType AddressIdentifierType1
        {
            get { return this.addressIdentifierType1Field; }
            set {
                if ((addressIdentifierType1Field.Equals(value) != true))
                {
                    this.addressIdentifierType1Field = value;

                }
            }
        }
        [XmlIgnore()]
        public bool AddressIdentifierType1Specified
        {
            get { return this.addressIdentifierType1FieldSpecified; }
            set {
                if ((addressIdentifierType1FieldSpecified.Equals(value) != true))
                {
                    this.addressIdentifierType1FieldSpecified = value;

                }
            }
        }
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    public enum AddressIdentifierTypeType
    {

        GLN,

        DUNS,

        ProprietaryAddressID,
    }
    public partial class CountryType
    {
        private CountryCodeType countryCodeField;
        private bool countryCodeFieldSpecified;
        private List<string> textField;
        public CountryType()
        {
            this.textField = new List<string>();
        }
        public CountryCodeType CountryCode
        {
            get { return this.countryCodeField; }
            set {
                if ((countryCodeField.Equals(value) != true))
                {
                    this.countryCodeField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool CountryCodeSpecified
        {
            get { return this.countryCodeFieldSpecified; }
            set {
                if ((countryCodeFieldSpecified.Equals(value) != true))
                {
                    this.countryCodeFieldSpecified = value;

                }
            }
        }
        [XmlText()]
        public List<string> Text
        {
            get { return this.textField; }
            set { this.textField = value; }
        }

    }
    public partial class DeliveryExtensionType
    {
        private DeliveryExtensionType1 deliveryExtensionField;
        private CustomType customField;
        public DeliveryExtensionType()
        {
            this.customField = new CustomType();
            this.deliveryExtensionField = new DeliveryExtensionType1();
        }
        public DeliveryExtensionType1 DeliveryExtension
        {
            get { return this.deliveryExtensionField; }
            set { this.deliveryExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class DeliveryExtensionType1
    {

    }
    public partial class OrderReferenceDetailType : OrderReferenceType
    {
        private string orderPositionNumberField = "";
        public string OrderPositionNumber
        {
            get { return this.orderPositionNumberField; }
            set { this.orderPositionNumberField = value; }
        }

    }
    [XmlInclude(typeof(OrderReferenceDetailType))]
    public partial class OrderReferenceType
    {
        private string orderIDField = "";
        private System.DateTime referenceDateField;
        private bool referenceDateFieldSpecified;
        private string descriptionField = "";
        public string OrderID
        {
            get { return this.orderIDField; }
            set { this.orderIDField = value; }
        }
        public System.DateTime ReferenceDate
        {
            get { return this.referenceDateField; }
            set {
                if ((referenceDateField.Equals(value) != true))
                {
                    this.referenceDateField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool ReferenceDateSpecified
        {
            get { return this.referenceDateFieldSpecified; }
            set {
                if ((referenceDateFieldSpecified.Equals(value) != true))
                {
                    this.referenceDateFieldSpecified = value;

                }
            }
        }
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

    }
    public partial class ItemListType
    {
        private string headerDescriptionField = "";
        private List<ListLineItemType> listLineItemField;
        private string footerDescriptionField = "";
        public ItemListType()
        {
            this.listLineItemField = new List<ListLineItemType>();
        }
        public string HeaderDescription
        {
            get { return this.headerDescriptionField; }
            set { this.headerDescriptionField = value; }
        }
        public List<ListLineItemType> ListLineItem
        {
            get { return this.listLineItemField; }
            set { this.listLineItemField = value; }
        }
        public string FooterDescription
        {
            get { return this.footerDescriptionField; }
            set { this.footerDescriptionField = value; }
        }
    }
    public partial class DetailsType
    {
        private string headerDescriptionField = "";
        private List<ItemListType> itemListField;
        private string footerDescriptionField = "";
        private List<BelowTheLineItemType> belowTheLineItemField;
        public DetailsType()
        {
            this.belowTheLineItemField = new List<BelowTheLineItemType>();
            this.itemListField = new List<ItemListType>();
        }
        public string HeaderDescription
        {
            get { return this.headerDescriptionField; }
            set { this.headerDescriptionField = value; }
        }
        public List<ItemListType> ItemList
        {
            get { return this.itemListField; }
            set { this.itemListField = value; }
        }
        public string FooterDescription
        {
            get { return this.footerDescriptionField; }
            set { this.footerDescriptionField = value; }
        }
        public List<BelowTheLineItemType> BelowTheLineItem
        {
            get { return this.belowTheLineItemField; }
            set { this.belowTheLineItemField = value; }
        }

        public void RecalcItemList()
        {
            foreach (ItemListType item in ItemList)
            {
                foreach (ListLineItemType lineItem in item.ListLineItem)
                {
                    lineItem.RecalcLineItem();
                }
            }
        }
    }
    public partial class OrderingPartyExtensionType1
    {

    }
    public partial class OrderingPartyExtensionType
    {
        private OrderingPartyExtensionType1 orderingPartyExtensionField;
        private CustomType customField;
        public OrderingPartyExtensionType()
        {
            this.customField = new CustomType();
            this.orderingPartyExtensionField = new OrderingPartyExtensionType1();
        }
        public OrderingPartyExtensionType1 OrderingPartyExtension
        {
            get { return this.orderingPartyExtensionField; }
            set { this.orderingPartyExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class InvoiceRecipientExtensionType1
    {

    }
    public partial class InvoiceRecipientExtensionType
    {
        private InvoiceRecipientExtensionType1 invoiceRecipientExtensionField;
        private CustomType customField;
        public InvoiceRecipientExtensionType()
        {
            this.customField = new CustomType();
            this.invoiceRecipientExtensionField = new InvoiceRecipientExtensionType1();
        }
        public InvoiceRecipientExtensionType1 InvoiceRecipientExtension
        {
            get { return this.invoiceRecipientExtensionField; }
            set { this.invoiceRecipientExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class BillerExtensionType1
    {
        private string billersContractPartnerNumberField = "";
        public string BillersContractPartnerNumber
        {
            get { return this.billersContractPartnerNumberField; }
            set { this.billersContractPartnerNumberField = value; }
        }

    }
    public partial class BillerExtensionType
    {
        private BillerExtensionType1 billerExtensionField;
        private CustomType customField;
        public BillerExtensionType()
        {
            this.customField = new CustomType();
            this.billerExtensionField = new BillerExtensionType1();
        }
        public BillerExtensionType1 BillerExtension
        {
            get { return this.billerExtensionField; }
            set { this.billerExtensionField = value; }
        }
        public CustomType Custom
        {
            get { return this.customField; }
            set { this.customField = value; }
        }

    }
    public partial class FurtherIdentificationType
    {
        private string identificationTypeField = "";
        private string valueField = "";
        public string IdentificationType
        {
            get { return this.identificationTypeField; }
            set { this.identificationTypeField = value; }
        }
        [XmlText()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }

    }
    [XmlInclude(typeof(OrderingPartyType))]
    [XmlInclude(typeof(InvoiceRecipientType))]
    [XmlInclude(typeof(BillerType))]
    public partial class AbstractPartyType
    {
        private string vATIdentificationNumberField = "";
        private List<FurtherIdentificationType> furtherIdentificationField;
        private OrderReferenceType orderReferenceField;
        private AddressType addressField;
        public AbstractPartyType()
        {
            this.addressField = new AddressType();
            this.orderReferenceField = new OrderReferenceType();
            this.furtherIdentificationField = new List<FurtherIdentificationType>();
        }
        public string VATIdentificationNumber
        {
            get { return this.vATIdentificationNumberField; }
            set { this.vATIdentificationNumberField = value; }
        }
        public List<FurtherIdentificationType> FurtherIdentification
        {
            get { return this.furtherIdentificationField; }
            set { this.furtherIdentificationField = value; }
        }
        public OrderReferenceType OrderReference
        {
            get { return this.orderReferenceField; }
            set { this.orderReferenceField = value; }
        }
        public AddressType Address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

    }
    public partial class OrderingPartyType : AbstractPartyType
    {
        private string billersOrderingPartyIDField = "";
        private OrderingPartyExtensionType orderingPartyExtensionField;
        public OrderingPartyType()
        {
            this.orderingPartyExtensionField = new OrderingPartyExtensionType();
        }
        public string BillersOrderingPartyID
        {
            get { return this.billersOrderingPartyIDField; }
            set { this.billersOrderingPartyIDField = value; }
        }
        public OrderingPartyExtensionType OrderingPartyExtension
        {
            get { return this.orderingPartyExtensionField; }
            set { this.orderingPartyExtensionField = value; }
        }

    }
    public partial class InvoiceRecipientType : AbstractPartyType
    {
        private string billersInvoiceRecipientIDField = "";
        private string accountingAreaField = "";
        private string subOrganizationIDField = "";
        private InvoiceRecipientExtensionType invoiceRecipientExtensionField;
        public InvoiceRecipientType()
        {
            this.invoiceRecipientExtensionField = new InvoiceRecipientExtensionType();
        }
        public string BillersInvoiceRecipientID
        {
            get { return this.billersInvoiceRecipientIDField; }
            set { this.billersInvoiceRecipientIDField = value; }
        }
        public string AccountingArea
        {
            get { return this.accountingAreaField; }
            set { this.accountingAreaField = value; }
        }
        public string SubOrganizationID
        {
            get { return this.subOrganizationIDField; }
            set { this.subOrganizationIDField = value; }
        }
        public InvoiceRecipientExtensionType InvoiceRecipientExtension
        {
            get { return this.invoiceRecipientExtensionField; }
            set { this.invoiceRecipientExtensionField = value; }
        }

    }
    public partial class BillerType : AbstractPartyType
    {
        private string invoiceRecipientsBillerIDField = "";
        private BillerExtensionType billerExtensionField;
        public BillerType()
        {
            this.billerExtensionField = new BillerExtensionType();
        }
        public string InvoiceRecipientsBillerID
        {
            get { return this.invoiceRecipientsBillerIDField; }
            set { this.invoiceRecipientsBillerIDField = value; }
        }
        public BillerExtensionType BillerExtension
        {
            get { return this.billerExtensionField; }
            set { this.billerExtensionField = value; }
        }

    }
    public partial class RelatedDocumentType
    {
        private string invoiceNumberField = "";
        private System.DateTime invoiceDateField;
        private bool invoiceDateFieldSpecified;
        private DocumentTypeType documentTypeField;
        private bool documentTypeFieldSpecified;
        private string commentField = "";
        public string InvoiceNumber
        {
            get { return this.invoiceNumberField; }
            set { this.invoiceNumberField = value; }
        }
        public System.DateTime InvoiceDate
        {
            get { return this.invoiceDateField; }
            set {
                if ((invoiceDateField.Equals(value) != true))
                {
                    this.invoiceDateField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool InvoiceDateSpecified
        {
            get { return this.invoiceDateFieldSpecified; }
            set {
                if ((invoiceDateFieldSpecified.Equals(value) != true))
                {
                    this.invoiceDateFieldSpecified = value;

                }
            }
        }
        public DocumentTypeType DocumentType
        {
            get { return this.documentTypeField; }
            set {
                if ((documentTypeField.Equals(value) != true))
                {
                    this.documentTypeField = value;

                }
            }
        }
        [XmlIgnore()]
        public bool DocumentTypeSpecified
        {
            get { return this.documentTypeFieldSpecified; }
            set {
                if ((documentTypeFieldSpecified.Equals(value) != true))
                {
                    this.documentTypeFieldSpecified = value;

                }
            }
        }
        public string Comment
        {
            get { return this.commentField; }
            set { this.commentField = value; }
        }

    }
    public enum CurrencyType
    {

        AED,

        AFN,

        ALL,

        AMD,

        ANG,

        AOA,

        ARS,

        AUD,

        AWG,

        AZN,

        BAM,

        BBD,

        BDT,

        BGN,

        BHD,

        BIF,

        BMD,

        BND,

        BOB,

        BOV,

        BRL,

        BSD,

        BTN,

        BWP,

        BYR,

        BZD,

        CAD,

        CDF,

        CHE,

        CHF,

        CHW,

        CLF,

        CLP,

        CNY,

        COP,

        COU,

        CRC,

        CUC,

        CUP,

        CVE,

        CZK,

        DJF,

        DKK,

        DOP,

        DZD,

        EGP,

        ERN,

        ETB,

        EUR,

        FJD,

        FKP,

        GBP,

        GEL,

        GHS,

        GIP,

        GMD,

        GNF,

        GTQ,

        GYD,

        HKD,

        HNL,

        HRK,

        HTG,

        HUF,

        IDR,

        ILS,

        INR,

        IQD,

        IRR,

        ISK,

        JMD,

        JOD,

        JPY,

        KES,

        KGS,

        KHR,

        KMF,

        KPW,

        KRW,

        KWD,

        KYD,

        KZT,

        LAK,

        LBP,

        LKR,

        LRD,

        LSL,

        LTL,

        LVL,

        LYD,

        MAD,

        MDL,

        MGA,

        MKD,

        MMK,

        MNT,

        MOP,

        MRO,

        MUR,

        MVR,

        MWK,

        MXN,

        MXV,

        MYR,

        MZN,

        NAD,

        NGN,

        NIO,

        NOK,

        NPR,

        NZD,

        OMR,

        PAB,

        PEN,

        PGK,

        PHP,

        PKR,

        PLN,

        PYG,

        QAR,

        RON,

        RSD,

        RUB,

        RWF,

        SAR,

        SBD,

        SCR,

        SDG,

        SEK,

        SGD,

        SHP,

        SLL,

        SOS,

        SRD,

        SSP,

        STD,

        SVC,

        SYP,

        SZL,

        THB,

        TJS,

        TMT,

        TND,

        TOP,

        TRY,

        TTD,

        TWD,

        TZS,

        UAH,

        UGX,

        USD,

        USN,

        USS,

        UYI,

        UYU,

        UZS,

        VEF,

        VND,

        VUV,

        WST,

        XAF,

        XAG,

        XAU,

        XBA,

        XBB,

        XBC,

        XBD,

        XCD,

        XDR,

        XFU,

        XOF,

        XPD,

        XPF,

        XPT,

        XSU,

        XTS,

        XUA,

        XXX,

        YER,

        ZAR,

        ZMK,

        ZWL,
    }
    public enum LanguageType
    {

        aar,

        abk,

        ace,

        ach,

        ada,

        ady,

        afa,

        afh,

        afr,

        aka,

        akk,

        alb,

        ale,

        alg,

        amh,

        ang,

        apa,

        ara,

        arc,

        arg,

        arm,

        arn,

        arp,

        art,

        arw,

        asm,

        ast,

        ath,

        aus,

        ava,

        ave,

        awa,

        aym,

        aze,

        bad,

        bai,

        bak,

        bal,

        bam,

        ban,

        baq,

        bas,

        bat,

        bej,

        bem,

        ben,

        ber,

        bho,

        bih,

        bik,

        bin,

        bis,

        bla,

        bnt,

        bod,

        bos,

        bra,

        bre,

        btk,

        bua,

        bug,

        bul,

        bur,

        byn,

        cad,

        cai,

        car,

        cat,

        cau,

        ceb,

        cel,

        ces,

        cha,

        chb,

        che,

        chg,

        chi,

        chk,

        chm,

        chn,

        cho,

        chp,

        chr,

        chu,

        chv,

        chy,

        cmc,

        cop,

        cor,

        cos,

        cpe,

        cpf,

        cpp,

        cre,

        crh,

        crp,

        csb,

        cus,

        cym,

        cze,

        dak,

        dan,

        dar,

        day,

        del,

        den,

        deu,

        dgr,

        din,

        div,

        doi,

        dra,

        dsb,

        dua,

        dum,

        dut,

        dyu,

        dzo,

        efi,

        egy,

        eka,

        ell,

        elx,

        eng,

        enm,

        epo,

        est,

        eus,

        ewe,

        ewo,

        fan,

        fao,

        fas,

        fat,

        fij,

        fil,

        fin,

        fiu,

        fon,

        fra,

        fre,

        frm,

        fro,

        fry,

        ful,

        fur,

        gaa,

        gay,

        gba,

        gem,

        geo,

        ger,

        gez,

        gil,

        gla,

        gle,

        glg,

        glv,

        gmh,

        goh,

        gon,

        gor,

        got,

        grb,

        grc,

        gre,

        grn,

        guj,

        gwi,

        hai,

        hat,

        hau,

        haw,

        heb,

        her,

        hil,

        him,

        hin,

        hit,

        hmn,

        hmo,

        hrv,

        hsb,

        hun,

        hup,

        hye,

        iba,

        ibo,

        ice,

        ido,

        iii,

        ijo,

        iku,

        ile,

        ilo,

        ina,

        inc,

        ind,

        ine,

        inh,

        ipk,

        ira,

        iro,

        isl,

        ita,

        jav,

        jbo,

        jpn,

        jpr,

        jrb,

        kaa,

        kab,

        kac,

        kal,

        kam,

        kan,

        kar,

        kas,

        kat,

        kau,

        kaw,

        kaz,

        kbd,

        kha,

        khi,

        khm,

        kho,

        kik,

        kin,

        kir,

        kmb,

        kok,

        kom,

        kon,

        kor,

        kos,

        kpe,

        krc,

        kro,

        kru,

        kua,

        kum,

        kur,

        kut,

        lad,

        lah,

        lam,

        lao,

        lat,

        lav,

        lez,

        lim,

        lin,

        lit,

        lol,

        loz,

        ltz,

        lua,

        lub,

        lug,

        lui,

        lun,

        luo,

        lus,

        mac,

        mad,

        mag,

        mah,

        mai,

        mak,

        mal,

        man,

        mao,

        map,

        mar,

        mas,

        may,

        mdf,

        mdr,

        men,

        mga,

        mic,

        min,

        mis,

        mkd,

        mkh,

        mlg,

        mlt,

        mnc,

        mni,

        mno,

        moh,

        mol,

        mon,

        mos,

        mri,

        msa,

        mul,

        mun,

        mus,

        mwl,

        mwr,

        mya,

        myn,

        myv,

        nah,

        nai,

        nap,

        nau,

        nav,

        nbl,

        nde,

        ndo,

        nds,

        nep,

        @new,

        nia,

        nic,

        niu,

        nld,

        nno,

        nob,

        nog,

        non,

        nor,

        nso,

        nub,

        nwc,

        nya,

        nym,

        nyn,

        nyo,

        nzi,

        oci,

        oji,

        ori,

        orm,

        osa,

        oss,

        ota,

        oto,

        paa,

        pag,

        pal,

        pam,

        pan,

        pap,

        pau,

        peo,

        per,

        phi,

        phn,

        pli,

        pol,

        pon,

        por,

        pra,

        pro,

        pus,

        que,

        raj,

        rap,

        rar,

        roa,

        roh,

        rom,

        ron,

        rum,

        run,

        rus,

        sad,

        sag,

        sah,

        sai,

        sal,

        sam,

        san,

        sas,

        sat,

        scc,

        scn,

        sco,

        scr,

        sel,

        sem,

        sga,

        sgn,

        shn,

        sid,

        sin,

        sio,

        sit,

        sla,

        slk,

        slo,

        slv,

        sma,

        sme,

        smi,

        smj,

        smn,

        smo,

        sms,

        sna,

        snd,

        snk,

        sog,

        som,

        son,

        sot,

        spa,

        sqi,

        srd,

        srp,

        srr,

        ssa,

        ssw,

        suk,

        sun,

        sus,

        sux,

        swa,

        swe,

        syr,

        tah,

        tai,

        tam,

        tat,

        tel,

        tem,

        ter,

        tet,

        tgk,

        tgl,

        tha,

        tib,

        tig,

        tir,

        tiv,

        tkl,

        tlh,

        tli,

        tmh,

        tog,

        ton,

        tpi,

        tsi,

        tsn,

        tso,

        tuk,

        tum,

        tup,

        tur,

        tut,

        tvl,

        twi,

        tyv,

        udm,

        uga,

        uig,

        ukr,

        umb,

        und,

        urd,

        uzb,

        vai,

        ven,

        vie,

        vol,

        vot,

        wak,

        wal,

        war,

        was,

        wel,

        wen,

        wln,

        wol,

        xal,

        xho,

        yao,

        yap,

        yid,

        yor,

        ypk,

        zap,

        zen,

        zha,

        zho,

        znd,

        zul,

        zun,
    }
    public partial class VATType
    {
        private List<VATItemType> vATItemField;
        public VATType()
        {
            this.vATItemField = new List<VATItemType>();
        }
        public List<VATItemType> VATItem
        {
            get { return this.vATItemField; }
            set { this.vATItemField = value; }
        }
    }

    // Mit ebInterface 5p0
    public partial class AdditionalInformationType
    {

        private string keyField;

        private string valueField;

        /// <remarks/>

        public string Key
        {
            get { return this.keyField; }
            set { this.keyField = value; }
        }
    }
}
