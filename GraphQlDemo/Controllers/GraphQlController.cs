using GraphQL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DM.GraphQlDemo.Queries;

namespace DM.GraphQlDemo.Controllers
{
    [Route("/graphql")]
    //[ApiController]
    public class GraphQlController : ControllerBase
    {
        //readonly BlogService blogService;
        //readonly AuthorSchema _schema;
        readonly ReportSchema _reportSchema;
        private readonly IDocumentExecuter _de;
        public GraphQlController(ReportSchema schema, IDocumentExecuter de)
        {
            //this.blogService = blogService;
            _reportSchema = schema;
            _de = de;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var v = query.Variables;
            var q = query.Query;

            //var schema = new Schema { Query = new AuthorQuery(blogService) };
            var schema = _reportSchema;// _schema;
            var result = await _de.ExecuteAsync(x =>
            {
                x.Schema = schema;
                x.Query = q; // query.Query;
                x.Inputs = v; //query.Variables;
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
