using System;
using System.Collections.Generic;

namespace X937
{
    public class DefaultRecordFactory : IRecordFactory
    {
        #region Properties

        /// <summary>
        /// Gets or sets the types used when instantiating new records.
        /// </summary>
        /// <value>
        /// The types used when instantiating new records.
        /// </value>
        public Dictionary<int, Type> Types { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRecordFactory"/> class.
        /// </summary>
        public DefaultRecordFactory()
        {
            Types = new Dictionary<int, Type>
            {
                { 1, typeof( Records.FileHeader ) },
                { 10, typeof( Records.CashLetterHeader ) },
                { 20, typeof( Records.BundleHeader ) },
                { 25, typeof( Records.CheckDetail ) },
                { 26, typeof( Records.CheckDetailAddendumA)  },
                { 50, typeof( Records.ImageViewDetail ) },
                { 52, typeof( Records.ImageViewData ) },
                { 61, typeof( Records.CreditDetail ) },
                { 70, typeof( Records.BundleControl ) },
                { 90, typeof( Records.CashLetterControl ) },
                { 99, typeof( Records.FileControl ) }
            };
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a new Record instance that is appropriate for the given record type.
        /// </summary>
        /// <param name="recordType">The type of record.</param>
        /// <returns></returns>
        public virtual Record GetRecordForType( int recordType )
        {
            if ( Types.ContainsKey( recordType ) )
            {
                return ( Record ) Activator.CreateInstance( Types[recordType] );
            }
            else
            {
                throw new ArgumentOutOfRangeException( nameof( recordType ), $"Unknown record type '{recordType}' found." );
            }
        }

        #endregion
    }
}
