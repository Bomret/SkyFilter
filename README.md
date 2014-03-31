# SkyFilter
---------
Easy creation and fluent combination of Microsoft Azure table filters.

## Creating filters
To create a filter use the static class `GenerateTableFilter`.

```csharp
var filter = GenerateTableFilter.WhereNotEquals("RowKey", Guid.Empty);
```

## Combining filters
Filters provide three methods to combine them with other filters: `And`, `Or` and `Not`. Those return the combined filter:

```csharp
var combined = filter1.And(filter2);
```

You can group filters logically by combining them:

```csharp
var combined = filter1.And(filter2.Or(filter3));
```

## Using filters
To use a filter for a table query, get the constructed Azure table filter string with the `AsAzureTableFilter` property:

```csharp
var azureFilter = filter1.AsAzureTableFilter;
```