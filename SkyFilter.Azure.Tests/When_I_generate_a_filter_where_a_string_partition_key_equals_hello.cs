using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests
{
    [Subject(typeof (GenerateAzureTableFilter), "WhereEquals")]
    internal class When_I_generate_a_filter_where_a_string_partition_key_equals_hello
    {
        private static string _expectedFilter;
        private static IGenerateAzureTableFilters _sut;
        private static IAzureTableFilter _result;

        private Establish ctx = () =>
            {
                _sut = new GenerateAzureTableFilter();

                _expectedFilter = "PartitionKey eq 'hello'";
            };

        private Because of = () => _result = _sut.WhereEqual("PartitionKey", "hello");

        private It should_return_the_expected_filter = () => _result.AsAzureTableFilter.Should().Be(_expectedFilter);
    }
}