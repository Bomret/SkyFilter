using System;

namespace SkyFilter.Azure.Contracts
{
    public interface IGenerateAzureTableFilters
    {
        IAzureTableFilter WhereLessThan(string propertyName, string expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, Guid expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, int expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, double expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, long expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, DateTimeOffset expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, byte[] expectedValue);
        IAzureTableFilter WhereLessThan(string propertyName, bool expectedValue);

        IAzureTableFilter WhereLessThanOrEqual(string propertyName, string expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, Guid expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, int expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, double expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, long expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, DateTimeOffset expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, byte[] expectedValue);
        IAzureTableFilter WhereLessThanOrEqual(string propertyName, bool expectedValue);

        IAzureTableFilter WhereEqual(string propertyName, string expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, Guid expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, int expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, double expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, long expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, DateTimeOffset expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, byte[] expectedValue);
        IAzureTableFilter WhereEqual(string propertyName, bool expectedValue);

        IAzureTableFilter WhereNotEqual(string propertyName, string expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, Guid expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, int expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, double expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, long expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, DateTimeOffset expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, byte[] expectedValue);
        IAzureTableFilter WhereNotEqual(string propertyName, bool expectedValue);

        IAzureTableFilter WhereGreaterThan(string propertyName, string expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, Guid expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, int expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, double expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, long expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, DateTimeOffset expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, byte[] expectedValue);
        IAzureTableFilter WhereGreaterThan(string propertyName, bool expectedValue);

        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, string expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, Guid expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, int expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, double expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, long expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, DateTimeOffset expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, byte[] expectedValue);
        IAzureTableFilter WhereGreaterThanOrEqual(string propertyName, bool expectedValue);
    }
}