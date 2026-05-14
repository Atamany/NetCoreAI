using Microsoft.AspNetCore.Mvc;
using NetCoreAI.Project20_RecipeSuggestionWithOpenAI.Models;

namespace NetCoreAI.Project20_RecipeSuggestionWithOpenAI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly OpenAIService OpenAIService;

        public DefaultController(OpenAIService openAIService)
        {
            OpenAIService = openAIService;
        }
        [HttpGet]
        public IActionResult CreateRecipe()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRecipe(string ingredients)
        {
            var recipeSuggestion = await OpenAIService.GetRecipeSuggestion(ingredients);
            ViewBag.RecipeSuggestion = recipeSuggestion;
            return View();
        }
    }
}
