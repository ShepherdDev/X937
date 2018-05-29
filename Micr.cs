using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X937
{
    public class Micr
    {
        #region Fields

        private string _content;

        #endregion

        #region Constructors

        public Micr( string content )
        {
            if ( content == null )
            {
                _content = string.Empty;
            }
            else if ( !content.Contains( "d" ) )
            {
                throw new ArgumentException( "Argument does not contain valid micr data.", "content" );
            }
            else
            {
                int index = content.IndexOf( 'd' ); // 2

                _content = content.Left( content.Length - ( content.Length - 43 - index ) );

            }
        }

        #endregion

        public string GetCharacterFields( int start, int end )
        {
            // "12345"
            // len = 5
            // start = 1
            // end = 5

            if ( start > _content.Length )
            {
                return string.Empty;
            }

            if ( end > _content.Length )
            {
                end = _content.Length;
            }

            return _content.Substring( _content.Length - end, end - start + 1 );
        }

        public string GetField( int field )
        {
            switch ( field )
            {
                case 1:
                    return GetCharacterFields( 1, 12 ).Trim();

                case 2:
                    var f2 = GetCharacterFields( 13, 32 );

                    return f2.Substring( f2.IndexOf( 'c' ) + 1 ).Trim();

                case 3:
                    var f3 = GetCharacterFields( 13, 32 );

                    return f3.Substring( 0, f3.IndexOf( 'c' ) + 1 ).Trim();

                case 5:
                    return GetCharacterFields( 33, 43 ).Trim();

                case 6:
                    return GetCharacterFields( 44, 44 ).Trim();

                case 7:
                    return GetCharacterFields( 45, 1000 ).Trim();

                default:
                    throw new ArgumentOutOfRangeException( "field", "Field must be a valid MICR field number" );
            }
        }
    }
}
