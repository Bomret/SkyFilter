using System;
using System.Globalization;
using System.Linq;
using System.Text;

#if WINDOWS_RT    
    using System.Runtime.InteropServices.WindowsRuntime;
#endif

namespace SkyFilter.Azure.Tables
{
    internal static class CreateFilter
    {
        public static string From(string propertyName, string op, string expectedValue)
        {
            var withEscapedSingleQuotes = expectedValue.Replace("'", "''");

            return string.Format(CultureInfo.InvariantCulture, "{0} {1} '{2}'", propertyName, op, withEscapedSingleQuotes);
        }

        public static string From(string propertyName, string op, Guid expectedValue)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} guid'{2}'", propertyName, op, expectedValue);
        }

        public static string From(string propertyName, string op, int expectedValue)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}", propertyName, op, Convert.ToString(expectedValue, CultureInfo.InvariantCulture));
        }

        public static string From(string propertyName, string op, long expectedValue)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}L", propertyName, op, Convert.ToString(expectedValue, CultureInfo.InvariantCulture));
        }

        public static string From(string propertyName, string op, double expectedValue)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}", propertyName, op, Convert.ToString(expectedValue, CultureInfo.InvariantCulture));
        }

        public static string From(string propertyName, string op, DateTimeOffset expectedValue)
        {
            var stringifiedDate = expectedValue.UtcDateTime.ToString("o", CultureInfo.InvariantCulture);

            return string.Format(CultureInfo.InvariantCulture, "{0} {1} datetime'{2}'", propertyName, op, stringifiedDate);
        }

        public static string From(string propertyName, string op, bool expectedValue)
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}", propertyName, op, expectedValue ? "true" : "false");
        }

        public static string From(string propertyName,
                                  string op,
#if WINDOWS_RT
            [ReadOnlyArray]
#endif
                                  byte[] expectedValue)
        {
            var asHexString = expectedValue.Aggregate(new StringBuilder(), (b, c) => b.AppendFormat("{0:x2}", c));

            return string.Format(CultureInfo.InvariantCulture, "{0} {1} X'{2}'", propertyName, op, asHexString);
        }
    }
}