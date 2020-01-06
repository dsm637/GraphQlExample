using DM.GraphQlDemo.Entities;
using GraphQL.Types;

namespace DM.GraphQlDemo.Queries.Types
{
    public class MetadataType : ObjectGraphType<Metadata>
    {
        public MetadataType()
        {
            Field(x => x.Name);
            Field(x => x.Value);
        }
    }
}
