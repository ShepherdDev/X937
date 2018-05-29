using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X937
{
    public static class StringExtensions
    {
        public static string Left( this string value, int size )
        {
            if ( value == null )
            {
                return null;
            }

            if ( value.Length > size )
            {
                return value.Substring( 0, size );
            }

            return value;
        }

        public static string Right( this string value, int size )
        {
            if ( value == null )
            {
                return null;
            }

            if ( value.Length > size )
            {
                return value.Substring( value.Length - size, size );
            }

            return value;
        }
    }
}
