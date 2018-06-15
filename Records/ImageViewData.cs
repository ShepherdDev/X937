using System;

using X937.Attributes;

namespace X937.Records
{
    public class ImageViewData : Record
    {
        [TextField( 2, 9 )]
        public string InstitutionRoutingNumber { get; set; }

        [DateField( 3 )]
        public DateTime BundleBusinessDate { get; set; }

        [TextField( 4, 2 )]
        public string CycleNumber { get; set; }

        [TextField( 5, 15, FieldJustification.Right )]
        public string ClientInstitutionItemSequenceNumber { get; set; }

        [TextField( 6, 16 )]
        public string SecurityOriginatorName { get; set; }

        [TextField( 7, 16 )]
        public string SecurityAuthenticatorName { get; set; }

        [TextField( 8, 16 )]
        public string SecurityKeyName { get; set; }

        [IntegerField( 9, 1 )]
        public int? ClippingOrigin { get; set; }

        [IntegerField( 10, 4 )]
        public int? ClippingCoordinateH1 { get; set; }

        [IntegerField( 11, 4 )]
        public int? ClippingCoordinateH2 { get; set; }
        
        [IntegerField( 12, 4 )]
        public int? ClippingCoordinateV1 { get; set; }

        [IntegerField( 13, 4 )]
        public int? ClippingCoordinateV2 { get; set; }

        [VariableTextField( 14, 4 )]
        public string ImageReferenceKey { get; set; }

        [VariableBinaryField( 16, 5 )]
        public byte[] DigitalSignature { get; set; }

        [VariableBinaryField( 17, 7 )]
        public byte[] ImageData { get; set; }

        public ImageViewData()
            : base( 52 )
        {
        }
    }
}
