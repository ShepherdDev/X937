using System;

using X937.Attributes;

namespace X937.Records
{
    public class CashLetterHeader : Record
    {
        [IntegerField( 2, 2 )]
        public int CollectionTypeIndicator { get; set; }

        [TextField( 3, 9 )]
        public string DestinationRoutingNumber { get; set; }

        [TextField( 4, 9 )]
        public string ClientInstitutionRoutingNumber { get; set; }

        [DateField( 5 )]
        public DateTime BusinessDate { get; set; }

        [DateTimeField( 6 )]
        public DateTime CreationDateTime { get; set; }

        [TextField( 8, 1 )]
        public string RecordTypeIndicator { get; set; }

        [TextField( 9, 1 )]
        public string DocumentationTypeIndicator { get; set; }

        [TextField( 10, 8 )]
        public string ID { get; set; }

        [TextField( 11, 14 )]
        public string OriginatorContactName { get; set; }

        [TextField( 12, 10 )]
        public string OriginatorContactPhoneNumber { get; set; }

        [TextField( 13, 1 )]
        public string WorkType { get; set; }

        [TextField( 14, 2 )]
        public string UserField { get; set; }

        [TextField( 15, 1 )]
        protected string Reserved { get; set; }

        public CashLetterHeader()
            : base( 10 )
        {
        }
    }
}
