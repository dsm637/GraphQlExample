namespace DM.GraphQlDemo.Entities
{
    public class ObjectInstance
    {
        public int Oid { get; set; }
    }

    public class Report : ObjectInstance
    {
        public Column[] Columns { get; set; }
    }

    public class Metadata
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Column : ObjectInstance
    {
        public bool IsCalculated { get; set; }
        public Property PropertyRef { get; set; }
        public string Expression { get; set; }
        public string Criteria { get; set; }
        public string DisplayFormat { get; set; }
        public Metadata[] Metadata { get; set; }
    }

    public class Property : ObjectInstance
    {
        public DataType Type { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
    }

    public enum DataType
    {
        Number,
        Date,
        Text,
        PickList,
    }
}