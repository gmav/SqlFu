﻿using System;
using System.Data;
using CavemanTools.Model;
using SqlFu;
using SqlFu.DDL;

namespace Tests
{
    public enum PostType
    {
        Post,
        Page
    }
    [Table("Posts")]
    class Post
    {
        public int Id { get; set; }
        [RedefineFor(DbEngine.SqlServer, "blblsd")]
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        //[InsertAsString]
        public PostType Type { get; set; }
        public int? TopicId { get; set; }
        public bool IsActive { get; set; }
     
    }


    public class PostViewModel
    {
        public int Id { get; set; }
        public IdName Author { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public PostType Type { get; set; }
        public IdName Topic { get; set; }
    }

}