namespace X937
{
    public interface IRecordFactory
    {
        /// <summary>
        /// Gets a new Record instance that is appropriate for the given record type.
        /// </summary>
        /// <param name="recordType">The type of record.</param>
        /// <returns></returns>
        Record GetRecordForType( int recordType );
    }
}
