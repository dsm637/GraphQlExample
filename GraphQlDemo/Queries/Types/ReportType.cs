using DM.GraphQlDemo.Entities;
using GraphQL.Types;

namespace DM.GraphQlDemo.Queries.Types
{
    public class ReportType : ObjectGraphType<Report>
    {
        public ReportType()
        {
            Field(x => x.Oid);
            Field(x => x.Name);
            Field(x => x.Description);
            Field<ListGraphType<ColumnType>>("columns");
        }
    }
}
