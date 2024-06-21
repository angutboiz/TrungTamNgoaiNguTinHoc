using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TTNgoaiNguTinHoc.Models;

namespace TTNgoaiNguTinHoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/gioithieu")]
        public IActionResult About()
        {
            return View();
        }

		[Route("/lienhe")]
		public IActionResult Contact()
		{
			return View();
		}
		[Route("/phuckhao")]
		public IActionResult Appeal()
		{
			return View();
		}
		[Route("/dangkyduthi")]
		public IActionResult FormRegis()
		{
			return View();
		}
		[Route("/lichthi")]
		public IActionResult Exam()
		{
			return View();
		}
		[Route("/lichkhaigiang")]
		public IActionResult Open()
		{
			return View();
		}
		[Route("/daotao")]
		public IActionResult Train()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
