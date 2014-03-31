# SkyFilter
Easy creation and fluent combination of Microsoft Azure table filters.

## Creating filters
To create a filter use the static class `GenerateTableFilter`.

```csharp
var filter = GenerateTableFilter.WhereNotEquals("RowKey", Guid.Empty);

// RowKey ne guid'00000000-0000-0000-0000-000000000000'
```

## Combining filters
Filters provide three methods to combine them with other filters: `And`, `Or` and `Not`. Those return the combined filter:

```csharp
var filter1 = GenerateTableFilter.WhereEqual("PartitionKey", "hello");
var filter2 = GenerateTableFilter.WhereNotEqual("RowKey", Guid.Empty);

var combined = filter1.And(filter2);

// (PartitionKey eq 'hello') and (RowKey ne guid'00000000-0000-0000-0000-000000000000')
```

You can group filters logically by combining them:

```csharp
var filter1 = GenerateTableFilter.WhereEqual("PartitionKey", "hello");
var filter2 = GenerateTableFilter.WhereNotEqual("RowKey", Guid.Empty);
var filter3 = GenerateTableFilter.WhereEqual("Name", "John");
var filter4 = GenerateTableFilter.WhereGreaterThanOrEqual("Age", 25);

var combined = filter1.And(filter2).And(filter3.Or(filter4));

// ((PartitionKey eq 'hello') and (RowKey ne guid'00000000-0000-0000-0000-000000000000')) and ((Name eq 'John') or (Age ge 25))
```

## Using filters
To use a filter for a table query, get the constructed Azure table filter string with the `AsFilterCondition` property:

```csharp
var filter = GenerateTableFilter.WhereNotEquals("RowKey", Guid.Empty);
var azureFilter = filter1.AsFilterCondition;

// "RowKey ne guid'00000000-0000-0000-0000-000000000000'"
```