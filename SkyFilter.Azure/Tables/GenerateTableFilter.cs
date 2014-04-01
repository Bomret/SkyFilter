using System;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Types;
using SkyFilter.Azure.Util;

namespace SkyFilter.Azure.Tables
{
    public static class GenerateTableFilter
    {
        public static IAzureTableFilter WhereLessThan(string propertyName, string expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, Guid expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, int expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, double expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, long expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, byte[] expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, bool expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, string expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, Guid expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, int expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, double expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, long expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, byte[] expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, bool expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, string expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, Guid expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, int expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, double expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, long expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, byte[] expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, bool expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, string expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, Guid expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, int expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, double expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, long expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, byte[] expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, bool expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, string expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, Guid expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, int expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, double expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, long expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, byte[] expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, bool expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, string expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, Guid expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, int expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, double expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, long expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, byte[] expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, bool expectedValue)
        {
            var filter = CreateFilter.From(propertyName, FilterOps.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }
    }
}