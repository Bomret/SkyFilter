using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests.WhereNotEqual
{
    [Subject(typeof(GenerateTableFilter), "WhereNotEquals")]
    internal class When_I_generate_a_filter_where_a_boolean_partition_key_not_equals_true
    {
        private static string _expectedFilter;
        private static IAzureTableFilter _result;

        private Establish ctx = () => _expectedFilter = "PartitionKey ne true";

        private Because of = () => _result = GenerateTableFilter.WhereNotEqual("PartitionKey", true);

        private It should_return_the_expected_filter = () => _result.AsFilterCondition.Should().Be(_expectedFilter);
    }
}