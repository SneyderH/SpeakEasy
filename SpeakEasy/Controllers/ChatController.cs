using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace SpeakEasy.Controllers
{
    public class ChatController : Controller
    {
        SqlConnection cn = new SqlConnection();

        public static Dictionary<int, string> Rooms =
            new Dictionary<int, string>()
            {
                { 1, "Cervezas" },
                { 2, "Programación" },
                { 3, "Moda" }
            };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int room)
        {
            return View("Room", room);
        }
    }
}
