﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenCollins.Web.ViewModel
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public HtmlString BodyHtml { get; set; }
        public HtmlString BodyExcerpt { get; set; }
        public bool Excerpted { get; set; }
        public string Slug { get; set; }
    }
}