using System;
using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests
{
    [Subject(typeof (AzureTableFilter), "And")]
    internal class When_I_combine_two_filters_with_and
    {
        private static string _expectedFilter;
        private static IAzureTableFilter _result;

        private static IAzureTableFilter _filter1;
        private static IAzureTableFilter _filter2;

        private Establish ctx = () =>
            {
                _filter1 = GenerateTableFilter.WhereEqual("PartitionKey", "hello");
                _filter2 = GenerateTableFilter.WhereNotEqual("RowKey", Guid.Empty);

                _expectedFilter = "(PartitionKey eq 'hello') and (RowKey ne guid'00000000-0000-0000-0000-000000000000')";
            };

        private Because of = () => _result = _filter1.And(_filter2);

        private It should_return_the_expected_filter = () => _result.AsAzureTableFilter.Should().Be(_expectedFilter);
    }
}