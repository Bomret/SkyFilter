namespace SkyFilter.Azure.Contracts
{
    public interface IAzureTableFilter
    {
        string AsFilterCondition { get; }
        IAzureTableFilter And(IAzureTableFilter other);
        IAzureTableFilter Or(IAzureTableFilter other);
        IAzureTableFilter Not(IAzureTableFilter other);
    }
}