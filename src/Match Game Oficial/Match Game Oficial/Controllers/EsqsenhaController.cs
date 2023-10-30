using Match_Game_Oficial.Models;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;

namespace Match_Game_Oficial.Controllers
{
    public class EsqsenhaController : Controller
    {
        private const string CodigoDeVerificacaoChave = "CodigoDeVerificacao"; // Chave para armazenar o código na sessão

        // Ação para solicitar o email
        public IActionResult SolicitarEmail()
        {
            return View();
        }

        // Ação para enviar o email com o código de verificação
        [HttpPost]
        public IActionResult EnviarEmail(Esqsenha model)
        {
            if (ModelState.IsValid)
            {
                // Gere um código de verificação
                string codigoDeVerificacao = GerarCodigoDeVerificacao();

                // Envie o email com o código
                EnviarEmailComCodigo(model.Email, codigoDeVerificacao);

                // Armazene o código de verificação na sessao
                HttpContext.Session.SetString(CodigoDeVerificacaoChave, codigoDeVerificacao);

                // Redirecione para a página de inserção do código
                return RedirectToAction("InserirCodigo");
            }

            return View("SolicitarEmail", model);
        }

        private string GerarCodigoDeVerificacao()
        {
            // Lógica para gerar um código de verificacao
            return "123456"; // Substitua isso pela lógica real
        }

        private void EnviarEmailComCodigo(string email, string codigo)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Seu Nome", "seuemail@example.com"));
            message.To.Add(new MailboxAddress("Nome do Destinatário", email));
            message.Subject = "Código de Verificação";

            var text = new TextPart("plain")
            {
                Text = $"Seu código de verificação: {codigo}"
            };

            message.Body = text;

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.example.com", 587, false); // Substitua com as informações do seu servidor SMTP
                client.Authenticate("seuemail@example.com", "suasenha"); // Substitua com suas credenciais de email
                client.Send(message);
                client.Disconnect(true);
            }
        }

        // Ação para inserir o código de verificação
        public IActionResult InserirCodigo()
        {
            return View();
        }

        // Ação para redefinir a senha
        [HttpPost]
        public IActionResult RedefinirSenha(Esqsenha model)
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

                // Implemente a lógica para redefinir a senha do usuário
                // Substitua o exemplo abaixo pela lógica real
                // Exemplo: Atualizar a senha no banco de dados

                // Limpe o código de verificacao da sessao
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
    }

}


