using System;
using System.Diagnostics;
using Microsoft.WindowsAzure.Storage.Table;
using SkyFilter.Azure.Contracts;

namespace SkyFilter.Azure.Tables
{
    [DebuggerDisplay("{_filter}")]
    public sealed class AzureTableFilter : IAzureTableFilter, IEquatable<IAzureTableFilter>
    {
        private readonly string _filter;

        internal AzureTableFilter(string filter)
        {
            _filter = filter;
        }

        public string AsFilterCondition
        {
            get { return _filter; }
        }

        public IAzureTableFilter And(IAzureTableFilter other)
        {
            var combined = TableQuery.CombineFilters(_filter, TableOperators.And, other.AsFilterCondition);

            return new AzureTableFilter(combined);
        }

        public IAzureTableFilter Or(IAzureTableFilter other)
        {
            var combined = TableQuery.CombineFilters(_filter, TableOperators.Or, other.AsFilterCondition);

            return new AzureTableFilter(combined);
        }

        public IAzureTableFilter Not(IAzureTableFilter other)
        {
            var combined = TableQuery.CombineFilters(_filter, TableOperators.Not, other.AsFilterCondition);

            return new AzureTableFilter(combined);
        }

        #region Equality

        public bool Equals(IAzureTableFilter other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return string.Equals(_filter, other.AsFilterCondition);
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