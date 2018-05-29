using System;

using X937.Attributes;

namespace X937.Records
{
    public class ImageViewDetail : Record
    {
        [IntegerField( 2, 1 )]
        public int ImageIndicator { get; set; }

        [TextField( 3, 9 )]
        public string ImageCreatorRoutingNumber { get; set; }

        [DateField( 4 )]
        public DateTime ImageCreatorDate { get; set; }

        [IntegerField( 5, 2 )]
        public int? ImageViewFormatIndicator { get; set; }

        [IntegerField( 6, 2 )]
        public int? CompressionAlgorithmIdentifier { get; set; }

        [IntegerField( 7, 7 )]
        public int DataSize { get; set; }

        [IntegerField( 8, 1 )]
        public int SideIndicator { get; set; }

        [IntegerField( 9, 2 )]
        public int ViewDescriptor { get; set; }

        [IntegerField( 10, 1 )]
        public int? DigitalSignatureIndicator { get; set; }

        [IntegerField( 11, 2 )]
        public int? DigitalSignatureMethod { get; set; }

        [IntegerField( 12, 5 )]
        public int? SecurityKeySize { get; set; }

        [IntegerField( 13, 7 )]
        public int? StartOfProtectedData { get; set; }

        [IntegerField( 14, 7 )]
        public int? LengthOfProtectedData { get; set; }

        [IntegerField( 15, 1 )]
        public int? ImageRecreateIndicator { get; set; }

        [TextField( 16, 8 )]
        public string UserField { get; set; }

        [TextField( 17, 15 )]
        protected string Reserved { get; set; }

        public ImageViewDetail()
            : base( 50 )
        {
        }
    }
}
