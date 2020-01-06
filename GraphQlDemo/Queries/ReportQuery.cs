using DM.GraphQlDemo.Data;
using DM.GraphQlDemo.Entities;
using DM.GraphQlDemo.Queries.Types;
using GraphQL.Types;

namespace DM.GraphQlDemo.Queries
{
    public class ReportQuery : ObjectGraphType
    {
        private readonly ReportsRepository _repo = new ReportsRepository();
        public ReportQuery()
        {
            Field<ReportType>(
                name: "report",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id", }),
                resolve: context =>
                {
                    int id = context.GetArgument<int>("id");
                    return _repo.GetReportById(id);
                });
            Field<ListGraphType<ColumnType>>(
                name: "columns",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    int id = context.GetArgument<int>("id");
                    return _repo.GetColumnsByReport(id);
                }
            );
        }
    }
}
