using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SistemaApiRestFroms.ModelView
{
    public class APIs
    {
        public string UrlPost { get; set; }

        public APIs() {
            this.UrlPost = "https://jsonplaceholder.typicode.com/posts";
        }
    }
}
