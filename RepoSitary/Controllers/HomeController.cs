using Microsoft.AspNetCore.Mvc;
using RepoSitary.Models;
using RepoSitary.Repository;
using System.Diagnostics;

namespace RepoSitary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepsitory _studentRepository = null;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepsitory();
        }
        public List<StudentModel> getAllStudents()
        {
return _studentRepository.getAllStudents();
        }
        public List<StudentModel> getbyid(int id)
        {
return _studentRepository.getStudentById(id);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
