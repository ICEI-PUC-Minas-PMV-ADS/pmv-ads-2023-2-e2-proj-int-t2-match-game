using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Net;


namespace Match_Game_Oficial.Controllers
{
    public class EsqsenhaController : Controller
    {
        private readonly DataContext _context;

        private readonly SmtpSettings _smtpSettings;

        private const string CodigoDeVerificacaoChave = "CodigoDeVerificacao"; // Chave para armazenar o código na sessão


      

        //COnfiguração do SMTP
        public EsqsenhaController(IOptions<SmtpSettings> smtpSettings, DataContext context)
        {
            _smtpSettings = smtpSettings.Value;

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

                // Chamada do método para enviar o email com o código
                EnviarEmailComCodigo(email, codigoDeVerificacao, _smtpSettings);

                // Armazene o código de verificação na sessão
                HttpContext.Session.SetString(CodigoDeVerificacaoChave, codigoDeVerificacao);

                // Redirecionamento para a página de inserção do código
                return View("InserirCodigo");
            }
        }

        //Método para gerar um código aleatório
        private string GerarCodigoDeVerificacao()
        {
            Random random = new();
            int codigo = random.Next(10000, 100000);
            
            return codigo.ToString("D5"); 
        }

        //Método que envia um email para o usuário com o SMTP
         private async Task EnviarEmailComCodigo(string email, string codigo, SmtpSettings smtpSettings)
        {
            //Aqui é onde ocorre a montagem do email
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Match Game", smtpSettings.SmtpUsername));
            message.To.Add(new MailboxAddress("Nome do Destinatário", email));
            message.Subject = "Código de Verificação";

            var text = new TextPart("plain")
            {
                Text = $"Seu código de verificação: {codigo}"
            };

            message.Body = text;

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(smtpSettings.SmtpServer, smtpSettings.SmtpPort, true); // Usando configurações do appsettings.json
                await client.AuthenticateAsync(smtpSettings.SmtpUsername, smtpSettings.SmtpPassword); // Usando configurações do appsettings.json
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }


        // Ação para inserir o código de verificação
        public IActionResult InserirCodigo()
        {
            return View();
        }

        // Ação para redefinir a senha
        [HttpPost]
        public async Task <IActionResult> RedefinirSenha(Esqsenha model)
        {
            if (ModelState.IsValid)
            {
                // Verifique o código de verificação na sessão
                string codigoDeVerificacao = HttpContext.Session.GetString(CodigoDeVerificacaoChave);

                if (model.Codigo != codigoDeVerificacao)
                {
                    ModelState.AddModelError("Codigo", "Código de verificação incorreto");
                    return View(model);
                }

                //Aqui, estamos resgatando o usuário que tenha o email fornecido
                var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == model.Email);

                //Definindo a nova senha
                usuario.Senha = model.NovaSenha;

                //Enviando para o Bando de Dados
                _context.Update(usuario);
                await _context.SaveChangesAsync();


                // Limpando o código de verificacao da sessao
                HttpContext.Session.Remove(CodigoDeVerificacaoChave);

                // Redirecione para a página de confirmação de senha
                return RedirectToAction("ConfirmacaoSenha");
            }

            return View(model);
        }

        // Ação para a página de confirmação de senha
        public IActionResult ConfirmacaoSenha()
        {
            return View();
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


