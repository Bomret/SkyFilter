using System;
using Microsoft.WindowsAzure.Storage.Table;
using SkyFilter.Azure.Contracts;

namespace SkyFilter.Azure.Tables
{
    public static class GenerateTableFilter
    {
        public static IAzureTableFilter WhereLessThan(string propertyName, string expectedValue)
        {
            var filter = TableQuery.GenerateFilterCondition(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, Guid expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForGuid(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, int expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForInt(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, double expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDouble(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, long expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForLong(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDate(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, byte[] expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBinary(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThan(string propertyName, bool expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBool(propertyName, QueryComparisons.LessThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, string expectedValue)
        {
            var filter = TableQuery.GenerateFilterCondition(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, Guid expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForGuid(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, int expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForInt(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, double expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDouble(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, long expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForLong(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDate(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, byte[] expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBinary(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereLessThanOrEqual(string propertyName, bool expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBool(propertyName, QueryComparisons.LessThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, string expectedValue)
        {
            var filter = TableQuery.GenerateFilterCondition(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, Guid expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForGuid(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, int expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForInt(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, double expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDouble(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, long expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForLong(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDate(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, byte[] expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBinary(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereEqual(string propertyName, bool expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBool(propertyName, QueryComparisons.Equal, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, string expectedValue)
        {
            var filter = TableQuery.GenerateFilterCondition(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, Guid expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForGuid(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, int expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForInt(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, double expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDouble(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, long expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForLong(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDate(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, byte[] expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBinary(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereNotEqual(string propertyName, bool expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBool(propertyName, QueryComparisons.NotEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, string expectedValue)
        {
            var filter = TableQuery.GenerateFilterCondition(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, Guid expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForGuid(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, int expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForInt(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, double expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDouble(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, long expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForLong(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDate(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, byte[] expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBinary(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThan(string propertyName, bool expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBool(propertyName, QueryComparisons.GreaterThan, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, string expectedValue)
        {
            var filter = TableQuery.GenerateFilterCondition(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, Guid expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForGuid(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, int expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForInt(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, double expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDouble(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, long expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForLong(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, DateTimeOffset expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForDate(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, byte[] expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBinary(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }

        public static IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, bool expectedValue)
        {
            var filter = TableQuery.GenerateFilterConditionForBool(propertyName, QueryComparisons.GreaterThanOrEqual, expectedValue);

            return new AzureTableFilter(filter);
        }
    }
}