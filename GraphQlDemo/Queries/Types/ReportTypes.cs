using DM.GraphQlDemo.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.GraphQlDemo.Queries.Types
{
    public class ReportType : ObjectGraphType<Report>
    {
        public ReportType()
        {
            Field(x => x.Oid);
            Field<ListGraphType<ColumnType>>("columns");
        }
    }

    public class ColumnType : ObjectGraphType<Column>
    {
        public ColumnType()
        {
            Field(x => x.Oid);
            Field(x => x.IsCalculated);
            Field(x => x.Expression);
            Field(x => x.Criteria);
            Field(x => x.DisplayFormat);
            //Field<PropertyType>("property");
            //Field<ListGraphType<MetadataType>>("metadata");
        }
    }

    public class MetadataType : ObjectGraphType<Metadata>
    {
        public MetadataType()
        {
            Field(x => x.Name);
            Field(x => x.Value);
        }
    }

    public class PropertyType : ObjectGraphType<Property>
    {
        PropertyType()
        {
            Field(x => x.Oid);
            //Field<EnumerationGraphType<DataType>>("type");
            Field(x => x.Name);
            Field(x => x.Value);
        }
    }

    public class DataTypetype : EnumerationGraphType<DataType>
    {
        public DataTypetype()
        {
            Name = "DataTypeType";
        }
    }
}
