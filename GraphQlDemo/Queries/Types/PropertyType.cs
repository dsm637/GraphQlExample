using DM.GraphQlDemo.Entities;
using GraphQL.Types;

namespace DM.GraphQlDemo.Queries.Types
{
    public class PropertyType : ObjectGraphType<Property>
    {
        public PropertyType()
        {
            //Field(x => x.Oid);
            //Field<EnumerationGraphType<DataType>>("type");
            Field(x => x.Name);
            //Field(x => x.Description);
            Field(x => x.Value);
        }
    }
}
