using X937.Attributes;

/// <summary>
/// Record Type 61 Credit Reconciliation for Bank of America Merill Lync
/// </summary>
namespace X937.Records
{
    /// <summary>
    /// Credit Reconciliation (Type 61).  This could be a 1 off but this is from BOA documentation.  Let's hope we dont have to get
    /// into a habit of doing these like this.
    /// </summary>
    public class CreditReconciliation : Record
    {
        /// <summary>
        /// Record Usage Indicator
        /// Conditional
        /// Size 1
        /// Type AN
        /// </summary>
        [IntegerField( 2, 1 )]
        public int RecordUsageIndicator { get; set; }

        /// <summary>
        /// Auxiliary On-Us
        /// Conditional
        /// Size 15
        /// Type NBMcd
        /// </summary>
        [TextField( 3, 15 )]
        public string AuxiliaryOnUs { get; set; }

        /// <summary>
        /// External Processing Code
        /// Conditional 
        /// Size 1
        /// Type ANS
        /// </summary>
        [TextField( 4, 1 )]
        public string ExternalProcessingCode { get; set; }

        /// <summary>
        /// Posting Account Routing Number
        /// Mandatory
        /// Size 9
        /// Type NBMcd
        /// </summary>
        [TextField( 5, 9 )]
        public string PostingAccountRoutingNumber { get; set; }

        /// <summary>
        /// Posting Account Bank On Us
        /// Conditional
        /// Size 20
        /// Type NBMcdo
        /// </summary>
        [TextField( 6, 20 )]
        public string PostingAccountBankOnUs { get; set; }

        /// <summary>
        /// Item Amount
        /// Mandatory
        /// Size 10
        /// Type Number
        /// </summary>
        [MoneyField( 7, 10 )]
        public decimal ItemAmount { get; set; }

        /// <summary>
        /// ECE Institution Sequence Number
        /// Mandatory
        /// Size 15
        /// Type NB
        /// </summary>
        [TextField( 8, 15 )]
        public string ECEInstitutionSequenceNumber { get; set; }

        /// <summary>
        /// Documentation Type Indicator
        /// Conditional
        /// Size 1
        /// Type AN
        /// </summary>
        [TextField( 9, 1 )]
        public string DocumentationTypeIndicator { get; set; }

        /// <summary>
        /// Type Of Account Code
        /// Conditional
        /// Size 1
        /// Type N
        /// </summary>
        [IntegerField( 10, 1 )]
        public int TypeOfAccountCode { get; set; }

        /// <summary>
        /// Source Of Work
        /// Conditional
        /// Size 2
        /// Type N
        /// </summary>
        [IntegerField( 11, 2 )]
        public int SourceOfWork { get; set; }
        
        /// <summary>
        /// Reserved
        /// Mandatory
        /// Size 3
        /// Type AB
        /// </summary>
        [TextField( 12, 3 )]
        public string Reserved { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="recordType"></param>
        public CreditReconciliation() 
            : base(61)
        {
        }
    }
}
