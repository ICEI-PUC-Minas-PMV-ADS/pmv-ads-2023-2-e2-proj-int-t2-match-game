using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
//using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Net;
using Org.BouncyCastle.Crypto.Macs;

namespace Match_Game_Oficial.Controllers
{
    public class EsqsenhaController : Controller
    {
        private readonly DataContext _context;

     

        private const string CodigoDeVerificacaoChave = "CodigoDeVerificacao"; // Chave para armazenar o código na sessão
        private const string EmailParaVerificação = "email"; // Chave para armazenar o código na sessão



        //COnfiguração do SMTP
        public EsqsenhaController( DataContext context)
        {
            
            _context = context;
        }
        // Ação para solicitar o email
        public IActionResult SolicitarEmail()
        {
            return View();
        }

        // Ação para enviar o email com o código de verificação
        [HttpPost]
        public async Task<IActionResult> EnviarEmail(Esqsenha model)
        {
            string email = HttpContext.Request.Form["Email"];

            // Valide o email
            bool emailIsValid = await IsValidEmail(email);

            if (!emailIsValid)
            {
                ModelState.AddModelError("Email", "O endereço de email não é válido.");
                return View("SolicitarEmail");
            }
            else
            {
                // Chamada do método para gerar código de verificação
                string codigoDeVerificacao = GerarCodigoDeVerificacao();
                Console.WriteLine(codigoDeVerificacao);

                // Chamada do método para enviar o email com o código
                EnviarEmailComCodigo(email, codigoDeVerificacao);
                Console.WriteLine(email);


                // Armazene o código de verificação na sessão
                HttpContext.Session.SetString(CodigoDeVerificacaoChave, codigoDeVerificacao);
                HttpContext.Session.SetString(EmailParaVerificação, email);

                // Redirecionamento para a página de inserção do código
                return View("InserirCodigo");
            }
        }

        //Método para gerar um código aleatório
        private string GerarCodigoDeVerificacao()
        {
            Random random = new Random();
            int codigo = random.Next(10000, 100000);
            
            return codigo.ToString("D5"); 
        }

        //Método que envia um email para o usuário com o SMTP
        private void EnviarEmailComCodigo(string email, string codigoDeVerificacao)
        {
            string fromMail = "matchgame02@gmail.com";
            string fromPassword = "ynzupkoqpimoynbh";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);

            message.Subject = "Código de Verificação";
            message.To.Add(new MailAddress(email));
            message.Body = $"<p>Seu código é: {codigoDeVerificacao}<p>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }


        // Ação para inserir o código de verificação
        public IActionResult InserirCodigo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerificaCodigo(Esqsenha model)
        {
            string codigo = model.Codigo;
            string NovaSenha = model.NovaSenha;
            string emailUser = HttpContext.Session.GetString(EmailParaVerificação);

            if (codigo == HttpContext.Session.GetString(CodigoDeVerificacaoChave))
            {
                Console.WriteLine(" O código Está Correto");
                Console.WriteLine();

                var dados = await BuscarUsuariosPorEmail(emailUser);

                Console.WriteLine(emailUser);
                Console.WriteLine(dados);
                if (dados.Count == 0)
                {
                    ViewBag.Message = "Email e/ou senha inválidos";


                    Console.WriteLine("Algo Deu errado no banco de dados");
                    return RedirectToAction ("InserirCodigo", "Esqsenha");

                }
                else
                {

                    Console.WriteLine("Deu certo o banco de ddados");
                    var primeiroUsuario = dados[0];
                    primeiroUsuario.Senha = BCrypt.Net.BCrypt.HashPassword(NovaSenha);

                    _context.Update(primeiroUsuario);
                    await _context.SaveChangesAsync();
                 
                    HttpContext.Session.Remove(CodigoDeVerificacaoChave);

                    return RedirectToAction("Login", "Usuarios");
                }
                         
            }
            else
            {
                Console.WriteLine("Seu código está Incorreto");
                ModelState.AddModelError("Codigo", "Código de verificação incorreto");

                return RedirectToAction("InserirCodigo","Esqsenha");
                
            }
        }

        public async Task<List<Usuario>> BuscarUsuariosPorEmail(string email)
        {
            var usuarios = await _context.Usuarios
                .Where(u => u.Email == email)
                .ToListAsync();

            return usuarios;
        }



        //Método que válida se o email existe no Banco de Dados
        public async Task<bool> IsValidEmail(string email)
        {
            var emailUser = await _context.Usuarios
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();

            return emailUser != null;
        }


    }


}


