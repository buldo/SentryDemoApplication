using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

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

        public void OnPostLog4NetError()
        {
            LogManager.GetLogger(typeof(IndexModel)).Error("Какая-то ошибка произошла Log4Net");
        }

        public void OnPostCreateExceptionLog4Net()
        {
            try
            {
                throw new ArgumentOutOfRangeException("testArg", "Wtf with arg");
            }
            catch (Exception e)
            {
                LogManager.GetLogger(typeof(IndexModel)).Error("Произошло исключение", e);
            }
        }
    }
}
