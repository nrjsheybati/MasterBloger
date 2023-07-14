using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts.Article
{
    public class ArticleViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string articleCategory { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateionDate { get; set; }
    }
}
