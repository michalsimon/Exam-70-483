namespace Reflection
{
    using System;

    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DataMappingAttribute : System.Attribute
    {
        public DataMappingAttribute(string columnName, string propertyName)
        {
            ColumnName = columnName;
            PropertyName = propertyName;
        }

        public string ColumnName { get; set; }

        public string PropertyName { get; set; }
    }
}