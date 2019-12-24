using DM.GraphQlDemo.Entities;
using DM.GraphQlDemo.Queries.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.GraphQlDemo.Queries
{
    public class ReportQuery : ObjectGraphType
    {
        public ReportQuery()
        {
            Field<ReportType>(
                name: "report",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id", }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return new Report
                    {
                        Oid = id,
                        Columns = new Column[]
                        {
                            new Column
                            {
                                Oid = id * 2,
                                DisplayFormat = "---==*%s*==---",
                                IsCalculated = false,
                                Criteria = "LIKE %",
                                Expression = "AVG",
                                Metadata = new Metadata[]
                                {
                                    new Metadata { Name = "font-weight", Value = "bold", },
                                    new Metadata { Name = "align", Value = "left", },
                                },
                                PropertyRef = new Property
                                {
                                    Name = "Name",
                                    Oid = id * id,
                                    Type = DataType.Text,
                                    Value = "TEST1159",
                                }
                            },
                            new Column
                            {
                                Oid = id * 3,
                                DisplayFormat = "%",
                                IsCalculated = true,
                                Expression = "NOW()",
                                Metadata = new Metadata[]
                                {
                                    new Metadata { Name = "vertical-align", Value = "top", },
                                },
                            },
                        },
                    };
                });
            Field<ListGraphType<ColumnType>>(
                name: "columns",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    int id = context.GetArgument<int>("id");

                    // get columns by report
                    return new Column[]
                    {
                        new Column
                        {
                            Oid = id * 2,
                            DisplayFormat = "---==*%s*==---",
                            IsCalculated = false,
                            Criteria = "LIKE %",
                            Expression = "AVG",
                            Metadata = new Metadata[]
                            {
                                new Metadata { Name = "font-weight", Value = "bold", },
                                new Metadata { Name = "align", Value = "left", },
                            },
                            PropertyRef = new Property
                            {
                                Name = "Name",
                                Oid = id * id,
                                Type = DataType.Text,
                                Value = "TEST1159",
                            }
                        },
                        new Column
                        {
                            Oid = id * 3,
                            DisplayFormat = "%",
                            IsCalculated = true,
                            Expression = "NOW()",
                            Metadata = new Metadata[]
                            {
                                new Metadata { Name = "vertical-align", Value = "top", },
                            },
                        },
                    };
                }
            );
        }
    }
}
