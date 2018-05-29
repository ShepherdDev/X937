using System;

using X937.Attributes;

namespace X937.Records
{
    public class FileHeader : Record
    {
        [IntegerField( 2, 2 )]
        public int StandardLevel { get; protected set; }

        [TextField( 3, 1 )]
        public string FileTypeIndicator { get; set; }

        [TextField( 4, 9 )]
        public string ImmediateDestinationRoutingNumber { get; set; }

        [TextField( 5, 9 )]
        public string ImmediateOriginRoutingNumber { get; set; }

        [DateTimeField( 6 )]
        public DateTime FileCreationDateTime { get; set; }

        [TextField( 8, 1 )]
        public string ResendIndicator { get; set; }

        [TextField( 9, 18 )]
        public string ImmediateDestinationName { get; set; }

        [TextField( 10, 18 )]
        public string ImmediateOriginName { get; set; }

        [TextField( 11, 1 )]
        public string FileIdModifier { get; set; }

        [TextField( 12, 2 )]
        public string CountryCode { get; set; }

        [TextField( 13, 4 )]
        public string UserField { get; set; }

        [TextField( 14, 1 )]
        protected string Reserved { get; set; }

        public FileHeader()
            : base( 01 )
        {
        }
    }
}
