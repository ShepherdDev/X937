using System;

using X937.Attributes;

namespace X937.Records
{
    public class CashLetterControl : Record
    {
        [IntegerField( 2, 6 )]
        public int BundleCount { get; set; }

        [IntegerField( 3, 8 )]
        public int ItemCount { get; set; }

        [MoneyField( 4, 14 )]
        public decimal TotalAmount { get; set; }

        [IntegerField( 5, 9 )]
        public int? ImageCount { get; set; }

        [TextField( 6, 18 )]
        public string ECEInstitutionName { get; set; }

        [DateField( 7 )]
        public DateTime SettlementDate { get; set; }

        [TextField( 8, 15 )]
        protected string Reserved { get; set; }

        public CashLetterControl()
            : base( 90 )
        {
        }
    }
}
