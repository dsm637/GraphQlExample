using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Services;

namespace WebApplication3.Queries
{
    public class AuthorSchema : Schema
    {
        public AuthorSchema(AuthorQuery query)
        {
            Query = query;
        }
    }
}
