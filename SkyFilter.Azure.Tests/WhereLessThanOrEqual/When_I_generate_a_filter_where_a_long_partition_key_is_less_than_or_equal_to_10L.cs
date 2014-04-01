using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests.WhereLessThanOrEqual
{
    [Subject(typeof(GenerateTableFilter), "WhereLessThanOrEqual")]
    internal class When_I_generate_a_filter_where_a_long_partition_key_is_less_than_or_equal_to_10L
    {
        private static string _expectedFilter;
        private static IAzureTableFilter _result;

        private Establish ctx = () => _expectedFilter = "PartitionKey le 10L";

        private Because of = () => _result = GenerateTableFilter.WhereLessThanOrEqual("PartitionKey", 10L);

        private It should_return_the_expected_filter = () => _result.AsFilterCondition.Should().Be(_expectedFilter);
    }
}