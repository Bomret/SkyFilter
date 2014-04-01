using System;
using FluentAssertions;
using Machine.Specifications;
using SkyFilter.Azure.Contracts;
using SkyFilter.Azure.Tables;

namespace SkyFilter.Azure.Tests.WhereEquals
{
    [Subject(typeof(GenerateTableFilter), "WhereEqual")]
    internal class When_I_generate_a_filter_where_a_datetime_partition_key_equals_july_10th_2001_noon
    {
        private static string _expectedFilter;
        private static IAzureTableFilter _result;

        private Establish ctx = () => _expectedFilter = "PartitionKey eq datetime'2001-07-10T12:00:00.0000000Z'";

        private Because of = () => _result = GenerateTableFilter.WhereEqual("PartitionKey", new DateTimeOffset(2001,7,10,12,0,0,TimeSpan.Zero));

        private It should_return_the_expected_filter = () => _result.AsFilterCondition.Should().Be(_expectedFilter);
    }
}