using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewly_net.Models
{
    public class Website
    {
        string _url;
        string _logopath;
        string _categories;

        public string Url { get => _url; set => _url = value; }
        public string Logopath { get => _logopath; set => _logopath = value; }
        public string Categories { get => _categories; set => _categories = value; }
    }
}