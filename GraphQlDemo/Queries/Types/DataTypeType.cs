using DM.GraphQlDemo.Entities;
using GraphQL.Types;

namespace DM.GraphQlDemo.Queries.Types
{
    public class DataTypetype : EnumerationGraphType<DataType>
    {
        public DataTypetype()
        {
            Name = "DataTypeType";
        }
    }
}
