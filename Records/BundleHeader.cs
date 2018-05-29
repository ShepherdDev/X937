using System;

using X937.Attributes;

namespace X937.Records
{
    public class BundleHeader : Record
    {
        [IntegerField( 2, 2 )]
        public int CollectionTypeIndicator { get; set; }

        [TextField( 3, 9 )]
        public string DestinationRoutingNumber { get; set; }

        [TextField( 4, 9 )]
        public string ClientInstitutionRoutingNumber { get; set; }

        [DateField( 5 )]
        public DateTime BusinessDate { get; set; }

        [DateField( 6 )]
        public DateTime CreationDate { get; set; }

        [TextField( 7, 10 )]
        public string ID { get; set; }

        [TextField( 8, 4 )]
        public string SequenceNumber { get; set; }

        [TextField( 9, 2 )]
        public string CycleNumber { get; set; }

        [TextField( 10, 9 )]
        public string ReturnLocationRoutingNumber { get; set; }
        
        [TextField( 11, 5 )]
        public string UserField { get; set; }

        [TextField( 12, 12 )]
        protected string Reserved { get; set; }

        public BundleHeader()
            : base( 20 )
        {
        }
    }
}
