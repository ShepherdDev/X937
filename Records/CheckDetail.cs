
using X937.Attributes;

namespace X937.Records
{
    public class CheckDetail : Record
    {
        [TextField( 2, 15, FieldJustification.Right )]
        public string AuxiliaryOnUs { get; set; }

        [TextField( 3, 1 )]
        public string ExternalProcessingCode { get; set; }

        [TextField( 4, 8 )]
        public string PayorBankRoutingNumber { get; set; }

        [TextField( 5, 1 )]
        public string PayorBankRoutingNumberCheckDigit { get; set; }

        [TextField( 6, 20, FieldJustification.Right )]
        public string OnUs { get; set; }

        [MoneyField( 7, 10 )]
        public decimal ItemAmount { get; set; }

        [TextField( 8, 15, FieldJustification.Right )]
        public string ClientInstitutionItemSequenceNumber { get; set; }

        [TextField( 9, 1 )]
        public string DocumentationTypeIndicator { get; set; }

        [TextField( 10, 1 )]
        public string ElectronicReturnAcceptanceIndicator { get; set; }

        [IntegerField( 11, 1 )]
        public int? MICRValidIndicator { get; set; }

        [TextField( 12, 1 )]
        public string BankOfFirstDepositIndicator { get; set; }

        [IntegerField( 13, 2 )]
        public int CheckDetailRecordAddendumCount { get; set; }

        [TextField( 14, 1 )]
        public string CorrectionIndicator { get; set; }

        [TextField( 15, 1 )]
        public string ArchiveTypeIndicator { get; set; }

        public CheckDetail()
            : base( 25 )
        {
        }
    }
}
