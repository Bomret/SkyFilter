using System;
using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests
{
    [Subject(typeof (GenerateTableFilter), "WhereNotEquals")]
    internal class When_I_generate_a_filter_where_a_guid_row_key_not_equals_the_empty_guid
    {
        private static string _expectedFilter;
        private static IGenerateTableQueryFilters _sut;
        private static IAzureTableFilter _result;

        private Establish ctx = () => _expectedFilter = "RowKey ne guid'00000000-0000-0000-0000-000000000000'";

        private Because of = () => _result = GenerateTableFilter.WhereNotEqual("RowKey", Guid.Empty);

        private It should_return_the_expected_filter = () => _result.AsAzureTableFilter.Should().Be(_expectedFilter);
    }
}