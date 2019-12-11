using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Entities;

namespace WebApplication3.Services
{
    public class BlogService
    {
        private readonly List<Author> authors = new List<Author>();
        private readonly List<Post> posts = new List<Post>();
        private readonly List<SocialNetwork> sns = new List<SocialNetwork>();

        public BlogService()
        {
            Author DinoEsposito = new Author
            {
                Id = "1",
                Name = "Dino Esposito",
                Bio = "Dino Esposito has authored more than 20 books and 1,000 articles in ...",
                ImgUrl = "https://secure.gravatar.com/avatar/ace158af8dfab0e682dcc70d965514e5?s=80&d=mm&r=g",
                ProfileUrl = "https://www.red-gate.com/simple-talk/author/dino-esposito/"
            };
            Author LanceTalbert = new Author
            {
                Id = "2",
                Name = "Lance Talbert",
                Bio = "Lance Talbert is a budding game developer that has been learning to program since ...",
                ImgUrl = "https://www.red-gate.com/simple-talk/wp-content/uploads/2018/01/red-gate-bio-pic.jpg",
                ProfileUrl = "https://www.red-gate.com/simple-talk/author/lancetalbert/"
            };
            authors.Add(DinoEsposito);
            authors.Add(LanceTalbert);
            Comment comment1 = new Comment
            {
                Url = "https://#",
                Description = "Bla bla bla",
            };
            Comment comment2 = new Comment
            {
                Url = "https://#",
                Description = "Bla bla bla",
            };
            Post FormsInVanilla = new Post
            {
                Id = "1",
                Title = "Building Better HTML Forms in Vanilla-JS",
                Description = "Creating forms is one of the most basic skills for a web developer...",
                Date = DateTime.Today,
                Url = "https://www.red-gate.com/simple-talk/dotnet/net-development/building-better-html-forms-in-vanilla-js/",
                Author = DinoEsposito,
                Comments = new List<Comment>() { comment1 },
                Categories = new string[] { ".NET Development" }
            };
            Post VoiceCommands = new Post
            {
                Id = "2",
                Title = "Voice Commands in Unity",
                Description = "Today, we use voice in many ways. We can order groceries...",
                Date = DateTime.Today,
                Url = "https://www.red-gate.com/simple-talk/dotnet/c-programming/voice-commands-in-unity/",
                Author = LanceTalbert,
                Comments = new List<Comment>() { comment2 },
                Categories = new string[] { "C# programming" }
            };
            posts.Add(FormsInVanilla);
            posts.Add(VoiceCommands);
            SocialNetwork sn1 = new SocialNetwork()
            {
                Type = SNType.INSTAGRAM,
                Author = DinoEsposito,
                NickName = "@dino",
                Url = "https://#"
            };
            SocialNetwork sn2 = new SocialNetwork()
            {
                Type = SNType.TWITTER,
                Author = DinoEsposito,
                NickName = "@dino",
                Url = "https://#"
            };
            sns.Add(sn1);
            sns.Add(sn2);
        }
        public List<Author> GetAllAuthors()
        {
            return this.authors;
        }
        public Author GetAuthorById(string id)
        {
            return authors.Where(author => author.Id == id).FirstOrDefault<Author>();
        }
        public List<Post> GetPostsByAuthor(string id)
        {
            return posts.Where(post => post.Author.Id == id).ToList<Post>();
        }
        public List<SocialNetwork> GetSNsByAuthor(string id)
        {
            return sns.Where(sn => sn.Author.Id == id).ToList<SocialNetwork>();
        }
    }
}
