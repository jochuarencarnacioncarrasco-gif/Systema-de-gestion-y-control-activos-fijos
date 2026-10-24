using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Systema_de_gestion_y_control_activos_fijos.Models;

namespace Systema_de_gestion_y_control_activos_fijos.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDBContext _context;

            public LoginController(AppDBContext context)
        {
            _context = context;
        
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // 2. Método POST: Procesa las credenciales cuando el usuario hace clic en "Ingresar"
        [HttpPost]
        public IActionResult Index(string usuario, string password)
        {
            var user = _context.Usuarios.FirstOrDefault(u => u.Email == usuario && u.PasswordHash == password);

            if (user != null)
            {
                // Guardamos la sesión
                HttpContext.Session.SetString("UsuarioLogueado", user.Email);

                // Redirige al Dashboard principal
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos.";
            return View();
        }




    }




}






