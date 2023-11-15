using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace Match_Game_Oficial.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly DataContext _context;

        public const string EmailRecomendacao = "email";
        private readonly ILogger<JogosRecomendadosController> _logger;


        public UsuariosController(DataContext context, ILogger<JogosRecomendadosController> logger)
        {
            _context = context;
            _logger = logger;

        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
              return _context.Usuarios != null ? 
                          View(await _context.Usuarios.ToListAsync()) :
                          Problem("Entity set 'DataContext.Usuarios'  is null.");
        }
        //Onde Criamos a view Login
        public IActionResult login()
                {
                    return View();
                }


        //Onde implementamos as validações e requisições
        [HttpPost]
        public async Task<IActionResult> login(Usuario usuario)
        {
            var dados = await _context.Usuarios
                .Where(u => u.Email == usuario.Email)
                .FirstOrDefaultAsync();

            if (dados == null)
            {
                ViewBag.Message = "Email e/ou senha inválidos";
                return View();
            }

            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOk)
            {
                string email = dados.Email;

                HttpContext.Session.SetString(EmailRecomendacao, email);
                Console.WriteLine(dados.Email);
                _logger.LogInformation($"Email na sessão: {email}");

                var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Email, dados.Email),
                new Claim(ClaimTypes.Name, dados.Nome)

                };

                var usuarioIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);



                return Redirect("/Recomendados/Index");
            }
            else
            {
                ViewBag.Message = "Email e/ou senha inválidos";
                return View();
            }
        }

        //Quando o usuário apertar em sair vai para 
        public async Task<IActionResult> Logout()
        {
            string email = HttpContext.Session.GetString(EmailRecomendacao);
            Console.WriteLine(email);

            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuarios");
           

        }


        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        public FileContentResult getImg(int id)
        {
            byte[] byteArray = _context.Usuarios.Find(id).Foto;
            return byteArray != null
                ? new FileContentResult(byteArray, "image/jpeg")
                : null;
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Senha,Email,Data_Nascimento,Foto")] Usuario usuario, IFormFile file)
        {

            if (ModelState.IsValid)
            {
                Console.WriteLine(usuario.Id) ;
                if (file.Headers != null && file.Length > 0)
                {
                   
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(target: memoryStream);
                        byte[] data = memoryStream.ToArray();
                        usuario.Foto = memoryStream.ToArray();
                    }
                }

                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Senha,Email,Data_Nascimento,Foto")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'DataContext.Usuarios'  is null.");
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return (_context.Usuarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
