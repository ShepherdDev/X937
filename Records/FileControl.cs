
using X937.Attributes;

namespace X937.Records
{
    public class FileControl : Record
    {
        [IntegerField( 2, 6 )]
        public int CashLetterCount { get; set; }

        [IntegerField( 3, 8 )]
        public int TotalRecordCount { get; set; }

        [IntegerField( 4, 8 )]
        public int TotalItemCount { get; set; }

        [MoneyField( 5, 16 )]
        public decimal TotalAmount { get; set; }

        [TextField( 6, 14 )]
        public string ImmediateOriginContactName { get; set; }

        [TextField( 7, 10 )]
        public string ImmediateOriginContactPhoneNumber { get; set; }

        [TextField( 8, 16 )]
        protected string Reserved { get; set; }

        public FileControl()
            : base( 99 )
        {
        }
    }
}
