using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Match_Game_Oficial.Controllers
{
    public class PerfilController : Controller
    {
        private readonly DataContext _context;
        public const string EmailRecomendacao = "email";

        public PerfilController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DetalhesPerfil()
        {
            string email = HttpContext.Session.GetString(EmailRecomendacao);
            Console.WriteLine("Deu");
            Console.WriteLine(email);

            if (email != null)
            {
                var dados = await BuscarDados(email);

                if (dados.Count > 0)
                {
                    var primeiroUsuario = dados[0];
                    return Json(primeiroUsuario);  // Retornar JSON em vez de uma visão
                }
            }

            // Se não houver dados ou e-mail na sessão, retornar um status 404 ou uma mensagem adequada.
            return NotFound();
        }



        public async Task<List<Usuario>> BuscarDados(string email)
        {
            var usuarios = await _context.Usuarios
                .Where(u => u.Email == email)
                .ToListAsync();

            return usuarios;
        }
    }
}
