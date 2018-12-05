using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPostLogError()
        {
            _logger.LogError("Какая-то ошибка произошла");
        }

        public void OnPostCreateException()
        {
            throw new ArgumentOutOfRangeException("testArg", "Wtf with arg");
        }
    }
}
