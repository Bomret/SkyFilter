using System;
using Microsoft.WindowsAzure.Storage.Table;
using SkyFilter.Azure.Contracts;

namespace SkyFilter.Azure.Tables
{
    public sealed class TableFilter : IAzureTableFilter, IEquatable<IAzureTableFilter>
    {
        private readonly string _filter;

        public TableFilter(string filter)
        {
            _filter = filter;
        }

        public string AsAzureTableFilter
        {
            get { return _filter; }
        }

        public IAzureTableFilter And(IAzureTableFilter other)
        {
            var combined = TableQuery.CombineFilters(_filter, TableOperators.And, other.AsAzureTableFilter);

            return new TableFilter(combined);
        }

        public IAzureTableFilter Or(IAzureTableFilter other)
        {
            var combined = TableQuery.CombineFilters(_filter, TableOperators.Or, other.AsAzureTableFilter);

            return new TableFilter(combined);
        }

        public IAzureTableFilter Not(IAzureTableFilter other)
        {
            var combined = TableQuery.CombineFilters(_filter, TableOperators.Not, other.AsAzureTableFilter);

            return new TableFilter(combined);
        }

        #region Equality

        public bool Equals(IAzureTableFilter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return string.Equals(_filter, other.AsAzureTableFilter);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IAzureTableFilter && Equals((IAzureTableFilter) obj);
        }

        public override int GetHashCode()
        {
            return (_filter != null ? _filter.GetHashCode() : 0);
        }

        #endregion
    }
}