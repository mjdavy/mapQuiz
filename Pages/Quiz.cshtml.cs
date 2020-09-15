using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace mapQuiz.Pages
{
    public class QuizModel : PageModel
    {
        private readonly ILogger<QuizModel> _logger;

        public QuizModel(ILogger<QuizModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
