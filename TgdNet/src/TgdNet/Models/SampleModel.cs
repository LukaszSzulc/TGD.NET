using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TgdNet.Models
{
    using Microsoft.AspNet.Mvc;

    public class SampleModel
    {
        [FromHeader]
        public string SampleHeader { get; set; }

        [FromQuery]
        
        public string SortOrder { get; set; }
    }
}
