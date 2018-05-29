
using X937.Attributes;

namespace X937.Records
{
    public class BundleControl : Record
    {
        [IntegerField( 2, 4 )]
        public int ItemCount { get; set; }

        [MoneyField( 3, 12 )]
        public decimal TotalAmount { get; set; }

        [MoneyField( 4, 12 )]
        public decimal? MICRValidTotalAmount { get; set; }

        [IntegerField( 5, 5 )]
        public int ImageCount { get; set; }

        [TextField( 6, 20 )]
        public string UserField { get; set; }

        [TextField( 7, 25 )]
        protected string Reserved { get; set; }

        public BundleControl()
            : base( 70 )
        {
        }
    }
}
