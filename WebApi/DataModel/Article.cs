﻿namespace DataModel
{
    using System;

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public ArticleCategory Category { get; set; }
        public string Resume { get; set; }
        public string ImageUrl { get; set; }
        public string UrlTitle { get; set; }
    }
}
