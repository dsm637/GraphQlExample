using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Entities
{
    public class Author
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImgUrl { get; set; }
        public string ProfileUrl { get; set; }
    }

    public class Comment
    {
        public string Url { get; set; }
        public string Description { get; set; }
    }

    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public Author Author { get; set; }
        public string[] Categories { get; set; }
        public List<Comment> Comments { get; set; }
    }
    public class SocialNetwork
    {
        public SNType Type { get; set; }
        public string NickName { get; set; }
        public string Url { get; set; }
        public Author Author { get; set; }
    }
    public enum SNType
    {
        INSTAGRAM, TWITTER
    }
}