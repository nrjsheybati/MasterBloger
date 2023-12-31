﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Query
{
    public class ArticleViewQuery
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string articleCategory { get; set; }
        public string CreateionDate { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get;  set; }
    }
}
