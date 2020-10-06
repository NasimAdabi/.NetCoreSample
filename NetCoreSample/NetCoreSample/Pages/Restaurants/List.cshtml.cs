using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace NetCoreSample.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration configuration;
        public String Message { get; set; }

        public ListModel(IConfiguration config)
        {
            this.configuration = config;
        }

        public void OnGet()
        {
            Message = configuration["Message"];
        }
    }
}
