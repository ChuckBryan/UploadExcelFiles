namespace UploadExcelFiles.web.Code
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public static class DataTableExtensions
    {
public static DataTable ToDataTable<T>(this IEnumerable<T> data)
{
    var propertyInfos = typeof(T).GetProperties();
    DataTable table = new DataTable();

    foreach (var property in propertyInfos)
    {
        table.Columns.Add(property.Name);
    }

    foreach (T item in data)
    {
        var newRow = table.NewRow();
        int column = 0;

        foreach (var property in propertyInfos)
        {
            var value = property.PropertyType.IsEnum
                ? Convert.ChangeType(property.GetValue(item, null), Enum.GetUnderlyingType(property.PropertyType))
                : property.GetValue(item, null);

            newRow[column] = value;

            column++;
        }

        table.Rows.Add(newRow);
    }
    return table;
}
    }
}