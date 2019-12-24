using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DM.GraphQlDemo.Queries
{
    public class ReportSchema : Schema
    {
        public ReportSchema(ReportQuery query)
        {
            Query = query;
        }
    }
}
