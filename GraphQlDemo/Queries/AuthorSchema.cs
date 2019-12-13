using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.GraphQlDemo.Services;

namespace DM.GraphQlDemo.Queries
{
    public class AuthorSchema : Schema
    {
        public AuthorSchema(AuthorQuery query)
        {
            Query = query;
        }
    }
}
