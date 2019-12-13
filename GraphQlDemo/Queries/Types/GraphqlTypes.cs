using GraphQL.Types;
using DM.GraphQlDemo.Entities;

namespace DM.GraphQlDemo.Queries.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.Id).Description("Id of an author");
            Field(x => x.Name).Description("Name of an author");
            Field(x => x.Bio).Description("Bio description of an author");
            Field(x => x.ImgUrl).Description("Url of an author's profile picture");
            Field(x => x.ProfileUrl).Description("Link of an author's profile");
        }
    }
    public class SocialNetworkType : ObjectGraphType<SocialNetwork>
    {
        public SocialNetworkType()
        {
            Field(x => x.NickName);
            Field<EnumerationGraphType<SNType>>("type");
            Field(x => x.Url);
            Field<AuthorType>("author");
        }
    }
    public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
    public class CommentType : ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Url);
            Field(x => x.Date);
            Field(x => x.Description);
            Field<AuthorType>("author");
            Field<ListGraphType<CommentType>>("comments");
            Field(x => x.Categories, nullable: true);
        }
    }
}
