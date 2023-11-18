using Match_Game_Oficial.Controllers;
using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Match_Game_Oficial.Controllers
{
    public class JogosRecomendadosController : Controller
    {
        private readonly DataContext _context;
        private const string EmailRecomendacao = "email";
        private readonly ILogger<JogosRecomendadosController> _logger;

        public JogosRecomendadosController(DataContext context, ILogger<JogosRecomendadosController> logger)
        {

            _context = context;
            _logger = logger;

        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MeusJogos()
        {
            try
            {
                string email = HttpContext.Session.GetString(EmailRecomendacao);
                _logger.LogInformation($"Email na sessão: {email}");

                if (email != null)
                {

                    Console.WriteLine(email);
                    Console.WriteLine("Existe um email na sessão");

                    var dados = await BuscarDados(email);

                    if (dados.Count > 0)
                    {
                        var primeiroUsuario = dados[0];
                        Console.WriteLine(dados[0]);

                        // Passar o link serializado para a view
                        ViewData.Add("Recomendado", primeiroUsuario.UsuarioLink);
                        Console.WriteLine($"Recomendado: {ViewData["Recomendado"]}");

                        return Json(new { Recomendaddo = dados[0].UsuarioLink });
                    }


                    else
                    {
                        Console.WriteLine("Existe um email na sessão, mas não encontrado no Banco");
                        Console.WriteLine("A lista está vazia");
                    }
                }

                else
                {
                    Console.WriteLine("Não existe um email na sessão");
                }

                // Lógica para tratar caso o usuário não seja encontrado
                return RedirectToAction("Index"); // ou qualquer outra ação apropriada
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao processar ação MeusJogos");
                return StatusCode(500, "Erro interno do servidor");
            }
        }

        public async Task<List<Usuario>> BuscarDados(string email)
        {
            var usuarios = await _context.Usuarios
                .Where(u => u.Email == email)
                .ToListAsync();

            return usuarios;
        }

        public IActionResult Jogos() 
        {
            return View();

        }

    }
}


