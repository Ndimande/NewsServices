using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsService.Models
{
    public class NewsModel
    {
            
            public string Headline { get; set; }
            public string Text { get; set; }
            public int RelevanceScore { get; set; }
            public DateTime Date { get; set; }
            public string Source { get; set; }
            public string[] Tags { get; set; }
        

    }

}


