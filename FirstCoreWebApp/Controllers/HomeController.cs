using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreWebApp.Controllers
{
    [Produces("application/json")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ITopicAreaService _topicAreaService;

        public HomeController(ITopicAreaService topicAreaService)
        {
            _topicAreaService = topicAreaService;
        }

        [HttpGet]
        public IEnumerable<TopicArea> GetAllTopicAreas()
        {
            return _topicAreaService.GetAllTopicAreas();
        }
    }
}