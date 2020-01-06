using DM.GraphQlDemo.Entities;
using GraphQL.Types;

namespace DM.GraphQlDemo.Queries.Types
{
    public class ColumnType : ObjectGraphType<Column>
    {
        public ColumnType()
        {
            Field(x => x.Oid);
            Field(x => x.Name);
            Field(x => x.Description);
            Field(x => x.IsCalculated);
            Field(x => x.Expression);
            Field(x => x.Criteria);
            Field(x => x.DisplayFormat);
            //Field(x => x.PropertyRef);
            //Field<PropertyType>(x => x.PropertyRef);
            Field<PropertyType>("propertyRef");
            Field<ListGraphType<MetadataType>>("metadata");
        }
    }
}
